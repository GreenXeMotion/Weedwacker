// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MechanicusLevelupGearRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from MechanicusLevelupGearRsp.proto</summary>
  public static partial class MechanicusLevelupGearRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MechanicusLevelupGearRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MechanicusLevelupGearRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5NZWNoYW5pY3VzTGV2ZWx1cEdlYXJSc3AucHJvdG8ibQoYTWVjaGFuaWN1",
            "c0xldmVsdXBHZWFyUnNwEg8KB2dlYXJfaWQYByABKA0SFQoNbWVjaGFuaWN1",
            "c19pZBgCIAEoDRIYChBhZnRlcl9nZWFyX2xldmVsGAwgASgNEg8KB3JldGNv",
            "ZGUYCCABKAVCGqoCF1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.MechanicusLevelupGearRsp), global::Weedwacker.Server.Proto.MechanicusLevelupGearRsp.Parser, new[]{ "GearId", "MechanicusId", "AfterGearLevel", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3999
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class MechanicusLevelupGearRsp : pb::IMessage<MechanicusLevelupGearRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MechanicusLevelupGearRsp> _parser = new pb::MessageParser<MechanicusLevelupGearRsp>(() => new MechanicusLevelupGearRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MechanicusLevelupGearRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.MechanicusLevelupGearRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusLevelupGearRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusLevelupGearRsp(MechanicusLevelupGearRsp other) : this() {
      gearId_ = other.gearId_;
      mechanicusId_ = other.mechanicusId_;
      afterGearLevel_ = other.afterGearLevel_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusLevelupGearRsp Clone() {
      return new MechanicusLevelupGearRsp(this);
    }

    /// <summary>Field number for the "gear_id" field.</summary>
    public const int GearIdFieldNumber = 7;
    private uint gearId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GearId {
      get { return gearId_; }
      set {
        gearId_ = value;
      }
    }

    /// <summary>Field number for the "mechanicus_id" field.</summary>
    public const int MechanicusIdFieldNumber = 2;
    private uint mechanicusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusId {
      get { return mechanicusId_; }
      set {
        mechanicusId_ = value;
      }
    }

    /// <summary>Field number for the "after_gear_level" field.</summary>
    public const int AfterGearLevelFieldNumber = 12;
    private uint afterGearLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AfterGearLevel {
      get { return afterGearLevel_; }
      set {
        afterGearLevel_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MechanicusLevelupGearRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MechanicusLevelupGearRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GearId != other.GearId) return false;
      if (MechanicusId != other.MechanicusId) return false;
      if (AfterGearLevel != other.AfterGearLevel) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GearId != 0) hash ^= GearId.GetHashCode();
      if (MechanicusId != 0) hash ^= MechanicusId.GetHashCode();
      if (AfterGearLevel != 0) hash ^= AfterGearLevel.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (MechanicusId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MechanicusId);
      }
      if (GearId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GearId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (AfterGearLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AfterGearLevel);
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
      if (MechanicusId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MechanicusId);
      }
      if (GearId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GearId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (AfterGearLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AfterGearLevel);
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
      if (GearId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GearId);
      }
      if (MechanicusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusId);
      }
      if (AfterGearLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AfterGearLevel);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MechanicusLevelupGearRsp other) {
      if (other == null) {
        return;
      }
      if (other.GearId != 0) {
        GearId = other.GearId;
      }
      if (other.MechanicusId != 0) {
        MechanicusId = other.MechanicusId;
      }
      if (other.AfterGearLevel != 0) {
        AfterGearLevel = other.AfterGearLevel;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 56: {
            GearId = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            AfterGearLevel = input.ReadUInt32();
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
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 56: {
            GearId = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            AfterGearLevel = input.ReadUInt32();
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