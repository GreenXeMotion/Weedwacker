// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewOnstageChangeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewOnstageChangeInfo.proto</summary>
  public static partial class GCGSkillPreviewOnstageChangeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewOnstageChangeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewOnstageChangeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZHQ0dTa2lsbFByZXZpZXdPbnN0YWdlQ2hhbmdlSW5mby5wcm90byJmCiBH",
            "Q0dTa2lsbFByZXZpZXdPbnN0YWdlQ2hhbmdlSW5mbxIgChh0YXJnZXRfb25z",
            "dGFnZV9jYXJkX2d1aWQYBiABKA0SIAoYc291cmNlX29uc3RhZ2VfY2FyZF9n",
            "dWlkGA8gASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfo), global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfo.Parser, new[]{ "TargetOnstageCardGuid", "SourceOnstageCardGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGSkillPreviewOnstageChangeInfo : pb::IMessage<GCGSkillPreviewOnstageChangeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewOnstageChangeInfo> _parser = new pb::MessageParser<GCGSkillPreviewOnstageChangeInfo>(() => new GCGSkillPreviewOnstageChangeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewOnstageChangeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewOnstageChangeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewOnstageChangeInfo(GCGSkillPreviewOnstageChangeInfo other) : this() {
      targetOnstageCardGuid_ = other.targetOnstageCardGuid_;
      sourceOnstageCardGuid_ = other.sourceOnstageCardGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewOnstageChangeInfo Clone() {
      return new GCGSkillPreviewOnstageChangeInfo(this);
    }

    /// <summary>Field number for the "target_onstage_card_guid" field.</summary>
    public const int TargetOnstageCardGuidFieldNumber = 6;
    private uint targetOnstageCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetOnstageCardGuid {
      get { return targetOnstageCardGuid_; }
      set {
        targetOnstageCardGuid_ = value;
      }
    }

    /// <summary>Field number for the "source_onstage_card_guid" field.</summary>
    public const int SourceOnstageCardGuidFieldNumber = 15;
    private uint sourceOnstageCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceOnstageCardGuid {
      get { return sourceOnstageCardGuid_; }
      set {
        sourceOnstageCardGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewOnstageChangeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewOnstageChangeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetOnstageCardGuid != other.TargetOnstageCardGuid) return false;
      if (SourceOnstageCardGuid != other.SourceOnstageCardGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetOnstageCardGuid != 0) hash ^= TargetOnstageCardGuid.GetHashCode();
      if (SourceOnstageCardGuid != 0) hash ^= SourceOnstageCardGuid.GetHashCode();
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
      if (TargetOnstageCardGuid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TargetOnstageCardGuid);
      }
      if (SourceOnstageCardGuid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceOnstageCardGuid);
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
      if (TargetOnstageCardGuid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(TargetOnstageCardGuid);
      }
      if (SourceOnstageCardGuid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SourceOnstageCardGuid);
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
      if (TargetOnstageCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetOnstageCardGuid);
      }
      if (SourceOnstageCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceOnstageCardGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewOnstageChangeInfo other) {
      if (other == null) {
        return;
      }
      if (other.TargetOnstageCardGuid != 0) {
        TargetOnstageCardGuid = other.TargetOnstageCardGuid;
      }
      if (other.SourceOnstageCardGuid != 0) {
        SourceOnstageCardGuid = other.SourceOnstageCardGuid;
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
            TargetOnstageCardGuid = input.ReadUInt32();
            break;
          }
          case 120: {
            SourceOnstageCardGuid = input.ReadUInt32();
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
            TargetOnstageCardGuid = input.ReadUInt32();
            break;
          }
          case 120: {
            SourceOnstageCardGuid = input.ReadUInt32();
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
