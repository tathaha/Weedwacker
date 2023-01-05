// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerMatchInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerMatchInfoNotify.proto</summary>
  public static partial class PlayerMatchInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerMatchInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerMatchInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbGF5ZXJNYXRjaEluZm9Ob3RpZnkucHJvdG8aD01hdGNoVHlwZS5wcm90",
            "byL9AQoVUGxheWVyTWF0Y2hJbmZvTm90aWZ5EhIKCmR1bmdlb25faWQYBCAB",
            "KA0SGAoQbWF0Y2hfYmVnaW5fdGltZRgFIAEoDRIgChhlc3RpbWF0ZV9tYXRj",
            "aF9jb3N0X3RpbWUYCiABKA0SEAoIaG9zdF91aWQYDCABKA0SHgoKbWF0Y2hf",
            "dHlwZRgNIAEoDjIKLk1hdGNoVHlwZRIiChptZWNoYW5pY3VzX2RpZmZpY3Vs",
            "dF9sZXZlbBgPIAEoDRISCgptcF9wbGF5X2lkGAIgASgNEhAKCG1hdGNoX2lk",
            "GAcgASgNEhgKEG1hdGNoX3BhcmFtX2xpc3QYCyADKA1CIqoCH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MatchTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerMatchInfoNotify), global::Weedwacker.Shared.Network.Proto.PlayerMatchInfoNotify.Parser, new[]{ "DungeonId", "MatchBeginTime", "EstimateMatchCostTime", "HostUid", "MatchType", "MechanicusDifficultLevel", "MpPlayId", "MatchId", "MatchParamList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4172;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerMatchInfoNotify : pb::IMessage<PlayerMatchInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerMatchInfoNotify> _parser = new pb::MessageParser<PlayerMatchInfoNotify>(() => new PlayerMatchInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerMatchInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerMatchInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchInfoNotify(PlayerMatchInfoNotify other) : this() {
      dungeonId_ = other.dungeonId_;
      matchBeginTime_ = other.matchBeginTime_;
      estimateMatchCostTime_ = other.estimateMatchCostTime_;
      hostUid_ = other.hostUid_;
      matchType_ = other.matchType_;
      mechanicusDifficultLevel_ = other.mechanicusDifficultLevel_;
      mpPlayId_ = other.mpPlayId_;
      matchId_ = other.matchId_;
      matchParamList_ = other.matchParamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchInfoNotify Clone() {
      return new PlayerMatchInfoNotify(this);
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 4;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "match_begin_time" field.</summary>
    public const int MatchBeginTimeFieldNumber = 5;
    private uint matchBeginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MatchBeginTime {
      get { return matchBeginTime_; }
      set {
        matchBeginTime_ = value;
      }
    }

    /// <summary>Field number for the "estimate_match_cost_time" field.</summary>
    public const int EstimateMatchCostTimeFieldNumber = 10;
    private uint estimateMatchCostTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EstimateMatchCostTime {
      get { return estimateMatchCostTime_; }
      set {
        estimateMatchCostTime_ = value;
      }
    }

    /// <summary>Field number for the "host_uid" field.</summary>
    public const int HostUidFieldNumber = 12;
    private uint hostUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HostUid {
      get { return hostUid_; }
      set {
        hostUid_ = value;
      }
    }

    /// <summary>Field number for the "match_type" field.</summary>
    public const int MatchTypeFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.MatchType matchType_ = global::Weedwacker.Shared.Network.Proto.MatchType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    /// <summary>Field number for the "mechanicus_difficult_level" field.</summary>
    public const int MechanicusDifficultLevelFieldNumber = 15;
    private uint mechanicusDifficultLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusDifficultLevel {
      get { return mechanicusDifficultLevel_; }
      set {
        mechanicusDifficultLevel_ = value;
      }
    }

    /// <summary>Field number for the "mp_play_id" field.</summary>
    public const int MpPlayIdFieldNumber = 2;
    private uint mpPlayId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MpPlayId {
      get { return mpPlayId_; }
      set {
        mpPlayId_ = value;
      }
    }

    /// <summary>Field number for the "match_id" field.</summary>
    public const int MatchIdFieldNumber = 7;
    private uint matchId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MatchId {
      get { return matchId_; }
      set {
        matchId_ = value;
      }
    }

    /// <summary>Field number for the "match_param_list" field.</summary>
    public const int MatchParamListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_matchParamList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> matchParamList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MatchParamList {
      get { return matchParamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerMatchInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerMatchInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DungeonId != other.DungeonId) return false;
      if (MatchBeginTime != other.MatchBeginTime) return false;
      if (EstimateMatchCostTime != other.EstimateMatchCostTime) return false;
      if (HostUid != other.HostUid) return false;
      if (MatchType != other.MatchType) return false;
      if (MechanicusDifficultLevel != other.MechanicusDifficultLevel) return false;
      if (MpPlayId != other.MpPlayId) return false;
      if (MatchId != other.MatchId) return false;
      if(!matchParamList_.Equals(other.matchParamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (MatchBeginTime != 0) hash ^= MatchBeginTime.GetHashCode();
      if (EstimateMatchCostTime != 0) hash ^= EstimateMatchCostTime.GetHashCode();
      if (HostUid != 0) hash ^= HostUid.GetHashCode();
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) hash ^= MatchType.GetHashCode();
      if (MechanicusDifficultLevel != 0) hash ^= MechanicusDifficultLevel.GetHashCode();
      if (MpPlayId != 0) hash ^= MpPlayId.GetHashCode();
      if (MatchId != 0) hash ^= MatchId.GetHashCode();
      hash ^= matchParamList_.GetHashCode();
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
      if (MpPlayId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MpPlayId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DungeonId);
      }
      if (MatchBeginTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MatchBeginTime);
      }
      if (MatchId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MatchId);
      }
      if (EstimateMatchCostTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EstimateMatchCostTime);
      }
      matchParamList_.WriteTo(output, _repeated_matchParamList_codec);
      if (HostUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HostUid);
      }
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) MatchType);
      }
      if (MechanicusDifficultLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MechanicusDifficultLevel);
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
      if (MpPlayId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MpPlayId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DungeonId);
      }
      if (MatchBeginTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MatchBeginTime);
      }
      if (MatchId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MatchId);
      }
      if (EstimateMatchCostTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EstimateMatchCostTime);
      }
      matchParamList_.WriteTo(ref output, _repeated_matchParamList_codec);
      if (HostUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HostUid);
      }
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) MatchType);
      }
      if (MechanicusDifficultLevel != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MechanicusDifficultLevel);
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
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (MatchBeginTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MatchBeginTime);
      }
      if (EstimateMatchCostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EstimateMatchCostTime);
      }
      if (HostUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HostUid);
      }
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (MechanicusDifficultLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusDifficultLevel);
      }
      if (MpPlayId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayId);
      }
      if (MatchId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MatchId);
      }
      size += matchParamList_.CalculateSize(_repeated_matchParamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerMatchInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.MatchBeginTime != 0) {
        MatchBeginTime = other.MatchBeginTime;
      }
      if (other.EstimateMatchCostTime != 0) {
        EstimateMatchCostTime = other.EstimateMatchCostTime;
      }
      if (other.HostUid != 0) {
        HostUid = other.HostUid;
      }
      if (other.MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        MatchType = other.MatchType;
      }
      if (other.MechanicusDifficultLevel != 0) {
        MechanicusDifficultLevel = other.MechanicusDifficultLevel;
      }
      if (other.MpPlayId != 0) {
        MpPlayId = other.MpPlayId;
      }
      if (other.MatchId != 0) {
        MatchId = other.MatchId;
      }
      matchParamList_.Add(other.matchParamList_);
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
            MpPlayId = input.ReadUInt32();
            break;
          }
          case 32: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 40: {
            MatchBeginTime = input.ReadUInt32();
            break;
          }
          case 56: {
            MatchId = input.ReadUInt32();
            break;
          }
          case 80: {
            EstimateMatchCostTime = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            matchParamList_.AddEntriesFrom(input, _repeated_matchParamList_codec);
            break;
          }
          case 96: {
            HostUid = input.ReadUInt32();
            break;
          }
          case 104: {
            MatchType = (global::Weedwacker.Shared.Network.Proto.MatchType) input.ReadEnum();
            break;
          }
          case 120: {
            MechanicusDifficultLevel = input.ReadUInt32();
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
            MpPlayId = input.ReadUInt32();
            break;
          }
          case 32: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 40: {
            MatchBeginTime = input.ReadUInt32();
            break;
          }
          case 56: {
            MatchId = input.ReadUInt32();
            break;
          }
          case 80: {
            EstimateMatchCostTime = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            matchParamList_.AddEntriesFrom(ref input, _repeated_matchParamList_codec);
            break;
          }
          case 96: {
            HostUid = input.ReadUInt32();
            break;
          }
          case 104: {
            MatchType = (global::Weedwacker.Shared.Network.Proto.MatchType) input.ReadEnum();
            break;
          }
          case 120: {
            MechanicusDifficultLevel = input.ReadUInt32();
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
