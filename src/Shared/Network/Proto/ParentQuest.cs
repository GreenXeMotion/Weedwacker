// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ParentQuest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ParentQuest.proto</summary>
  public static partial class ParentQuestReflection {

    #region Descriptor
    /// <summary>File descriptor for ParentQuest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParentQuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQYXJlbnRRdWVzdC5wcm90bxoQQ2hpbGRRdWVzdC5wcm90bxoXSW5mZXJl",
            "bmNlUGFnZUluZm8ucHJvdG8aG1BhcmVudFF1ZXN0UmFuZG9tSW5mby5wcm90",
            "byKTAwoLUGFyZW50UXVlc3QSEQoJcXVlc3RfdmFyGA4gAygFEjIKDHRpbWVf",
            "dmFyX21hcBgIIAMoCzIcLlBhcmVudFF1ZXN0LlRpbWVWYXJNYXBFbnRyeRIa",
            "ChJwYXJlbnRfcXVlc3Rfc3RhdGUYASABKA0SEwoLaXNfZmluaXNoZWQYByAB",
            "KAgSLwoTaW5mZXJlbmNlX3BhZ2VfbGlzdBgPIAMoCzISLkluZmVyZW5jZVBh",
            "Z2VJbmZvEisKC3JhbmRvbV9pbmZvGAwgASgLMhYuUGFyZW50UXVlc3RSYW5k",
            "b21JbmZvEhcKD3BhcmVudF9xdWVzdF9pZBgDIAEoDRIRCglpc19yYW5kb20Y",
            "DSABKAgSEQoJdmlkZW9fa2V5GAYgASgEEhUKDXF1ZXN0X3Zhcl9zZXEYCyAB",
            "KA0SJQoQY2hpbGRfcXVlc3RfbGlzdBgJIAMoCzILLkNoaWxkUXVlc3QaMQoP",
            "VGltZVZhck1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToC",
            "OAFCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ChildQuestReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.InferencePageInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ParentQuest), global::Weedwacker.Shared.Network.Proto.ParentQuest.Parser, new[]{ "QuestVar", "TimeVarMap", "ParentQuestState", "IsFinished", "InferencePageList", "RandomInfo", "ParentQuestId", "IsRandom", "VideoKey", "QuestVarSeq", "ChildQuestList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ParentQuest : pb::IMessage<ParentQuest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ParentQuest> _parser = new pb::MessageParser<ParentQuest>(() => new ParentQuest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ParentQuest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ParentQuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParentQuest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParentQuest(ParentQuest other) : this() {
      questVar_ = other.questVar_.Clone();
      timeVarMap_ = other.timeVarMap_.Clone();
      parentQuestState_ = other.parentQuestState_;
      isFinished_ = other.isFinished_;
      inferencePageList_ = other.inferencePageList_.Clone();
      randomInfo_ = other.randomInfo_ != null ? other.randomInfo_.Clone() : null;
      parentQuestId_ = other.parentQuestId_;
      isRandom_ = other.isRandom_;
      videoKey_ = other.videoKey_;
      questVarSeq_ = other.questVarSeq_;
      childQuestList_ = other.childQuestList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParentQuest Clone() {
      return new ParentQuest(this);
    }

    /// <summary>Field number for the "quest_var" field.</summary>
    public const int QuestVarFieldNumber = 14;
    private static readonly pb::FieldCodec<int> _repeated_questVar_codec
        = pb::FieldCodec.ForInt32(114);
    private readonly pbc::RepeatedField<int> questVar_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> QuestVar {
      get { return questVar_; }
    }

    /// <summary>Field number for the "time_var_map" field.</summary>
    public const int TimeVarMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, uint>.Codec _map_timeVarMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 66);
    private readonly pbc::MapField<uint, uint> timeVarMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> TimeVarMap {
      get { return timeVarMap_; }
    }

    /// <summary>Field number for the "parent_quest_state" field.</summary>
    public const int ParentQuestStateFieldNumber = 1;
    private uint parentQuestState_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestState {
      get { return parentQuestState_; }
      set {
        parentQuestState_ = value;
      }
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 7;
    private bool isFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinished {
      get { return isFinished_; }
      set {
        isFinished_ = value;
      }
    }

    /// <summary>Field number for the "inference_page_list" field.</summary>
    public const int InferencePageListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.InferencePageInfo> _repeated_inferencePageList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.InferencePageInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InferencePageInfo> inferencePageList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InferencePageInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InferencePageInfo> InferencePageList {
      get { return inferencePageList_; }
    }

    /// <summary>Field number for the "random_info" field.</summary>
    public const int RandomInfoFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfo randomInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfo RandomInfo {
      get { return randomInfo_; }
      set {
        randomInfo_ = value;
      }
    }

    /// <summary>Field number for the "parent_quest_id" field.</summary>
    public const int ParentQuestIdFieldNumber = 3;
    private uint parentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestId {
      get { return parentQuestId_; }
      set {
        parentQuestId_ = value;
      }
    }

    /// <summary>Field number for the "is_random" field.</summary>
    public const int IsRandomFieldNumber = 13;
    private bool isRandom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRandom {
      get { return isRandom_; }
      set {
        isRandom_ = value;
      }
    }

    /// <summary>Field number for the "video_key" field.</summary>
    public const int VideoKeyFieldNumber = 6;
    private ulong videoKey_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong VideoKey {
      get { return videoKey_; }
      set {
        videoKey_ = value;
      }
    }

    /// <summary>Field number for the "quest_var_seq" field.</summary>
    public const int QuestVarSeqFieldNumber = 11;
    private uint questVarSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestVarSeq {
      get { return questVarSeq_; }
      set {
        questVarSeq_ = value;
      }
    }

    /// <summary>Field number for the "child_quest_list" field.</summary>
    public const int ChildQuestListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ChildQuest> _repeated_childQuestList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.ChildQuest.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChildQuest> childQuestList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChildQuest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChildQuest> ChildQuestList {
      get { return childQuestList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ParentQuest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ParentQuest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!questVar_.Equals(other.questVar_)) return false;
      if (!TimeVarMap.Equals(other.TimeVarMap)) return false;
      if (ParentQuestState != other.ParentQuestState) return false;
      if (IsFinished != other.IsFinished) return false;
      if(!inferencePageList_.Equals(other.inferencePageList_)) return false;
      if (!object.Equals(RandomInfo, other.RandomInfo)) return false;
      if (ParentQuestId != other.ParentQuestId) return false;
      if (IsRandom != other.IsRandom) return false;
      if (VideoKey != other.VideoKey) return false;
      if (QuestVarSeq != other.QuestVarSeq) return false;
      if(!childQuestList_.Equals(other.childQuestList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= questVar_.GetHashCode();
      hash ^= TimeVarMap.GetHashCode();
      if (ParentQuestState != 0) hash ^= ParentQuestState.GetHashCode();
      if (IsFinished != false) hash ^= IsFinished.GetHashCode();
      hash ^= inferencePageList_.GetHashCode();
      if (randomInfo_ != null) hash ^= RandomInfo.GetHashCode();
      if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
      if (IsRandom != false) hash ^= IsRandom.GetHashCode();
      if (VideoKey != 0UL) hash ^= VideoKey.GetHashCode();
      if (QuestVarSeq != 0) hash ^= QuestVarSeq.GetHashCode();
      hash ^= childQuestList_.GetHashCode();
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
      if (ParentQuestState != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestState);
      }
      if (ParentQuestId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ParentQuestId);
      }
      if (VideoKey != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(VideoKey);
      }
      if (IsFinished != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinished);
      }
      timeVarMap_.WriteTo(output, _map_timeVarMap_codec);
      childQuestList_.WriteTo(output, _repeated_childQuestList_codec);
      if (QuestVarSeq != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(QuestVarSeq);
      }
      if (randomInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RandomInfo);
      }
      if (IsRandom != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsRandom);
      }
      questVar_.WriteTo(output, _repeated_questVar_codec);
      inferencePageList_.WriteTo(output, _repeated_inferencePageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ParentQuestState != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestState);
      }
      if (ParentQuestId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ParentQuestId);
      }
      if (VideoKey != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(VideoKey);
      }
      if (IsFinished != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinished);
      }
      timeVarMap_.WriteTo(ref output, _map_timeVarMap_codec);
      childQuestList_.WriteTo(ref output, _repeated_childQuestList_codec);
      if (QuestVarSeq != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(QuestVarSeq);
      }
      if (randomInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(RandomInfo);
      }
      if (IsRandom != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsRandom);
      }
      questVar_.WriteTo(ref output, _repeated_questVar_codec);
      inferencePageList_.WriteTo(ref output, _repeated_inferencePageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += questVar_.CalculateSize(_repeated_questVar_codec);
      size += timeVarMap_.CalculateSize(_map_timeVarMap_codec);
      if (ParentQuestState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestState);
      }
      if (IsFinished != false) {
        size += 1 + 1;
      }
      size += inferencePageList_.CalculateSize(_repeated_inferencePageList_codec);
      if (randomInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RandomInfo);
      }
      if (ParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
      }
      if (IsRandom != false) {
        size += 1 + 1;
      }
      if (VideoKey != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(VideoKey);
      }
      if (QuestVarSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestVarSeq);
      }
      size += childQuestList_.CalculateSize(_repeated_childQuestList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ParentQuest other) {
      if (other == null) {
        return;
      }
      questVar_.Add(other.questVar_);
      timeVarMap_.Add(other.timeVarMap_);
      if (other.ParentQuestState != 0) {
        ParentQuestState = other.ParentQuestState;
      }
      if (other.IsFinished != false) {
        IsFinished = other.IsFinished;
      }
      inferencePageList_.Add(other.inferencePageList_);
      if (other.randomInfo_ != null) {
        if (randomInfo_ == null) {
          RandomInfo = new global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfo();
        }
        RandomInfo.MergeFrom(other.RandomInfo);
      }
      if (other.ParentQuestId != 0) {
        ParentQuestId = other.ParentQuestId;
      }
      if (other.IsRandom != false) {
        IsRandom = other.IsRandom;
      }
      if (other.VideoKey != 0UL) {
        VideoKey = other.VideoKey;
      }
      if (other.QuestVarSeq != 0) {
        QuestVarSeq = other.QuestVarSeq;
      }
      childQuestList_.Add(other.childQuestList_);
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
          case 8: {
            ParentQuestState = input.ReadUInt32();
            break;
          }
          case 24: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 48: {
            VideoKey = input.ReadUInt64();
            break;
          }
          case 56: {
            IsFinished = input.ReadBool();
            break;
          }
          case 66: {
            timeVarMap_.AddEntriesFrom(input, _map_timeVarMap_codec);
            break;
          }
          case 74: {
            childQuestList_.AddEntriesFrom(input, _repeated_childQuestList_codec);
            break;
          }
          case 88: {
            QuestVarSeq = input.ReadUInt32();
            break;
          }
          case 98: {
            if (randomInfo_ == null) {
              RandomInfo = new global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfo();
            }
            input.ReadMessage(RandomInfo);
            break;
          }
          case 104: {
            IsRandom = input.ReadBool();
            break;
          }
          case 114:
          case 112: {
            questVar_.AddEntriesFrom(input, _repeated_questVar_codec);
            break;
          }
          case 122: {
            inferencePageList_.AddEntriesFrom(input, _repeated_inferencePageList_codec);
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
          case 8: {
            ParentQuestState = input.ReadUInt32();
            break;
          }
          case 24: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 48: {
            VideoKey = input.ReadUInt64();
            break;
          }
          case 56: {
            IsFinished = input.ReadBool();
            break;
          }
          case 66: {
            timeVarMap_.AddEntriesFrom(ref input, _map_timeVarMap_codec);
            break;
          }
          case 74: {
            childQuestList_.AddEntriesFrom(ref input, _repeated_childQuestList_codec);
            break;
          }
          case 88: {
            QuestVarSeq = input.ReadUInt32();
            break;
          }
          case 98: {
            if (randomInfo_ == null) {
              RandomInfo = new global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfo();
            }
            input.ReadMessage(RandomInfo);
            break;
          }
          case 104: {
            IsRandom = input.ReadBool();
            break;
          }
          case 114:
          case 112: {
            questVar_.AddEntriesFrom(ref input, _repeated_questVar_codec);
            break;
          }
          case 122: {
            inferencePageList_.AddEntriesFrom(ref input, _repeated_inferencePageList_codec);
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
