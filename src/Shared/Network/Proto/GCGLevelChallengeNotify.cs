// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGLevelChallengeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGLevelChallengeNotify.proto</summary>
  public static partial class GCGLevelChallengeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGLevelChallengeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGLevelChallengeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HQ0dMZXZlbENoYWxsZW5nZU5vdGlmeS5wcm90bxoaR0NHQm9zc0NoYWxs",
            "ZW5nZURhdGEucHJvdG8aEkdDR0xldmVsRGF0YS5wcm90byKcAQoXR0NHTGV2",
            "ZWxDaGFsbGVuZ2VOb3RpZnkSOQoadW5sb2NrX2Jvc3NfY2hhbGxlbmdlX2xp",
            "c3QYAyADKAsyFS5HQ0dCb3NzQ2hhbGxlbmdlRGF0YRIjCht1bmxvY2tfd29y",
            "bGRfY2hhbGxlbmdlX2xpc3QYCCADKA0SIQoKbGV2ZWxfbGlzdBgKIAMoCzIN",
            "LkdDR0xldmVsRGF0YUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGBossChallengeDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGLevelDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGLevelChallengeNotify), global::Weedwacker.Shared.Network.Proto.GCGLevelChallengeNotify.Parser, new[]{ "UnlockBossChallengeList", "UnlockWorldChallengeList", "LevelList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 7055
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GCGLevelChallengeNotify : pb::IMessage<GCGLevelChallengeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGLevelChallengeNotify> _parser = new pb::MessageParser<GCGLevelChallengeNotify>(() => new GCGLevelChallengeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGLevelChallengeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGLevelChallengeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGLevelChallengeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGLevelChallengeNotify(GCGLevelChallengeNotify other) : this() {
      unlockBossChallengeList_ = other.unlockBossChallengeList_.Clone();
      unlockWorldChallengeList_ = other.unlockWorldChallengeList_.Clone();
      levelList_ = other.levelList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGLevelChallengeNotify Clone() {
      return new GCGLevelChallengeNotify(this);
    }

    /// <summary>Field number for the "unlock_boss_challenge_list" field.</summary>
    public const int UnlockBossChallengeListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGBossChallengeData> _repeated_unlockBossChallengeList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.GCGBossChallengeData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGBossChallengeData> unlockBossChallengeList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGBossChallengeData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGBossChallengeData> UnlockBossChallengeList {
      get { return unlockBossChallengeList_; }
    }

    /// <summary>Field number for the "unlock_world_challenge_list" field.</summary>
    public const int UnlockWorldChallengeListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_unlockWorldChallengeList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> unlockWorldChallengeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockWorldChallengeList {
      get { return unlockWorldChallengeList_; }
    }

    /// <summary>Field number for the "level_list" field.</summary>
    public const int LevelListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGLevelData> _repeated_levelList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.GCGLevelData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGLevelData> levelList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGLevelData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGLevelData> LevelList {
      get { return levelList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGLevelChallengeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGLevelChallengeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockBossChallengeList_.Equals(other.unlockBossChallengeList_)) return false;
      if(!unlockWorldChallengeList_.Equals(other.unlockWorldChallengeList_)) return false;
      if(!levelList_.Equals(other.levelList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockBossChallengeList_.GetHashCode();
      hash ^= unlockWorldChallengeList_.GetHashCode();
      hash ^= levelList_.GetHashCode();
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
      unlockBossChallengeList_.WriteTo(output, _repeated_unlockBossChallengeList_codec);
      unlockWorldChallengeList_.WriteTo(output, _repeated_unlockWorldChallengeList_codec);
      levelList_.WriteTo(output, _repeated_levelList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unlockBossChallengeList_.WriteTo(ref output, _repeated_unlockBossChallengeList_codec);
      unlockWorldChallengeList_.WriteTo(ref output, _repeated_unlockWorldChallengeList_codec);
      levelList_.WriteTo(ref output, _repeated_levelList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unlockBossChallengeList_.CalculateSize(_repeated_unlockBossChallengeList_codec);
      size += unlockWorldChallengeList_.CalculateSize(_repeated_unlockWorldChallengeList_codec);
      size += levelList_.CalculateSize(_repeated_levelList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGLevelChallengeNotify other) {
      if (other == null) {
        return;
      }
      unlockBossChallengeList_.Add(other.unlockBossChallengeList_);
      unlockWorldChallengeList_.Add(other.unlockWorldChallengeList_);
      levelList_.Add(other.levelList_);
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
          case 26: {
            unlockBossChallengeList_.AddEntriesFrom(input, _repeated_unlockBossChallengeList_codec);
            break;
          }
          case 66:
          case 64: {
            unlockWorldChallengeList_.AddEntriesFrom(input, _repeated_unlockWorldChallengeList_codec);
            break;
          }
          case 82: {
            levelList_.AddEntriesFrom(input, _repeated_levelList_codec);
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
          case 26: {
            unlockBossChallengeList_.AddEntriesFrom(ref input, _repeated_unlockBossChallengeList_codec);
            break;
          }
          case 66:
          case 64: {
            unlockWorldChallengeList_.AddEntriesFrom(ref input, _repeated_unlockWorldChallengeList_codec);
            break;
          }
          case 82: {
            levelList_.AddEntriesFrom(ref input, _repeated_levelList_codec);
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
