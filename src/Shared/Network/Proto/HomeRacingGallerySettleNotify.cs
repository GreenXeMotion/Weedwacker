// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeRacingGallerySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeRacingGallerySettleNotify.proto</summary>
  public static partial class HomeRacingGallerySettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeRacingGallerySettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeRacingGallerySettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNIb21lUmFjaW5nR2FsbGVyeVNldHRsZU5vdGlmeS5wcm90bxodUmFjaW5n",
            "R2FsbGVyeVNldHRsZUluZm8ucHJvdG8ihwEKHUhvbWVSYWNpbmdHYWxsZXJ5",
            "U2V0dGxlTm90aWZ5EhIKCmdhbGxlcnlfaWQYCyABKA0SLQoLc2V0dGxlX2lu",
            "Zm8YDCABKAsyGC5SYWNpbmdHYWxsZXJ5U2V0dGxlSW5mbxIMCgRyYW5rGAcg",
            "ASgNEhUKDWlzX25ld19yZWNvcmQYAiABKAhCIqoCH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeRacingGallerySettleNotify), global::Weedwacker.Shared.Network.Proto.HomeRacingGallerySettleNotify.Parser, new[]{ "GalleryId", "SettleInfo", "Rank", "IsNewRecord" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4805
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class HomeRacingGallerySettleNotify : pb::IMessage<HomeRacingGallerySettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeRacingGallerySettleNotify> _parser = new pb::MessageParser<HomeRacingGallerySettleNotify>(() => new HomeRacingGallerySettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeRacingGallerySettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeRacingGallerySettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeRacingGallerySettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeRacingGallerySettleNotify(HomeRacingGallerySettleNotify other) : this() {
      galleryId_ = other.galleryId_;
      settleInfo_ = other.settleInfo_ != null ? other.settleInfo_.Clone() : null;
      rank_ = other.rank_;
      isNewRecord_ = other.isNewRecord_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeRacingGallerySettleNotify Clone() {
      return new HomeRacingGallerySettleNotify(this);
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 11;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "settle_info" field.</summary>
    public const int SettleInfoFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfo settleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfo SettleInfo {
      get { return settleInfo_; }
      set {
        settleInfo_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 7;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 2;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeRacingGallerySettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeRacingGallerySettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GalleryId != other.GalleryId) return false;
      if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
      if (Rank != other.Rank) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (settleInfo_ != null) hash ^= SettleInfo.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
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
      if (IsNewRecord != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsNewRecord);
      }
      if (Rank != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Rank);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(SettleInfo);
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
      if (IsNewRecord != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsNewRecord);
      }
      if (Rank != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Rank);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryId);
      }
      if (settleInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(SettleInfo);
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
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (settleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeRacingGallerySettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.settleInfo_ != null) {
        if (settleInfo_ == null) {
          SettleInfo = new global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfo();
        }
        SettleInfo.MergeFrom(other.SettleInfo);
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
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
            IsNewRecord = input.ReadBool();
            break;
          }
          case 56: {
            Rank = input.ReadUInt32();
            break;
          }
          case 88: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfo();
            }
            input.ReadMessage(SettleInfo);
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
            IsNewRecord = input.ReadBool();
            break;
          }
          case 56: {
            Rank = input.ReadUInt32();
            break;
          }
          case 88: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (settleInfo_ == null) {
              SettleInfo = new global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfo();
            }
            input.ReadMessage(SettleInfo);
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