// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryRepairInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RogueDiaryRepairInfoNotify.proto</summary>
  public static partial class RogueDiaryRepairInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryRepairInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryRepairInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBSb2d1ZURpYXJ5UmVwYWlySW5mb05vdGlmeS5wcm90bxoWUm9ndWVEaWFy",
            "eUF2YXRhci5wcm90bxoYUm9ndWVEaWFyeVJvb21JbmZvLnByb3RvIqcCChpS",
            "b2d1ZURpYXJ5UmVwYWlySW5mb05vdGlmeRIQCghzdGFnZV9pZBgIIAEoDRIY",
            "ChBzZWxlY3RfY2FyZF9saXN0GA4gAygNEiYKC2F2YXRhcl9saXN0GA0gAygL",
            "MhEuUm9ndWVEaWFyeUF2YXRhchImCglyb29tX2xpc3QYAiADKAsyEy5Sb2d1",
            "ZURpYXJ5Um9vbUluZm8SFgoOcmFuZF9jYXJkX2xpc3QYCiADKA0SLQoSc2Vs",
            "ZWN0X2F2YXRhcl9saXN0GAkgAygLMhEuUm9ndWVEaWFyeUF2YXRhchIYChBj",
            "aG9zZW5fY2FyZF9saXN0GA8gAygNEiwKEXRyaWFsX2F2YXRhcl9saXN0GAsg",
            "AygLMhEuUm9ndWVEaWFyeUF2YXRhckIiqgIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RogueDiaryRepairInfoNotify), global::Weedwacker.Shared.Network.Proto.RogueDiaryRepairInfoNotify.Parser, new[]{ "StageId", "SelectCardList", "AvatarList", "RoomList", "RandCardList", "SelectAvatarList", "ChosenCardList", "TrialAvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8641
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class RogueDiaryRepairInfoNotify : pb::IMessage<RogueDiaryRepairInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryRepairInfoNotify> _parser = new pb::MessageParser<RogueDiaryRepairInfoNotify>(() => new RogueDiaryRepairInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryRepairInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RogueDiaryRepairInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryRepairInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryRepairInfoNotify(RogueDiaryRepairInfoNotify other) : this() {
      stageId_ = other.stageId_;
      selectCardList_ = other.selectCardList_.Clone();
      avatarList_ = other.avatarList_.Clone();
      roomList_ = other.roomList_.Clone();
      randCardList_ = other.randCardList_.Clone();
      selectAvatarList_ = other.selectAvatarList_.Clone();
      chosenCardList_ = other.chosenCardList_.Clone();
      trialAvatarList_ = other.trialAvatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryRepairInfoNotify Clone() {
      return new RogueDiaryRepairInfoNotify(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 8;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "select_card_list" field.</summary>
    public const int SelectCardListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_selectCardList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> selectCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectCardList {
      get { return selectCardList_; }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(106, global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> avatarList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "room_list" field.</summary>
    public const int RoomListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo> _repeated_roomList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo> roomList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo> RoomList {
      get { return roomList_; }
    }

    /// <summary>Field number for the "rand_card_list" field.</summary>
    public const int RandCardListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_randCardList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> randCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RandCardList {
      get { return randCardList_; }
    }

    /// <summary>Field number for the "select_avatar_list" field.</summary>
    public const int SelectAvatarListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> _repeated_selectAvatarList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> selectAvatarList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> SelectAvatarList {
      get { return selectAvatarList_; }
    }

    /// <summary>Field number for the "chosen_card_list" field.</summary>
    public const int ChosenCardListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_chosenCardList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> chosenCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenCardList {
      get { return chosenCardList_; }
    }

    /// <summary>Field number for the "trial_avatar_list" field.</summary>
    public const int TrialAvatarListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> _repeated_trialAvatarList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> trialAvatarList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar> TrialAvatarList {
      get { return trialAvatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryRepairInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryRepairInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if(!selectCardList_.Equals(other.selectCardList_)) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if(!roomList_.Equals(other.roomList_)) return false;
      if(!randCardList_.Equals(other.randCardList_)) return false;
      if(!selectAvatarList_.Equals(other.selectAvatarList_)) return false;
      if(!chosenCardList_.Equals(other.chosenCardList_)) return false;
      if(!trialAvatarList_.Equals(other.trialAvatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= selectCardList_.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      hash ^= roomList_.GetHashCode();
      hash ^= randCardList_.GetHashCode();
      hash ^= selectAvatarList_.GetHashCode();
      hash ^= chosenCardList_.GetHashCode();
      hash ^= trialAvatarList_.GetHashCode();
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
      roomList_.WriteTo(output, _repeated_roomList_codec);
      if (StageId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StageId);
      }
      selectAvatarList_.WriteTo(output, _repeated_selectAvatarList_codec);
      randCardList_.WriteTo(output, _repeated_randCardList_codec);
      trialAvatarList_.WriteTo(output, _repeated_trialAvatarList_codec);
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      selectCardList_.WriteTo(output, _repeated_selectCardList_codec);
      chosenCardList_.WriteTo(output, _repeated_chosenCardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      roomList_.WriteTo(ref output, _repeated_roomList_codec);
      if (StageId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StageId);
      }
      selectAvatarList_.WriteTo(ref output, _repeated_selectAvatarList_codec);
      randCardList_.WriteTo(ref output, _repeated_randCardList_codec);
      trialAvatarList_.WriteTo(ref output, _repeated_trialAvatarList_codec);
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      selectCardList_.WriteTo(ref output, _repeated_selectCardList_codec);
      chosenCardList_.WriteTo(ref output, _repeated_chosenCardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += selectCardList_.CalculateSize(_repeated_selectCardList_codec);
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      size += roomList_.CalculateSize(_repeated_roomList_codec);
      size += randCardList_.CalculateSize(_repeated_randCardList_codec);
      size += selectAvatarList_.CalculateSize(_repeated_selectAvatarList_codec);
      size += chosenCardList_.CalculateSize(_repeated_chosenCardList_codec);
      size += trialAvatarList_.CalculateSize(_repeated_trialAvatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryRepairInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      selectCardList_.Add(other.selectCardList_);
      avatarList_.Add(other.avatarList_);
      roomList_.Add(other.roomList_);
      randCardList_.Add(other.randCardList_);
      selectAvatarList_.Add(other.selectAvatarList_);
      chosenCardList_.Add(other.chosenCardList_);
      trialAvatarList_.Add(other.trialAvatarList_);
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
          case 18: {
            roomList_.AddEntriesFrom(input, _repeated_roomList_codec);
            break;
          }
          case 64: {
            StageId = input.ReadUInt32();
            break;
          }
          case 74: {
            selectAvatarList_.AddEntriesFrom(input, _repeated_selectAvatarList_codec);
            break;
          }
          case 82:
          case 80: {
            randCardList_.AddEntriesFrom(input, _repeated_randCardList_codec);
            break;
          }
          case 90: {
            trialAvatarList_.AddEntriesFrom(input, _repeated_trialAvatarList_codec);
            break;
          }
          case 106: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 114:
          case 112: {
            selectCardList_.AddEntriesFrom(input, _repeated_selectCardList_codec);
            break;
          }
          case 122:
          case 120: {
            chosenCardList_.AddEntriesFrom(input, _repeated_chosenCardList_codec);
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
          case 18: {
            roomList_.AddEntriesFrom(ref input, _repeated_roomList_codec);
            break;
          }
          case 64: {
            StageId = input.ReadUInt32();
            break;
          }
          case 74: {
            selectAvatarList_.AddEntriesFrom(ref input, _repeated_selectAvatarList_codec);
            break;
          }
          case 82:
          case 80: {
            randCardList_.AddEntriesFrom(ref input, _repeated_randCardList_codec);
            break;
          }
          case 90: {
            trialAvatarList_.AddEntriesFrom(ref input, _repeated_trialAvatarList_codec);
            break;
          }
          case 106: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 114:
          case 112: {
            selectCardList_.AddEntriesFrom(ref input, _repeated_selectCardList_codec);
            break;
          }
          case 122:
          case 120: {
            chosenCardList_.AddEntriesFrom(ref input, _repeated_chosenCardList_codec);
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
