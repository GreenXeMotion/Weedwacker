// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MuqadasPotionDungeonSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MuqadasPotionDungeonSettleNotify.proto</summary>
  public static partial class MuqadasPotionDungeonSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MuqadasPotionDungeonSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuqadasPotionDungeonSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZNdXFhZGFzUG90aW9uRHVuZ2VvblNldHRsZU5vdGlmeS5wcm90byKUAQog",
            "TXVxYWRhc1BvdGlvbkR1bmdlb25TZXR0bGVOb3RpZnkSEwoLZmluYWxfc2Nv",
            "cmUYCyABKA0SHgoWY2FwdHVyZV93ZWFrbmVzc19jb3VudBgPIAEoDRISCgpp",
            "c19zdWNjZXNzGAYgASgIEhAKCGxldmVsX2lkGAogASgNEhUKDWlzX25ld19y",
            "ZWNvcmQYAiABKAhCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MuqadasPotionDungeonSettleNotify), global::Weedwacker.Shared.Network.Proto.MuqadasPotionDungeonSettleNotify.Parser, new[]{ "FinalScore", "CaptureWeaknessCount", "IsSuccess", "LevelId", "IsNewRecord" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 20005
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class MuqadasPotionDungeonSettleNotify : pb::IMessage<MuqadasPotionDungeonSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MuqadasPotionDungeonSettleNotify> _parser = new pb::MessageParser<MuqadasPotionDungeonSettleNotify>(() => new MuqadasPotionDungeonSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MuqadasPotionDungeonSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MuqadasPotionDungeonSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuqadasPotionDungeonSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuqadasPotionDungeonSettleNotify(MuqadasPotionDungeonSettleNotify other) : this() {
      finalScore_ = other.finalScore_;
      captureWeaknessCount_ = other.captureWeaknessCount_;
      isSuccess_ = other.isSuccess_;
      levelId_ = other.levelId_;
      isNewRecord_ = other.isNewRecord_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuqadasPotionDungeonSettleNotify Clone() {
      return new MuqadasPotionDungeonSettleNotify(this);
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 11;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "capture_weakness_count" field.</summary>
    public const int CaptureWeaknessCountFieldNumber = 15;
    private uint captureWeaknessCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CaptureWeaknessCount {
      get { return captureWeaknessCount_; }
      set {
        captureWeaknessCount_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 6;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 10;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 2;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MuqadasPotionDungeonSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MuqadasPotionDungeonSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FinalScore != other.FinalScore) return false;
      if (CaptureWeaknessCount != other.CaptureWeaknessCount) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (LevelId != other.LevelId) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (CaptureWeaknessCount != 0) hash ^= CaptureWeaknessCount.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
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
      if (IsNewRecord != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsNewRecord);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsSuccess);
      }
      if (LevelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FinalScore);
      }
      if (CaptureWeaknessCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CaptureWeaknessCount);
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
      if (IsNewRecord != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsNewRecord);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsSuccess);
      }
      if (LevelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FinalScore);
      }
      if (CaptureWeaknessCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CaptureWeaknessCount);
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
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (CaptureWeaknessCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CaptureWeaknessCount);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MuqadasPotionDungeonSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.CaptureWeaknessCount != 0) {
        CaptureWeaknessCount = other.CaptureWeaknessCount;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
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
          case 16: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 48: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 80: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 88: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            CaptureWeaknessCount = input.ReadUInt32();
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
          case 16: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 48: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 80: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 88: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            CaptureWeaknessCount = input.ReadUInt32();
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
