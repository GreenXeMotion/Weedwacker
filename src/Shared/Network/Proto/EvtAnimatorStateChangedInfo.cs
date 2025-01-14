// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAnimatorStateChangedInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtAnimatorStateChangedInfo.proto</summary>
  public static partial class EvtAnimatorStateChangedInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtAnimatorStateChangedInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtAnimatorStateChangedInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFdnRBbmltYXRvclN0YXRlQ2hhbmdlZEluZm8ucHJvdG8aDFZlY3Rvci5w",
            "cm90byL/AQobRXZ0QW5pbWF0b3JTdGF0ZUNoYW5nZWRJbmZvEhoKEmZhY2Vf",
            "YW5nbGVfY29tcGFjdBgOIAEoBRIVCg10b19zdGF0ZV9oYXNoGAUgASgNEh8K",
            "F25vcm1hbGl6ZWRfdGltZV9jb21wYWN0GAkgASgNEg0KBWxheWVyGAIgASgN",
            "EhQKA3BvcxgNIAEoCzIHLlZlY3RvchIVCg1mYWRlX2R1cmF0aW9uGAMgASgC",
            "EhIKCmZvcmNlX3N5bmMYASABKAgSEQoJZW50aXR5X2lkGA8gASgNEikKIWhh",
            "bmRsZV9hbmltYXRvcl9zdGF0ZV9pbW1lZGlhdGVseRgHIAEoCEIiqgIfV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtAnimatorStateChangedInfo), global::Weedwacker.Shared.Network.Proto.EvtAnimatorStateChangedInfo.Parser, new[]{ "FaceAngleCompact", "ToStateHash", "NormalizedTimeCompact", "Layer", "Pos", "FadeDuration", "ForceSync", "EntityId", "HandleAnimatorStateImmediately" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtAnimatorStateChangedInfo : pb::IMessage<EvtAnimatorStateChangedInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtAnimatorStateChangedInfo> _parser = new pb::MessageParser<EvtAnimatorStateChangedInfo>(() => new EvtAnimatorStateChangedInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtAnimatorStateChangedInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtAnimatorStateChangedInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorStateChangedInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorStateChangedInfo(EvtAnimatorStateChangedInfo other) : this() {
      faceAngleCompact_ = other.faceAngleCompact_;
      toStateHash_ = other.toStateHash_;
      normalizedTimeCompact_ = other.normalizedTimeCompact_;
      layer_ = other.layer_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      fadeDuration_ = other.fadeDuration_;
      forceSync_ = other.forceSync_;
      entityId_ = other.entityId_;
      handleAnimatorStateImmediately_ = other.handleAnimatorStateImmediately_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorStateChangedInfo Clone() {
      return new EvtAnimatorStateChangedInfo(this);
    }

    /// <summary>Field number for the "face_angle_compact" field.</summary>
    public const int FaceAngleCompactFieldNumber = 14;
    private int faceAngleCompact_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FaceAngleCompact {
      get { return faceAngleCompact_; }
      set {
        faceAngleCompact_ = value;
      }
    }

    /// <summary>Field number for the "to_state_hash" field.</summary>
    public const int ToStateHashFieldNumber = 5;
    private uint toStateHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ToStateHash {
      get { return toStateHash_; }
      set {
        toStateHash_ = value;
      }
    }

    /// <summary>Field number for the "normalized_time_compact" field.</summary>
    public const int NormalizedTimeCompactFieldNumber = 9;
    private uint normalizedTimeCompact_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NormalizedTimeCompact {
      get { return normalizedTimeCompact_; }
      set {
        normalizedTimeCompact_ = value;
      }
    }

    /// <summary>Field number for the "layer" field.</summary>
    public const int LayerFieldNumber = 2;
    private uint layer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Layer {
      get { return layer_; }
      set {
        layer_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "fade_duration" field.</summary>
    public const int FadeDurationFieldNumber = 3;
    private float fadeDuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FadeDuration {
      get { return fadeDuration_; }
      set {
        fadeDuration_ = value;
      }
    }

    /// <summary>Field number for the "force_sync" field.</summary>
    public const int ForceSyncFieldNumber = 1;
    private bool forceSync_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ForceSync {
      get { return forceSync_; }
      set {
        forceSync_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 15;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "handle_animator_state_immediately" field.</summary>
    public const int HandleAnimatorStateImmediatelyFieldNumber = 7;
    private bool handleAnimatorStateImmediately_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HandleAnimatorStateImmediately {
      get { return handleAnimatorStateImmediately_; }
      set {
        handleAnimatorStateImmediately_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtAnimatorStateChangedInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtAnimatorStateChangedInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FaceAngleCompact != other.FaceAngleCompact) return false;
      if (ToStateHash != other.ToStateHash) return false;
      if (NormalizedTimeCompact != other.NormalizedTimeCompact) return false;
      if (Layer != other.Layer) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FadeDuration, other.FadeDuration)) return false;
      if (ForceSync != other.ForceSync) return false;
      if (EntityId != other.EntityId) return false;
      if (HandleAnimatorStateImmediately != other.HandleAnimatorStateImmediately) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FaceAngleCompact != 0) hash ^= FaceAngleCompact.GetHashCode();
      if (ToStateHash != 0) hash ^= ToStateHash.GetHashCode();
      if (NormalizedTimeCompact != 0) hash ^= NormalizedTimeCompact.GetHashCode();
      if (Layer != 0) hash ^= Layer.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (FadeDuration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FadeDuration);
      if (ForceSync != false) hash ^= ForceSync.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (HandleAnimatorStateImmediately != false) hash ^= HandleAnimatorStateImmediately.GetHashCode();
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
      if (ForceSync != false) {
        output.WriteRawTag(8);
        output.WriteBool(ForceSync);
      }
      if (Layer != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Layer);
      }
      if (FadeDuration != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(FadeDuration);
      }
      if (ToStateHash != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ToStateHash);
      }
      if (HandleAnimatorStateImmediately != false) {
        output.WriteRawTag(56);
        output.WriteBool(HandleAnimatorStateImmediately);
      }
      if (NormalizedTimeCompact != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NormalizedTimeCompact);
      }
      if (pos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Pos);
      }
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(FaceAngleCompact);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntityId);
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
      if (ForceSync != false) {
        output.WriteRawTag(8);
        output.WriteBool(ForceSync);
      }
      if (Layer != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Layer);
      }
      if (FadeDuration != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(FadeDuration);
      }
      if (ToStateHash != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ToStateHash);
      }
      if (HandleAnimatorStateImmediately != false) {
        output.WriteRawTag(56);
        output.WriteBool(HandleAnimatorStateImmediately);
      }
      if (NormalizedTimeCompact != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NormalizedTimeCompact);
      }
      if (pos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Pos);
      }
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(FaceAngleCompact);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntityId);
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
      if (FaceAngleCompact != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FaceAngleCompact);
      }
      if (ToStateHash != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ToStateHash);
      }
      if (NormalizedTimeCompact != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NormalizedTimeCompact);
      }
      if (Layer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Layer);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (FadeDuration != 0F) {
        size += 1 + 4;
      }
      if (ForceSync != false) {
        size += 1 + 1;
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (HandleAnimatorStateImmediately != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtAnimatorStateChangedInfo other) {
      if (other == null) {
        return;
      }
      if (other.FaceAngleCompact != 0) {
        FaceAngleCompact = other.FaceAngleCompact;
      }
      if (other.ToStateHash != 0) {
        ToStateHash = other.ToStateHash;
      }
      if (other.NormalizedTimeCompact != 0) {
        NormalizedTimeCompact = other.NormalizedTimeCompact;
      }
      if (other.Layer != 0) {
        Layer = other.Layer;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.FadeDuration != 0F) {
        FadeDuration = other.FadeDuration;
      }
      if (other.ForceSync != false) {
        ForceSync = other.ForceSync;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.HandleAnimatorStateImmediately != false) {
        HandleAnimatorStateImmediately = other.HandleAnimatorStateImmediately;
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
            ForceSync = input.ReadBool();
            break;
          }
          case 16: {
            Layer = input.ReadUInt32();
            break;
          }
          case 29: {
            FadeDuration = input.ReadFloat();
            break;
          }
          case 40: {
            ToStateHash = input.ReadUInt32();
            break;
          }
          case 56: {
            HandleAnimatorStateImmediately = input.ReadBool();
            break;
          }
          case 72: {
            NormalizedTimeCompact = input.ReadUInt32();
            break;
          }
          case 106: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 112: {
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 120: {
            EntityId = input.ReadUInt32();
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
            ForceSync = input.ReadBool();
            break;
          }
          case 16: {
            Layer = input.ReadUInt32();
            break;
          }
          case 29: {
            FadeDuration = input.ReadFloat();
            break;
          }
          case 40: {
            ToStateHash = input.ReadUInt32();
            break;
          }
          case 56: {
            HandleAnimatorStateImmediately = input.ReadBool();
            break;
          }
          case 72: {
            NormalizedTimeCompact = input.ReadUInt32();
            break;
          }
          case 106: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 112: {
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 120: {
            EntityId = input.ReadUInt32();
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
