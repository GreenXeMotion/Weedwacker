// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from IrodoriChessInfo.proto</summary>
  public static partial class IrodoriChessInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for IrodoriChessInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IrodoriChessInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZJcm9kb3JpQ2hlc3NJbmZvLnByb3RvGh1Jcm9kb3JpQ2hlc3NNeXN0ZXJ5",
            "SW5mby5wcm90byKnAQoQSXJvZG9yaUNoZXNzSW5mbxIuCgxteXN0ZXJ5X2lu",
            "Zm8YAyABKAsyGC5Jcm9kb3JpQ2hlc3NNeXN0ZXJ5SW5mbxIVCg1sZWZ0X21v",
            "bnN0ZXJzGAwgASgNEh0KFXNlbGVjdGVkX2NhcmRfaWRfbGlzdBgNIAMoDRIX",
            "Cg9idWlsZGluZ19wb2ludHMYByABKA0SFAoMc2V0dGxlX3Njb3JlGAQgASgN",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.IrodoriChessInfo), global::Weedwacker.Shared.Network.Proto.IrodoriChessInfo.Parser, new[]{ "MysteryInfo", "LeftMonsters", "SelectedCardIdList", "BuildingPoints", "SettleScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IrodoriChessInfo : pb::IMessage<IrodoriChessInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IrodoriChessInfo> _parser = new pb::MessageParser<IrodoriChessInfo>(() => new IrodoriChessInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IrodoriChessInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.IrodoriChessInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessInfo(IrodoriChessInfo other) : this() {
      mysteryInfo_ = other.mysteryInfo_ != null ? other.mysteryInfo_.Clone() : null;
      leftMonsters_ = other.leftMonsters_;
      selectedCardIdList_ = other.selectedCardIdList_.Clone();
      buildingPoints_ = other.buildingPoints_;
      settleScore_ = other.settleScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriChessInfo Clone() {
      return new IrodoriChessInfo(this);
    }

    /// <summary>Field number for the "mystery_info" field.</summary>
    public const int MysteryInfoFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfo mysteryInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfo MysteryInfo {
      get { return mysteryInfo_; }
      set {
        mysteryInfo_ = value;
      }
    }

    /// <summary>Field number for the "left_monsters" field.</summary>
    public const int LeftMonstersFieldNumber = 12;
    private uint leftMonsters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftMonsters {
      get { return leftMonsters_; }
      set {
        leftMonsters_ = value;
      }
    }

    /// <summary>Field number for the "selected_card_id_list" field.</summary>
    public const int SelectedCardIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_selectedCardIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> selectedCardIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectedCardIdList {
      get { return selectedCardIdList_; }
    }

    /// <summary>Field number for the "building_points" field.</summary>
    public const int BuildingPointsFieldNumber = 7;
    private uint buildingPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuildingPoints {
      get { return buildingPoints_; }
      set {
        buildingPoints_ = value;
      }
    }

    /// <summary>Field number for the "settle_score" field.</summary>
    public const int SettleScoreFieldNumber = 4;
    private uint settleScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SettleScore {
      get { return settleScore_; }
      set {
        settleScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IrodoriChessInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IrodoriChessInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MysteryInfo, other.MysteryInfo)) return false;
      if (LeftMonsters != other.LeftMonsters) return false;
      if(!selectedCardIdList_.Equals(other.selectedCardIdList_)) return false;
      if (BuildingPoints != other.BuildingPoints) return false;
      if (SettleScore != other.SettleScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (mysteryInfo_ != null) hash ^= MysteryInfo.GetHashCode();
      if (LeftMonsters != 0) hash ^= LeftMonsters.GetHashCode();
      hash ^= selectedCardIdList_.GetHashCode();
      if (BuildingPoints != 0) hash ^= BuildingPoints.GetHashCode();
      if (SettleScore != 0) hash ^= SettleScore.GetHashCode();
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
      if (mysteryInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MysteryInfo);
      }
      if (SettleScore != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SettleScore);
      }
      if (BuildingPoints != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BuildingPoints);
      }
      if (LeftMonsters != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LeftMonsters);
      }
      selectedCardIdList_.WriteTo(output, _repeated_selectedCardIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (mysteryInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MysteryInfo);
      }
      if (SettleScore != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SettleScore);
      }
      if (BuildingPoints != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BuildingPoints);
      }
      if (LeftMonsters != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LeftMonsters);
      }
      selectedCardIdList_.WriteTo(ref output, _repeated_selectedCardIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (mysteryInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MysteryInfo);
      }
      if (LeftMonsters != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftMonsters);
      }
      size += selectedCardIdList_.CalculateSize(_repeated_selectedCardIdList_codec);
      if (BuildingPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingPoints);
      }
      if (SettleScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SettleScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IrodoriChessInfo other) {
      if (other == null) {
        return;
      }
      if (other.mysteryInfo_ != null) {
        if (mysteryInfo_ == null) {
          MysteryInfo = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfo();
        }
        MysteryInfo.MergeFrom(other.MysteryInfo);
      }
      if (other.LeftMonsters != 0) {
        LeftMonsters = other.LeftMonsters;
      }
      selectedCardIdList_.Add(other.selectedCardIdList_);
      if (other.BuildingPoints != 0) {
        BuildingPoints = other.BuildingPoints;
      }
      if (other.SettleScore != 0) {
        SettleScore = other.SettleScore;
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
          case 26: {
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 32: {
            SettleScore = input.ReadUInt32();
            break;
          }
          case 56: {
            BuildingPoints = input.ReadUInt32();
            break;
          }
          case 96: {
            LeftMonsters = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            selectedCardIdList_.AddEntriesFrom(input, _repeated_selectedCardIdList_codec);
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
            if (mysteryInfo_ == null) {
              MysteryInfo = new global::Weedwacker.Shared.Network.Proto.IrodoriChessMysteryInfo();
            }
            input.ReadMessage(MysteryInfo);
            break;
          }
          case 32: {
            SettleScore = input.ReadUInt32();
            break;
          }
          case 56: {
            BuildingPoints = input.ReadUInt32();
            break;
          }
          case 96: {
            LeftMonsters = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            selectedCardIdList_.AddEntriesFrom(ref input, _repeated_selectedCardIdList_codec);
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
