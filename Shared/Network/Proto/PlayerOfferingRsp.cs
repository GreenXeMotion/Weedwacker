// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerOfferingRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerOfferingRsp.proto</summary>
  public static partial class PlayerOfferingRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerOfferingRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerOfferingRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQbGF5ZXJPZmZlcmluZ1JzcC5wcm90bxoPSXRlbVBhcmFtLnByb3RvGhhQ",
            "bGF5ZXJPZmZlcmluZ0RhdGEucHJvdG8ibwoRUGxheWVyT2ZmZXJpbmdSc3AS",
            "HQoJaXRlbV9saXN0GAcgAygLMgouSXRlbVBhcmFtEg8KB3JldGNvZGUYBCAB",
            "KAUSKgoNb2ZmZXJpbmdfZGF0YRgKIAEoCzITLlBsYXllck9mZmVyaW5nRGF0",
            "YUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.PlayerOfferingDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerOfferingRsp), global::Weedwacker.Shared.Network.Proto.PlayerOfferingRsp.Parser, new[]{ "ItemList", "Retcode", "OfferingData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 2917
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class PlayerOfferingRsp : pb::IMessage<PlayerOfferingRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerOfferingRsp> _parser = new pb::MessageParser<PlayerOfferingRsp>(() => new PlayerOfferingRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerOfferingRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerOfferingRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerOfferingRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerOfferingRsp(PlayerOfferingRsp other) : this() {
      itemList_ = other.itemList_.Clone();
      retcode_ = other.retcode_;
      offeringData_ = other.offeringData_ != null ? other.offeringData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerOfferingRsp Clone() {
      return new PlayerOfferingRsp(this);
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> itemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "offering_data" field.</summary>
    public const int OfferingDataFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.PlayerOfferingData offeringData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PlayerOfferingData OfferingData {
      get { return offeringData_; }
      set {
        offeringData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerOfferingRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerOfferingRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!itemList_.Equals(other.itemList_)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(OfferingData, other.OfferingData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= itemList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (offeringData_ != null) hash ^= OfferingData.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (offeringData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(OfferingData);
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (offeringData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(OfferingData);
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
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (offeringData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OfferingData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerOfferingRsp other) {
      if (other == null) {
        return;
      }
      itemList_.Add(other.itemList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.offeringData_ != null) {
        if (offeringData_ == null) {
          OfferingData = new global::Weedwacker.Shared.Network.Proto.PlayerOfferingData();
        }
        OfferingData.MergeFrom(other.OfferingData);
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
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 58: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 82: {
            if (offeringData_ == null) {
              OfferingData = new global::Weedwacker.Shared.Network.Proto.PlayerOfferingData();
            }
            input.ReadMessage(OfferingData);
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
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 58: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 82: {
            if (offeringData_ == null) {
              OfferingData = new global::Weedwacker.Shared.Network.Proto.PlayerOfferingData();
            }
            input.ReadMessage(OfferingData);
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