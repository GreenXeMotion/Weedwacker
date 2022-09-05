// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HitTreeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HitTreeNotify.proto</summary>
  public static partial class HitTreeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HitTreeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HitTreeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNIaXRUcmVlTm90aWZ5LnByb3RvGgxWZWN0b3IucHJvdG8iWAoNSGl0VHJl",
            "ZU5vdGlmeRIRCgl0cmVlX3R5cGUYCyABKA0SGQoIdHJlZV9wb3MYAiABKAsy",
            "By5WZWN0b3ISGQoIZHJvcF9wb3MYCCABKAsyBy5WZWN0b3JCGqoCF1dlZWR3",
            "YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HitTreeNotify), global::Weedwacker.Server.Proto.HitTreeNotify.Parser, new[]{ "TreeType", "TreePos", "DropPos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3019
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class HitTreeNotify : pb::IMessage<HitTreeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HitTreeNotify> _parser = new pb::MessageParser<HitTreeNotify>(() => new HitTreeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HitTreeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HitTreeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitTreeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitTreeNotify(HitTreeNotify other) : this() {
      treeType_ = other.treeType_;
      treePos_ = other.treePos_ != null ? other.treePos_.Clone() : null;
      dropPos_ = other.dropPos_ != null ? other.dropPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitTreeNotify Clone() {
      return new HitTreeNotify(this);
    }

    /// <summary>Field number for the "tree_type" field.</summary>
    public const int TreeTypeFieldNumber = 11;
    private uint treeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TreeType {
      get { return treeType_; }
      set {
        treeType_ = value;
      }
    }

    /// <summary>Field number for the "tree_pos" field.</summary>
    public const int TreePosFieldNumber = 2;
    private global::Weedwacker.Server.Proto.Vector treePos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector TreePos {
      get { return treePos_; }
      set {
        treePos_ = value;
      }
    }

    /// <summary>Field number for the "drop_pos" field.</summary>
    public const int DropPosFieldNumber = 8;
    private global::Weedwacker.Server.Proto.Vector dropPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Server.Proto.Vector DropPos {
      get { return dropPos_; }
      set {
        dropPos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HitTreeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HitTreeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TreeType != other.TreeType) return false;
      if (!object.Equals(TreePos, other.TreePos)) return false;
      if (!object.Equals(DropPos, other.DropPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TreeType != 0) hash ^= TreeType.GetHashCode();
      if (treePos_ != null) hash ^= TreePos.GetHashCode();
      if (dropPos_ != null) hash ^= DropPos.GetHashCode();
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
      if (treePos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TreePos);
      }
      if (dropPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(DropPos);
      }
      if (TreeType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TreeType);
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
      if (treePos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TreePos);
      }
      if (dropPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(DropPos);
      }
      if (TreeType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TreeType);
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
      if (TreeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TreeType);
      }
      if (treePos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TreePos);
      }
      if (dropPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DropPos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HitTreeNotify other) {
      if (other == null) {
        return;
      }
      if (other.TreeType != 0) {
        TreeType = other.TreeType;
      }
      if (other.treePos_ != null) {
        if (treePos_ == null) {
          TreePos = new global::Weedwacker.Server.Proto.Vector();
        }
        TreePos.MergeFrom(other.TreePos);
      }
      if (other.dropPos_ != null) {
        if (dropPos_ == null) {
          DropPos = new global::Weedwacker.Server.Proto.Vector();
        }
        DropPos.MergeFrom(other.DropPos);
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
            if (treePos_ == null) {
              TreePos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(TreePos);
            break;
          }
          case 66: {
            if (dropPos_ == null) {
              DropPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DropPos);
            break;
          }
          case 88: {
            TreeType = input.ReadUInt32();
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
            if (treePos_ == null) {
              TreePos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(TreePos);
            break;
          }
          case 66: {
            if (dropPos_ == null) {
              DropPos = new global::Weedwacker.Server.Proto.Vector();
            }
            input.ReadMessage(DropPos);
            break;
          }
          case 88: {
            TreeType = input.ReadUInt32();
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