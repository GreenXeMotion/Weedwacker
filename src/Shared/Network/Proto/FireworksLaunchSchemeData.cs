// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FireworksLaunchSchemeData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FireworksLaunchSchemeData.proto</summary>
  public static partial class FireworksLaunchSchemeDataReflection {

    #region Descriptor
    /// <summary>File descriptor for FireworksLaunchSchemeData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FireworksLaunchSchemeDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9GaXJld29ya3NMYXVuY2hTY2hlbWVEYXRhLnByb3RvGhpGaXJld29ya3NM",
            "YXVuY2hQYXJhbS5wcm90byJ7ChlGaXJld29ya3NMYXVuY2hTY2hlbWVEYXRh",
            "EhEKCXNjaGVtZV9pZBgDIAEoDRIZChFmaXJld29ya3NfaWRfbGlzdBgCIAMo",
            "DRIwChFsYXVuY2hfcGFyYW1fbGlzdBgHIAMoCzIVLkZpcmV3b3Jrc0xhdW5j",
            "aFBhcmFtQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FireworksLaunchParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FireworksLaunchSchemeData), global::Weedwacker.Shared.Network.Proto.FireworksLaunchSchemeData.Parser, new[]{ "SchemeId", "FireworksIdList", "LaunchParamList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FireworksLaunchSchemeData : pb::IMessage<FireworksLaunchSchemeData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FireworksLaunchSchemeData> _parser = new pb::MessageParser<FireworksLaunchSchemeData>(() => new FireworksLaunchSchemeData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FireworksLaunchSchemeData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FireworksLaunchSchemeDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FireworksLaunchSchemeData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FireworksLaunchSchemeData(FireworksLaunchSchemeData other) : this() {
      schemeId_ = other.schemeId_;
      fireworksIdList_ = other.fireworksIdList_.Clone();
      launchParamList_ = other.launchParamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FireworksLaunchSchemeData Clone() {
      return new FireworksLaunchSchemeData(this);
    }

    /// <summary>Field number for the "scheme_id" field.</summary>
    public const int SchemeIdFieldNumber = 3;
    private uint schemeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SchemeId {
      get { return schemeId_; }
      set {
        schemeId_ = value;
      }
    }

    /// <summary>Field number for the "fireworks_id_list" field.</summary>
    public const int FireworksIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_fireworksIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> fireworksIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FireworksIdList {
      get { return fireworksIdList_; }
    }

    /// <summary>Field number for the "launch_param_list" field.</summary>
    public const int LaunchParamListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.FireworksLaunchParam> _repeated_launchParamList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.FireworksLaunchParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.FireworksLaunchParam> launchParamList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.FireworksLaunchParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.FireworksLaunchParam> LaunchParamList {
      get { return launchParamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FireworksLaunchSchemeData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FireworksLaunchSchemeData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SchemeId != other.SchemeId) return false;
      if(!fireworksIdList_.Equals(other.fireworksIdList_)) return false;
      if(!launchParamList_.Equals(other.launchParamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SchemeId != 0) hash ^= SchemeId.GetHashCode();
      hash ^= fireworksIdList_.GetHashCode();
      hash ^= launchParamList_.GetHashCode();
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
      fireworksIdList_.WriteTo(output, _repeated_fireworksIdList_codec);
      if (SchemeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SchemeId);
      }
      launchParamList_.WriteTo(output, _repeated_launchParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      fireworksIdList_.WriteTo(ref output, _repeated_fireworksIdList_codec);
      if (SchemeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SchemeId);
      }
      launchParamList_.WriteTo(ref output, _repeated_launchParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (SchemeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SchemeId);
      }
      size += fireworksIdList_.CalculateSize(_repeated_fireworksIdList_codec);
      size += launchParamList_.CalculateSize(_repeated_launchParamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FireworksLaunchSchemeData other) {
      if (other == null) {
        return;
      }
      if (other.SchemeId != 0) {
        SchemeId = other.SchemeId;
      }
      fireworksIdList_.Add(other.fireworksIdList_);
      launchParamList_.Add(other.launchParamList_);
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
          case 18:
          case 16: {
            fireworksIdList_.AddEntriesFrom(input, _repeated_fireworksIdList_codec);
            break;
          }
          case 24: {
            SchemeId = input.ReadUInt32();
            break;
          }
          case 58: {
            launchParamList_.AddEntriesFrom(input, _repeated_launchParamList_codec);
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
          case 18:
          case 16: {
            fireworksIdList_.AddEntriesFrom(ref input, _repeated_fireworksIdList_codec);
            break;
          }
          case 24: {
            SchemeId = input.ReadUInt32();
            break;
          }
          case 58: {
            launchParamList_.AddEntriesFrom(ref input, _repeated_launchParamList_codec);
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
