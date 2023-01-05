// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Quest.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Quest.proto</summary>
  public static partial class QuestReflection {

    #region Descriptor
    /// <summary>File descriptor for Quest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtRdWVzdC5wcm90byLxAwoFUXVlc3QSEAoIcXVlc3RfaWQYASABKA0SDQoF",
            "c3RhdGUYAiABKA0SEgoKc3RhcnRfdGltZRgEIAEoDRIRCglpc19yYW5kb20Y",
            "BSABKAgSFwoPcGFyZW50X3F1ZXN0X2lkGAYgASgNEhcKD3F1ZXN0X2NvbmZp",
            "Z19pZBgHIAEoDRIXCg9zdGFydF9nYW1lX3RpbWUYCCABKA0SEwoLYWNjZXB0",
            "X3RpbWUYCSABKA0SFwoPbGFja2VkX25wY19saXN0GAogAygNEhwKFGZpbmlz",
            "aF9wcm9ncmVzc19saXN0GAsgAygNEhoKEmZhaWxfcHJvZ3Jlc3NfbGlzdBgM",
            "IAMoDRIwCg5sYWNrZWRfbnBjX21hcBgNIAMoCzIYLlF1ZXN0LkxhY2tlZE5w",
            "Y01hcEVudHJ5EhkKEWxhY2tlZF9wbGFjZV9saXN0GA4gAygNEjQKEGxhY2tl",
            "ZF9wbGFjZV9tYXAYDyADKAsyGi5RdWVzdC5MYWNrZWRQbGFjZU1hcEVudHJ5",
            "GjMKEUxhY2tlZE5wY01hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgC",
            "IAEoDToCOAEaNQoTTGFja2VkUGxhY2VNYXBFbnRyeRILCgNrZXkYASABKA0S",
            "DQoFdmFsdWUYAiABKA06AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Quest), global::Weedwacker.Shared.Network.Proto.Quest.Parser, new[]{ "QuestId", "State", "StartTime", "IsRandom", "ParentQuestId", "QuestConfigId", "StartGameTime", "AcceptTime", "LackedNpcList", "FinishProgressList", "FailProgressList", "LackedNpcMap", "LackedPlaceList", "LackedPlaceMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Quest : pb::IMessage<Quest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Quest> _parser = new pb::MessageParser<Quest>(() => new Quest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Quest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.QuestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quest(Quest other) : this() {
      questId_ = other.questId_;
      state_ = other.state_;
      startTime_ = other.startTime_;
      isRandom_ = other.isRandom_;
      parentQuestId_ = other.parentQuestId_;
      questConfigId_ = other.questConfigId_;
      startGameTime_ = other.startGameTime_;
      acceptTime_ = other.acceptTime_;
      lackedNpcList_ = other.lackedNpcList_.Clone();
      finishProgressList_ = other.finishProgressList_.Clone();
      failProgressList_ = other.failProgressList_.Clone();
      lackedNpcMap_ = other.lackedNpcMap_.Clone();
      lackedPlaceList_ = other.lackedPlaceList_.Clone();
      lackedPlaceMap_ = other.lackedPlaceMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quest Clone() {
      return new Quest(this);
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 1;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private uint state_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 4;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "is_random" field.</summary>
    public const int IsRandomFieldNumber = 5;
    private bool isRandom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRandom {
      get { return isRandom_; }
      set {
        isRandom_ = value;
      }
    }

    /// <summary>Field number for the "parent_quest_id" field.</summary>
    public const int ParentQuestIdFieldNumber = 6;
    private uint parentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestId {
      get { return parentQuestId_; }
      set {
        parentQuestId_ = value;
      }
    }

    /// <summary>Field number for the "quest_config_id" field.</summary>
    public const int QuestConfigIdFieldNumber = 7;
    private uint questConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestConfigId {
      get { return questConfigId_; }
      set {
        questConfigId_ = value;
      }
    }

    /// <summary>Field number for the "start_game_time" field.</summary>
    public const int StartGameTimeFieldNumber = 8;
    private uint startGameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartGameTime {
      get { return startGameTime_; }
      set {
        startGameTime_ = value;
      }
    }

    /// <summary>Field number for the "accept_time" field.</summary>
    public const int AcceptTimeFieldNumber = 9;
    private uint acceptTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AcceptTime {
      get { return acceptTime_; }
      set {
        acceptTime_ = value;
      }
    }

    /// <summary>Field number for the "lacked_npc_list" field.</summary>
    public const int LackedNpcListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_lackedNpcList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> lackedNpcList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LackedNpcList {
      get { return lackedNpcList_; }
    }

    /// <summary>Field number for the "finish_progress_list" field.</summary>
    public const int FinishProgressListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_finishProgressList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> finishProgressList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishProgressList {
      get { return finishProgressList_; }
    }

    /// <summary>Field number for the "fail_progress_list" field.</summary>
    public const int FailProgressListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_failProgressList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> failProgressList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FailProgressList {
      get { return failProgressList_; }
    }

    /// <summary>Field number for the "lacked_npc_map" field.</summary>
    public const int LackedNpcMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_lackedNpcMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> lackedNpcMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> LackedNpcMap {
      get { return lackedNpcMap_; }
    }

    /// <summary>Field number for the "lacked_place_list" field.</summary>
    public const int LackedPlaceListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_lackedPlaceList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> lackedPlaceList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LackedPlaceList {
      get { return lackedPlaceList_; }
    }

    /// <summary>Field number for the "lacked_place_map" field.</summary>
    public const int LackedPlaceMapFieldNumber = 15;
    private static readonly pbc::MapField<uint, uint>.Codec _map_lackedPlaceMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<uint, uint> lackedPlaceMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> LackedPlaceMap {
      get { return lackedPlaceMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Quest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Quest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestId != other.QuestId) return false;
      if (State != other.State) return false;
      if (StartTime != other.StartTime) return false;
      if (IsRandom != other.IsRandom) return false;
      if (ParentQuestId != other.ParentQuestId) return false;
      if (QuestConfigId != other.QuestConfigId) return false;
      if (StartGameTime != other.StartGameTime) return false;
      if (AcceptTime != other.AcceptTime) return false;
      if(!lackedNpcList_.Equals(other.lackedNpcList_)) return false;
      if(!finishProgressList_.Equals(other.finishProgressList_)) return false;
      if(!failProgressList_.Equals(other.failProgressList_)) return false;
      if (!LackedNpcMap.Equals(other.LackedNpcMap)) return false;
      if(!lackedPlaceList_.Equals(other.lackedPlaceList_)) return false;
      if (!LackedPlaceMap.Equals(other.LackedPlaceMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (IsRandom != false) hash ^= IsRandom.GetHashCode();
      if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
      if (QuestConfigId != 0) hash ^= QuestConfigId.GetHashCode();
      if (StartGameTime != 0) hash ^= StartGameTime.GetHashCode();
      if (AcceptTime != 0) hash ^= AcceptTime.GetHashCode();
      hash ^= lackedNpcList_.GetHashCode();
      hash ^= finishProgressList_.GetHashCode();
      hash ^= failProgressList_.GetHashCode();
      hash ^= LackedNpcMap.GetHashCode();
      hash ^= lackedPlaceList_.GetHashCode();
      hash ^= LackedPlaceMap.GetHashCode();
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
      if (QuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(QuestId);
      }
      if (State != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(State);
      }
      if (StartTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StartTime);
      }
      if (IsRandom != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsRandom);
      }
      if (ParentQuestId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestConfigId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(QuestConfigId);
      }
      if (StartGameTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StartGameTime);
      }
      if (AcceptTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AcceptTime);
      }
      lackedNpcList_.WriteTo(output, _repeated_lackedNpcList_codec);
      finishProgressList_.WriteTo(output, _repeated_finishProgressList_codec);
      failProgressList_.WriteTo(output, _repeated_failProgressList_codec);
      lackedNpcMap_.WriteTo(output, _map_lackedNpcMap_codec);
      lackedPlaceList_.WriteTo(output, _repeated_lackedPlaceList_codec);
      lackedPlaceMap_.WriteTo(output, _map_lackedPlaceMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (QuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(QuestId);
      }
      if (State != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(State);
      }
      if (StartTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StartTime);
      }
      if (IsRandom != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsRandom);
      }
      if (ParentQuestId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestConfigId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(QuestConfigId);
      }
      if (StartGameTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StartGameTime);
      }
      if (AcceptTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(AcceptTime);
      }
      lackedNpcList_.WriteTo(ref output, _repeated_lackedNpcList_codec);
      finishProgressList_.WriteTo(ref output, _repeated_finishProgressList_codec);
      failProgressList_.WriteTo(ref output, _repeated_failProgressList_codec);
      lackedNpcMap_.WriteTo(ref output, _map_lackedNpcMap_codec);
      lackedPlaceList_.WriteTo(ref output, _repeated_lackedPlaceList_codec);
      lackedPlaceMap_.WriteTo(ref output, _map_lackedPlaceMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (QuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(State);
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (IsRandom != false) {
        size += 1 + 1;
      }
      if (ParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
      }
      if (QuestConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestConfigId);
      }
      if (StartGameTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartGameTime);
      }
      if (AcceptTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AcceptTime);
      }
      size += lackedNpcList_.CalculateSize(_repeated_lackedNpcList_codec);
      size += finishProgressList_.CalculateSize(_repeated_finishProgressList_codec);
      size += failProgressList_.CalculateSize(_repeated_failProgressList_codec);
      size += lackedNpcMap_.CalculateSize(_map_lackedNpcMap_codec);
      size += lackedPlaceList_.CalculateSize(_repeated_lackedPlaceList_codec);
      size += lackedPlaceMap_.CalculateSize(_map_lackedPlaceMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Quest other) {
      if (other == null) {
        return;
      }
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.IsRandom != false) {
        IsRandom = other.IsRandom;
      }
      if (other.ParentQuestId != 0) {
        ParentQuestId = other.ParentQuestId;
      }
      if (other.QuestConfigId != 0) {
        QuestConfigId = other.QuestConfigId;
      }
      if (other.StartGameTime != 0) {
        StartGameTime = other.StartGameTime;
      }
      if (other.AcceptTime != 0) {
        AcceptTime = other.AcceptTime;
      }
      lackedNpcList_.Add(other.lackedNpcList_);
      finishProgressList_.Add(other.finishProgressList_);
      failProgressList_.Add(other.failProgressList_);
      lackedNpcMap_.Add(other.lackedNpcMap_);
      lackedPlaceList_.Add(other.lackedPlaceList_);
      lackedPlaceMap_.Add(other.lackedPlaceMap_);
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
            QuestId = input.ReadUInt32();
            break;
          }
          case 16: {
            State = input.ReadUInt32();
            break;
          }
          case 32: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 40: {
            IsRandom = input.ReadBool();
            break;
          }
          case 48: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 56: {
            QuestConfigId = input.ReadUInt32();
            break;
          }
          case 64: {
            StartGameTime = input.ReadUInt32();
            break;
          }
          case 72: {
            AcceptTime = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            lackedNpcList_.AddEntriesFrom(input, _repeated_lackedNpcList_codec);
            break;
          }
          case 90:
          case 88: {
            finishProgressList_.AddEntriesFrom(input, _repeated_finishProgressList_codec);
            break;
          }
          case 98:
          case 96: {
            failProgressList_.AddEntriesFrom(input, _repeated_failProgressList_codec);
            break;
          }
          case 106: {
            lackedNpcMap_.AddEntriesFrom(input, _map_lackedNpcMap_codec);
            break;
          }
          case 114:
          case 112: {
            lackedPlaceList_.AddEntriesFrom(input, _repeated_lackedPlaceList_codec);
            break;
          }
          case 122: {
            lackedPlaceMap_.AddEntriesFrom(input, _map_lackedPlaceMap_codec);
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
            QuestId = input.ReadUInt32();
            break;
          }
          case 16: {
            State = input.ReadUInt32();
            break;
          }
          case 32: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 40: {
            IsRandom = input.ReadBool();
            break;
          }
          case 48: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 56: {
            QuestConfigId = input.ReadUInt32();
            break;
          }
          case 64: {
            StartGameTime = input.ReadUInt32();
            break;
          }
          case 72: {
            AcceptTime = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            lackedNpcList_.AddEntriesFrom(ref input, _repeated_lackedNpcList_codec);
            break;
          }
          case 90:
          case 88: {
            finishProgressList_.AddEntriesFrom(ref input, _repeated_finishProgressList_codec);
            break;
          }
          case 98:
          case 96: {
            failProgressList_.AddEntriesFrom(ref input, _repeated_failProgressList_codec);
            break;
          }
          case 106: {
            lackedNpcMap_.AddEntriesFrom(ref input, _map_lackedNpcMap_codec);
            break;
          }
          case 114:
          case 112: {
            lackedPlaceList_.AddEntriesFrom(ref input, _repeated_lackedPlaceList_codec);
            break;
          }
          case 122: {
            lackedPlaceMap_.AddEntriesFrom(ref input, _map_lackedPlaceMap_codec);
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
