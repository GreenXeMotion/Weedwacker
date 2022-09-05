// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeCustomFurnitureInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HomeCustomFurnitureInfo.proto</summary>
  public static partial class HomeCustomFurnitureInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeCustomFurnitureInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeCustomFurnitureInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Ib21lQ3VzdG9tRnVybml0dXJlSW5mby5wcm90bxoaQ3VzdG9tQ29tbW9u",
            "Tm9kZUluZm8ucHJvdG8iWgoXSG9tZUN1c3RvbUZ1cm5pdHVyZUluZm8SMQoS",
            "c3ViX2Z1cm5pdHVyZV9saXN0GAwgAygLMhUuQ3VzdG9tQ29tbW9uTm9kZUlu",
            "Zm8SDAoEZ3VpZBgGIAEoDUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.CustomCommonNodeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HomeCustomFurnitureInfo), global::Weedwacker.Server.Proto.HomeCustomFurnitureInfo.Parser, new[]{ "SubFurnitureList", "Guid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeCustomFurnitureInfo : pb::IMessage<HomeCustomFurnitureInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeCustomFurnitureInfo> _parser = new pb::MessageParser<HomeCustomFurnitureInfo>(() => new HomeCustomFurnitureInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeCustomFurnitureInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HomeCustomFurnitureInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCustomFurnitureInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCustomFurnitureInfo(HomeCustomFurnitureInfo other) : this() {
      subFurnitureList_ = other.subFurnitureList_.Clone();
      guid_ = other.guid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCustomFurnitureInfo Clone() {
      return new HomeCustomFurnitureInfo(this);
    }

    /// <summary>Field number for the "sub_furniture_list" field.</summary>
    public const int SubFurnitureListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.CustomCommonNodeInfo> _repeated_subFurnitureList_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Server.Proto.CustomCommonNodeInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.CustomCommonNodeInfo> subFurnitureList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.CustomCommonNodeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.CustomCommonNodeInfo> SubFurnitureList {
      get { return subFurnitureList_; }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 6;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeCustomFurnitureInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeCustomFurnitureInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!subFurnitureList_.Equals(other.subFurnitureList_)) return false;
      if (Guid != other.Guid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= subFurnitureList_.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
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
      if (Guid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Guid);
      }
      subFurnitureList_.WriteTo(output, _repeated_subFurnitureList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Guid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Guid);
      }
      subFurnitureList_.WriteTo(ref output, _repeated_subFurnitureList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += subFurnitureList_.CalculateSize(_repeated_subFurnitureList_codec);
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeCustomFurnitureInfo other) {
      if (other == null) {
        return;
      }
      subFurnitureList_.Add(other.subFurnitureList_);
      if (other.Guid != 0) {
        Guid = other.Guid;
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
          case 48: {
            Guid = input.ReadUInt32();
            break;
          }
          case 98: {
            subFurnitureList_.AddEntriesFrom(input, _repeated_subFurnitureList_codec);
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
          case 48: {
            Guid = input.ReadUInt32();
            break;
          }
          case 98: {
            subFurnitureList_.AddEntriesFrom(ref input, _repeated_subFurnitureList_codec);
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