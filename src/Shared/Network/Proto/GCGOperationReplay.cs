// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGOperationReplay.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGOperationReplay.proto</summary>
  public static partial class GCGOperationReplayReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGOperationReplay.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGOperationReplayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHQ0dPcGVyYXRpb25SZXBsYXkucHJvdG8aFkdDR09wZXJhdGlvbkRhdGEu",
            "cHJvdG8iYwoSR0NHT3BlcmF0aW9uUmVwbGF5Eg8KB2dhbWVfaWQYASABKA0S",
            "DAoEc2VlZBgLIAEoDRIuChNvcGVyYXRpb25fZGF0YV9saXN0GAkgAygLMhEu",
            "R0NHT3BlcmF0aW9uRGF0YUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGOperationDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGOperationReplay), global::Weedwacker.Shared.Network.Proto.GCGOperationReplay.Parser, new[]{ "GameId", "Seed", "OperationDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGOperationReplay : pb::IMessage<GCGOperationReplay>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGOperationReplay> _parser = new pb::MessageParser<GCGOperationReplay>(() => new GCGOperationReplay());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGOperationReplay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGOperationReplayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationReplay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationReplay(GCGOperationReplay other) : this() {
      gameId_ = other.gameId_;
      seed_ = other.seed_;
      operationDataList_ = other.operationDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationReplay Clone() {
      return new GCGOperationReplay(this);
    }

    /// <summary>Field number for the "game_id" field.</summary>
    public const int GameIdFieldNumber = 1;
    private uint gameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameId {
      get { return gameId_; }
      set {
        gameId_ = value;
      }
    }

    /// <summary>Field number for the "seed" field.</summary>
    public const int SeedFieldNumber = 11;
    private uint seed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Seed {
      get { return seed_; }
      set {
        seed_ = value;
      }
    }

    /// <summary>Field number for the "operation_data_list" field.</summary>
    public const int OperationDataListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGOperationData> _repeated_operationDataList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.GCGOperationData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGOperationData> operationDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGOperationData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGOperationData> OperationDataList {
      get { return operationDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGOperationReplay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGOperationReplay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GameId != other.GameId) return false;
      if (Seed != other.Seed) return false;
      if(!operationDataList_.Equals(other.operationDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GameId != 0) hash ^= GameId.GetHashCode();
      if (Seed != 0) hash ^= Seed.GetHashCode();
      hash ^= operationDataList_.GetHashCode();
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
      if (GameId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GameId);
      }
      operationDataList_.WriteTo(output, _repeated_operationDataList_codec);
      if (Seed != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Seed);
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
      if (GameId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GameId);
      }
      operationDataList_.WriteTo(ref output, _repeated_operationDataList_codec);
      if (Seed != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Seed);
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
      if (GameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameId);
      }
      if (Seed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Seed);
      }
      size += operationDataList_.CalculateSize(_repeated_operationDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGOperationReplay other) {
      if (other == null) {
        return;
      }
      if (other.GameId != 0) {
        GameId = other.GameId;
      }
      if (other.Seed != 0) {
        Seed = other.Seed;
      }
      operationDataList_.Add(other.operationDataList_);
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
            GameId = input.ReadUInt32();
            break;
          }
          case 74: {
            operationDataList_.AddEntriesFrom(input, _repeated_operationDataList_codec);
            break;
          }
          case 88: {
            Seed = input.ReadUInt32();
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
            GameId = input.ReadUInt32();
            break;
          }
          case 74: {
            operationDataList_.AddEntriesFrom(ref input, _repeated_operationDataList_codec);
            break;
          }
          case 88: {
            Seed = input.ReadUInt32();
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
