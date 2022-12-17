// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewPlayCardInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewPlayCardInfo.proto</summary>
  public static partial class GCGSkillPreviewPlayCardInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewPlayCardInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewPlayCardInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFHQ0dTa2lsbFByZXZpZXdQbGF5Q2FyZEluZm8ucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8aGUdDR1NraWxsUHJldmlld0luZm8u",
            "cHJvdG8inQEKG0dDR1NraWxsUHJldmlld1BsYXlDYXJkSW5mbxIWCg5oYW5k",
            "X2NhcmRfZ3VpZBgPIAEoDRJMCg5wbGF5X2NhcmRfaW5mbxgKIAEoCzI0Lldl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uR0NHU2tpbGxQcmV2aWV3",
            "SW5mbxIYChB0YXJnZXRfY2FyZF9ndWlkGAggASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfo), global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfo.Parser, new[]{ "HandCardGuid", "PlayCardInfo", "TargetCardGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGSkillPreviewPlayCardInfo : pb::IMessage<GCGSkillPreviewPlayCardInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewPlayCardInfo> _parser = new pb::MessageParser<GCGSkillPreviewPlayCardInfo>(() => new GCGSkillPreviewPlayCardInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewPlayCardInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewPlayCardInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewPlayCardInfo(GCGSkillPreviewPlayCardInfo other) : this() {
      handCardGuid_ = other.handCardGuid_;
      playCardInfo_ = other.playCardInfo_ != null ? other.playCardInfo_.Clone() : null;
      targetCardGuid_ = other.targetCardGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewPlayCardInfo Clone() {
      return new GCGSkillPreviewPlayCardInfo(this);
    }

    /// <summary>Field number for the "hand_card_guid" field.</summary>
    public const int HandCardGuidFieldNumber = 15;
    private uint handCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HandCardGuid {
      get { return handCardGuid_; }
      set {
        handCardGuid_ = value;
      }
    }

    /// <summary>Field number for the "play_card_info" field.</summary>
    public const int PlayCardInfoFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo playCardInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo PlayCardInfo {
      get { return playCardInfo_; }
      set {
        playCardInfo_ = value;
      }
    }

    /// <summary>Field number for the "target_card_guid" field.</summary>
    public const int TargetCardGuidFieldNumber = 8;
    private uint targetCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetCardGuid {
      get { return targetCardGuid_; }
      set {
        targetCardGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewPlayCardInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewPlayCardInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HandCardGuid != other.HandCardGuid) return false;
      if (!object.Equals(PlayCardInfo, other.PlayCardInfo)) return false;
      if (TargetCardGuid != other.TargetCardGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HandCardGuid != 0) hash ^= HandCardGuid.GetHashCode();
      if (playCardInfo_ != null) hash ^= PlayCardInfo.GetHashCode();
      if (TargetCardGuid != 0) hash ^= TargetCardGuid.GetHashCode();
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
      if (TargetCardGuid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TargetCardGuid);
      }
      if (playCardInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PlayCardInfo);
      }
      if (HandCardGuid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HandCardGuid);
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
      if (TargetCardGuid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TargetCardGuid);
      }
      if (playCardInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PlayCardInfo);
      }
      if (HandCardGuid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HandCardGuid);
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
      if (HandCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HandCardGuid);
      }
      if (playCardInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayCardInfo);
      }
      if (TargetCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetCardGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewPlayCardInfo other) {
      if (other == null) {
        return;
      }
      if (other.HandCardGuid != 0) {
        HandCardGuid = other.HandCardGuid;
      }
      if (other.playCardInfo_ != null) {
        if (playCardInfo_ == null) {
          PlayCardInfo = new global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo();
        }
        PlayCardInfo.MergeFrom(other.PlayCardInfo);
      }
      if (other.TargetCardGuid != 0) {
        TargetCardGuid = other.TargetCardGuid;
      }
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
          case 64: {
            TargetCardGuid = input.ReadUInt32();
            break;
          }
          case 82: {
            if (playCardInfo_ == null) {
              PlayCardInfo = new global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo();
            }
            input.ReadMessage(PlayCardInfo);
            break;
          }
          case 120: {
            HandCardGuid = input.ReadUInt32();
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
          case 64: {
            TargetCardGuid = input.ReadUInt32();
            break;
          }
          case 82: {
            if (playCardInfo_ == null) {
              PlayCardInfo = new global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo();
            }
            input.ReadMessage(PlayCardInfo);
            break;
          }
          case 120: {
            HandCardGuid = input.ReadUInt32();
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