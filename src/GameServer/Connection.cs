﻿using KcpSharp;
using Microsoft.VisualBasic;
using System.Buffers;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer
{
    internal class Connection
    {
        public long? ConversationID => Conversation.ConversationId;
        readonly KcpConversation Conversation;
        readonly CancellationTokenSource CancelToken;
        public readonly IPEndPoint RemoteEndPoint;
        public SessionState State { get; private set; } = SessionState.INACTIVE;
        private bool UseSecretKey = false;
        public Connection(KcpConversation conversation, IPEndPoint remote)
        {
            Conversation = conversation;
            RemoteEndPoint = remote;
            CancelToken = new CancellationTokenSource();
            Start();           
        }
        async void Start()
        {
            Logger.WriteLine($"New connection to {RemoteEndPoint} created with conversation id {Conversation.ConversationId}");
            State = SessionState.WAITING_FOR_TOKEN;
            await ReceiveLoop();
        }
        void Stop()
        {
            Listener.UnregisterConnection(this);
            Conversation.Dispose();
            CancelToken.Cancel();
            CancelToken.Dispose();
        }
#if DEBUG
        void LogPacket(string sendOrRecv, ushort opcode, byte[] payload)
        {
            Logger.DebugWriteLine(sendOrRecv + ": " + Enum.GetName(typeof(OpCode), opcode) + " (" + opcode + ")");
            Logger.DebugWriteLine(Convert.ToHexString(payload));
        }
#endif
        async Task ReceiveLoop()
        {
            while (!CancelToken.IsCancellationRequested)
            {
                // WaitToReceiveAsync call completes when there is at least one message is received or the transport is closed.
                KcpConversationReceiveResult result = await Conversation.WaitToReceiveAsync(CancelToken.Token);
                if (result.TransportClosed)
                {
                    Logger.WriteErrorLine("Transport was closed");
                    break;
                }
                if (result.BytesReceived > Listener.MAX_MSG_SIZE)
                {
                    // The message is too large.
                    Logger.WriteErrorLine("Packet too large");
                    Conversation.SetTransportClosed();
                    break;
                }

                byte[] buffer = ArrayPool<byte>.Shared.Rent(result.BytesReceived);
                try
                {
                    // TryReceive should not return false here, unless the transport is closed.
                    // So we don't need to check for result.TransportClosed.
                    if (!Conversation.TryReceive(buffer, out result))
                    {
                        Logger.WriteErrorLine("Failed to receive packet");
                        break;
                    }
                    await ProcessMessageAsync(buffer.AsMemory(0, result.BytesReceived));
                }
                catch (Exception ex)
                {
                    Logger.WriteErrorLine("Packet parse error", ex);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(buffer);
                }
            }
            Stop();
        }
        // DO THE PROCESSING OF THE GAME PACKET
        async Task ProcessMessageAsync(Memory<byte> data)
        {
            byte[] gamePacket = data.ToArray();
            // Decrypt and turn back into a packet
            Crypto.Xor(gamePacket, UseSecretKey ? Crypto.ENCRYPT_KEY : Crypto.DISPATCH_KEY);
            await using var ms = new MemoryStream(gamePacket);
            using var br = new BinaryReader(ms);
            // Log
            //logPacket(packet);
            // Handle
            try
            {
#if DEBUG
                bool allDebug = GameServer.Configuration.server.logPackets == Shared.Enums.ServerDebugMode.ALL;
#endif
                while (br.BaseStream.Position< br.BaseStream.Length)
                {
                    // Length
                    if (br.BaseStream.Length - br.BaseStream.Position < 12)
                    {
                        return;
                    }
                    // Packet sanity check
                    ushort Magic1 = br.ReadUInt16();
                    if (Magic1 != 0x4567)
                    {
#if DEBUG
                        if (allDebug)
                        {
                            Logger.WriteErrorLine(string.Format("Bad Data Package Received: got {0} ,expect 0x4567", Magic1));
                        }
#endif
                        return; // Bad packet
                    }
                    // Data
                    ushort opcode = br.ReadUInt16();
                    ushort headerLength = br.ReadUInt16();
                    uint payloadLength = br.ReadUInt32();
                    byte[] header = br.ReadBytes(headerLength);
                    byte[] payload = br.ReadBytes((int)payloadLength);

                    // Sanity check #2
                    ushort Magic2 = br.ReadUInt16();
                    if (Magic2 != 0x89ab)
                    {
#if DEBUG
                        if (allDebug)
                        {
                            Logger.WriteErrorLine(string.Format("Bad Data Package Received: got {0} ,expect 0x89ab", Magic2));
                        }
#endif
                        return; // Bad packet
                    }
#if DEBUG
                    // Log packet
                    switch (GameServer.Configuration.server.logPackets)
                    {
                        case Shared.Enums.ServerDebugMode.ALL:
                            {
                                LogPacket("RECV", opcode, payload);   
                                break;
                            }
                        case Shared.Enums.ServerDebugMode.WHITELIST: 
                            {
                                if (GameServer.Configuration.server.debugWhitelist.Contains(Enum.GetName(typeof(OpCode), opcode)))
                                {
                                    LogPacket("RECV", opcode, payload);
                                }
                                break;
                            }
                        case Shared.Enums.ServerDebugMode.BLACKLIST: 
                            {
                                if (!GameServer.Configuration.server.debugBlacklist.Contains(Enum.GetName(typeof(OpCode), opcode)))
                                {
                                    LogPacket("RECV", opcode, payload);
                                }
                                break;
                            }
                    }
#endif
                    // Find the Handler for this opcode
                    var query =
                        from type in Assembly.GetExecutingAssembly().GetTypes()
                        where type.GetCustomAttribute<OpCodeAttribute>()?.OpCodeNum == opcode
                        select type;
                    var handlerType = query.FirstOrDefault();
                    if (handlerType != null)
                    {
                        // Handle
                        var handler = (BaseHandler)Activator.CreateInstance(handlerType);
                        // Make sure session is ready for packets
                        SessionState state = State;
                        switch ((OpCode)opcode)
                        {
                            case OpCode.GetPlayerTokenReq:
                                {
                                    if (state != SessionState.WAITING_FOR_TOKEN)
                                    {
                                        return;
                                    }
                                    goto default;
                                }
                            case OpCode.PlayerLoginReq:
                                {
                                    if (state != SessionState.WAITING_FOR_LOGIN)
                                    {
                                        return;
                                    }
                                    goto default;
                                }
                            case OpCode.SetPlayerBornDataReq:
                                {
                                    if (state != SessionState.PICKING_CHARACTER)
                                    {
                                        return;
                                    }
                                    goto default;
                                }
                            default:
                                break;
                        }
                        await handler.HandleAsync(this, header, payload);
                    }
#if DEBUG
                    // Log unhandled packets
                    if (GameServer.Configuration.server.logPackets == Shared.Enums.ServerDebugMode.MISSING)
                    {
                        Logger.DebugWriteLine("Unhandled packet (" + opcode + "): " + Enum.GetName(typeof(OpCode), opcode));
                    }
#endif
                }
  
            }
            catch (Exception e)
            {
                Logger.WriteErrorLine(e.Message,e);
            }
            finally
            {
                await ms.DisposeAsync();
            }
        }
    }
}
