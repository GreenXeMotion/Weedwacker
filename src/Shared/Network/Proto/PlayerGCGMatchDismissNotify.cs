// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerGCGMatchDismissNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerGCGMatchDismissNotify.proto</summary>
  public static partial class PlayerGCGMatchDismissNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerGCGMatchDismissNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerGCGMatchDismissNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFQbGF5ZXJHQ0dNYXRjaERpc21pc3NOb3RpZnkucHJvdG8aEU1hdGNoUmVh",
            "c29uLnByb3RvIl8KG1BsYXllckdDR01hdGNoRGlzbWlzc05vdGlmeRIQCght",
            "YXRjaF9pZBgLIAEoDRIcCgZyZWFzb24YBSABKA4yDC5NYXRjaFJlYXNvbhIQ",
            "Cgh1aWRfbGlzdBgHIAMoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MatchReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerGCGMatchDismissNotify), global::Weedwacker.Shared.Network.Proto.PlayerGCGMatchDismissNotify.Parser, new[]{ "MatchId", "Reason", "UidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4173
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerGCGMatchDismissNotify : pb::IMessage<PlayerGCGMatchDismissNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerGCGMatchDismissNotify> _parser = new pb::MessageParser<PlayerGCGMatchDismissNotify>(() => new PlayerGCGMatchDismissNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerGCGMatchDismissNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerGCGMatchDismissNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGCGMatchDismissNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGCGMatchDismissNotify(PlayerGCGMatchDismissNotify other) : this() {
      matchId_ = other.matchId_;
      reason_ = other.reason_;
      uidList_ = other.uidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGCGMatchDismissNotify Clone() {
      return new PlayerGCGMatchDismissNotify(this);
    }

    /// <summary>Field number for the "match_id" field.</summary>
    public const int MatchIdFieldNumber = 11;
    private uint matchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MatchId {
      get { return matchId_; }
      set {
        matchId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.MatchReason reason_ = global::Weedwacker.Shared.Network.Proto.MatchReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MatchReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerGCGMatchDismissNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerGCGMatchDismissNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MatchId != other.MatchId) return false;
      if (Reason != other.Reason) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MatchId != 0) hash ^= MatchId.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) hash ^= Reason.GetHashCode();
      hash ^= uidList_.GetHashCode();
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
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Reason);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      if (MatchId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MatchId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Reason);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      if (MatchId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MatchId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MatchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MatchId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerGCGMatchDismissNotify other) {
      if (other == null) {
        return;
      }
      if (other.MatchId != 0) {
        MatchId = other.MatchId;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.MatchReason.None) {
        Reason = other.Reason;
      }
      uidList_.Add(other.uidList_);
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
          case 40: {
            Reason = (global::Weedwacker.Shared.Network.Proto.MatchReason) input.ReadEnum();
            break;
          }
          case 58:
          case 56: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
            break;
          }
          case 88: {
            MatchId = input.ReadUInt32();
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
          case 40: {
            Reason = (global::Weedwacker.Shared.Network.Proto.MatchReason) input.ReadEnum();
            break;
          }
          case 58:
          case 56: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
            break;
          }
          case 88: {
            MatchId = input.ReadUInt32();
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
