// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageHuntingFirstStageSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageHuntingFirstStageSettleInfo.proto</summary>
  public static partial class VintageHuntingFirstStageSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageHuntingFirstStageSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageHuntingFirstStageSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihWaW50YWdlSHVudGluZ0ZpcnN0U3RhZ2VTZXR0bGVJbmZvLnByb3RvIm0K",
            "IlZpbnRhZ2VIdW50aW5nRmlyc3RTdGFnZVNldHRsZUluZm8SEQoJZWxpdGVf",
            "Y250GAogASgNEhEKCXRpbWlkX2NudBgCIAEoDRISCgpicnV0YWxfY250GAYg",
            "ASgNEg0KBXNjb3JlGA4gASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo), global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfo.Parser, new[]{ "EliteCnt", "TimidCnt", "BrutalCnt", "Score" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageHuntingFirstStageSettleInfo : pb::IMessage<VintageHuntingFirstStageSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageHuntingFirstStageSettleInfo> _parser = new pb::MessageParser<VintageHuntingFirstStageSettleInfo>(() => new VintageHuntingFirstStageSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageHuntingFirstStageSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingFirstStageSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingFirstStageSettleInfo(VintageHuntingFirstStageSettleInfo other) : this() {
      eliteCnt_ = other.eliteCnt_;
      timidCnt_ = other.timidCnt_;
      brutalCnt_ = other.brutalCnt_;
      score_ = other.score_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingFirstStageSettleInfo Clone() {
      return new VintageHuntingFirstStageSettleInfo(this);
    }

    /// <summary>Field number for the "elite_cnt" field.</summary>
    public const int EliteCntFieldNumber = 10;
    private uint eliteCnt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EliteCnt {
      get { return eliteCnt_; }
      set {
        eliteCnt_ = value;
      }
    }

    /// <summary>Field number for the "timid_cnt" field.</summary>
    public const int TimidCntFieldNumber = 2;
    private uint timidCnt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimidCnt {
      get { return timidCnt_; }
      set {
        timidCnt_ = value;
      }
    }

    /// <summary>Field number for the "brutal_cnt" field.</summary>
    public const int BrutalCntFieldNumber = 6;
    private uint brutalCnt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BrutalCnt {
      get { return brutalCnt_; }
      set {
        brutalCnt_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 14;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageHuntingFirstStageSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageHuntingFirstStageSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EliteCnt != other.EliteCnt) return false;
      if (TimidCnt != other.TimidCnt) return false;
      if (BrutalCnt != other.BrutalCnt) return false;
      if (Score != other.Score) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EliteCnt != 0) hash ^= EliteCnt.GetHashCode();
      if (TimidCnt != 0) hash ^= TimidCnt.GetHashCode();
      if (BrutalCnt != 0) hash ^= BrutalCnt.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
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
      if (TimidCnt != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TimidCnt);
      }
      if (BrutalCnt != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BrutalCnt);
      }
      if (EliteCnt != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EliteCnt);
      }
      if (Score != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Score);
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
      if (TimidCnt != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TimidCnt);
      }
      if (BrutalCnt != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BrutalCnt);
      }
      if (EliteCnt != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EliteCnt);
      }
      if (Score != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Score);
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
      if (EliteCnt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EliteCnt);
      }
      if (TimidCnt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimidCnt);
      }
      if (BrutalCnt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BrutalCnt);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageHuntingFirstStageSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.EliteCnt != 0) {
        EliteCnt = other.EliteCnt;
      }
      if (other.TimidCnt != 0) {
        TimidCnt = other.TimidCnt;
      }
      if (other.BrutalCnt != 0) {
        BrutalCnt = other.BrutalCnt;
      }
      if (other.Score != 0) {
        Score = other.Score;
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
            TimidCnt = input.ReadUInt32();
            break;
          }
          case 48: {
            BrutalCnt = input.ReadUInt32();
            break;
          }
          case 80: {
            EliteCnt = input.ReadUInt32();
            break;
          }
          case 112: {
            Score = input.ReadUInt32();
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
            TimidCnt = input.ReadUInt32();
            break;
          }
          case 48: {
            BrutalCnt = input.ReadUInt32();
            break;
          }
          case 80: {
            EliteCnt = input.ReadUInt32();
            break;
          }
          case 112: {
            Score = input.ReadUInt32();
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
