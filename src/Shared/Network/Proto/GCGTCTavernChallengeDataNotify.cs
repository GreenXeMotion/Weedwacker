// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGTCTavernChallengeDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGTCTavernChallengeDataNotify.proto</summary>
  public static partial class GCGTCTavernChallengeDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGTCTavernChallengeDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGTCTavernChallengeDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRHQ0dUQ1RhdmVybkNoYWxsZW5nZURhdGFOb3RpZnkucHJvdG8aHkdDR1RD",
            "VGF2ZXJuQ2hhbGxlbmdlRGF0YS5wcm90byJaCh5HQ0dUQ1RhdmVybkNoYWxs",
            "ZW5nZURhdGFOb3RpZnkSOAoVdGF2ZXJuX2NoYWxsZW5nZV9saXN0GA0gAygL",
            "MhkuR0NHVENUYXZlcm5DaGFsbGVuZ2VEYXRhQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeDataNotify), global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeDataNotify.Parser, new[]{ "TavernChallengeList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 7294
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GCGTCTavernChallengeDataNotify : pb::IMessage<GCGTCTavernChallengeDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGTCTavernChallengeDataNotify> _parser = new pb::MessageParser<GCGTCTavernChallengeDataNotify>(() => new GCGTCTavernChallengeDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGTCTavernChallengeDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGTCTavernChallengeDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGTCTavernChallengeDataNotify(GCGTCTavernChallengeDataNotify other) : this() {
      tavernChallengeList_ = other.tavernChallengeList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGTCTavernChallengeDataNotify Clone() {
      return new GCGTCTavernChallengeDataNotify(this);
    }

    /// <summary>Field number for the "tavern_challenge_list" field.</summary>
    public const int TavernChallengeListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeData> _repeated_tavernChallengeList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeData> tavernChallengeList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGTCTavernChallengeData> TavernChallengeList {
      get { return tavernChallengeList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGTCTavernChallengeDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGTCTavernChallengeDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tavernChallengeList_.Equals(other.tavernChallengeList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tavernChallengeList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      tavernChallengeList_.WriteTo(output, _repeated_tavernChallengeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      tavernChallengeList_.WriteTo(ref output, _repeated_tavernChallengeList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += tavernChallengeList_.CalculateSize(_repeated_tavernChallengeList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGTCTavernChallengeDataNotify other) {
      if (other == null) {
        return;
      }
      tavernChallengeList_.Add(other.tavernChallengeList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 106: {
            tavernChallengeList_.AddEntriesFrom(input, _repeated_tavernChallengeList_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 106: {
            tavernChallengeList_.AddEntriesFrom(ref input, _repeated_tavernChallengeList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
