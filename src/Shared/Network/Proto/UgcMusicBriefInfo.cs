// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UgcMusicBriefInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from UgcMusicBriefInfo.proto</summary>
  public static partial class UgcMusicBriefInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for UgcMusicBriefInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UgcMusicBriefInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdVZ2NNdXNpY0JyaWVmSW5mby5wcm90byLoAwoRVWdjTXVzaWNCcmllZklu",
            "Zm8SHAoUaW1wb3J0X2Zyb21fdWdjX2d1aWQYBSABKAQSFAoMaXNfcHVibGlz",
            "aGVkGAggASgIEhEKCWlzX3BsYXllZBgBIAEoCBIQCghtdXNpY19pZBgCIAEo",
            "DRIXCg5zYXZlX3BhZ2VfdHlwZRieCSABKA0SEAoIc2F2ZV9pZHgYDCABKA0S",
            "GAoQY3JlYXRvcl9uaWNrbmFtZRgKIAEoCRIPCgd2ZXJzaW9uGA8gASgNEhEK",
            "CXNhdmVfdGltZRgDIAEoDRIYCg9hZnRlcl9ub3RlX2xpc3QY6gcgAygNEhkK",
            "EGJlZm9yZV9ub3RlX2xpc3QY1gcgAygNEhcKD2lzX3Bzbl9wbGF0Zm9ybRgJ",
            "IAEoCBIcChN0aW1lX2xpbmVfZWRpdF90aW1lGJ4OIAEoDRIgChhpc19jaGFu",
            "Z2VkX2FmdGVyX3B1Ymxpc2gYCyABKAgSFAoMcHVibGlzaF90aW1lGA0gASgN",
            "EhEKCW1heF9zY29yZRgOIAEoDRIcChNyZWFsX3RpbWVfZWRpdF90aW1lGMAE",
            "IAEoDRISCgpub3RlX2NvdW50GAcgASgNEhAKCHVnY19ndWlkGAQgASgEEhYK",
            "DnNlbGZfbWF4X3Njb3JlGAYgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo), global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo.Parser, new[]{ "ImportFromUgcGuid", "IsPublished", "IsPlayed", "MusicId", "SavePageType", "SaveIdx", "CreatorNickname", "Version", "SaveTime", "AfterNoteList", "BeforeNoteList", "IsPsnPlatform", "TimeLineEditTime", "IsChangedAfterPublish", "PublishTime", "MaxScore", "RealTimeEditTime", "NoteCount", "UgcGuid", "SelfMaxScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UgcMusicBriefInfo : pb::IMessage<UgcMusicBriefInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UgcMusicBriefInfo> _parser = new pb::MessageParser<UgcMusicBriefInfo>(() => new UgcMusicBriefInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UgcMusicBriefInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcMusicBriefInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcMusicBriefInfo(UgcMusicBriefInfo other) : this() {
      importFromUgcGuid_ = other.importFromUgcGuid_;
      isPublished_ = other.isPublished_;
      isPlayed_ = other.isPlayed_;
      musicId_ = other.musicId_;
      savePageType_ = other.savePageType_;
      saveIdx_ = other.saveIdx_;
      creatorNickname_ = other.creatorNickname_;
      version_ = other.version_;
      saveTime_ = other.saveTime_;
      afterNoteList_ = other.afterNoteList_.Clone();
      beforeNoteList_ = other.beforeNoteList_.Clone();
      isPsnPlatform_ = other.isPsnPlatform_;
      timeLineEditTime_ = other.timeLineEditTime_;
      isChangedAfterPublish_ = other.isChangedAfterPublish_;
      publishTime_ = other.publishTime_;
      maxScore_ = other.maxScore_;
      realTimeEditTime_ = other.realTimeEditTime_;
      noteCount_ = other.noteCount_;
      ugcGuid_ = other.ugcGuid_;
      selfMaxScore_ = other.selfMaxScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcMusicBriefInfo Clone() {
      return new UgcMusicBriefInfo(this);
    }

    /// <summary>Field number for the "import_from_ugc_guid" field.</summary>
    public const int ImportFromUgcGuidFieldNumber = 5;
    private ulong importFromUgcGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ImportFromUgcGuid {
      get { return importFromUgcGuid_; }
      set {
        importFromUgcGuid_ = value;
      }
    }

    /// <summary>Field number for the "is_published" field.</summary>
    public const int IsPublishedFieldNumber = 8;
    private bool isPublished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPublished {
      get { return isPublished_; }
      set {
        isPublished_ = value;
      }
    }

    /// <summary>Field number for the "is_played" field.</summary>
    public const int IsPlayedFieldNumber = 1;
    private bool isPlayed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPlayed {
      get { return isPlayed_; }
      set {
        isPlayed_ = value;
      }
    }

    /// <summary>Field number for the "music_id" field.</summary>
    public const int MusicIdFieldNumber = 2;
    private uint musicId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MusicId {
      get { return musicId_; }
      set {
        musicId_ = value;
      }
    }

    /// <summary>Field number for the "save_page_type" field.</summary>
    public const int SavePageTypeFieldNumber = 1182;
    private uint savePageType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SavePageType {
      get { return savePageType_; }
      set {
        savePageType_ = value;
      }
    }

    /// <summary>Field number for the "save_idx" field.</summary>
    public const int SaveIdxFieldNumber = 12;
    private uint saveIdx_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SaveIdx {
      get { return saveIdx_; }
      set {
        saveIdx_ = value;
      }
    }

    /// <summary>Field number for the "creator_nickname" field.</summary>
    public const int CreatorNicknameFieldNumber = 10;
    private string creatorNickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CreatorNickname {
      get { return creatorNickname_; }
      set {
        creatorNickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 15;
    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    /// <summary>Field number for the "save_time" field.</summary>
    public const int SaveTimeFieldNumber = 3;
    private uint saveTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SaveTime {
      get { return saveTime_; }
      set {
        saveTime_ = value;
      }
    }

    /// <summary>Field number for the "after_note_list" field.</summary>
    public const int AfterNoteListFieldNumber = 1002;
    private static readonly pb::FieldCodec<uint> _repeated_afterNoteList_codec
        = pb::FieldCodec.ForUInt32(8018);
    private readonly pbc::RepeatedField<uint> afterNoteList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AfterNoteList {
      get { return afterNoteList_; }
    }

    /// <summary>Field number for the "before_note_list" field.</summary>
    public const int BeforeNoteListFieldNumber = 982;
    private static readonly pb::FieldCodec<uint> _repeated_beforeNoteList_codec
        = pb::FieldCodec.ForUInt32(7858);
    private readonly pbc::RepeatedField<uint> beforeNoteList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BeforeNoteList {
      get { return beforeNoteList_; }
    }

    /// <summary>Field number for the "is_psn_platform" field.</summary>
    public const int IsPsnPlatformFieldNumber = 9;
    private bool isPsnPlatform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPsnPlatform {
      get { return isPsnPlatform_; }
      set {
        isPsnPlatform_ = value;
      }
    }

    /// <summary>Field number for the "time_line_edit_time" field.</summary>
    public const int TimeLineEditTimeFieldNumber = 1822;
    private uint timeLineEditTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeLineEditTime {
      get { return timeLineEditTime_; }
      set {
        timeLineEditTime_ = value;
      }
    }

    /// <summary>Field number for the "is_changed_after_publish" field.</summary>
    public const int IsChangedAfterPublishFieldNumber = 11;
    private bool isChangedAfterPublish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsChangedAfterPublish {
      get { return isChangedAfterPublish_; }
      set {
        isChangedAfterPublish_ = value;
      }
    }

    /// <summary>Field number for the "publish_time" field.</summary>
    public const int PublishTimeFieldNumber = 13;
    private uint publishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PublishTime {
      get { return publishTime_; }
      set {
        publishTime_ = value;
      }
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 14;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    /// <summary>Field number for the "real_time_edit_time" field.</summary>
    public const int RealTimeEditTimeFieldNumber = 576;
    private uint realTimeEditTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RealTimeEditTime {
      get { return realTimeEditTime_; }
      set {
        realTimeEditTime_ = value;
      }
    }

    /// <summary>Field number for the "note_count" field.</summary>
    public const int NoteCountFieldNumber = 7;
    private uint noteCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NoteCount {
      get { return noteCount_; }
      set {
        noteCount_ = value;
      }
    }

    /// <summary>Field number for the "ugc_guid" field.</summary>
    public const int UgcGuidFieldNumber = 4;
    private ulong ugcGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UgcGuid {
      get { return ugcGuid_; }
      set {
        ugcGuid_ = value;
      }
    }

    /// <summary>Field number for the "self_max_score" field.</summary>
    public const int SelfMaxScoreFieldNumber = 6;
    private uint selfMaxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelfMaxScore {
      get { return selfMaxScore_; }
      set {
        selfMaxScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UgcMusicBriefInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UgcMusicBriefInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ImportFromUgcGuid != other.ImportFromUgcGuid) return false;
      if (IsPublished != other.IsPublished) return false;
      if (IsPlayed != other.IsPlayed) return false;
      if (MusicId != other.MusicId) return false;
      if (SavePageType != other.SavePageType) return false;
      if (SaveIdx != other.SaveIdx) return false;
      if (CreatorNickname != other.CreatorNickname) return false;
      if (Version != other.Version) return false;
      if (SaveTime != other.SaveTime) return false;
      if(!afterNoteList_.Equals(other.afterNoteList_)) return false;
      if(!beforeNoteList_.Equals(other.beforeNoteList_)) return false;
      if (IsPsnPlatform != other.IsPsnPlatform) return false;
      if (TimeLineEditTime != other.TimeLineEditTime) return false;
      if (IsChangedAfterPublish != other.IsChangedAfterPublish) return false;
      if (PublishTime != other.PublishTime) return false;
      if (MaxScore != other.MaxScore) return false;
      if (RealTimeEditTime != other.RealTimeEditTime) return false;
      if (NoteCount != other.NoteCount) return false;
      if (UgcGuid != other.UgcGuid) return false;
      if (SelfMaxScore != other.SelfMaxScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ImportFromUgcGuid != 0UL) hash ^= ImportFromUgcGuid.GetHashCode();
      if (IsPublished != false) hash ^= IsPublished.GetHashCode();
      if (IsPlayed != false) hash ^= IsPlayed.GetHashCode();
      if (MusicId != 0) hash ^= MusicId.GetHashCode();
      if (SavePageType != 0) hash ^= SavePageType.GetHashCode();
      if (SaveIdx != 0) hash ^= SaveIdx.GetHashCode();
      if (CreatorNickname.Length != 0) hash ^= CreatorNickname.GetHashCode();
      if (Version != 0) hash ^= Version.GetHashCode();
      if (SaveTime != 0) hash ^= SaveTime.GetHashCode();
      hash ^= afterNoteList_.GetHashCode();
      hash ^= beforeNoteList_.GetHashCode();
      if (IsPsnPlatform != false) hash ^= IsPsnPlatform.GetHashCode();
      if (TimeLineEditTime != 0) hash ^= TimeLineEditTime.GetHashCode();
      if (IsChangedAfterPublish != false) hash ^= IsChangedAfterPublish.GetHashCode();
      if (PublishTime != 0) hash ^= PublishTime.GetHashCode();
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
      if (RealTimeEditTime != 0) hash ^= RealTimeEditTime.GetHashCode();
      if (NoteCount != 0) hash ^= NoteCount.GetHashCode();
      if (UgcGuid != 0UL) hash ^= UgcGuid.GetHashCode();
      if (SelfMaxScore != 0) hash ^= SelfMaxScore.GetHashCode();
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
      if (IsPlayed != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsPlayed);
      }
      if (MusicId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MusicId);
      }
      if (SaveTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SaveTime);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(UgcGuid);
      }
      if (ImportFromUgcGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(ImportFromUgcGuid);
      }
      if (SelfMaxScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SelfMaxScore);
      }
      if (NoteCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(NoteCount);
      }
      if (IsPublished != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsPublished);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (CreatorNickname.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(CreatorNickname);
      }
      if (IsChangedAfterPublish != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsChangedAfterPublish);
      }
      if (SaveIdx != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SaveIdx);
      }
      if (PublishTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PublishTime);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MaxScore);
      }
      if (Version != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Version);
      }
      if (RealTimeEditTime != 0) {
        output.WriteRawTag(128, 36);
        output.WriteUInt32(RealTimeEditTime);
      }
      beforeNoteList_.WriteTo(output, _repeated_beforeNoteList_codec);
      afterNoteList_.WriteTo(output, _repeated_afterNoteList_codec);
      if (SavePageType != 0) {
        output.WriteRawTag(240, 73);
        output.WriteUInt32(SavePageType);
      }
      if (TimeLineEditTime != 0) {
        output.WriteRawTag(240, 113);
        output.WriteUInt32(TimeLineEditTime);
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
      if (IsPlayed != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsPlayed);
      }
      if (MusicId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MusicId);
      }
      if (SaveTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SaveTime);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(UgcGuid);
      }
      if (ImportFromUgcGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(ImportFromUgcGuid);
      }
      if (SelfMaxScore != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SelfMaxScore);
      }
      if (NoteCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(NoteCount);
      }
      if (IsPublished != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsPublished);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (CreatorNickname.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(CreatorNickname);
      }
      if (IsChangedAfterPublish != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsChangedAfterPublish);
      }
      if (SaveIdx != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SaveIdx);
      }
      if (PublishTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PublishTime);
      }
      if (MaxScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MaxScore);
      }
      if (Version != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Version);
      }
      if (RealTimeEditTime != 0) {
        output.WriteRawTag(128, 36);
        output.WriteUInt32(RealTimeEditTime);
      }
      beforeNoteList_.WriteTo(ref output, _repeated_beforeNoteList_codec);
      afterNoteList_.WriteTo(ref output, _repeated_afterNoteList_codec);
      if (SavePageType != 0) {
        output.WriteRawTag(240, 73);
        output.WriteUInt32(SavePageType);
      }
      if (TimeLineEditTime != 0) {
        output.WriteRawTag(240, 113);
        output.WriteUInt32(TimeLineEditTime);
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
      if (ImportFromUgcGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ImportFromUgcGuid);
      }
      if (IsPublished != false) {
        size += 1 + 1;
      }
      if (IsPlayed != false) {
        size += 1 + 1;
      }
      if (MusicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MusicId);
      }
      if (SavePageType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SavePageType);
      }
      if (SaveIdx != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SaveIdx);
      }
      if (CreatorNickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreatorNickname);
      }
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      if (SaveTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SaveTime);
      }
      size += afterNoteList_.CalculateSize(_repeated_afterNoteList_codec);
      size += beforeNoteList_.CalculateSize(_repeated_beforeNoteList_codec);
      if (IsPsnPlatform != false) {
        size += 1 + 1;
      }
      if (TimeLineEditTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(TimeLineEditTime);
      }
      if (IsChangedAfterPublish != false) {
        size += 1 + 1;
      }
      if (PublishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PublishTime);
      }
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (RealTimeEditTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(RealTimeEditTime);
      }
      if (NoteCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NoteCount);
      }
      if (UgcGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UgcGuid);
      }
      if (SelfMaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelfMaxScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UgcMusicBriefInfo other) {
      if (other == null) {
        return;
      }
      if (other.ImportFromUgcGuid != 0UL) {
        ImportFromUgcGuid = other.ImportFromUgcGuid;
      }
      if (other.IsPublished != false) {
        IsPublished = other.IsPublished;
      }
      if (other.IsPlayed != false) {
        IsPlayed = other.IsPlayed;
      }
      if (other.MusicId != 0) {
        MusicId = other.MusicId;
      }
      if (other.SavePageType != 0) {
        SavePageType = other.SavePageType;
      }
      if (other.SaveIdx != 0) {
        SaveIdx = other.SaveIdx;
      }
      if (other.CreatorNickname.Length != 0) {
        CreatorNickname = other.CreatorNickname;
      }
      if (other.Version != 0) {
        Version = other.Version;
      }
      if (other.SaveTime != 0) {
        SaveTime = other.SaveTime;
      }
      afterNoteList_.Add(other.afterNoteList_);
      beforeNoteList_.Add(other.beforeNoteList_);
      if (other.IsPsnPlatform != false) {
        IsPsnPlatform = other.IsPsnPlatform;
      }
      if (other.TimeLineEditTime != 0) {
        TimeLineEditTime = other.TimeLineEditTime;
      }
      if (other.IsChangedAfterPublish != false) {
        IsChangedAfterPublish = other.IsChangedAfterPublish;
      }
      if (other.PublishTime != 0) {
        PublishTime = other.PublishTime;
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
      }
      if (other.RealTimeEditTime != 0) {
        RealTimeEditTime = other.RealTimeEditTime;
      }
      if (other.NoteCount != 0) {
        NoteCount = other.NoteCount;
      }
      if (other.UgcGuid != 0UL) {
        UgcGuid = other.UgcGuid;
      }
      if (other.SelfMaxScore != 0) {
        SelfMaxScore = other.SelfMaxScore;
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
          case 8: {
            IsPlayed = input.ReadBool();
            break;
          }
          case 16: {
            MusicId = input.ReadUInt32();
            break;
          }
          case 24: {
            SaveTime = input.ReadUInt32();
            break;
          }
          case 32: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 40: {
            ImportFromUgcGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            SelfMaxScore = input.ReadUInt32();
            break;
          }
          case 56: {
            NoteCount = input.ReadUInt32();
            break;
          }
          case 64: {
            IsPublished = input.ReadBool();
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            CreatorNickname = input.ReadString();
            break;
          }
          case 88: {
            IsChangedAfterPublish = input.ReadBool();
            break;
          }
          case 96: {
            SaveIdx = input.ReadUInt32();
            break;
          }
          case 104: {
            PublishTime = input.ReadUInt32();
            break;
          }
          case 112: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 120: {
            Version = input.ReadUInt32();
            break;
          }
          case 4608: {
            RealTimeEditTime = input.ReadUInt32();
            break;
          }
          case 7858:
          case 7856: {
            beforeNoteList_.AddEntriesFrom(input, _repeated_beforeNoteList_codec);
            break;
          }
          case 8018:
          case 8016: {
            afterNoteList_.AddEntriesFrom(input, _repeated_afterNoteList_codec);
            break;
          }
          case 9456: {
            SavePageType = input.ReadUInt32();
            break;
          }
          case 14576: {
            TimeLineEditTime = input.ReadUInt32();
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
            IsPlayed = input.ReadBool();
            break;
          }
          case 16: {
            MusicId = input.ReadUInt32();
            break;
          }
          case 24: {
            SaveTime = input.ReadUInt32();
            break;
          }
          case 32: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 40: {
            ImportFromUgcGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            SelfMaxScore = input.ReadUInt32();
            break;
          }
          case 56: {
            NoteCount = input.ReadUInt32();
            break;
          }
          case 64: {
            IsPublished = input.ReadBool();
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            CreatorNickname = input.ReadString();
            break;
          }
          case 88: {
            IsChangedAfterPublish = input.ReadBool();
            break;
          }
          case 96: {
            SaveIdx = input.ReadUInt32();
            break;
          }
          case 104: {
            PublishTime = input.ReadUInt32();
            break;
          }
          case 112: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 120: {
            Version = input.ReadUInt32();
            break;
          }
          case 4608: {
            RealTimeEditTime = input.ReadUInt32();
            break;
          }
          case 7858:
          case 7856: {
            beforeNoteList_.AddEntriesFrom(ref input, _repeated_beforeNoteList_codec);
            break;
          }
          case 8018:
          case 8016: {
            afterNoteList_.AddEntriesFrom(ref input, _repeated_afterNoteList_codec);
            break;
          }
          case 9456: {
            SavePageType = input.ReadUInt32();
            break;
          }
          case 14576: {
            TimeLineEditTime = input.ReadUInt32();
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
