// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryTiredAvatarNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RogueDiaryTiredAvatarNotify.proto</summary>
  public static partial class RogueDiaryTiredAvatarNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryTiredAvatarNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryTiredAvatarNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFSb2d1ZURpYXJ5VGlyZWRBdmF0YXJOb3RpZnkucHJvdG8aFlJvZ3VlRGlh",
            "cnlBdmF0YXIucHJvdG8imgEKG1JvZ3VlRGlhcnlUaXJlZEF2YXRhck5vdGlm",
            "eRI1ChpvcHRpYW5hbF90aXJlZF9hdmF0YXJfbGlzdBgKIAMoCzIRLlJvZ3Vl",
            "RGlhcnlBdmF0YXISGgoScmVzZXJ2ZV9hdmF0YXJfbnVtGAYgASgNEhIKCnRp",
            "cmVkX3R5cGUYCCABKA0SFAoMaXNfbmVlZF9zaG93GAcgASgIQiKqAh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RogueDiaryTiredAvatarNotify), global::Weedwacker.Shared.Network.Proto.RogueDiaryTiredAvatarNotify.Parser, new[]{ "OptianalTiredAvatarList", "ReserveAvatarNum", "TiredType", "IsNeedShow" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8514
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class RogueDiaryTiredAvatarNotify : pb::IMessage<RogueDiaryTiredAvatarNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryTiredAvatarNotify> _parser = new pb::MessageParser<RogueDiaryTiredAvatarNotify>(() => new RogueDiaryTiredAvatarNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryTiredAvatarNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RogueDiaryTiredAvatarNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryTiredAvatarNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryTiredAvatarNotify(RogueDiaryTiredAvatarNotify other) : this() {
      optianalTiredAvatarList_ = other.optianalTiredAvatarList_.Clone();
      reserveAvatarNum_ = other.reserveAvatarNum_;
      tiredType_ = other.tiredType_;
      isNeedShow_ = other.isNeedShow_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryTiredAvatarNotify Clone() {
      return new RogueDiaryTiredAvatarNotify(this);
    }

    /// <summary>Field number for the "optianal_tired_avatar_list" field.</summary>
    public const int OptianalTiredAvatarListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> _repeated_optianalTiredAvatarList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> optianalTiredAvatarList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> OptianalTiredAvatarList {
      get { return optianalTiredAvatarList_; }
    }

    /// <summary>Field number for the "reserve_avatar_num" field.</summary>
    public const int ReserveAvatarNumFieldNumber = 6;
    private uint reserveAvatarNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReserveAvatarNum {
      get { return reserveAvatarNum_; }
      set {
        reserveAvatarNum_ = value;
      }
    }

    /// <summary>Field number for the "tired_type" field.</summary>
    public const int TiredTypeFieldNumber = 8;
    private uint tiredType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TiredType {
      get { return tiredType_; }
      set {
        tiredType_ = value;
      }
    }

    /// <summary>Field number for the "is_need_show" field.</summary>
    public const int IsNeedShowFieldNumber = 7;
    private bool isNeedShow_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNeedShow {
      get { return isNeedShow_; }
      set {
        isNeedShow_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryTiredAvatarNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryTiredAvatarNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!optianalTiredAvatarList_.Equals(other.optianalTiredAvatarList_)) return false;
      if (ReserveAvatarNum != other.ReserveAvatarNum) return false;
      if (TiredType != other.TiredType) return false;
      if (IsNeedShow != other.IsNeedShow) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= optianalTiredAvatarList_.GetHashCode();
      if (ReserveAvatarNum != 0) hash ^= ReserveAvatarNum.GetHashCode();
      if (TiredType != 0) hash ^= TiredType.GetHashCode();
      if (IsNeedShow != false) hash ^= IsNeedShow.GetHashCode();
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
      if (ReserveAvatarNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ReserveAvatarNum);
      }
      if (IsNeedShow != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsNeedShow);
      }
      if (TiredType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TiredType);
      }
      optianalTiredAvatarList_.WriteTo(output, _repeated_optianalTiredAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ReserveAvatarNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ReserveAvatarNum);
      }
      if (IsNeedShow != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsNeedShow);
      }
      if (TiredType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TiredType);
      }
      optianalTiredAvatarList_.WriteTo(ref output, _repeated_optianalTiredAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += optianalTiredAvatarList_.CalculateSize(_repeated_optianalTiredAvatarList_codec);
      if (ReserveAvatarNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReserveAvatarNum);
      }
      if (TiredType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TiredType);
      }
      if (IsNeedShow != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryTiredAvatarNotify other) {
      if (other == null) {
        return;
      }
      optianalTiredAvatarList_.Add(other.optianalTiredAvatarList_);
      if (other.ReserveAvatarNum != 0) {
        ReserveAvatarNum = other.ReserveAvatarNum;
      }
      if (other.TiredType != 0) {
        TiredType = other.TiredType;
      }
      if (other.IsNeedShow != false) {
        IsNeedShow = other.IsNeedShow;
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
          case 48: {
            ReserveAvatarNum = input.ReadUInt32();
            break;
          }
          case 56: {
            IsNeedShow = input.ReadBool();
            break;
          }
          case 64: {
            TiredType = input.ReadUInt32();
            break;
          }
          case 82: {
            optianalTiredAvatarList_.AddEntriesFrom(input, _repeated_optianalTiredAvatarList_codec);
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
          case 48: {
            ReserveAvatarNum = input.ReadUInt32();
            break;
          }
          case 56: {
            IsNeedShow = input.ReadBool();
            break;
          }
          case 64: {
            TiredType = input.ReadUInt32();
            break;
          }
          case 82: {
            optianalTiredAvatarList_.AddEntriesFrom(ref input, _repeated_optianalTiredAvatarList_codec);
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
