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
            "GhRHQ0dNZXNzYWdlUGFjay5wcm90bxoVR0NHUFZFSW50ZW50aW9uLnByb3Rv",
            "Gg5HQ0dQaGFzZS5wcm90bxoUR0NHUGxheWVyRmllbGQucHJvdG8aGVVuazMz",
            "MDBfQURIRU5DSUZLTkkucHJvdG8iqwUKB0dDR0R1ZWwSEgoKc2VydmVyX3Nl",
            "cRgDIAEoDRIuCg5zaG93X2luZm9fbGlzdBgHIAMoCzIWLkdDR0NvbnRyb2xs",
            "ZXJTaG93SW5mbxIlChxmb3JiaWRfZmluaXNoX2NoYWxsZW5nZV9saXN0GMAB",
            "IAMoDRIbCgljYXJkX2xpc3QYASADKAsyCC5HQ0dDYXJkEhsKE1VuazMzMDBf",
            "QklBTk1PUERFSE8YCSABKA0SJwoLY29zdF9yZXZpc2UYCCABKAsyEi5HQ0dD",
            "b3N0UmV2aXNlSW5mbxIPCgdnYW1lX2lkGAQgASgNEiMKCmZpZWxkX2xpc3QY",
            "BSADKAsyDy5HQ0dQbGF5ZXJGaWVsZBIyChNVbmszMzAwX0NEQ01CT0tCTEFL",
            "GMMPIAMoCzIULlVuazMzMDBfQURIRU5DSUZLTkkSKwoNYnVzaW5lc3NfdHlw",
            "ZRgNIAEoDjIULkdDR0dhbWVCdXNpbmVzc1R5cGUSKAoOaW50ZW50aW9uX2xp",
            "c3QYAiADKAsyEC5HQ0dQVkVJbnRlbnRpb24SKgoOY2hhbGxlbmdlX2xpc3QY",
            "0QwgAygLMhEuR0NHRHVlbENoYWxsZW5nZRIkChFoaXN0b3J5X2NhcmRfbGlz",
            "dBjQDiADKAsyCC5HQ0dDYXJkEg0KBXJvdW5kGAsgASgNEhUKDWNvbnRyb2xs",
            "ZXJfaWQYDCABKA0SLwoVaGlzdG9yeV9tc2dfcGFja19saXN0GJ0GIAMoCzIP",
            "LkdDR01lc3NhZ2VQYWNrEhsKE1VuazMzMDBfSkhERE5LRlBJTkEYCiABKA0S",
            "FAoMY2FyZF9pZF9saXN0GAYgAygNEhsKE1VuazMzMDBfSkJCTUJLR09PTk8Y",
            "DyABKA0SGAoFcGhhc2UYDiABKAsyCS5HQ0dQaGFzZUIiqgIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGCardReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGDuelChallengeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGGameBusinessTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGMessagePackReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGPVEIntentionReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGPhaseReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGPlayerFieldReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk3300ADHENCIFKNIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGDuel), global::Weedwacker.Shared.Network.Proto.GCGDuel.Parser, new[]{ "ServerSeq", "ShowInfoList", "ForbidFinishChallengeList", "CardList", "Unk3300BIANMOPDEHO", "CostRevise", "GameId", "FieldList", "Unk3300CDCMBOKBLAK", "BusinessType", "IntentionList", "ChallengeList", "HistoryCardList", "Round", "ControllerId", "HistoryMsgPackList", "Unk3300JHDDNKFPINA", "CardIdList", "Unk3300JBBMBKGOONO", "Phase" }, null, null, null, null)
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
      showInfoList_ = other.showInfoList_.Clone();
      forbidFinishChallengeList_ = other.forbidFinishChallengeList_.Clone();
      cardList_ = other.cardList_.Clone();
      unk3300BIANMOPDEHO_ = other.unk3300BIANMOPDEHO_;
      costRevise_ = other.costRevise_ != null ? other.costRevise_.Clone() : null;
      gameId_ = other.gameId_;
      fieldList_ = other.fieldList_.Clone();
      unk3300CDCMBOKBLAK_ = other.unk3300CDCMBOKBLAK_.Clone();
      businessType_ = other.businessType_;
      intentionList_ = other.intentionList_.Clone();
      challengeList_ = other.challengeList_.Clone();
      historyCardList_ = other.historyCardList_.Clone();
      round_ = other.round_;
      controllerId_ = other.controllerId_;
      historyMsgPackList_ = other.historyMsgPackList_.Clone();
      unk3300JHDDNKFPINA_ = other.unk3300JHDDNKFPINA_;
      cardIdList_ = other.cardIdList_.Clone();
      unk3300JBBMBKGOONO_ = other.unk3300JBBMBKGOONO_;
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

    /// <summary>Field number for the "show_info_list" field.</summary>
    public const int ShowInfoListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo> _repeated_showInfoList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo> showInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGControllerShowInfo> ShowInfoList {
      get { return showInfoList_; }
    }

    /// <summary>Field number for the "forbid_finish_challenge_list" field.</summary>
    public const int ForbidFinishChallengeListFieldNumber = 192;
    private static readonly pb::FieldCodec<uint> _repeated_forbidFinishChallengeList_codec
        = pb::FieldCodec.ForUInt32(1538);
    private readonly pbc::RepeatedField<uint> forbidFinishChallengeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ForbidFinishChallengeList {
      get { return forbidFinishChallengeList_; }
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGCard> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.GCGCard.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "Unk3300_BIANMOPDEHO" field.</summary>
    public const int Unk3300BIANMOPDEHOFieldNumber = 9;
    private uint unk3300BIANMOPDEHO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300BIANMOPDEHO {
      get { return unk3300BIANMOPDEHO_; }
      set {
        unk3300BIANMOPDEHO_ = value;
      }
    }

    /// <summary>Field number for the "cost_revise" field.</summary>
    public const int CostReviseFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo costRevise_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo CostRevise {
      get { return costRevise_; }
      set {
        costRevise_ = value;
      }
    }

    /// <summary>Field number for the "game_id" field.</summary>
    public const int GameIdFieldNumber = 4;
    private uint gameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameId {
      get { return gameId_; }
      set {
        gameId_ = value;
      }
    }

    /// <summary>Field number for the "field_list" field.</summary>
    public const int FieldListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGPlayerField> _repeated_fieldList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.GCGPlayerField.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayerField> fieldList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayerField>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayerField> FieldList {
      get { return fieldList_; }
    }

    /// <summary>Field number for the "Unk3300_CDCMBOKBLAK" field.</summary>
    public const int Unk3300CDCMBOKBLAKFieldNumber = 1987;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk3300_ADHENCIFKNI> _repeated_unk3300CDCMBOKBLAK_codec
        = pb::FieldCodec.ForMessage(15898, global::Weedwacker.Shared.Network.Proto.Unk3300_ADHENCIFKNI.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3300_ADHENCIFKNI> unk3300CDCMBOKBLAK_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3300_ADHENCIFKNI>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3300_ADHENCIFKNI> Unk3300CDCMBOKBLAK {
      get { return unk3300CDCMBOKBLAK_; }
    }

    /// <summary>Field number for the "business_type" field.</summary>
    public const int BusinessTypeFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType businessType_ = global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType BusinessType {
      get { return businessType_; }
      set {
        businessType_ = value;
      }
    }

    /// <summary>Field number for the "intention_list" field.</summary>
    public const int IntentionListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention> _repeated_intentionList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.GCGPVEIntention.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention> intentionList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPVEIntention> IntentionList {
      get { return intentionList_; }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 1617;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(12938, global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge> challengeList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGDuelChallenge> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "history_card_list" field.</summary>
    public const int HistoryCardListFieldNumber = 1872;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGCard> _repeated_historyCardList_codec
        = pb::FieldCodec.ForMessage(14978, global::Weedwacker.Shared.Network.Proto.GCGCard.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard> historyCardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGCard> HistoryCardList {
      get { return historyCardList_; }
    }

    /// <summary>Field number for the "round" field.</summary>
    public const int RoundFieldNumber = 11;
    private uint round_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Round {
      get { return round_; }
      set {
        round_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 12;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "history_msg_pack_list" field.</summary>
    public const int HistoryMsgPackListFieldNumber = 797;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGMessagePack> _repeated_historyMsgPackList_codec
        = pb::FieldCodec.ForMessage(6378, global::Weedwacker.Shared.Network.Proto.GCGMessagePack.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGMessagePack> historyMsgPackList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGMessagePack>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGMessagePack> HistoryMsgPackList {
      get { return historyMsgPackList_; }
    }

    /// <summary>Field number for the "Unk3300_JHDDNKFPINA" field.</summary>
    public const int Unk3300JHDDNKFPINAFieldNumber = 10;
    private uint unk3300JHDDNKFPINA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JHDDNKFPINA {
      get { return unk3300JHDDNKFPINA_; }
      set {
        unk3300JHDDNKFPINA_ = value;
      }
    }

    /// <summary>Field number for the "card_id_list" field.</summary>
    public const int CardIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_cardIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> cardIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardIdList {
      get { return cardIdList_; }
    }

    /// <summary>Field number for the "Unk3300_JBBMBKGOONO" field.</summary>
    public const int Unk3300JBBMBKGOONOFieldNumber = 15;
    private uint unk3300JBBMBKGOONO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JBBMBKGOONO {
      get { return unk3300JBBMBKGOONO_; }
      set {
        unk3300JBBMBKGOONO_ = value;
      }
    }

    /// <summary>Field number for the "phase" field.</summary>
    public const int PhaseFieldNumber = 14;
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
      if(!showInfoList_.Equals(other.showInfoList_)) return false;
      if(!forbidFinishChallengeList_.Equals(other.forbidFinishChallengeList_)) return false;
      if(!cardList_.Equals(other.cardList_)) return false;
      if (Unk3300BIANMOPDEHO != other.Unk3300BIANMOPDEHO) return false;
      if (!object.Equals(CostRevise, other.CostRevise)) return false;
      if (GameId != other.GameId) return false;
      if(!fieldList_.Equals(other.fieldList_)) return false;
      if(!unk3300CDCMBOKBLAK_.Equals(other.unk3300CDCMBOKBLAK_)) return false;
      if (BusinessType != other.BusinessType) return false;
      if(!intentionList_.Equals(other.intentionList_)) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if(!historyCardList_.Equals(other.historyCardList_)) return false;
      if (Round != other.Round) return false;
      if (ControllerId != other.ControllerId) return false;
      if(!historyMsgPackList_.Equals(other.historyMsgPackList_)) return false;
      if (Unk3300JHDDNKFPINA != other.Unk3300JHDDNKFPINA) return false;
      if(!cardIdList_.Equals(other.cardIdList_)) return false;
      if (Unk3300JBBMBKGOONO != other.Unk3300JBBMBKGOONO) return false;
      if (!object.Equals(Phase, other.Phase)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerSeq != 0) hash ^= ServerSeq.GetHashCode();
      hash ^= showInfoList_.GetHashCode();
      hash ^= forbidFinishChallengeList_.GetHashCode();
      hash ^= cardList_.GetHashCode();
      if (Unk3300BIANMOPDEHO != 0) hash ^= Unk3300BIANMOPDEHO.GetHashCode();
      if (costRevise_ != null) hash ^= CostRevise.GetHashCode();
      if (GameId != 0) hash ^= GameId.GetHashCode();
      hash ^= fieldList_.GetHashCode();
      hash ^= unk3300CDCMBOKBLAK_.GetHashCode();
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) hash ^= BusinessType.GetHashCode();
      hash ^= intentionList_.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      hash ^= historyCardList_.GetHashCode();
      if (Round != 0) hash ^= Round.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      hash ^= historyMsgPackList_.GetHashCode();
      if (Unk3300JHDDNKFPINA != 0) hash ^= Unk3300JHDDNKFPINA.GetHashCode();
      hash ^= cardIdList_.GetHashCode();
      if (Unk3300JBBMBKGOONO != 0) hash ^= Unk3300JBBMBKGOONO.GetHashCode();
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
      cardList_.WriteTo(output, _repeated_cardList_codec);
      intentionList_.WriteTo(output, _repeated_intentionList_codec);
      if (ServerSeq != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ServerSeq);
      }
      if (GameId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GameId);
      }
      fieldList_.WriteTo(output, _repeated_fieldList_codec);
      cardIdList_.WriteTo(output, _repeated_cardIdList_codec);
      showInfoList_.WriteTo(output, _repeated_showInfoList_codec);
      if (costRevise_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(CostRevise);
      }
      if (Unk3300BIANMOPDEHO != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300BIANMOPDEHO);
      }
      if (Unk3300JHDDNKFPINA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JHDDNKFPINA);
      }
      if (Round != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Round);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ControllerId);
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) BusinessType);
      }
      if (phase_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Phase);
      }
      if (Unk3300JBBMBKGOONO != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300JBBMBKGOONO);
      }
      forbidFinishChallengeList_.WriteTo(output, _repeated_forbidFinishChallengeList_codec);
      historyMsgPackList_.WriteTo(output, _repeated_historyMsgPackList_codec);
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      historyCardList_.WriteTo(output, _repeated_historyCardList_codec);
      unk3300CDCMBOKBLAK_.WriteTo(output, _repeated_unk3300CDCMBOKBLAK_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      intentionList_.WriteTo(ref output, _repeated_intentionList_codec);
      if (ServerSeq != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ServerSeq);
      }
      if (GameId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GameId);
      }
      fieldList_.WriteTo(ref output, _repeated_fieldList_codec);
      cardIdList_.WriteTo(ref output, _repeated_cardIdList_codec);
      showInfoList_.WriteTo(ref output, _repeated_showInfoList_codec);
      if (costRevise_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(CostRevise);
      }
      if (Unk3300BIANMOPDEHO != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300BIANMOPDEHO);
      }
      if (Unk3300JHDDNKFPINA != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300JHDDNKFPINA);
      }
      if (Round != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Round);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ControllerId);
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) BusinessType);
      }
      if (phase_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Phase);
      }
      if (Unk3300JBBMBKGOONO != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300JBBMBKGOONO);
      }
      forbidFinishChallengeList_.WriteTo(ref output, _repeated_forbidFinishChallengeList_codec);
      historyMsgPackList_.WriteTo(ref output, _repeated_historyMsgPackList_codec);
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      historyCardList_.WriteTo(ref output, _repeated_historyCardList_codec);
      unk3300CDCMBOKBLAK_.WriteTo(ref output, _repeated_unk3300CDCMBOKBLAK_codec);
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
      size += showInfoList_.CalculateSize(_repeated_showInfoList_codec);
      size += forbidFinishChallengeList_.CalculateSize(_repeated_forbidFinishChallengeList_codec);
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      if (Unk3300BIANMOPDEHO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BIANMOPDEHO);
      }
      if (costRevise_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostRevise);
      }
      if (GameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameId);
      }
      size += fieldList_.CalculateSize(_repeated_fieldList_codec);
      size += unk3300CDCMBOKBLAK_.CalculateSize(_repeated_unk3300CDCMBOKBLAK_codec);
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BusinessType);
      }
      size += intentionList_.CalculateSize(_repeated_intentionList_codec);
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      size += historyCardList_.CalculateSize(_repeated_historyCardList_codec);
      if (Round != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Round);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      size += historyMsgPackList_.CalculateSize(_repeated_historyMsgPackList_codec);
      if (Unk3300JHDDNKFPINA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JHDDNKFPINA);
      }
      size += cardIdList_.CalculateSize(_repeated_cardIdList_codec);
      if (Unk3300JBBMBKGOONO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JBBMBKGOONO);
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
      showInfoList_.Add(other.showInfoList_);
      forbidFinishChallengeList_.Add(other.forbidFinishChallengeList_);
      cardList_.Add(other.cardList_);
      if (other.Unk3300BIANMOPDEHO != 0) {
        Unk3300BIANMOPDEHO = other.Unk3300BIANMOPDEHO;
      }
      if (other.costRevise_ != null) {
        if (costRevise_ == null) {
          CostRevise = new global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo();
        }
        CostRevise.MergeFrom(other.CostRevise);
      }
      if (other.GameId != 0) {
        GameId = other.GameId;
      }
      fieldList_.Add(other.fieldList_);
      unk3300CDCMBOKBLAK_.Add(other.unk3300CDCMBOKBLAK_);
      if (other.BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        BusinessType = other.BusinessType;
      }
      intentionList_.Add(other.intentionList_);
      challengeList_.Add(other.challengeList_);
      historyCardList_.Add(other.historyCardList_);
      if (other.Round != 0) {
        Round = other.Round;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      historyMsgPackList_.Add(other.historyMsgPackList_);
      if (other.Unk3300JHDDNKFPINA != 0) {
        Unk3300JHDDNKFPINA = other.Unk3300JHDDNKFPINA;
      }
      cardIdList_.Add(other.cardIdList_);
      if (other.Unk3300JBBMBKGOONO != 0) {
        Unk3300JBBMBKGOONO = other.Unk3300JBBMBKGOONO;
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
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 18: {
            intentionList_.AddEntriesFrom(input, _repeated_intentionList_codec);
            break;
          }
          case 24: {
            ServerSeq = input.ReadUInt32();
            break;
          }
          case 32: {
            GameId = input.ReadUInt32();
            break;
          }
          case 42: {
            fieldList_.AddEntriesFrom(input, _repeated_fieldList_codec);
            break;
          }
          case 50:
          case 48: {
            cardIdList_.AddEntriesFrom(input, _repeated_cardIdList_codec);
            break;
          }
          case 58: {
            showInfoList_.AddEntriesFrom(input, _repeated_showInfoList_codec);
            break;
          }
          case 66: {
            if (costRevise_ == null) {
              CostRevise = new global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo();
            }
            input.ReadMessage(CostRevise);
            break;
          }
          case 72: {
            Unk3300BIANMOPDEHO = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300JHDDNKFPINA = input.ReadUInt32();
            break;
          }
          case 88: {
            Round = input.ReadUInt32();
            break;
          }
          case 96: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 114: {
            if (phase_ == null) {
              Phase = new global::Weedwacker.Shared.Network.Proto.GCGPhase();
            }
            input.ReadMessage(Phase);
            break;
          }
          case 120: {
            Unk3300JBBMBKGOONO = input.ReadUInt32();
            break;
          }
          case 1538:
          case 1536: {
            forbidFinishChallengeList_.AddEntriesFrom(input, _repeated_forbidFinishChallengeList_codec);
            break;
          }
          case 6378: {
            historyMsgPackList_.AddEntriesFrom(input, _repeated_historyMsgPackList_codec);
            break;
          }
          case 12938: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
            break;
          }
          case 14978: {
            historyCardList_.AddEntriesFrom(input, _repeated_historyCardList_codec);
            break;
          }
          case 15898: {
            unk3300CDCMBOKBLAK_.AddEntriesFrom(input, _repeated_unk3300CDCMBOKBLAK_codec);
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
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 18: {
            intentionList_.AddEntriesFrom(ref input, _repeated_intentionList_codec);
            break;
          }
          case 24: {
            ServerSeq = input.ReadUInt32();
            break;
          }
          case 32: {
            GameId = input.ReadUInt32();
            break;
          }
          case 42: {
            fieldList_.AddEntriesFrom(ref input, _repeated_fieldList_codec);
            break;
          }
          case 50:
          case 48: {
            cardIdList_.AddEntriesFrom(ref input, _repeated_cardIdList_codec);
            break;
          }
          case 58: {
            showInfoList_.AddEntriesFrom(ref input, _repeated_showInfoList_codec);
            break;
          }
          case 66: {
            if (costRevise_ == null) {
              CostRevise = new global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo();
            }
            input.ReadMessage(CostRevise);
            break;
          }
          case 72: {
            Unk3300BIANMOPDEHO = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300JHDDNKFPINA = input.ReadUInt32();
            break;
          }
          case 88: {
            Round = input.ReadUInt32();
            break;
          }
          case 96: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 114: {
            if (phase_ == null) {
              Phase = new global::Weedwacker.Shared.Network.Proto.GCGPhase();
            }
            input.ReadMessage(Phase);
            break;
          }
          case 120: {
            Unk3300JBBMBKGOONO = input.ReadUInt32();
            break;
          }
          case 1538:
          case 1536: {
            forbidFinishChallengeList_.AddEntriesFrom(ref input, _repeated_forbidFinishChallengeList_codec);
            break;
          }
          case 6378: {
            historyMsgPackList_.AddEntriesFrom(ref input, _repeated_historyMsgPackList_codec);
            break;
          }
          case 12938: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
            break;
          }
          case 14978: {
            historyCardList_.AddEntriesFrom(ref input, _repeated_historyCardList_codec);
            break;
          }
          case 15898: {
            unk3300CDCMBOKBLAK_.AddEntriesFrom(ref input, _repeated_unk3300CDCMBOKBLAK_codec);
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
