// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MiracleRingDeliverItemReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from MiracleRingDeliverItemReq.proto</summary>
  public static partial class MiracleRingDeliverItemReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MiracleRingDeliverItemReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MiracleRingDeliverItemReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9NaXJhY2xlUmluZ0RlbGl2ZXJJdGVtUmVxLnByb3RvGhFJbnRlck9wVHlw",
            "ZS5wcm90bxoPSXRlbVBhcmFtLnByb3RvIqsBChlNaXJhY2xlUmluZ0RlbGl2",
            "ZXJJdGVtUmVxEh0KB29wX3R5cGUYCSABKA4yDC5JbnRlck9wVHlwZRIjCg9p",
            "dGVtX3BhcmFtX2xpc3QYASADKAsyCi5JdGVtUGFyYW0SHQoVZm9vZF93ZWFw",
            "b25fZ3VpZF9saXN0GAQgAygEEhEKCWdhZGdldF9pZBgOIAEoDRIYChBnYWRn",
            "ZXRfZW50aXR5X2lkGAUgASgNQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.InterOpTypeReflection.Descriptor, global::Weedwacker.Server.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.MiracleRingDeliverItemReq), global::Weedwacker.Server.Proto.MiracleRingDeliverItemReq.Parser, new[]{ "OpType", "ItemParamList", "FoodWeaponGuidList", "GadgetId", "GadgetEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5229
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class MiracleRingDeliverItemReq : pb::IMessage<MiracleRingDeliverItemReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MiracleRingDeliverItemReq> _parser = new pb::MessageParser<MiracleRingDeliverItemReq>(() => new MiracleRingDeliverItemReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MiracleRingDeliverItemReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.MiracleRingDeliverItemReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MiracleRingDeliverItemReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MiracleRingDeliverItemReq(MiracleRingDeliverItemReq other) : this() {
      opType_ = other.opType_;
      itemParamList_ = other.itemParamList_.Clone();
      foodWeaponGuidList_ = other.foodWeaponGuidList_.Clone();
      gadgetId_ = other.gadgetId_;
      gadgetEntityId_ = other.gadgetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MiracleRingDeliverItemReq Clone() {
      return new MiracleRingDeliverItemReq(this);
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 9;
    private global::Weedwacker.Server.Proto.InterOpType opType_ = global::Weedwacker.Server.Proto.InterOpType.Finish;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.InterOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "item_param_list" field.</summary>
    public const int ItemParamListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.ItemParam> _repeated_itemParamList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Server.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> itemParamList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.ItemParam> ItemParamList {
      get { return itemParamList_; }
    }

    /// <summary>Field number for the "food_weapon_guid_list" field.</summary>
    public const int FoodWeaponGuidListFieldNumber = 4;
    private static readonly pb::FieldCodec<ulong> _repeated_foodWeaponGuidList_codec
        = pb::FieldCodec.ForUInt64(34);
    private readonly pbc::RepeatedField<ulong> foodWeaponGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> FoodWeaponGuidList {
      get { return foodWeaponGuidList_; }
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 14;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 5;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MiracleRingDeliverItemReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MiracleRingDeliverItemReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpType != other.OpType) return false;
      if(!itemParamList_.Equals(other.itemParamList_)) return false;
      if(!foodWeaponGuidList_.Equals(other.foodWeaponGuidList_)) return false;
      if (GadgetId != other.GadgetId) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OpType != global::Weedwacker.Server.Proto.InterOpType.Finish) hash ^= OpType.GetHashCode();
      hash ^= itemParamList_.GetHashCode();
      hash ^= foodWeaponGuidList_.GetHashCode();
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
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
      itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
      foodWeaponGuidList_.WriteTo(output, _repeated_foodWeaponGuidList_codec);
      if (GadgetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::Weedwacker.Server.Proto.InterOpType.Finish) {
        output.WriteRawTag(72);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GadgetId);
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
      itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
      foodWeaponGuidList_.WriteTo(ref output, _repeated_foodWeaponGuidList_codec);
      if (GadgetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::Weedwacker.Server.Proto.InterOpType.Finish) {
        output.WriteRawTag(72);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GadgetId);
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
      if (OpType != global::Weedwacker.Server.Proto.InterOpType.Finish) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
      size += foodWeaponGuidList_.CalculateSize(_repeated_foodWeaponGuidList_codec);
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MiracleRingDeliverItemReq other) {
      if (other == null) {
        return;
      }
      if (other.OpType != global::Weedwacker.Server.Proto.InterOpType.Finish) {
        OpType = other.OpType;
      }
      itemParamList_.Add(other.itemParamList_);
      foodWeaponGuidList_.Add(other.foodWeaponGuidList_);
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
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
            itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
            break;
          }
          case 34:
          case 32: {
            foodWeaponGuidList_.AddEntriesFrom(input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 40: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            OpType = (global::Weedwacker.Server.Proto.InterOpType) input.ReadEnum();
            break;
          }
          case 112: {
            GadgetId = input.ReadUInt32();
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
            itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
            break;
          }
          case 34:
          case 32: {
            foodWeaponGuidList_.AddEntriesFrom(ref input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 40: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            OpType = (global::Weedwacker.Server.Proto.InterOpType) input.ReadEnum();
            break;
          }
          case 112: {
            GadgetId = input.ReadUInt32();
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