// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MassiveEntityElementOpBatchNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MassiveEntityElementOpBatchNotify.proto</summary>
  public static partial class MassiveEntityElementOpBatchNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MassiveEntityElementOpBatchNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MassiveEntityElementOpBatchNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidNYXNzaXZlRW50aXR5RWxlbWVudE9wQmF0Y2hOb3RpZnkucHJvdG8aDlNo",
            "YXBlQm94LnByb3RvGhFTaGFwZVNwaGVyZS5wcm90byKhAgohTWFzc2l2ZUVu",
            "dGl0eUVsZW1lbnRPcEJhdGNoTm90aWZ5EhMKC2VudGl0eV90eXBlGAYgASgF",
            "Eg4KBm9wX2lkeBgJIAEoDRIPCgd1c2VyX2lkGAsgASgNEhMKC2F0dGFja2Vy",
            "X2lkGAMgASgNEhsKE3NvdXJjZV9lbGVtZW50X3R5cGUYDCABKAUSHAoUcmVh",
            "Y3Rpb25fc291cmNlX3R5cGUYBCABKAUSIQoZYXR0YWNrX2VsZW1lbnRfZHVy",
            "YWJpbGl0eRgHIAEoAhIkCgxzaGFwZV9zcGhlcmUYCiABKAsyDC5TaGFwZVNw",
            "aGVyZUgAEh4KCXNoYXBlX2JveBgCIAEoCzIJLlNoYXBlQm94SABCDQoLY2hl",
            "Y2tfc2hhcGVCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ShapeBoxReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ShapeSphereReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MassiveEntityElementOpBatchNotify), global::Weedwacker.Shared.Network.Proto.MassiveEntityElementOpBatchNotify.Parser, new[]{ "EntityType", "OpIdx", "UserId", "AttackerId", "SourceElementType", "ReactionSourceType", "AttackElementDurability", "ShapeSphere", "ShapeBox" }, new[]{ "CheckShape" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 357
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class MassiveEntityElementOpBatchNotify : pb::IMessage<MassiveEntityElementOpBatchNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MassiveEntityElementOpBatchNotify> _parser = new pb::MessageParser<MassiveEntityElementOpBatchNotify>(() => new MassiveEntityElementOpBatchNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MassiveEntityElementOpBatchNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MassiveEntityElementOpBatchNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassiveEntityElementOpBatchNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassiveEntityElementOpBatchNotify(MassiveEntityElementOpBatchNotify other) : this() {
      entityType_ = other.entityType_;
      opIdx_ = other.opIdx_;
      userId_ = other.userId_;
      attackerId_ = other.attackerId_;
      sourceElementType_ = other.sourceElementType_;
      reactionSourceType_ = other.reactionSourceType_;
      attackElementDurability_ = other.attackElementDurability_;
      switch (other.CheckShapeCase) {
        case CheckShapeOneofCase.ShapeSphere:
          ShapeSphere = other.ShapeSphere.Clone();
          break;
        case CheckShapeOneofCase.ShapeBox:
          ShapeBox = other.ShapeBox.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassiveEntityElementOpBatchNotify Clone() {
      return new MassiveEntityElementOpBatchNotify(this);
    }

    /// <summary>Field number for the "entity_type" field.</summary>
    public const int EntityTypeFieldNumber = 6;
    private int entityType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EntityType {
      get { return entityType_; }
      set {
        entityType_ = value;
      }
    }

    /// <summary>Field number for the "op_idx" field.</summary>
    public const int OpIdxFieldNumber = 9;
    private uint opIdx_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpIdx {
      get { return opIdx_; }
      set {
        opIdx_ = value;
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 11;
    private uint userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "attacker_id" field.</summary>
    public const int AttackerIdFieldNumber = 3;
    private uint attackerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AttackerId {
      get { return attackerId_; }
      set {
        attackerId_ = value;
      }
    }

    /// <summary>Field number for the "source_element_type" field.</summary>
    public const int SourceElementTypeFieldNumber = 12;
    private int sourceElementType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int SourceElementType {
      get { return sourceElementType_; }
      set {
        sourceElementType_ = value;
      }
    }

    /// <summary>Field number for the "reaction_source_type" field.</summary>
    public const int ReactionSourceTypeFieldNumber = 4;
    private int reactionSourceType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ReactionSourceType {
      get { return reactionSourceType_; }
      set {
        reactionSourceType_ = value;
      }
    }

    /// <summary>Field number for the "attack_element_durability" field.</summary>
    public const int AttackElementDurabilityFieldNumber = 7;
    private float attackElementDurability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AttackElementDurability {
      get { return attackElementDurability_; }
      set {
        attackElementDurability_ = value;
      }
    }

    /// <summary>Field number for the "shape_sphere" field.</summary>
    public const int ShapeSphereFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ShapeSphere ShapeSphere {
      get { return checkShapeCase_ == CheckShapeOneofCase.ShapeSphere ? (global::Weedwacker.Shared.Network.Proto.ShapeSphere) checkShape_ : null; }
      set {
        checkShape_ = value;
        checkShapeCase_ = value == null ? CheckShapeOneofCase.None : CheckShapeOneofCase.ShapeSphere;
      }
    }

    /// <summary>Field number for the "shape_box" field.</summary>
    public const int ShapeBoxFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ShapeBox ShapeBox {
      get { return checkShapeCase_ == CheckShapeOneofCase.ShapeBox ? (global::Weedwacker.Shared.Network.Proto.ShapeBox) checkShape_ : null; }
      set {
        checkShape_ = value;
        checkShapeCase_ = value == null ? CheckShapeOneofCase.None : CheckShapeOneofCase.ShapeBox;
      }
    }

    private object checkShape_;
    /// <summary>Enum of possible cases for the "check_shape" oneof.</summary>
    public enum CheckShapeOneofCase {
      None = 0,
      ShapeSphere = 10,
      ShapeBox = 2,
    }
    private CheckShapeOneofCase checkShapeCase_ = CheckShapeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckShapeOneofCase CheckShapeCase {
      get { return checkShapeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCheckShape() {
      checkShapeCase_ = CheckShapeOneofCase.None;
      checkShape_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MassiveEntityElementOpBatchNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MassiveEntityElementOpBatchNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityType != other.EntityType) return false;
      if (OpIdx != other.OpIdx) return false;
      if (UserId != other.UserId) return false;
      if (AttackerId != other.AttackerId) return false;
      if (SourceElementType != other.SourceElementType) return false;
      if (ReactionSourceType != other.ReactionSourceType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackElementDurability, other.AttackElementDurability)) return false;
      if (!object.Equals(ShapeSphere, other.ShapeSphere)) return false;
      if (!object.Equals(ShapeBox, other.ShapeBox)) return false;
      if (CheckShapeCase != other.CheckShapeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityType != 0) hash ^= EntityType.GetHashCode();
      if (OpIdx != 0) hash ^= OpIdx.GetHashCode();
      if (UserId != 0) hash ^= UserId.GetHashCode();
      if (AttackerId != 0) hash ^= AttackerId.GetHashCode();
      if (SourceElementType != 0) hash ^= SourceElementType.GetHashCode();
      if (ReactionSourceType != 0) hash ^= ReactionSourceType.GetHashCode();
      if (AttackElementDurability != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackElementDurability);
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeSphere) hash ^= ShapeSphere.GetHashCode();
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeBox) hash ^= ShapeBox.GetHashCode();
      hash ^= (int) checkShapeCase_;
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
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeBox) {
        output.WriteRawTag(18);
        output.WriteMessage(ShapeBox);
      }
      if (AttackerId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AttackerId);
      }
      if (ReactionSourceType != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ReactionSourceType);
      }
      if (EntityType != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(EntityType);
      }
      if (AttackElementDurability != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(AttackElementDurability);
      }
      if (OpIdx != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OpIdx);
      }
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeSphere) {
        output.WriteRawTag(82);
        output.WriteMessage(ShapeSphere);
      }
      if (UserId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UserId);
      }
      if (SourceElementType != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(SourceElementType);
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
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeBox) {
        output.WriteRawTag(18);
        output.WriteMessage(ShapeBox);
      }
      if (AttackerId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AttackerId);
      }
      if (ReactionSourceType != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ReactionSourceType);
      }
      if (EntityType != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(EntityType);
      }
      if (AttackElementDurability != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(AttackElementDurability);
      }
      if (OpIdx != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(OpIdx);
      }
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeSphere) {
        output.WriteRawTag(82);
        output.WriteMessage(ShapeSphere);
      }
      if (UserId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UserId);
      }
      if (SourceElementType != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(SourceElementType);
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
      if (EntityType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EntityType);
      }
      if (OpIdx != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpIdx);
      }
      if (UserId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UserId);
      }
      if (AttackerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttackerId);
      }
      if (SourceElementType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SourceElementType);
      }
      if (ReactionSourceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReactionSourceType);
      }
      if (AttackElementDurability != 0F) {
        size += 1 + 4;
      }
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeSphere) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ShapeSphere);
      }
      if (checkShapeCase_ == CheckShapeOneofCase.ShapeBox) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ShapeBox);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MassiveEntityElementOpBatchNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityType != 0) {
        EntityType = other.EntityType;
      }
      if (other.OpIdx != 0) {
        OpIdx = other.OpIdx;
      }
      if (other.UserId != 0) {
        UserId = other.UserId;
      }
      if (other.AttackerId != 0) {
        AttackerId = other.AttackerId;
      }
      if (other.SourceElementType != 0) {
        SourceElementType = other.SourceElementType;
      }
      if (other.ReactionSourceType != 0) {
        ReactionSourceType = other.ReactionSourceType;
      }
      if (other.AttackElementDurability != 0F) {
        AttackElementDurability = other.AttackElementDurability;
      }
      switch (other.CheckShapeCase) {
        case CheckShapeOneofCase.ShapeSphere:
          if (ShapeSphere == null) {
            ShapeSphere = new global::Weedwacker.Shared.Network.Proto.ShapeSphere();
          }
          ShapeSphere.MergeFrom(other.ShapeSphere);
          break;
        case CheckShapeOneofCase.ShapeBox:
          if (ShapeBox == null) {
            ShapeBox = new global::Weedwacker.Shared.Network.Proto.ShapeBox();
          }
          ShapeBox.MergeFrom(other.ShapeBox);
          break;
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
          case 18: {
            global::Weedwacker.Shared.Network.Proto.ShapeBox subBuilder = new global::Weedwacker.Shared.Network.Proto.ShapeBox();
            if (checkShapeCase_ == CheckShapeOneofCase.ShapeBox) {
              subBuilder.MergeFrom(ShapeBox);
            }
            input.ReadMessage(subBuilder);
            ShapeBox = subBuilder;
            break;
          }
          case 24: {
            AttackerId = input.ReadUInt32();
            break;
          }
          case 32: {
            ReactionSourceType = input.ReadInt32();
            break;
          }
          case 48: {
            EntityType = input.ReadInt32();
            break;
          }
          case 61: {
            AttackElementDurability = input.ReadFloat();
            break;
          }
          case 72: {
            OpIdx = input.ReadUInt32();
            break;
          }
          case 82: {
            global::Weedwacker.Shared.Network.Proto.ShapeSphere subBuilder = new global::Weedwacker.Shared.Network.Proto.ShapeSphere();
            if (checkShapeCase_ == CheckShapeOneofCase.ShapeSphere) {
              subBuilder.MergeFrom(ShapeSphere);
            }
            input.ReadMessage(subBuilder);
            ShapeSphere = subBuilder;
            break;
          }
          case 88: {
            UserId = input.ReadUInt32();
            break;
          }
          case 96: {
            SourceElementType = input.ReadInt32();
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
            global::Weedwacker.Shared.Network.Proto.ShapeBox subBuilder = new global::Weedwacker.Shared.Network.Proto.ShapeBox();
            if (checkShapeCase_ == CheckShapeOneofCase.ShapeBox) {
              subBuilder.MergeFrom(ShapeBox);
            }
            input.ReadMessage(subBuilder);
            ShapeBox = subBuilder;
            break;
          }
          case 24: {
            AttackerId = input.ReadUInt32();
            break;
          }
          case 32: {
            ReactionSourceType = input.ReadInt32();
            break;
          }
          case 48: {
            EntityType = input.ReadInt32();
            break;
          }
          case 61: {
            AttackElementDurability = input.ReadFloat();
            break;
          }
          case 72: {
            OpIdx = input.ReadUInt32();
            break;
          }
          case 82: {
            global::Weedwacker.Shared.Network.Proto.ShapeSphere subBuilder = new global::Weedwacker.Shared.Network.Proto.ShapeSphere();
            if (checkShapeCase_ == CheckShapeOneofCase.ShapeSphere) {
              subBuilder.MergeFrom(ShapeSphere);
            }
            input.ReadMessage(subBuilder);
            ShapeSphere = subBuilder;
            break;
          }
          case 88: {
            UserId = input.ReadUInt32();
            break;
          }
          case 96: {
            SourceElementType = input.ReadInt32();
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