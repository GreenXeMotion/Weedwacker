// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGDuel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGDuel.proto</summary>
  public static partial class GCGDuelReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGDuel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGDuelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1HQ0dEdWVsLnByb3RvGg1HQ0dDYXJkLnByb3RvGhtHQ0dDb250cm9sbGVy",
            "U2hvd0luZm8ucHJvdG8aF0dDR0Nvc3RSZXZpc2VJbmZvLnByb3RvGhZHQ0dE",
            "dWVsQ2hhbGxlbmdlLnByb3RvGhlHQ0dHYW1lQnVzaW5lc3NUeXBlLnByb3Rv",
            "GhVHQ0dQVkVJbnRlbnRpb24ucHJvdG8aDkdDR1BoYXNlLnByb3RvGhRHQ0dQ",
            "bGF5ZXJGaWVsZC5wcm90byLOAwoHR0NHRHVlbBISCgpzZXJ2ZXJfc2VxGAMg",
            "ASgNEiMKCmZpZWxkX2xpc3QYByADKAsyDy5HQ0dQbGF5ZXJGaWVsZBIrCg1i",
            "dXNpbmVzc190eXBlGA4gASgOMhQuR0NHR2FtZUJ1c2luZXNzVHlwZRIpCg5j",
            "aGFsbGVuZ2VfbGlzdBgFIAMoCzIRLkdDR0R1ZWxDaGFsbGVuZ2USDwoHZ2Ft",
            "ZV9pZBgLIAEoDRIVCg1jb250cm9sbGVyX2lkGA0gASgNEg0KBXJvdW5kGA8g",
            "ASgNEhkKEWN1cl9jb250cm9sbGVyX2lkGAwgASgNEicKDWludGV0aW9uX2xp",
            "c3QYASADKAsyEC5HQ0dQVkVJbnRlbnRpb24SJwoLY29zdF9yZXZpc2UYCiAB",
            "KAsyEi5HQ0dDb3N0UmV2aXNlSW5mbxIUCgxjYXJkX2lkX2xpc3QYBCADKA0S",
            "GwoJY2FyZF9saXN0GAkgAygLMgguR0NHQ2FyZBIuCg5zaG93X2luZm9fbGlz",
            "dBgGIAMoCzIWLkdDR0NvbnRyb2xsZXJTaG93SW5mbxIRCglnYW1lX3R5cGUY",
            "AiABKA0SGAoFcGhhc2UYCCABKAsyCS5HQ0dQaGFzZUIiqgIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGCardReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGDuelChallengeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGGameBusinessTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGPVEIntentionReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGPhaseReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGPlayerFieldReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGDuel), global::Weedwacker.Shared.Network.Proto.GCGDuel.Parser, new[]{ "ServerSeq", "FieldList", "BusinessType", "ChallengeList", "GameId", "ControllerId", "Round", "CurControllerId", "IntetionList", "CostRevise", "CardIdList", "CardList", "ShowInfoList", "GameType", "Phase" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGDuel : pb::IMessage<GCGDuel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGDuel> _parser = new pb::MessageParser<GCGDuel>(() => new GCGDuel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGDuel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGDuelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuel(GCGDuel other) : this() {
      serverSeq_ = other.serverSeq_;
      fieldList_ = other.fieldList_.Clone();
      businessType_ = other.businessType_;
      challengeList_ = other.challengeList_.Clone();
      gameId_ = other.gameId_;
      controllerId_ = other.controllerId_;
      round_ = other.round_;
      curControllerId_ = other.curControllerId_;
      intetionList_ = other.intetionList_.Clone();
      costRevise_ = other.costRevise_ != null ? other.costRevise_.Clone() : null;
      cardIdList_ = other.cardIdList_.Clone();
      cardList_ = other.cardList_.Clone();
      showInfoList_ = other.showInfoList_.Clone();
      gameType_ = other.gameType_;
      phase_ = other.phase_ != null ? other.phase_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuel Clone() {
      return new GCGDuel(this);
    }

    /// <summary>Field number for the "server_seq" field.</summary>
    public const int ServerSeqFieldNumber = 3;
    private uint serverSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ServerSeq {
      get { return serverSeq_; }
      set {
        serverSeq_ = value;
      }
    }

    /// <summary>Field number for the "field_list" field.</summary>
    public const int FieldListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGPlayerField> _repeated_fieldList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.GCGPlayerField.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayerField> fieldList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayerField>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayerField> FieldList {
      get { return fieldList_; }
    }

    /// <summary>Field number for the "business_type" field.</summary>
    public const int BusinessTypeFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType businessType_ = global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType BusinessType {
      get { return businessType_; }
      set {
        businessType_ = value;
      }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge> challengeList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "game_id" field.</summary>
    public const int GameIdFieldNumber = 11;
    private uint gameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameId {
      get { return gameId_; }
      set {
        gameId_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 13;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 15;
    private uint round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    /// <summary>Field number for the "cur_controller_id" field.</summary>
    public const int CurControllerIdFieldNumber = 12;
    private uint curControllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurControllerId {
      get { return curControllerId_; }
      set {
        curControllerId_ = value;
      }
    }

    /// <summary>Field number for the "intetion_list" field.</summary>
    public const int IntetionListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention> _repeated_intetionList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.GCGPVEIntention.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention> intetionList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention> IntetionList {
      get { return intetionList_; }
    }

    /// <summary>Field number for the "cost_revise" field.</summary>
    public const int CostReviseFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo costRevise_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo CostRevise {
      get { return costRevise_; }
      set {
        costRevise_ = value;
      }
    }

    /// <summary>Field number for the "card_id_list" field.</summary>
    public const int CardIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_cardIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> cardIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardIdList {
      get { return cardIdList_; }
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGCard> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.GCGCard.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "show_info_list" field.</summary>
    public const int ShowInfoListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo> _repeated_showInfoList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo> showInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo> ShowInfoList {
      get { return showInfoList_; }
    }

    /// <summary>Field number for the "game_type" field.</summary>
    public const int GameTypeFieldNumber = 2;
    private uint gameType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameType {
      get { return gameType_; }
      set {
        gameType_ = value;
      }
    }

    /// <summary>Field number for the "phase" field.</summary>
    public const int PhaseFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.GCGPhase phase_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGPhase Phase {
      get { return phase_; }
      set {
        phase_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGDuel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGDuel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerSeq != other.ServerSeq) return false;
      if(!fieldList_.Equals(other.fieldList_)) return false;
      if (BusinessType != other.BusinessType) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if (GameId != other.GameId) return false;
      if (ControllerId != other.ControllerId) return false;
      if (Round != other.Round) return false;
      if (CurControllerId != other.CurControllerId) return false;
      if(!intetionList_.Equals(other.intetionList_)) return false;
      if (!object.Equals(CostRevise, other.CostRevise)) return false;
      if(!cardIdList_.Equals(other.cardIdList_)) return false;
      if(!cardList_.Equals(other.cardList_)) return false;
      if(!showInfoList_.Equals(other.showInfoList_)) return false;
      if (GameType != other.GameType) return false;
      if (!object.Equals(Phase, other.Phase)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerSeq != 0) hash ^= ServerSeq.GetHashCode();
      hash ^= fieldList_.GetHashCode();
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) hash ^= BusinessType.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      if (GameId != 0) hash ^= GameId.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      if (Round != 0) hash ^= Round.GetHashCode();
      if (CurControllerId != 0) hash ^= CurControllerId.GetHashCode();
      hash ^= intetionList_.GetHashCode();
      if (costRevise_ != null) hash ^= CostRevise.GetHashCode();
      hash ^= cardIdList_.GetHashCode();
      hash ^= cardList_.GetHashCode();
      hash ^= showInfoList_.GetHashCode();
      if (GameType != 0) hash ^= GameType.GetHashCode();
      if (phase_ != null) hash ^= Phase.GetHashCode();
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
      intetionList_.WriteTo(output, _repeated_intetionList_codec);
      if (GameType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameType);
      }
      if (ServerSeq != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ServerSeq);
      }
      cardIdList_.WriteTo(output, _repeated_cardIdList_codec);
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      showInfoList_.WriteTo(output, _repeated_showInfoList_codec);
      fieldList_.WriteTo(output, _repeated_fieldList_codec);
      if (phase_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Phase);
      }
      cardList_.WriteTo(output, _repeated_cardList_codec);
      if (costRevise_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CostRevise);
      }
      if (GameId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GameId);
      }
      if (CurControllerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurControllerId);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ControllerId);
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) BusinessType);
      }
      if (Round != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Round);
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
      intetionList_.WriteTo(ref output, _repeated_intetionList_codec);
      if (GameType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameType);
      }
      if (ServerSeq != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ServerSeq);
      }
      cardIdList_.WriteTo(ref output, _repeated_cardIdList_codec);
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      showInfoList_.WriteTo(ref output, _repeated_showInfoList_codec);
      fieldList_.WriteTo(ref output, _repeated_fieldList_codec);
      if (phase_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Phase);
      }
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      if (costRevise_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CostRevise);
      }
      if (GameId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GameId);
      }
      if (CurControllerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CurControllerId);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ControllerId);
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(112);
        output.WriteEnum((int) BusinessType);
      }
      if (Round != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Round);
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
      if (ServerSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ServerSeq);
      }
      size += fieldList_.CalculateSize(_repeated_fieldList_codec);
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BusinessType);
      }
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      if (GameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameId);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
      }
      if (CurControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurControllerId);
      }
      size += intetionList_.CalculateSize(_repeated_intetionList_codec);
      if (costRevise_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostRevise);
      }
      size += cardIdList_.CalculateSize(_repeated_cardIdList_codec);
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      size += showInfoList_.CalculateSize(_repeated_showInfoList_codec);
      if (GameType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameType);
      }
      if (phase_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Phase);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGDuel other) {
      if (other == null) {
        return;
      }
      if (other.ServerSeq != 0) {
        ServerSeq = other.ServerSeq;
      }
      fieldList_.Add(other.fieldList_);
      if (other.BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        BusinessType = other.BusinessType;
      }
      challengeList_.Add(other.challengeList_);
      if (other.GameId != 0) {
        GameId = other.GameId;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      if (other.Round != 0) {
        Round = other.Round;
      }
      if (other.CurControllerId != 0) {
        CurControllerId = other.CurControllerId;
      }
      intetionList_.Add(other.intetionList_);
      if (other.costRevise_ != null) {
        if (costRevise_ == null) {
          CostRevise = new global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo();
        }
        CostRevise.MergeFrom(other.CostRevise);
      }
      cardIdList_.Add(other.cardIdList_);
      cardList_.Add(other.cardList_);
      showInfoList_.Add(other.showInfoList_);
      if (other.GameType != 0) {
        GameType = other.GameType;
      }
      if (other.phase_ != null) {
        if (phase_ == null) {
          Phase = new global::Weedwacker.Shared.Network.Proto.GCGPhase();
        }
        Phase.MergeFrom(other.Phase);
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
          case 10: {
            intetionList_.AddEntriesFrom(input, _repeated_intetionList_codec);
            break;
          }
          case 16: {
            GameType = input.ReadUInt32();
            break;
          }
          case 24: {
            ServerSeq = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            cardIdList_.AddEntriesFrom(input, _repeated_cardIdList_codec);
            break;
          }
          case 42: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
            break;
          }
          case 50: {
            showInfoList_.AddEntriesFrom(input, _repeated_showInfoList_codec);
            break;
          }
          case 58: {
            fieldList_.AddEntriesFrom(input, _repeated_fieldList_codec);
            break;
          }
          case 66: {
            if (phase_ == null) {
              Phase = new global::Weedwacker.Shared.Network.Proto.GCGPhase();
            }
            input.ReadMessage(Phase);
            break;
          }
          case 74: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 82: {
            if (costRevise_ == null) {
              CostRevise = new global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo();
            }
            input.ReadMessage(CostRevise);
            break;
          }
          case 88: {
            GameId = input.ReadUInt32();
            break;
          }
          case 96: {
            CurControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 112: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 120: {
            Round = input.ReadUInt32();
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
          case 10: {
            intetionList_.AddEntriesFrom(ref input, _repeated_intetionList_codec);
            break;
          }
          case 16: {
            GameType = input.ReadUInt32();
            break;
          }
          case 24: {
            ServerSeq = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            cardIdList_.AddEntriesFrom(ref input, _repeated_cardIdList_codec);
            break;
          }
          case 42: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
            break;
          }
          case 50: {
            showInfoList_.AddEntriesFrom(ref input, _repeated_showInfoList_codec);
            break;
          }
          case 58: {
            fieldList_.AddEntriesFrom(ref input, _repeated_fieldList_codec);
            break;
          }
          case 66: {
            if (phase_ == null) {
              Phase = new global::Weedwacker.Shared.Network.Proto.GCGPhase();
            }
            input.ReadMessage(Phase);
            break;
          }
          case 74: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 82: {
            if (costRevise_ == null) {
              CostRevise = new global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo();
            }
            input.ReadMessage(CostRevise);
            break;
          }
          case 88: {
            GameId = input.ReadUInt32();
            break;
          }
          case 96: {
            CurControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 112: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 120: {
            Round = input.ReadUInt32();
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
