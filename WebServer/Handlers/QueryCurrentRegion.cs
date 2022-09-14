﻿using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Weedwacker.Shared.Utils;

namespace Weedwacker.WebServer.Handlers
{
    internal class QueryCurrentRegion : IHandler
    {
        private struct QueryCurRegionRspJson
        {
            public string content;
            public string sign;
        }

        public Task<bool> HandleAsync(HttpContext context)
        {
            var req = context.Request;
            string last = req.Path.ToString().Split('/').Last();
            if (last == "query_cur_region")
            {
                //Not Found version config
                var rsp = context.Response.WriteAsync("28\r\nCAESGE5vdCBGb3VuZCB2ZXJzaW9uIGNvbmZpZxoA\r\n0");
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(WithQuery(context));
            }
        }

        // /query_cur_region/<region>?<query>
        private static bool WithQuery(HttpContext context)
        {
            var req = context.Request;
            // Get region to query.
            string regionName = req.Path.ToString().Split('/').Last();
            string versionName = req.Query["version"];
            // Get region data.
            string regionData = "CAESGE5vdCBGb3VuZCB2ZXJzaW9uIGNvbmZpZw==";
            if (req.Query.Count > 0)
            {
                if (RegionManager.Regions.TryGetValue(regionName, out RegionManager.RegionData region))
                    regionData = region.base64;
            }

            string[] versionCode = new Regex("[a-zA-Z]").Replace(versionName, "").Split("\\.");
            int versionMajor = int.Parse(versionCode[0]);
            int versionMinor = int.Parse(versionCode[1]);
            int versionFix = int.Parse(versionCode[2]);

            if (versionMajor >= 3 || (versionMajor == 2 && versionMinor == 7 && versionFix >= 50) || (versionMajor == 2 && versionMinor == 8))
            {
                try
                {
                    //TODO QueryCurrentRegionEvent  

                    if (req.Query.ContainsKey("dispatchSeed"))
                    {
                        // More love for UA Patch players
                        var response = new RegionManager.QueryCurRegionRspJson
                        {
                            content = regionData,
                            sign = "TW9yZSBsb3ZlIGZvciBVQSBQYXRjaCBwbGF5ZXJz"
                        };

                        context.Response.WriteAsJsonAsync(JsonConvert.SerializeObject(response));
                        return true;
                    }

                    string key_id = req.Query["key_id"];
                    var encryptor = key_id.Equals("3") ? Crypto.CurOSEncryptor : Crypto.CurCNEncryptor;
                    var regionInfo = Convert.FromBase64String(regionData);

                    //Encrypt regionInfo in chunks
                    byte[] encryptedRegionInfoStream = new byte[regionInfo.Length];

                    //Thank you so much GH Copilot
                    int chunkSize = 256 - 11;
                    int regionInfoLength = regionInfo.Length;
                    int numChunks = (int)Math.Ceiling(regionInfoLength / (double)chunkSize);

                    for (int i = 0; i < numChunks; i++)
                    {
                        byte[] chunk = new byte[chunkSize];
                        Array.Copy(regionInfo, i * chunkSize, chunk, i * chunkSize, Math.Min((i + 1) * chunkSize, regionInfoLength));
                        byte[] encryptedChunk = encryptor.Encrypt(chunk, RSAEncryptionPadding.OaepSHA1);
                        Array.Copy(encryptedChunk, i * chunkSize, encryptedRegionInfoStream, i * chunkSize, Math.Min((i + 1) * chunkSize, regionInfoLength));
                    }
                    var signer = Crypto.CurSigner;
                    byte[] privateSignature = signer.SignData(regionInfo, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);


                    var rsp = new QueryCurRegionRspJson
                    {
                        content = Convert.ToBase64String(encryptedRegionInfoStream),
                        sign = Convert.ToBase64String(privateSignature)
                    };

                    context.Response.WriteAsJsonAsync(JsonConvert.SerializeObject(rsp));
                }
                catch (Exception e)
                {
                    Logger.WriteErrorLine(string.Format("An error occurred while handling query_cur_region/{0}.", regionName), e);
                }
            }
            else
            {
                //TODO QueryCurrentRegionEvent

                context.Response.WriteAsync(regionData);
            }
            // Log to console.
            Logger.WriteLine(string.Format("Client {0}s request: query_cur_region/{1}s", context.Connection.RemoteIpAddress.ToString(), regionName));
            return true;
        }
    }
}