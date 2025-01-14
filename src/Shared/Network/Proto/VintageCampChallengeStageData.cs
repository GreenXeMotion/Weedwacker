// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageCampChallengeStageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageCampChallengeStageData.proto</summary>
  public static partial class VintageCampChallengeStageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageCampChallengeStageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageCampChallengeStageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNWaW50YWdlQ2FtcENoYWxsZW5nZVN0YWdlRGF0YS5wcm90bxojVmludGFn",
            "ZUNhbXBDaGFsbGVuZ2VMZXZlbERhdGEucHJvdG8iowIKHVZpbnRhZ2VDYW1w",
            "Q2hhbGxlbmdlU3RhZ2VEYXRhEg8KB2lzX29wZW4YBSABKAgSGgoSbWF4X2Zp",
            "bmlzaGVkX2xldmVsGAsgASgNEhEKCW9wZW5fdGltZRgDIAEoDRIRCglpc19m",
            "aW5pc2gYCiABKAgSEAoIc3RhZ2VfaWQYBCABKA0SSAoOY2FtcF9sZXZlbF9t",
            "YXAYAiADKAsyMC5WaW50YWdlQ2FtcENoYWxsZW5nZVN0YWdlRGF0YS5DYW1w",
            "TGV2ZWxNYXBFbnRyeRpTChFDYW1wTGV2ZWxNYXBFbnRyeRILCgNrZXkYASAB",
            "KA0SLQoFdmFsdWUYAiABKAsyHi5WaW50YWdlQ2FtcENoYWxsZW5nZUxldmVs",
            "RGF0YToCOAFCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VintageCampChallengeLevelDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData), global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData.Parser, new[]{ "IsOpen", "MaxFinishedLevel", "OpenTime", "IsFinish", "StageId", "CampLevelMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageCampChallengeStageData : pb::IMessage<VintageCampChallengeStageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageCampChallengeStageData> _parser = new pb::MessageParser<VintageCampChallengeStageData>(() => new VintageCampChallengeStageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageCampChallengeStageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageCampChallengeStageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageCampChallengeStageData(VintageCampChallengeStageData other) : this() {
      isOpen_ = other.isOpen_;
      maxFinishedLevel_ = other.maxFinishedLevel_;
      openTime_ = other.openTime_;
      isFinish_ = other.isFinish_;
      stageId_ = other.stageId_;
      campLevelMap_ = other.campLevelMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageCampChallengeStageData Clone() {
      return new VintageCampChallengeStageData(this);
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 5;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "max_finished_level" field.</summary>
    public const int MaxFinishedLevelFieldNumber = 11;
    private uint maxFinishedLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxFinishedLevel {
      get { return maxFinishedLevel_; }
      set {
        maxFinishedLevel_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 3;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 10;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 4;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "camp_level_map" field.</summary>
    public const int CampLevelMapFieldNumber = 2;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeLevelData>.Codec _map_campLevelMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeLevelData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeLevelData.Parser), 18);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeLevelData> campLevelMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeLevelData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeLevelData> CampLevelMap {
      get { return campLevelMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageCampChallengeStageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageCampChallengeStageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOpen != other.IsOpen) return false;
      if (MaxFinishedLevel != other.MaxFinishedLevel) return false;
      if (OpenTime != other.OpenTime) return false;
      if (IsFinish != other.IsFinish) return false;
      if (StageId != other.StageId) return false;
      if (!CampLevelMap.Equals(other.CampLevelMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (MaxFinishedLevel != 0) hash ^= MaxFinishedLevel.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= CampLevelMap.GetHashCode();
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
      campLevelMap_.WriteTo(output, _map_campLevelMap_codec);
      if (OpenTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OpenTime);
      }
      if (StageId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StageId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (IsFinish != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsFinish);
      }
      if (MaxFinishedLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaxFinishedLevel);
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
      campLevelMap_.WriteTo(ref output, _map_campLevelMap_codec);
      if (OpenTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OpenTime);
      }
      if (StageId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StageId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (IsFinish != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsFinish);
      }
      if (MaxFinishedLevel != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaxFinishedLevel);
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
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (MaxFinishedLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxFinishedLevel);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += campLevelMap_.CalculateSize(_map_campLevelMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageCampChallengeStageData other) {
      if (other == null) {
        return;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.MaxFinishedLevel != 0) {
        MaxFinishedLevel = other.MaxFinishedLevel;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      campLevelMap_.Add(other.campLevelMap_);
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
            campLevelMap_.AddEntriesFrom(input, _map_campLevelMap_codec);
            break;
          }
          case 24: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 32: {
            StageId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 80: {
            IsFinish = input.ReadBool();
            break;
          }
          case 88: {
            MaxFinishedLevel = input.ReadUInt32();
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
            campLevelMap_.AddEntriesFrom(ref input, _map_campLevelMap_codec);
            break;
          }
          case 24: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 32: {
            StageId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 80: {
            IsFinish = input.ReadBool();
            break;
          }
          case 88: {
            MaxFinishedLevel = input.ReadUInt32();
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
