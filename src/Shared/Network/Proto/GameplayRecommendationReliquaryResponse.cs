// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GameplayRecommendationReliquaryResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GameplayRecommendationReliquaryResponse.proto</summary>
  public static partial class GameplayRecommendationReliquaryResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for GameplayRecommendationReliquaryResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameplayRecommendationReliquaryResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1HYW1lcGxheVJlY29tbWVuZGF0aW9uUmVsaXF1YXJ5UmVzcG9uc2UucHJv",
            "dG8aMUdhbWVwbGF5UmVjb21tZW5kYXRpb25SZWxpcXVhcnlNYWluUHJvcERh",
            "dGEucHJvdG8iiAEKJ0dhbWVwbGF5UmVjb21tZW5kYXRpb25SZWxpcXVhcnlS",
            "ZXNwb25zZRJJChNtYWluX3Byb3BfZGF0YV9saXN0GAggAygLMiwuR2FtZXBs",
            "YXlSZWNvbW1lbmRhdGlvblJlbGlxdWFyeU1haW5Qcm9wRGF0YRISCgplcXVp",
            "cF90eXBlGAMgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryResponse), global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryResponse.Parser, new[]{ "MainPropDataList", "EquipType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GameplayRecommendationReliquaryResponse : pb::IMessage<GameplayRecommendationReliquaryResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameplayRecommendationReliquaryResponse> _parser = new pb::MessageParser<GameplayRecommendationReliquaryResponse>(() => new GameplayRecommendationReliquaryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameplayRecommendationReliquaryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryResponse(GameplayRecommendationReliquaryResponse other) : this() {
      mainPropDataList_ = other.mainPropDataList_.Clone();
      equipType_ = other.equipType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryResponse Clone() {
      return new GameplayRecommendationReliquaryResponse(this);
    }

    /// <summary>Field number for the "main_prop_data_list" field.</summary>
    public const int MainPropDataListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData> _repeated_mainPropDataList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData> mainPropDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData> MainPropDataList {
      get { return mainPropDataList_; }
    }

    /// <summary>Field number for the "equip_type" field.</summary>
    public const int EquipTypeFieldNumber = 3;
    private uint equipType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EquipType {
      get { return equipType_; }
      set {
        equipType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameplayRecommendationReliquaryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameplayRecommendationReliquaryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!mainPropDataList_.Equals(other.mainPropDataList_)) return false;
      if (EquipType != other.EquipType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= mainPropDataList_.GetHashCode();
      if (EquipType != 0) hash ^= EquipType.GetHashCode();
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
      if (EquipType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EquipType);
      }
      mainPropDataList_.WriteTo(output, _repeated_mainPropDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EquipType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EquipType);
      }
      mainPropDataList_.WriteTo(ref output, _repeated_mainPropDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += mainPropDataList_.CalculateSize(_repeated_mainPropDataList_codec);
      if (EquipType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EquipType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameplayRecommendationReliquaryResponse other) {
      if (other == null) {
        return;
      }
      mainPropDataList_.Add(other.mainPropDataList_);
      if (other.EquipType != 0) {
        EquipType = other.EquipType;
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
          case 24: {
            EquipType = input.ReadUInt32();
            break;
          }
          case 66: {
            mainPropDataList_.AddEntriesFrom(input, _repeated_mainPropDataList_codec);
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
          case 24: {
            EquipType = input.ReadUInt32();
            break;
          }
          case 66: {
            mainPropDataList_.AddEntriesFrom(ref input, _repeated_mainPropDataList_codec);
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
