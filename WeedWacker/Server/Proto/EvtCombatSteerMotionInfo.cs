// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtCombatSteerMotionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from EvtCombatSteerMotionInfo.proto</summary>
  public static partial class EvtCombatSteerMotionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtCombatSteerMotionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtCombatSteerMotionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5FdnRDb21iYXRTdGVlck1vdGlvbkluZm8ucHJvdG8aDFZlY3Rvci5wcm90",
            "byJ5ChhFdnRDb21iYXRTdGVlck1vdGlvbkluZm8SFAoDcG9zGAwgASgLMgcu",
            "VmVjdG9yEhkKCHZlbG9jaXR5GAogASgLMgcuVmVjdG9yEhEKCWVudGl0eV9p",
            "ZBgEIAEoDRIZCghmYWNlX2RpchgBIAEoCzIHLlZlY3RvckIaqgIXV2VlZHdh",
            "Y2tlci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.EvtCombatSteerMotionInfo), global::Weedwacker.Server.Proto.EvtCombatSteerMotionInfo.Parser, new[]{ "Pos", "Velocity", "EntityId", "FaceDir" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtCombatSteerMotionInfo : pb::IMessage<EvtCombatSteerMotionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtCombatSteerMotionInfo> _parser = new pb::MessageParser<EvtCombatSteerMotionInfo>(() => new EvtCombatSteerMotionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtCombatSteerMotionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.EvtCombatSteerMotionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCombatSteerMotionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCombatSteerMotionInfo(EvtCombatSteerMotionInfo other) : this() {
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      velocity_ = other.velocity_ != null ? other.velocity_.Clone() : null;
      entityId_ = other.entityId_;
      faceDir_ = other.faceDir_ != null ? other.faceDir_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtCombatSteerMotionInfo Clone() {
      return new EvtCombatSteerMotionInfo(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 12;
    private global::Weedwacker.Server.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "velocity" field.</summary>
    public const int VelocityFieldNumber = 10;
    private global::Weedwacker.Server.Proto.Vector velocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector Velocity {
      get { return velocity_; }
      set {
        velocity_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 4;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "face_dir" field.</summary>
    public const int FaceDirFieldNumber = 1;
    private global::Weedwacker.Server.Proto.Vector faceDir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector FaceDir {
      get { return faceDir_; }
      set {
        faceDir_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtCombatSteerMotionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtCombatSteerMotionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(Velocity, other.Velocity)) return false;
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(FaceDir, other.FaceDir)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (velocity_ != null) hash ^= Velocity.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (faceDir_ != null) hash ^= FaceDir.GetHashCode();
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
      if (faceDir_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FaceDir);
      }
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (velocity_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Velocity);
      }
      if (pos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Pos);
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
      if (faceDir_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(FaceDir);
      }
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (velocity_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Velocity);
      }
      if (pos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Pos);
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
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (velocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Velocity);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (faceDir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FaceDir);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtCombatSteerMotionInfo other) {
      if (other == null) {
        return;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Server.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.velocity_ != null) {
        if (velocity_ == null) {
          Velocity = new global::Weedwacker.Server.Proto.Vector();
        }
        Velocity.MergeFrom(other.Velocity);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.faceDir_ != null) {
        if (faceDir_ == null) {
          FaceDir = new global::Weedwacker.Server.Proto.Vector();
        }
        FaceDir.MergeFrom(other.FaceDir);
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
          case 10: {
            if (faceDir_ == null) {
              FaceDir = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(FaceDir);
            break;
          }
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (velocity_ == null) {
              Velocity = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 98: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Pos);
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
          case 10: {
            if (faceDir_ == null) {
              FaceDir = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(FaceDir);
            break;
          }
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (velocity_ == null) {
              Velocity = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 98: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(Pos);
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