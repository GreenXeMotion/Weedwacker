// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AranaraCollectionSuite.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AranaraCollectionSuite.proto</summary>
  public static partial class AranaraCollectionSuiteReflection {

    #region Descriptor
    /// <summary>File descriptor for AranaraCollectionSuite.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AranaraCollectionSuiteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxBcmFuYXJhQ29sbGVjdGlvblN1aXRlLnByb3RvGhxBcmFuYXJhQ29sbGVj",
            "dGlvblN0YXRlLnByb3RvItsBChZBcmFuYXJhQ29sbGVjdGlvblN1aXRlElIK",
            "F2NvbGxlY3Rpb25faWRfc3RhdGVfbWFwGAYgAygLMjEuQXJhbmFyYUNvbGxl",
            "Y3Rpb25TdWl0ZS5Db2xsZWN0aW9uSWRTdGF0ZU1hcEVudHJ5EhcKD2NvbGxl",
            "Y3Rpb25fdHlwZRgMIAEoDRpUChlDb2xsZWN0aW9uSWRTdGF0ZU1hcEVudHJ5",
            "EgsKA2tleRgBIAEoDRImCgV2YWx1ZRgCIAEoDjIXLkFyYW5hcmFDb2xsZWN0",
            "aW9uU3RhdGU6AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AranaraCollectionStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AranaraCollectionSuite), global::Weedwacker.Shared.Network.Proto.AranaraCollectionSuite.Parser, new[]{ "CollectionIdStateMap", "CollectionType" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AranaraCollectionSuite : pb::IMessage<AranaraCollectionSuite>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AranaraCollectionSuite> _parser = new pb::MessageParser<AranaraCollectionSuite>(() => new AranaraCollectionSuite());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AranaraCollectionSuite> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AranaraCollectionSuiteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AranaraCollectionSuite() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AranaraCollectionSuite(AranaraCollectionSuite other) : this() {
      collectionIdStateMap_ = other.collectionIdStateMap_.Clone();
      collectionType_ = other.collectionType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AranaraCollectionSuite Clone() {
      return new AranaraCollectionSuite(this);
    }

    /// <summary>Field number for the "collection_id_state_map" field.</summary>
    public const int CollectionIdStateMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AranaraCollectionState>.Codec _map_collectionIdStateMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AranaraCollectionState>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForEnum(16, x => (int) x, x => (global::Weedwacker.Shared.Network.Proto.AranaraCollectionState) x, global::Weedwacker.Shared.Network.Proto.AranaraCollectionState.None), 50);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AranaraCollectionState> collectionIdStateMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AranaraCollectionState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.AranaraCollectionState> CollectionIdStateMap {
      get { return collectionIdStateMap_; }
    }

    /// <summary>Field number for the "collection_type" field.</summary>
    public const int CollectionTypeFieldNumber = 12;
    private uint collectionType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CollectionType {
      get { return collectionType_; }
      set {
        collectionType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AranaraCollectionSuite);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AranaraCollectionSuite other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!CollectionIdStateMap.Equals(other.CollectionIdStateMap)) return false;
      if (CollectionType != other.CollectionType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= CollectionIdStateMap.GetHashCode();
      if (CollectionType != 0) hash ^= CollectionType.GetHashCode();
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
      collectionIdStateMap_.WriteTo(output, _map_collectionIdStateMap_codec);
      if (CollectionType != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CollectionType);
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
      collectionIdStateMap_.WriteTo(ref output, _map_collectionIdStateMap_codec);
      if (CollectionType != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CollectionType);
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
      size += collectionIdStateMap_.CalculateSize(_map_collectionIdStateMap_codec);
      if (CollectionType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CollectionType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AranaraCollectionSuite other) {
      if (other == null) {
        return;
      }
      collectionIdStateMap_.Add(other.collectionIdStateMap_);
      if (other.CollectionType != 0) {
        CollectionType = other.CollectionType;
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
          case 50: {
            collectionIdStateMap_.AddEntriesFrom(input, _map_collectionIdStateMap_codec);
            break;
          }
          case 96: {
            CollectionType = input.ReadUInt32();
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
          case 50: {
            collectionIdStateMap_.AddEntriesFrom(ref input, _map_collectionIdStateMap_codec);
            break;
          }
          case 96: {
            CollectionType = input.ReadUInt32();
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
