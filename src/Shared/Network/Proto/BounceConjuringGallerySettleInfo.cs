// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BounceConjuringGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BounceConjuringGallerySettleInfo.proto</summary>
  public static partial class BounceConjuringGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BounceConjuringGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BounceConjuringGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZCb3VuY2VDb25qdXJpbmdHYWxsZXJ5U2V0dGxlSW5mby5wcm90bxobRXho",
            "aWJpdGlvbkRpc3BsYXlJbmZvLnByb3RvGhZPbmxpbmVQbGF5ZXJJbmZvLnBy",
            "b3RvIpADCiBCb3VuY2VDb25qdXJpbmdHYWxsZXJ5U2V0dGxlSW5mbxIbChNV",
            "bmszMzAwX1BFTEhCSkRNS0FFGAYgASgNEg0KBXNjb3JlGA8gASgNEk8KEGdh",
            "ZGdldF9jb3VudF9tYXAYAyADKAsyNS5Cb3VuY2VDb25qdXJpbmdHYWxsZXJ5",
            "U2V0dGxlSW5mby5HYWRnZXRDb3VudE1hcEVudHJ5EhsKE1VuazMzMDBfQ05H",
            "T0JPRkRFT0UYCyABKA0SGwoTVW5rMzMwMF9OS0dGS0xHREZBQxgBIAEoDRIm",
            "CgtwbGF5ZXJfaW5mbxgCIAEoCzIRLk9ubGluZVBsYXllckluZm8SDgoGZGFt",
            "YWdlGAwgASgCEhsKE1VuazMzMDBfQkpIQ0RLTkZERk4YByABKA0SKQoJY2Fy",
            "ZF9saXN0GAkgAygLMhYuRXhoaWJpdGlvbkRpc3BsYXlJbmZvGjUKE0dhZGdl",
            "dENvdW50TWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4",
            "AUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BounceConjuringGallerySettleInfo), global::Weedwacker.Shared.Network.Proto.BounceConjuringGallerySettleInfo.Parser, new[]{ "Unk3300PELHBJDMKAE", "Score", "GadgetCountMap", "Unk3300CNGOBOFDEOE", "Unk3300NKGFKLGDFAC", "PlayerInfo", "Damage", "Unk3300BJHCDKNFDFN", "CardList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BounceConjuringGallerySettleInfo : pb::IMessage<BounceConjuringGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BounceConjuringGallerySettleInfo> _parser = new pb::MessageParser<BounceConjuringGallerySettleInfo>(() => new BounceConjuringGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BounceConjuringGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BounceConjuringGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringGallerySettleInfo(BounceConjuringGallerySettleInfo other) : this() {
      unk3300PELHBJDMKAE_ = other.unk3300PELHBJDMKAE_;
      score_ = other.score_;
      gadgetCountMap_ = other.gadgetCountMap_.Clone();
      unk3300CNGOBOFDEOE_ = other.unk3300CNGOBOFDEOE_;
      unk3300NKGFKLGDFAC_ = other.unk3300NKGFKLGDFAC_;
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      damage_ = other.damage_;
      unk3300BJHCDKNFDFN_ = other.unk3300BJHCDKNFDFN_;
      cardList_ = other.cardList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BounceConjuringGallerySettleInfo Clone() {
      return new BounceConjuringGallerySettleInfo(this);
    }

    /// <summary>Field number for the "Unk3300_PELHBJDMKAE" field.</summary>
    public const int Unk3300PELHBJDMKAEFieldNumber = 6;
    private uint unk3300PELHBJDMKAE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PELHBJDMKAE {
      get { return unk3300PELHBJDMKAE_; }
      set {
        unk3300PELHBJDMKAE_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 15;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "gadget_count_map" field.</summary>
    public const int GadgetCountMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_gadgetCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> gadgetCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> GadgetCountMap {
      get { return gadgetCountMap_; }
    }

    /// <summary>Field number for the "Unk3300_CNGOBOFDEOE" field.</summary>
    public const int Unk3300CNGOBOFDEOEFieldNumber = 11;
    private uint unk3300CNGOBOFDEOE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300CNGOBOFDEOE {
      get { return unk3300CNGOBOFDEOE_; }
      set {
        unk3300CNGOBOFDEOE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NKGFKLGDFAC" field.</summary>
    public const int Unk3300NKGFKLGDFACFieldNumber = 1;
    private uint unk3300NKGFKLGDFAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NKGFKLGDFAC {
      get { return unk3300NKGFKLGDFAC_; }
      set {
        unk3300NKGFKLGDFAC_ = value;
      }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "damage" field.</summary>
    public const int DamageFieldNumber = 12;
    private float damage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Damage {
      get { return damage_; }
      set {
        damage_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BJHCDKNFDFN" field.</summary>
    public const int Unk3300BJHCDKNFDFNFieldNumber = 7;
    private uint unk3300BJHCDKNFDFN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300BJHCDKNFDFN {
      get { return unk3300BJHCDKNFDFN_; }
      set {
        unk3300BJHCDKNFDFN_ = value;
      }
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> cardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ExhibitionDisplayInfo> CardList {
      get { return cardList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BounceConjuringGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BounceConjuringGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300PELHBJDMKAE != other.Unk3300PELHBJDMKAE) return false;
      if (Score != other.Score) return false;
      if (!GadgetCountMap.Equals(other.GadgetCountMap)) return false;
      if (Unk3300CNGOBOFDEOE != other.Unk3300CNGOBOFDEOE) return false;
      if (Unk3300NKGFKLGDFAC != other.Unk3300NKGFKLGDFAC) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Damage, other.Damage)) return false;
      if (Unk3300BJHCDKNFDFN != other.Unk3300BJHCDKNFDFN) return false;
      if(!cardList_.Equals(other.cardList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300PELHBJDMKAE != 0) hash ^= Unk3300PELHBJDMKAE.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      hash ^= GadgetCountMap.GetHashCode();
      if (Unk3300CNGOBOFDEOE != 0) hash ^= Unk3300CNGOBOFDEOE.GetHashCode();
      if (Unk3300NKGFKLGDFAC != 0) hash ^= Unk3300NKGFKLGDFAC.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (Damage != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Damage);
      if (Unk3300BJHCDKNFDFN != 0) hash ^= Unk3300BJHCDKNFDFN.GetHashCode();
      hash ^= cardList_.GetHashCode();
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
      if (Unk3300NKGFKLGDFAC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300NKGFKLGDFAC);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerInfo);
      }
      gadgetCountMap_.WriteTo(output, _map_gadgetCountMap_codec);
      if (Unk3300PELHBJDMKAE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300PELHBJDMKAE);
      }
      if (Unk3300BJHCDKNFDFN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300BJHCDKNFDFN);
      }
      cardList_.WriteTo(output, _repeated_cardList_codec);
      if (Unk3300CNGOBOFDEOE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300CNGOBOFDEOE);
      }
      if (Damage != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Damage);
      }
      if (Score != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Score);
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
      if (Unk3300NKGFKLGDFAC != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300NKGFKLGDFAC);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PlayerInfo);
      }
      gadgetCountMap_.WriteTo(ref output, _map_gadgetCountMap_codec);
      if (Unk3300PELHBJDMKAE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300PELHBJDMKAE);
      }
      if (Unk3300BJHCDKNFDFN != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300BJHCDKNFDFN);
      }
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      if (Unk3300CNGOBOFDEOE != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300CNGOBOFDEOE);
      }
      if (Damage != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Damage);
      }
      if (Score != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Score);
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
      if (Unk3300PELHBJDMKAE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PELHBJDMKAE);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      size += gadgetCountMap_.CalculateSize(_map_gadgetCountMap_codec);
      if (Unk3300CNGOBOFDEOE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300CNGOBOFDEOE);
      }
      if (Unk3300NKGFKLGDFAC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NKGFKLGDFAC);
      }
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (Damage != 0F) {
        size += 1 + 4;
      }
      if (Unk3300BJHCDKNFDFN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BJHCDKNFDFN);
      }
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BounceConjuringGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300PELHBJDMKAE != 0) {
        Unk3300PELHBJDMKAE = other.Unk3300PELHBJDMKAE;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      gadgetCountMap_.Add(other.gadgetCountMap_);
      if (other.Unk3300CNGOBOFDEOE != 0) {
        Unk3300CNGOBOFDEOE = other.Unk3300CNGOBOFDEOE;
      }
      if (other.Unk3300NKGFKLGDFAC != 0) {
        Unk3300NKGFKLGDFAC = other.Unk3300NKGFKLGDFAC;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.Damage != 0F) {
        Damage = other.Damage;
      }
      if (other.Unk3300BJHCDKNFDFN != 0) {
        Unk3300BJHCDKNFDFN = other.Unk3300BJHCDKNFDFN;
      }
      cardList_.Add(other.cardList_);
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
          case 8: {
            Unk3300NKGFKLGDFAC = input.ReadUInt32();
            break;
          }
          case 18: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 26: {
            gadgetCountMap_.AddEntriesFrom(input, _map_gadgetCountMap_codec);
            break;
          }
          case 48: {
            Unk3300PELHBJDMKAE = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300BJHCDKNFDFN = input.ReadUInt32();
            break;
          }
          case 74: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 88: {
            Unk3300CNGOBOFDEOE = input.ReadUInt32();
            break;
          }
          case 101: {
            Damage = input.ReadFloat();
            break;
          }
          case 120: {
            Score = input.ReadUInt32();
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
          case 8: {
            Unk3300NKGFKLGDFAC = input.ReadUInt32();
            break;
          }
          case 18: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 26: {
            gadgetCountMap_.AddEntriesFrom(ref input, _map_gadgetCountMap_codec);
            break;
          }
          case 48: {
            Unk3300PELHBJDMKAE = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300BJHCDKNFDFN = input.ReadUInt32();
            break;
          }
          case 74: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 88: {
            Unk3300CNGOBOFDEOE = input.ReadUInt32();
            break;
          }
          case 101: {
            Damage = input.ReadFloat();
            break;
          }
          case 120: {
            Score = input.ReadUInt32();
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
