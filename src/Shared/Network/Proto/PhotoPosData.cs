// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PhotoPosData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PhotoPosData.proto</summary>
  public static partial class PhotoPosDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PhotoPosData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PhotoPosDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQaG90b1Bvc0RhdGEucHJvdG8aDFZlY3Rvci5wcm90byJsCgxQaG90b1Bv",
            "c0RhdGESFwoGY2VudGVyGA8gASgLMgcuVmVjdG9yEhEKCW9wZW5fdGltZRgC",
            "IAEoDRIPCgdpc192aWV3GAQgASgIEg4KBnBvc19pZBgJIAEoDRIPCgdpc19v",
            "cGVuGAYgASgIQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PhotoPosData), global::Weedwacker.Shared.Network.Proto.PhotoPosData.Parser, new[]{ "Center", "OpenTime", "IsView", "PosId", "IsOpen" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PhotoPosData : pb::IMessage<PhotoPosData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PhotoPosData> _parser = new pb::MessageParser<PhotoPosData>(() => new PhotoPosData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PhotoPosData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PhotoPosDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoPosData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoPosData(PhotoPosData other) : this() {
      center_ = other.center_ != null ? other.center_.Clone() : null;
      openTime_ = other.openTime_;
      isView_ = other.isView_;
      posId_ = other.posId_;
      isOpen_ = other.isOpen_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoPosData Clone() {
      return new PhotoPosData(this);
    }

    /// <summary>Field number for the "center" field.</summary>
    public const int CenterFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.Vector center_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Center {
      get { return center_; }
      set {
        center_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 2;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "is_view" field.</summary>
    public const int IsViewFieldNumber = 4;
    private bool isView_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsView {
      get { return isView_; }
      set {
        isView_ = value;
      }
    }

    /// <summary>Field number for the "pos_id" field.</summary>
    public const int PosIdFieldNumber = 9;
    private uint posId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PosId {
      get { return posId_; }
      set {
        posId_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 6;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PhotoPosData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PhotoPosData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Center, other.Center)) return false;
      if (OpenTime != other.OpenTime) return false;
      if (IsView != other.IsView) return false;
      if (PosId != other.PosId) return false;
      if (IsOpen != other.IsOpen) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (center_ != null) hash ^= Center.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (IsView != false) hash ^= IsView.GetHashCode();
      if (PosId != 0) hash ^= PosId.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
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
      if (OpenTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OpenTime);
      }
      if (IsView != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsView);
      }
      if (IsOpen != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsOpen);
      }
      if (PosId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PosId);
      }
      if (center_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Center);
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
      if (OpenTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OpenTime);
      }
      if (IsView != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsView);
      }
      if (IsOpen != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsOpen);
      }
      if (PosId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PosId);
      }
      if (center_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Center);
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
      if (center_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Center);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (IsView != false) {
        size += 1 + 1;
      }
      if (PosId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PosId);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PhotoPosData other) {
      if (other == null) {
        return;
      }
      if (other.center_ != null) {
        if (center_ == null) {
          Center = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Center.MergeFrom(other.Center);
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      if (other.IsView != false) {
        IsView = other.IsView;
      }
      if (other.PosId != 0) {
        PosId = other.PosId;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
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
          case 16: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 32: {
            IsView = input.ReadBool();
            break;
          }
          case 48: {
            IsOpen = input.ReadBool();
            break;
          }
          case 72: {
            PosId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
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
          case 16: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 32: {
            IsView = input.ReadBool();
            break;
          }
          case 48: {
            IsOpen = input.ReadBool();
            break;
          }
          case 72: {
            PosId = input.ReadUInt32();
            break;
          }
          case 122: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
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
