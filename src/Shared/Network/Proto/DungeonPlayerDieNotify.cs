// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonPlayerDieNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DungeonPlayerDieNotify.proto</summary>
  public static partial class DungeonPlayerDieNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonPlayerDieNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonPlayerDieNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxEdW5nZW9uUGxheWVyRGllTm90aWZ5LnByb3RvGhNQbGF5ZXJEaWVUeXBl",
            "LnByb3RvGhlTdHJlbmd0aGVuUG9pbnREYXRhLnByb3RvIvUCChZEdW5nZW9u",
            "UGxheWVyRGllTm90aWZ5ElYKGXN0cmVuZ3RoZW5fcG9pbnRfZGF0YV9tYXAY",
            "ByADKAsyMy5EdW5nZW9uUGxheWVyRGllTm90aWZ5LlN0cmVuZ3RoZW5Qb2lu",
            "dERhdGFNYXBFbnRyeRIgCghkaWVfdHlwZRgIIAEoDjIOLlBsYXllckRpZVR5",
            "cGUSFAoMcmV2aXZlX2NvdW50GAMgASgNEhEKCXdhaXRfdGltZRgEIAEoDRIS",
            "CgpkdW5nZW9uX2lkGAYgASgNEhoKEm11cmRlcmVyX2VudGl0eV9pZBgLIAEo",
            "DRIUCgptb25zdGVyX2lkGAogASgNSAASEwoJZ2FkZ2V0X2lkGA4gASgNSAAa",
            "UwobU3RyZW5ndGhlblBvaW50RGF0YU1hcEVudHJ5EgsKA2tleRgBIAEoDRIj",
            "CgV2YWx1ZRgCIAEoCzIULlN0cmVuZ3RoZW5Qb2ludERhdGE6AjgBQggKBmVu",
            "dGl0eUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.PlayerDieTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.StrengthenPointDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DungeonPlayerDieNotify), global::Weedwacker.Shared.Network.Proto.DungeonPlayerDieNotify.Parser, new[]{ "StrengthenPointDataMap", "DieType", "ReviveCount", "WaitTime", "DungeonId", "MurdererEntityId", "MonsterId", "GadgetId" }, new[]{ "Entity" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 927;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class DungeonPlayerDieNotify : pb::IMessage<DungeonPlayerDieNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonPlayerDieNotify> _parser = new pb::MessageParser<DungeonPlayerDieNotify>(() => new DungeonPlayerDieNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonPlayerDieNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DungeonPlayerDieNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonPlayerDieNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonPlayerDieNotify(DungeonPlayerDieNotify other) : this() {
      strengthenPointDataMap_ = other.strengthenPointDataMap_.Clone();
      dieType_ = other.dieType_;
      reviveCount_ = other.reviveCount_;
      waitTime_ = other.waitTime_;
      dungeonId_ = other.dungeonId_;
      murdererEntityId_ = other.murdererEntityId_;
      switch (other.EntityCase) {
        case EntityOneofCase.MonsterId:
          MonsterId = other.MonsterId;
          break;
        case EntityOneofCase.GadgetId:
          GadgetId = other.GadgetId;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonPlayerDieNotify Clone() {
      return new DungeonPlayerDieNotify(this);
    }

    /// <summary>Field number for the "strengthen_point_data_map" field.</summary>
    public const int StrengthenPointDataMapFieldNumber = 7;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.StrengthenPointData>.Codec _map_strengthenPointDataMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.StrengthenPointData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.StrengthenPointData.Parser), 58);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.StrengthenPointData> strengthenPointDataMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.StrengthenPointData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.StrengthenPointData> StrengthenPointDataMap {
      get { return strengthenPointDataMap_; }
    }

    /// <summary>Field number for the "die_type" field.</summary>
    public const int DieTypeFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.PlayerDieType dieType_ = global::Weedwacker.Shared.Network.Proto.PlayerDieType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PlayerDieType DieType {
      get { return dieType_; }
      set {
        dieType_ = value;
      }
    }

    /// <summary>Field number for the "revive_count" field.</summary>
    public const int ReviveCountFieldNumber = 3;
    private uint reviveCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReviveCount {
      get { return reviveCount_; }
      set {
        reviveCount_ = value;
      }
    }

    /// <summary>Field number for the "wait_time" field.</summary>
    public const int WaitTimeFieldNumber = 4;
    private uint waitTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaitTime {
      get { return waitTime_; }
      set {
        waitTime_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 6;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "murderer_entity_id" field.</summary>
    public const int MurdererEntityIdFieldNumber = 11;
    private uint murdererEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MurdererEntityId {
      get { return murdererEntityId_; }
      set {
        murdererEntityId_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return entityCase_ == EntityOneofCase.MonsterId ? (uint) entity_ : 0; }
      set {
        entity_ = value;
        entityCase_ = EntityOneofCase.MonsterId;
      }
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return entityCase_ == EntityOneofCase.GadgetId ? (uint) entity_ : 0; }
      set {
        entity_ = value;
        entityCase_ = EntityOneofCase.GadgetId;
      }
    }

    private object entity_;
    /// <summary>Enum of possible cases for the "entity" oneof.</summary>
    public enum EntityOneofCase {
      None = 0,
      MonsterId = 10,
      GadgetId = 14,
    }
    private EntityOneofCase entityCase_ = EntityOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityOneofCase EntityCase {
      get { return entityCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEntity() {
      entityCase_ = EntityOneofCase.None;
      entity_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonPlayerDieNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonPlayerDieNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!StrengthenPointDataMap.Equals(other.StrengthenPointDataMap)) return false;
      if (DieType != other.DieType) return false;
      if (ReviveCount != other.ReviveCount) return false;
      if (WaitTime != other.WaitTime) return false;
      if (DungeonId != other.DungeonId) return false;
      if (MurdererEntityId != other.MurdererEntityId) return false;
      if (MonsterId != other.MonsterId) return false;
      if (GadgetId != other.GadgetId) return false;
      if (EntityCase != other.EntityCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= StrengthenPointDataMap.GetHashCode();
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) hash ^= DieType.GetHashCode();
      if (ReviveCount != 0) hash ^= ReviveCount.GetHashCode();
      if (WaitTime != 0) hash ^= WaitTime.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (MurdererEntityId != 0) hash ^= MurdererEntityId.GetHashCode();
      if (entityCase_ == EntityOneofCase.MonsterId) hash ^= MonsterId.GetHashCode();
      if (entityCase_ == EntityOneofCase.GadgetId) hash ^= GadgetId.GetHashCode();
      hash ^= (int) entityCase_;
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
      if (ReviveCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ReviveCount);
      }
      if (WaitTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WaitTime);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      strengthenPointDataMap_.WriteTo(output, _map_strengthenPointDataMap_codec);
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) DieType);
      }
      if (entityCase_ == EntityOneofCase.MonsterId) {
        output.WriteRawTag(80);
        output.WriteUInt32(MonsterId);
      }
      if (MurdererEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MurdererEntityId);
      }
      if (entityCase_ == EntityOneofCase.GadgetId) {
        output.WriteRawTag(112);
        output.WriteUInt32(GadgetId);
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
      if (ReviveCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ReviveCount);
      }
      if (WaitTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WaitTime);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      strengthenPointDataMap_.WriteTo(ref output, _map_strengthenPointDataMap_codec);
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) DieType);
      }
      if (entityCase_ == EntityOneofCase.MonsterId) {
        output.WriteRawTag(80);
        output.WriteUInt32(MonsterId);
      }
      if (MurdererEntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MurdererEntityId);
      }
      if (entityCase_ == EntityOneofCase.GadgetId) {
        output.WriteRawTag(112);
        output.WriteUInt32(GadgetId);
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
      size += strengthenPointDataMap_.CalculateSize(_map_strengthenPointDataMap_codec);
      if (DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DieType);
      }
      if (ReviveCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReviveCount);
      }
      if (WaitTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaitTime);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (MurdererEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MurdererEntityId);
      }
      if (entityCase_ == EntityOneofCase.MonsterId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (entityCase_ == EntityOneofCase.GadgetId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonPlayerDieNotify other) {
      if (other == null) {
        return;
      }
      strengthenPointDataMap_.Add(other.strengthenPointDataMap_);
      if (other.DieType != global::Weedwacker.Shared.Network.Proto.PlayerDieType.None) {
        DieType = other.DieType;
      }
      if (other.ReviveCount != 0) {
        ReviveCount = other.ReviveCount;
      }
      if (other.WaitTime != 0) {
        WaitTime = other.WaitTime;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.MurdererEntityId != 0) {
        MurdererEntityId = other.MurdererEntityId;
      }
      switch (other.EntityCase) {
        case EntityOneofCase.MonsterId:
          MonsterId = other.MonsterId;
          break;
        case EntityOneofCase.GadgetId:
          GadgetId = other.GadgetId;
          break;
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
            ReviveCount = input.ReadUInt32();
            break;
          }
          case 32: {
            WaitTime = input.ReadUInt32();
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 58: {
            strengthenPointDataMap_.AddEntriesFrom(input, _map_strengthenPointDataMap_codec);
            break;
          }
          case 64: {
            DieType = (global::Weedwacker.Shared.Network.Proto.PlayerDieType) input.ReadEnum();
            break;
          }
          case 80: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 88: {
            MurdererEntityId = input.ReadUInt32();
            break;
          }
          case 112: {
            GadgetId = input.ReadUInt32();
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
            ReviveCount = input.ReadUInt32();
            break;
          }
          case 32: {
            WaitTime = input.ReadUInt32();
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 58: {
            strengthenPointDataMap_.AddEntriesFrom(ref input, _map_strengthenPointDataMap_codec);
            break;
          }
          case 64: {
            DieType = (global::Weedwacker.Shared.Network.Proto.PlayerDieType) input.ReadEnum();
            break;
          }
          case 80: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 88: {
            MurdererEntityId = input.ReadUInt32();
            break;
          }
          case 112: {
            GadgetId = input.ReadUInt32();
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
