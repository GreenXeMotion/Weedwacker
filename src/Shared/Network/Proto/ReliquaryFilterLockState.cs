// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReliquaryFilterLockState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ReliquaryFilterLockState.proto</summary>
  public static partial class ReliquaryFilterLockStateReflection {

    #region Descriptor
    /// <summary>File descriptor for ReliquaryFilterLockState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReliquaryFilterLockStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5SZWxpcXVhcnlGaWx0ZXJMb2NrU3RhdGUucHJvdG8SH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8qjgEKGFJlbGlxdWFyeUZpbHRlckxvY2tT",
            "dGF0ZRIkCiBSRUxJUVVBUllfRklMVEVSX0xPQ0tfU1RBVEVfTk9ORRAAEiQK",
            "IFJFTElRVUFSWV9GSUxURVJfTE9DS19TVEFURV9MT0NLEAESJgoiUkVMSVFV",
            "QVJZX0ZJTFRFUl9MT0NLX1NUQVRFX1VOTE9DSxACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.ReliquaryFilterLockState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ReliquaryFilterLockState {
    [pbr::OriginalName("RELIQUARY_FILTER_LOCK_STATE_NONE")] None = 0,
    [pbr::OriginalName("RELIQUARY_FILTER_LOCK_STATE_LOCK")] Lock = 1,
    [pbr::OriginalName("RELIQUARY_FILTER_LOCK_STATE_UNLOCK")] Unlock = 2,
  }

  #endregion

}

#endregion Designer generated code