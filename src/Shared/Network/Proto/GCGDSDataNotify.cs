// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGDSDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGDSDataNotify.proto</summary>
  public static partial class GCGDSDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGDSDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGDSDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHQ0dEU0RhdGFOb3RpZnkucHJvdG8aE0dDR0RTQ2FyZERhdGEucHJvdG8a",
            "E0dDR0RTRGVja0RhdGEucHJvdG8iyQEKD0dDR0RTRGF0YU5vdGlmeRIhCglk",
            "ZWNrX2xpc3QYBCADKAsyDi5HQ0dEU0RlY2tEYXRhEiAKGHVubG9ja19jYXJk",
            "X2JhY2tfaWRfbGlzdBgFIAMoDRIcChR1bmxvY2tfZmllbGRfaWRfbGlzdBgG",
            "IAMoDRITCgtjdXJfZGVja19pZBgKIAEoDRIhCgljYXJkX2xpc3QYAyADKAsy",
            "Di5HQ0dEU0NhcmREYXRhEhsKE3VubG9ja19kZWNrX2lkX2xpc3QYASADKA1C",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGDSCardDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGDSDeckDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGDSDataNotify), global::Weedwacker.Shared.Network.Proto.GCGDSDataNotify.Parser, new[]{ "DeckList", "UnlockCardBackIdList", "UnlockFieldIdList", "CurDeckId", "CardList", "UnlockDeckIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 7122
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GCGDSDataNotify : pb::IMessage<GCGDSDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGDSDataNotify> _parser = new pb::MessageParser<GCGDSDataNotify>(() => new GCGDSDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGDSDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGDSDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDSDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDSDataNotify(GCGDSDataNotify other) : this() {
      deckList_ = other.deckList_.Clone();
      unlockCardBackIdList_ = other.unlockCardBackIdList_.Clone();
      unlockFieldIdList_ = other.unlockFieldIdList_.Clone();
      curDeckId_ = other.curDeckId_;
      cardList_ = other.cardList_.Clone();
      unlockDeckIdList_ = other.unlockDeckIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDSDataNotify Clone() {
      return new GCGDSDataNotify(this);
    }

    /// <summary>Field number for the "deck_list" field.</summary>
    public const int DeckListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGDSDeckData> _repeated_deckList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.GCGDSDeckData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDSDeckData> deckList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDSDeckData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDSDeckData> DeckList {
      get { return deckList_; }
    }

    /// <summary>Field number for the "unlock_card_back_id_list" field.</summary>
    public const int UnlockCardBackIdListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_unlockCardBackIdList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> unlockCardBackIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockCardBackIdList {
      get { return unlockCardBackIdList_; }
    }

    /// <summary>Field number for the "unlock_field_id_list" field.</summary>
    public const int UnlockFieldIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_unlockFieldIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> unlockFieldIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockFieldIdList {
      get { return unlockFieldIdList_; }
    }

    /// <summary>Field number for the "cur_deck_id" field.</summary>
    public const int CurDeckIdFieldNumber = 10;
    private uint curDeckId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurDeckId {
      get { return curDeckId_; }
      set {
        curDeckId_ = value;
      }
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGDSCardData> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.GCGDSCardData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDSCardData> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDSCardData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDSCardData> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "unlock_deck_id_list" field.</summary>
    public const int UnlockDeckIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_unlockDeckIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> unlockDeckIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockDeckIdList {
      get { return unlockDeckIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGDSDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGDSDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!deckList_.Equals(other.deckList_)) return false;
      if(!unlockCardBackIdList_.Equals(other.unlockCardBackIdList_)) return false;
      if(!unlockFieldIdList_.Equals(other.unlockFieldIdList_)) return false;
      if (CurDeckId != other.CurDeckId) return false;
      if(!cardList_.Equals(other.cardList_)) return false;
      if(!unlockDeckIdList_.Equals(other.unlockDeckIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= deckList_.GetHashCode();
      hash ^= unlockCardBackIdList_.GetHashCode();
      hash ^= unlockFieldIdList_.GetHashCode();
      if (CurDeckId != 0) hash ^= CurDeckId.GetHashCode();
      hash ^= cardList_.GetHashCode();
      hash ^= unlockDeckIdList_.GetHashCode();
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
      unlockDeckIdList_.WriteTo(output, _repeated_unlockDeckIdList_codec);
      cardList_.WriteTo(output, _repeated_cardList_codec);
      deckList_.WriteTo(output, _repeated_deckList_codec);
      unlockCardBackIdList_.WriteTo(output, _repeated_unlockCardBackIdList_codec);
      unlockFieldIdList_.WriteTo(output, _repeated_unlockFieldIdList_codec);
      if (CurDeckId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurDeckId);
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
      unlockDeckIdList_.WriteTo(ref output, _repeated_unlockDeckIdList_codec);
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      deckList_.WriteTo(ref output, _repeated_deckList_codec);
      unlockCardBackIdList_.WriteTo(ref output, _repeated_unlockCardBackIdList_codec);
      unlockFieldIdList_.WriteTo(ref output, _repeated_unlockFieldIdList_codec);
      if (CurDeckId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurDeckId);
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
      size += deckList_.CalculateSize(_repeated_deckList_codec);
      size += unlockCardBackIdList_.CalculateSize(_repeated_unlockCardBackIdList_codec);
      size += unlockFieldIdList_.CalculateSize(_repeated_unlockFieldIdList_codec);
      if (CurDeckId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurDeckId);
      }
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      size += unlockDeckIdList_.CalculateSize(_repeated_unlockDeckIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGDSDataNotify other) {
      if (other == null) {
        return;
      }
      deckList_.Add(other.deckList_);
      unlockCardBackIdList_.Add(other.unlockCardBackIdList_);
      unlockFieldIdList_.Add(other.unlockFieldIdList_);
      if (other.CurDeckId != 0) {
        CurDeckId = other.CurDeckId;
      }
      cardList_.Add(other.cardList_);
      unlockDeckIdList_.Add(other.unlockDeckIdList_);
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
          case 10:
          case 8: {
            unlockDeckIdList_.AddEntriesFrom(input, _repeated_unlockDeckIdList_codec);
            break;
          }
          case 26: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 34: {
            deckList_.AddEntriesFrom(input, _repeated_deckList_codec);
            break;
          }
          case 42:
          case 40: {
            unlockCardBackIdList_.AddEntriesFrom(input, _repeated_unlockCardBackIdList_codec);
            break;
          }
          case 50:
          case 48: {
            unlockFieldIdList_.AddEntriesFrom(input, _repeated_unlockFieldIdList_codec);
            break;
          }
          case 80: {
            CurDeckId = input.ReadUInt32();
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
          case 10:
          case 8: {
            unlockDeckIdList_.AddEntriesFrom(ref input, _repeated_unlockDeckIdList_codec);
            break;
          }
          case 26: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 34: {
            deckList_.AddEntriesFrom(ref input, _repeated_deckList_codec);
            break;
          }
          case 42:
          case 40: {
            unlockCardBackIdList_.AddEntriesFrom(ref input, _repeated_unlockCardBackIdList_codec);
            break;
          }
          case 50:
          case 48: {
            unlockFieldIdList_.AddEntriesFrom(ref input, _repeated_unlockFieldIdList_codec);
            break;
          }
          case 80: {
            CurDeckId = input.ReadUInt32();
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
