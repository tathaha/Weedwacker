// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerMatchSuccNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerMatchSuccNotify.proto</summary>
  public static partial class PlayerMatchSuccNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerMatchSuccNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerMatchSuccNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQbGF5ZXJNYXRjaFN1Y2NOb3RpZnkucHJvdG8aEkdDR01hdGNoSW5mby5w",
            "cm90bxoWR2VuZXJhbE1hdGNoSW5mby5wcm90bxoPTWF0Y2hUeXBlLnByb3Rv",
            "IoUCChVQbGF5ZXJNYXRjaFN1Y2NOb3RpZnkSLQoSZ2VuZXJhbF9tYXRjaF9p",
            "bmZvGAcgASgLMhEuR2VuZXJhbE1hdGNoSW5mbxISCgpkdW5nZW9uX2lkGAMg",
            "ASgNEh4KCm1hdGNoX3R5cGUYDyABKA4yCi5NYXRjaFR5cGUSIgoabWVjaGFu",
            "aWN1c19kaWZmaWN1bHRfbGV2ZWwYBSABKA0SGAoQY29uZmlybV9lbmRfdGlt",
            "ZRgNIAEoDRIlCg5nY2dfbWF0Y2hfaW5mbxgJIAEoCzINLkdDR01hdGNoSW5m",
            "bxISCgptcF9wbGF5X2lkGAsgASgNEhAKCGhvc3RfdWlkGAogASgNQiKqAh9X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGMatchInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GeneralMatchInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.MatchTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerMatchSuccNotify), global::Weedwacker.Shared.Network.Proto.PlayerMatchSuccNotify.Parser, new[]{ "GeneralMatchInfo", "DungeonId", "MatchType", "MechanicusDifficultLevel", "ConfirmEndTime", "GcgMatchInfo", "MpPlayId", "HostUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4194;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerMatchSuccNotify : pb::IMessage<PlayerMatchSuccNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerMatchSuccNotify> _parser = new pb::MessageParser<PlayerMatchSuccNotify>(() => new PlayerMatchSuccNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerMatchSuccNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerMatchSuccNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchSuccNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchSuccNotify(PlayerMatchSuccNotify other) : this() {
      generalMatchInfo_ = other.generalMatchInfo_ != null ? other.generalMatchInfo_.Clone() : null;
      dungeonId_ = other.dungeonId_;
      matchType_ = other.matchType_;
      mechanicusDifficultLevel_ = other.mechanicusDifficultLevel_;
      confirmEndTime_ = other.confirmEndTime_;
      gcgMatchInfo_ = other.gcgMatchInfo_ != null ? other.gcgMatchInfo_.Clone() : null;
      mpPlayId_ = other.mpPlayId_;
      hostUid_ = other.hostUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerMatchSuccNotify Clone() {
      return new PlayerMatchSuccNotify(this);
    }

    /// <summary>Field number for the "general_match_info" field.</summary>
    public const int GeneralMatchInfoFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.GeneralMatchInfo generalMatchInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GeneralMatchInfo GeneralMatchInfo {
      get { return generalMatchInfo_; }
      set {
        generalMatchInfo_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 3;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "match_type" field.</summary>
    public const int MatchTypeFieldNumber = 15;
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
    public const int MechanicusDifficultLevelFieldNumber = 5;
    private uint mechanicusDifficultLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusDifficultLevel {
      get { return mechanicusDifficultLevel_; }
      set {
        mechanicusDifficultLevel_ = value;
      }
    }

    /// <summary>Field number for the "confirm_end_time" field.</summary>
    public const int ConfirmEndTimeFieldNumber = 13;
    private uint confirmEndTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfirmEndTime {
      get { return confirmEndTime_; }
      set {
        confirmEndTime_ = value;
      }
    }

    /// <summary>Field number for the "gcg_match_info" field.</summary>
    public const int GcgMatchInfoFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.GCGMatchInfo gcgMatchInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGMatchInfo GcgMatchInfo {
      get { return gcgMatchInfo_; }
      set {
        gcgMatchInfo_ = value;
      }
    }

    /// <summary>Field number for the "mp_play_id" field.</summary>
    public const int MpPlayIdFieldNumber = 11;
    private uint mpPlayId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MpPlayId {
      get { return mpPlayId_; }
      set {
        mpPlayId_ = value;
      }
    }

    /// <summary>Field number for the "host_uid" field.</summary>
    public const int HostUidFieldNumber = 10;
    private uint hostUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HostUid {
      get { return hostUid_; }
      set {
        hostUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerMatchSuccNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerMatchSuccNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GeneralMatchInfo, other.GeneralMatchInfo)) return false;
      if (DungeonId != other.DungeonId) return false;
      if (MatchType != other.MatchType) return false;
      if (MechanicusDifficultLevel != other.MechanicusDifficultLevel) return false;
      if (ConfirmEndTime != other.ConfirmEndTime) return false;
      if (!object.Equals(GcgMatchInfo, other.GcgMatchInfo)) return false;
      if (MpPlayId != other.MpPlayId) return false;
      if (HostUid != other.HostUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (generalMatchInfo_ != null) hash ^= GeneralMatchInfo.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) hash ^= MatchType.GetHashCode();
      if (MechanicusDifficultLevel != 0) hash ^= MechanicusDifficultLevel.GetHashCode();
      if (ConfirmEndTime != 0) hash ^= ConfirmEndTime.GetHashCode();
      if (gcgMatchInfo_ != null) hash ^= GcgMatchInfo.GetHashCode();
      if (MpPlayId != 0) hash ^= MpPlayId.GetHashCode();
      if (HostUid != 0) hash ^= HostUid.GetHashCode();
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
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      if (MechanicusDifficultLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MechanicusDifficultLevel);
      }
      if (generalMatchInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(GeneralMatchInfo);
      }
      if (gcgMatchInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(GcgMatchInfo);
      }
      if (HostUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HostUid);
      }
      if (MpPlayId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MpPlayId);
      }
      if (ConfirmEndTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ConfirmEndTime);
      }
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) MatchType);
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
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      if (MechanicusDifficultLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MechanicusDifficultLevel);
      }
      if (generalMatchInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(GeneralMatchInfo);
      }
      if (gcgMatchInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(GcgMatchInfo);
      }
      if (HostUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HostUid);
      }
      if (MpPlayId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MpPlayId);
      }
      if (ConfirmEndTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ConfirmEndTime);
      }
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) MatchType);
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
      if (generalMatchInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GeneralMatchInfo);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (MechanicusDifficultLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusDifficultLevel);
      }
      if (ConfirmEndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfirmEndTime);
      }
      if (gcgMatchInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GcgMatchInfo);
      }
      if (MpPlayId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayId);
      }
      if (HostUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HostUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerMatchSuccNotify other) {
      if (other == null) {
        return;
      }
      if (other.generalMatchInfo_ != null) {
        if (generalMatchInfo_ == null) {
          GeneralMatchInfo = new global::Weedwacker.Shared.Network.Proto.GeneralMatchInfo();
        }
        GeneralMatchInfo.MergeFrom(other.GeneralMatchInfo);
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.MatchType != global::Weedwacker.Shared.Network.Proto.MatchType.None) {
        MatchType = other.MatchType;
      }
      if (other.MechanicusDifficultLevel != 0) {
        MechanicusDifficultLevel = other.MechanicusDifficultLevel;
      }
      if (other.ConfirmEndTime != 0) {
        ConfirmEndTime = other.ConfirmEndTime;
      }
      if (other.gcgMatchInfo_ != null) {
        if (gcgMatchInfo_ == null) {
          GcgMatchInfo = new global::Weedwacker.Shared.Network.Proto.GCGMatchInfo();
        }
        GcgMatchInfo.MergeFrom(other.GcgMatchInfo);
      }
      if (other.MpPlayId != 0) {
        MpPlayId = other.MpPlayId;
      }
      if (other.HostUid != 0) {
        HostUid = other.HostUid;
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
          case 24: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 40: {
            MechanicusDifficultLevel = input.ReadUInt32();
            break;
          }
          case 58: {
            if (generalMatchInfo_ == null) {
              GeneralMatchInfo = new global::Weedwacker.Shared.Network.Proto.GeneralMatchInfo();
            }
            input.ReadMessage(GeneralMatchInfo);
            break;
          }
          case 74: {
            if (gcgMatchInfo_ == null) {
              GcgMatchInfo = new global::Weedwacker.Shared.Network.Proto.GCGMatchInfo();
            }
            input.ReadMessage(GcgMatchInfo);
            break;
          }
          case 80: {
            HostUid = input.ReadUInt32();
            break;
          }
          case 88: {
            MpPlayId = input.ReadUInt32();
            break;
          }
          case 104: {
            ConfirmEndTime = input.ReadUInt32();
            break;
          }
          case 120: {
            MatchType = (global::Weedwacker.Shared.Network.Proto.MatchType) input.ReadEnum();
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
          case 24: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 40: {
            MechanicusDifficultLevel = input.ReadUInt32();
            break;
          }
          case 58: {
            if (generalMatchInfo_ == null) {
              GeneralMatchInfo = new global::Weedwacker.Shared.Network.Proto.GeneralMatchInfo();
            }
            input.ReadMessage(GeneralMatchInfo);
            break;
          }
          case 74: {
            if (gcgMatchInfo_ == null) {
              GcgMatchInfo = new global::Weedwacker.Shared.Network.Proto.GCGMatchInfo();
            }
            input.ReadMessage(GcgMatchInfo);
            break;
          }
          case 80: {
            HostUid = input.ReadUInt32();
            break;
          }
          case 88: {
            MpPlayId = input.ReadUInt32();
            break;
          }
          case 104: {
            ConfirmEndTime = input.ReadUInt32();
            break;
          }
          case 120: {
            MatchType = (global::Weedwacker.Shared.Network.Proto.MatchType) input.ReadEnum();
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
