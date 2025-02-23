// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanternRiteFireworksReformSkillInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LanternRiteFireworksReformSkillInfo.proto</summary>
  public static partial class LanternRiteFireworksReformSkillInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LanternRiteFireworksReformSkillInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanternRiteFireworksReformSkillInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilMYW50ZXJuUml0ZUZpcmV3b3Jrc1JlZm9ybVNraWxsSW5mby5wcm90byKG",
            "AQojTGFudGVyblJpdGVGaXJld29ya3NSZWZvcm1Ta2lsbEluZm8SEAoIc2tp",
            "bGxfaWQYAiABKA0SEQoJaXNfdW5sb2NrGAsgASgIEh0KFXVubG9ja19jaGFs",
            "bGVuZ2VfdGltZRgBIAEoDRIbChN1bmxvY2tfY2hhbGxlbmdlX2lkGA4gASgN",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksReformSkillInfo), global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksReformSkillInfo.Parser, new[]{ "SkillId", "IsUnlock", "UnlockChallengeTime", "UnlockChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LanternRiteFireworksReformSkillInfo : pb::IMessage<LanternRiteFireworksReformSkillInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanternRiteFireworksReformSkillInfo> _parser = new pb::MessageParser<LanternRiteFireworksReformSkillInfo>(() => new LanternRiteFireworksReformSkillInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanternRiteFireworksReformSkillInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksReformSkillInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteFireworksReformSkillInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteFireworksReformSkillInfo(LanternRiteFireworksReformSkillInfo other) : this() {
      skillId_ = other.skillId_;
      isUnlock_ = other.isUnlock_;
      unlockChallengeTime_ = other.unlockChallengeTime_;
      unlockChallengeId_ = other.unlockChallengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteFireworksReformSkillInfo Clone() {
      return new LanternRiteFireworksReformSkillInfo(this);
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 2;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    /// <summary>Field number for the "is_unlock" field.</summary>
    public const int IsUnlockFieldNumber = 11;
    private bool isUnlock_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnlock {
      get { return isUnlock_; }
      set {
        isUnlock_ = value;
      }
    }

    /// <summary>Field number for the "unlock_challenge_time" field.</summary>
    public const int UnlockChallengeTimeFieldNumber = 1;
    private uint unlockChallengeTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UnlockChallengeTime {
      get { return unlockChallengeTime_; }
      set {
        unlockChallengeTime_ = value;
      }
    }

    /// <summary>Field number for the "unlock_challenge_id" field.</summary>
    public const int UnlockChallengeIdFieldNumber = 14;
    private uint unlockChallengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UnlockChallengeId {
      get { return unlockChallengeId_; }
      set {
        unlockChallengeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanternRiteFireworksReformSkillInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanternRiteFireworksReformSkillInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SkillId != other.SkillId) return false;
      if (IsUnlock != other.IsUnlock) return false;
      if (UnlockChallengeTime != other.UnlockChallengeTime) return false;
      if (UnlockChallengeId != other.UnlockChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      if (IsUnlock != false) hash ^= IsUnlock.GetHashCode();
      if (UnlockChallengeTime != 0) hash ^= UnlockChallengeTime.GetHashCode();
      if (UnlockChallengeId != 0) hash ^= UnlockChallengeId.GetHashCode();
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
      if (UnlockChallengeTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnlockChallengeTime);
      }
      if (SkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkillId);
      }
      if (IsUnlock != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsUnlock);
      }
      if (UnlockChallengeId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(UnlockChallengeId);
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
      if (UnlockChallengeTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnlockChallengeTime);
      }
      if (SkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SkillId);
      }
      if (IsUnlock != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsUnlock);
      }
      if (UnlockChallengeId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(UnlockChallengeId);
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
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (IsUnlock != false) {
        size += 1 + 1;
      }
      if (UnlockChallengeTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockChallengeTime);
      }
      if (UnlockChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockChallengeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanternRiteFireworksReformSkillInfo other) {
      if (other == null) {
        return;
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      if (other.IsUnlock != false) {
        IsUnlock = other.IsUnlock;
      }
      if (other.UnlockChallengeTime != 0) {
        UnlockChallengeTime = other.UnlockChallengeTime;
      }
      if (other.UnlockChallengeId != 0) {
        UnlockChallengeId = other.UnlockChallengeId;
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
            UnlockChallengeTime = input.ReadUInt32();
            break;
          }
          case 16: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 88: {
            IsUnlock = input.ReadBool();
            break;
          }
          case 112: {
            UnlockChallengeId = input.ReadUInt32();
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
            UnlockChallengeTime = input.ReadUInt32();
            break;
          }
          case 16: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 88: {
            IsUnlock = input.ReadBool();
            break;
          }
          case 112: {
            UnlockChallengeId = input.ReadUInt32();
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
