// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewInfo.proto</summary>
  public static partial class GCGSkillPreviewInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlHQ0dTa2lsbFByZXZpZXdJbmZvLnByb3RvGh1HQ0dTa2lsbFByZXZpZXdD",
            "YXJkSW5mby5wcm90bxooR0NHU2tpbGxQcmV2aWV3RWxlbWVudFJlYWN0aW9u",
            "SW5mby5wcm90bxobR0NHU2tpbGxQcmV2aWV3SHBJbmZvLnByb3RvGiZHQ0dT",
            "a2lsbFByZXZpZXdPbnN0YWdlQ2hhbmdlSW5mby5wcm90bxokR0NHU2tpbGxQ",
            "cmV2aWV3VG9rZW5DaGFuZ2VJbmZvLnByb3RvIqIFChNHQ0dTa2lsbFByZXZp",
            "ZXdJbmZvEi4KDHJtX2NhcmRfbGlzdBgMIAMoCzIYLkdDR1NraWxsUHJldmll",
            "d0NhcmRJbmZvEjgKC2hwX2luZm9fbWFwGAggAygLMiMuR0NHU2tpbGxQcmV2",
            "aWV3SW5mby5IcEluZm9NYXBFbnRyeRJEChFyZWFjdGlvbl9pbmZvX21hcBgF",
            "IAMoCzIpLkdDR1NraWxsUHJldmlld0luZm8uUmVhY3Rpb25JbmZvTWFwRW50",
            "cnkSSAodY2hhbmdlX29uc3RhZ2VfY2hhcmFjdGVyX2xpc3QYCSADKAsyIS5H",
            "Q0dTa2lsbFByZXZpZXdPbnN0YWdlQ2hhbmdlSW5mbxIQCghza2lsbF9pZBgG",
            "IAEoDRJLChVjYXJkX3Rva2VuX2NoYW5nZV9tYXAYAyADKAsyLC5HQ0dTa2ls",
            "bFByZXZpZXdJbmZvLkNhcmRUb2tlbkNoYW5nZU1hcEVudHJ5Ei8KDWFkZF9j",
            "YXJkX2xpc3QYCyADKAsyGC5HQ0dTa2lsbFByZXZpZXdDYXJkSW5mbxpICg5I",
            "cEluZm9NYXBFbnRyeRILCgNrZXkYASABKA0SJQoFdmFsdWUYAiABKAsyFi5H",
            "Q0dTa2lsbFByZXZpZXdIcEluZm86AjgBGlsKFFJlYWN0aW9uSW5mb01hcEVu",
            "dHJ5EgsKA2tleRgBIAEoDRIyCgV2YWx1ZRgCIAEoCzIjLkdDR1NraWxsUHJl",
            "dmlld0VsZW1lbnRSZWFjdGlvbkluZm86AjgBGloKF0NhcmRUb2tlbkNoYW5n",
            "ZU1hcEVudHJ5EgsKA2tleRgBIAEoDRIuCgV2YWx1ZRgCIAEoCzIfLkdDR1Nr",
            "aWxsUHJldmlld1Rva2VuQ2hhbmdlSW5mbzoCOAFCIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewElementReactionInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewHpInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenChangeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo), global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo.Parser, new[]{ "RmCardList", "HpInfoMap", "ReactionInfoMap", "ChangeOnstageCharacterList", "SkillId", "CardTokenChangeMap", "AddCardList" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGSkillPreviewInfo : pb::IMessage<GCGSkillPreviewInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewInfo> _parser = new pb::MessageParser<GCGSkillPreviewInfo>(() => new GCGSkillPreviewInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewInfo(GCGSkillPreviewInfo other) : this() {
      rmCardList_ = other.rmCardList_.Clone();
      hpInfoMap_ = other.hpInfoMap_.Clone();
      reactionInfoMap_ = other.reactionInfoMap_.Clone();
      changeOnstageCharacterList_ = other.changeOnstageCharacterList_.Clone();
      skillId_ = other.skillId_;
      cardTokenChangeMap_ = other.cardTokenChangeMap_.Clone();
      addCardList_ = other.addCardList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewInfo Clone() {
      return new GCGSkillPreviewInfo(this);
    }

    /// <summary>Field number for the "rm_card_list" field.</summary>
    public const int RmCardListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo> _repeated_rmCardList_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo> rmCardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo> RmCardList {
      get { return rmCardList_; }
    }

    /// <summary>Field number for the "hp_info_map" field.</summary>
    public const int HpInfoMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewHpInfo>.Codec _map_hpInfoMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewHpInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewHpInfo.Parser), 66);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewHpInfo> hpInfoMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewHpInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewHpInfo> HpInfoMap {
      get { return hpInfoMap_; }
    }

    /// <summary>Field number for the "reaction_info_map" field.</summary>
    public const int ReactionInfoMapFieldNumber = 5;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewElementReactionInfo>.Codec _map_reactionInfoMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewElementReactionInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewElementReactionInfo.Parser), 42);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewElementReactionInfo> reactionInfoMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewElementReactionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewElementReactionInfo> ReactionInfoMap {
      get { return reactionInfoMap_; }
    }

    /// <summary>Field number for the "change_onstage_character_list" field.</summary>
    public const int ChangeOnstageCharacterListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfo> _repeated_changeOnstageCharacterList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfo> changeOnstageCharacterList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewOnstageChangeInfo> ChangeOnstageCharacterList {
      get { return changeOnstageCharacterList_; }
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 6;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    /// <summary>Field number for the "card_token_change_map" field.</summary>
    public const int CardTokenChangeMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenChangeInfo>.Codec _map_cardTokenChangeMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenChangeInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenChangeInfo.Parser), 26);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenChangeInfo> cardTokenChangeMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenChangeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenChangeInfo> CardTokenChangeMap {
      get { return cardTokenChangeMap_; }
    }

    /// <summary>Field number for the "add_card_list" field.</summary>
    public const int AddCardListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo> _repeated_addCardList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo> addCardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo> AddCardList {
      get { return addCardList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rmCardList_.Equals(other.rmCardList_)) return false;
      if (!HpInfoMap.Equals(other.HpInfoMap)) return false;
      if (!ReactionInfoMap.Equals(other.ReactionInfoMap)) return false;
      if(!changeOnstageCharacterList_.Equals(other.changeOnstageCharacterList_)) return false;
      if (SkillId != other.SkillId) return false;
      if (!CardTokenChangeMap.Equals(other.CardTokenChangeMap)) return false;
      if(!addCardList_.Equals(other.addCardList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rmCardList_.GetHashCode();
      hash ^= HpInfoMap.GetHashCode();
      hash ^= ReactionInfoMap.GetHashCode();
      hash ^= changeOnstageCharacterList_.GetHashCode();
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      hash ^= CardTokenChangeMap.GetHashCode();
      hash ^= addCardList_.GetHashCode();
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
      cardTokenChangeMap_.WriteTo(output, _map_cardTokenChangeMap_codec);
      reactionInfoMap_.WriteTo(output, _map_reactionInfoMap_codec);
      if (SkillId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SkillId);
      }
      hpInfoMap_.WriteTo(output, _map_hpInfoMap_codec);
      changeOnstageCharacterList_.WriteTo(output, _repeated_changeOnstageCharacterList_codec);
      addCardList_.WriteTo(output, _repeated_addCardList_codec);
      rmCardList_.WriteTo(output, _repeated_rmCardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      cardTokenChangeMap_.WriteTo(ref output, _map_cardTokenChangeMap_codec);
      reactionInfoMap_.WriteTo(ref output, _map_reactionInfoMap_codec);
      if (SkillId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SkillId);
      }
      hpInfoMap_.WriteTo(ref output, _map_hpInfoMap_codec);
      changeOnstageCharacterList_.WriteTo(ref output, _repeated_changeOnstageCharacterList_codec);
      addCardList_.WriteTo(ref output, _repeated_addCardList_codec);
      rmCardList_.WriteTo(ref output, _repeated_rmCardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += rmCardList_.CalculateSize(_repeated_rmCardList_codec);
      size += hpInfoMap_.CalculateSize(_map_hpInfoMap_codec);
      size += reactionInfoMap_.CalculateSize(_map_reactionInfoMap_codec);
      size += changeOnstageCharacterList_.CalculateSize(_repeated_changeOnstageCharacterList_codec);
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      size += cardTokenChangeMap_.CalculateSize(_map_cardTokenChangeMap_codec);
      size += addCardList_.CalculateSize(_repeated_addCardList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewInfo other) {
      if (other == null) {
        return;
      }
      rmCardList_.Add(other.rmCardList_);
      hpInfoMap_.Add(other.hpInfoMap_);
      reactionInfoMap_.Add(other.reactionInfoMap_);
      changeOnstageCharacterList_.Add(other.changeOnstageCharacterList_);
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      cardTokenChangeMap_.Add(other.cardTokenChangeMap_);
      addCardList_.Add(other.addCardList_);
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
            cardTokenChangeMap_.AddEntriesFrom(input, _map_cardTokenChangeMap_codec);
            break;
          }
          case 42: {
            reactionInfoMap_.AddEntriesFrom(input, _map_reactionInfoMap_codec);
            break;
          }
          case 48: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 66: {
            hpInfoMap_.AddEntriesFrom(input, _map_hpInfoMap_codec);
            break;
          }
          case 74: {
            changeOnstageCharacterList_.AddEntriesFrom(input, _repeated_changeOnstageCharacterList_codec);
            break;
          }
          case 90: {
            addCardList_.AddEntriesFrom(input, _repeated_addCardList_codec);
            break;
          }
          case 98: {
            rmCardList_.AddEntriesFrom(input, _repeated_rmCardList_codec);
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
            cardTokenChangeMap_.AddEntriesFrom(ref input, _map_cardTokenChangeMap_codec);
            break;
          }
          case 42: {
            reactionInfoMap_.AddEntriesFrom(ref input, _map_reactionInfoMap_codec);
            break;
          }
          case 48: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 66: {
            hpInfoMap_.AddEntriesFrom(ref input, _map_hpInfoMap_codec);
            break;
          }
          case 74: {
            changeOnstageCharacterList_.AddEntriesFrom(ref input, _repeated_changeOnstageCharacterList_codec);
            break;
          }
          case 90: {
            addCardList_.AddEntriesFrom(ref input, _repeated_addCardList_codec);
            break;
          }
          case 98: {
            rmCardList_.AddEntriesFrom(ref input, _repeated_rmCardList_codec);
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