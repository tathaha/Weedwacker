// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryDungeonInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RogueDiaryDungeonInfoNotify.proto</summary>
  public static partial class RogueDiaryDungeonInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryDungeonInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryDungeonInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFSb2d1ZURpYXJ5RHVuZ2VvbkluZm9Ob3RpZnkucHJvdG8aGFJvZ3VlRGlh",
            "cnlSb29tSW5mby5wcm90byL6AQobUm9ndWVEaWFyeUR1bmdlb25JbmZvTm90",
            "aWZ5EhAKCHN0YWdlX2lkGAwgASgNEgwKBHRpbWUYCSABKA0SGwoTVW5rMzMw",
            "MF9NTUJFSkdERkNHRRgGIAMoDRIQCghjdXJfcm9vbRgBIAEoDRIbChNVbmsz",
            "MzAwX0RLQ0ZHTEFLUEpMGAggAygNEhIKCmR1bmdlb25faWQYByABKA0SJgoJ",
            "cm9vbV9saXN0GAUgAygLMhMuUm9ndWVEaWFyeVJvb21JbmZvEhIKCmRpZmZp",
            "Y3VsdHkYDiABKA0SEQoJY3VyX3JvdW5kGAogASgNEgwKBGNvaW4YAyABKA1C",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RogueDiaryDungeonInfoNotify), global::Weedwacker.Shared.Network.Proto.RogueDiaryDungeonInfoNotify.Parser, new[]{ "StageId", "Time", "Unk3300MMBEJGDFCGE", "CurRoom", "Unk3300DKCFGLAKPJL", "DungeonId", "RoomList", "Difficulty", "CurRound", "Coin" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8096;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class RogueDiaryDungeonInfoNotify : pb::IMessage<RogueDiaryDungeonInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryDungeonInfoNotify> _parser = new pb::MessageParser<RogueDiaryDungeonInfoNotify>(() => new RogueDiaryDungeonInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryDungeonInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RogueDiaryDungeonInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryDungeonInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryDungeonInfoNotify(RogueDiaryDungeonInfoNotify other) : this() {
      stageId_ = other.stageId_;
      time_ = other.time_;
      unk3300MMBEJGDFCGE_ = other.unk3300MMBEJGDFCGE_.Clone();
      curRoom_ = other.curRoom_;
      unk3300DKCFGLAKPJL_ = other.unk3300DKCFGLAKPJL_.Clone();
      dungeonId_ = other.dungeonId_;
      roomList_ = other.roomList_.Clone();
      difficulty_ = other.difficulty_;
      curRound_ = other.curRound_;
      coin_ = other.coin_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryDungeonInfoNotify Clone() {
      return new RogueDiaryDungeonInfoNotify(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 12;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 9;
    private uint time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MMBEJGDFCGE" field.</summary>
    public const int Unk3300MMBEJGDFCGEFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300MMBEJGDFCGE_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> unk3300MMBEJGDFCGE_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300MMBEJGDFCGE {
      get { return unk3300MMBEJGDFCGE_; }
    }

    /// <summary>Field number for the "cur_room" field.</summary>
    public const int CurRoomFieldNumber = 1;
    private uint curRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurRoom {
      get { return curRoom_; }
      set {
        curRoom_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DKCFGLAKPJL" field.</summary>
    public const int Unk3300DKCFGLAKPJLFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300DKCFGLAKPJL_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> unk3300DKCFGLAKPJL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300DKCFGLAKPJL {
      get { return unk3300DKCFGLAKPJL_; }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 7;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "room_list" field.</summary>
    public const int RoomListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo> _repeated_roomList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo> roomList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryRoomInfo> RoomList {
      get { return roomList_; }
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 14;
    private uint difficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    /// <summary>Field number for the "cur_round" field.</summary>
    public const int CurRoundFieldNumber = 10;
    private uint curRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurRound {
      get { return curRound_; }
      set {
        curRound_ = value;
      }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 3;
    private uint coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryDungeonInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryDungeonInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if (Time != other.Time) return false;
      if(!unk3300MMBEJGDFCGE_.Equals(other.unk3300MMBEJGDFCGE_)) return false;
      if (CurRoom != other.CurRoom) return false;
      if(!unk3300DKCFGLAKPJL_.Equals(other.unk3300DKCFGLAKPJL_)) return false;
      if (DungeonId != other.DungeonId) return false;
      if(!roomList_.Equals(other.roomList_)) return false;
      if (Difficulty != other.Difficulty) return false;
      if (CurRound != other.CurRound) return false;
      if (Coin != other.Coin) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (Time != 0) hash ^= Time.GetHashCode();
      hash ^= unk3300MMBEJGDFCGE_.GetHashCode();
      if (CurRoom != 0) hash ^= CurRoom.GetHashCode();
      hash ^= unk3300DKCFGLAKPJL_.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      hash ^= roomList_.GetHashCode();
      if (Difficulty != 0) hash ^= Difficulty.GetHashCode();
      if (CurRound != 0) hash ^= CurRound.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
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
      if (CurRoom != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurRoom);
      }
      if (Coin != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Coin);
      }
      roomList_.WriteTo(output, _repeated_roomList_codec);
      unk3300MMBEJGDFCGE_.WriteTo(output, _repeated_unk3300MMBEJGDFCGE_codec);
      if (DungeonId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DungeonId);
      }
      unk3300DKCFGLAKPJL_.WriteTo(output, _repeated_unk3300DKCFGLAKPJL_codec);
      if (Time != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Time);
      }
      if (CurRound != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurRound);
      }
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Difficulty);
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
      if (CurRoom != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CurRoom);
      }
      if (Coin != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Coin);
      }
      roomList_.WriteTo(ref output, _repeated_roomList_codec);
      unk3300MMBEJGDFCGE_.WriteTo(ref output, _repeated_unk3300MMBEJGDFCGE_codec);
      if (DungeonId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DungeonId);
      }
      unk3300DKCFGLAKPJL_.WriteTo(ref output, _repeated_unk3300DKCFGLAKPJL_codec);
      if (Time != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Time);
      }
      if (CurRound != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurRound);
      }
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Difficulty);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (Time != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Time);
      }
      size += unk3300MMBEJGDFCGE_.CalculateSize(_repeated_unk3300MMBEJGDFCGE_codec);
      if (CurRoom != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurRoom);
      }
      size += unk3300DKCFGLAKPJL_.CalculateSize(_repeated_unk3300DKCFGLAKPJL_codec);
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      size += roomList_.CalculateSize(_repeated_roomList_codec);
      if (Difficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficulty);
      }
      if (CurRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurRound);
      }
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryDungeonInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.Time != 0) {
        Time = other.Time;
      }
      unk3300MMBEJGDFCGE_.Add(other.unk3300MMBEJGDFCGE_);
      if (other.CurRoom != 0) {
        CurRoom = other.CurRoom;
      }
      unk3300DKCFGLAKPJL_.Add(other.unk3300DKCFGLAKPJL_);
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      roomList_.Add(other.roomList_);
      if (other.Difficulty != 0) {
        Difficulty = other.Difficulty;
      }
      if (other.CurRound != 0) {
        CurRound = other.CurRound;
      }
      if (other.Coin != 0) {
        Coin = other.Coin;
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
          case 8: {
            CurRoom = input.ReadUInt32();
            break;
          }
          case 24: {
            Coin = input.ReadUInt32();
            break;
          }
          case 42: {
            roomList_.AddEntriesFrom(input, _repeated_roomList_codec);
            break;
          }
          case 50:
          case 48: {
            unk3300MMBEJGDFCGE_.AddEntriesFrom(input, _repeated_unk3300MMBEJGDFCGE_codec);
            break;
          }
          case 56: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            unk3300DKCFGLAKPJL_.AddEntriesFrom(input, _repeated_unk3300DKCFGLAKPJL_codec);
            break;
          }
          case 72: {
            Time = input.ReadUInt32();
            break;
          }
          case 80: {
            CurRound = input.ReadUInt32();
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            Difficulty = input.ReadUInt32();
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
            CurRoom = input.ReadUInt32();
            break;
          }
          case 24: {
            Coin = input.ReadUInt32();
            break;
          }
          case 42: {
            roomList_.AddEntriesFrom(ref input, _repeated_roomList_codec);
            break;
          }
          case 50:
          case 48: {
            unk3300MMBEJGDFCGE_.AddEntriesFrom(ref input, _repeated_unk3300MMBEJGDFCGE_codec);
            break;
          }
          case 56: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 66:
          case 64: {
            unk3300DKCFGLAKPJL_.AddEntriesFrom(ref input, _repeated_unk3300DKCFGLAKPJL_codec);
            break;
          }
          case 72: {
            Time = input.ReadUInt32();
            break;
          }
          case 80: {
            CurRound = input.ReadUInt32();
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            Difficulty = input.ReadUInt32();
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
