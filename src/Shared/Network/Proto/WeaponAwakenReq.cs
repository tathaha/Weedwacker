// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WeaponAwakenReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WeaponAwakenReq.proto</summary>
  public static partial class WeaponAwakenReqReflection {

    #region Descriptor
    /// <summary>File descriptor for WeaponAwakenReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeaponAwakenReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXZWFwb25Bd2FrZW5SZXEucHJvdG8itAEKD1dlYXBvbkF3YWtlblJlcRI8",
            "Cg9hZmZpeF9sZXZlbF9tYXAYDSADKAsyIy5XZWFwb25Bd2FrZW5SZXEuQWZm",
            "aXhMZXZlbE1hcEVudHJ5EhoKEnRhcmdldF93ZWFwb25fZ3VpZBgFIAEoBBIR",
            "CglpdGVtX2d1aWQYBiABKAQaNAoSQWZmaXhMZXZlbE1hcEVudHJ5EgsKA2tl",
            "eRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCIqoCH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WeaponAwakenReq), global::Weedwacker.Shared.Network.Proto.WeaponAwakenReq.Parser, new[]{ "AffixLevelMap", "TargetWeaponGuid", "ItemGuid" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 633;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class WeaponAwakenReq : pb::IMessage<WeaponAwakenReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WeaponAwakenReq> _parser = new pb::MessageParser<WeaponAwakenReq>(() => new WeaponAwakenReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WeaponAwakenReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WeaponAwakenReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenReq(WeaponAwakenReq other) : this() {
      affixLevelMap_ = other.affixLevelMap_.Clone();
      targetWeaponGuid_ = other.targetWeaponGuid_;
      itemGuid_ = other.itemGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponAwakenReq Clone() {
      return new WeaponAwakenReq(this);
    }

    /// <summary>Field number for the "affix_level_map" field.</summary>
    public const int AffixLevelMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_affixLevelMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> affixLevelMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> AffixLevelMap {
      get { return affixLevelMap_; }
    }

    /// <summary>Field number for the "target_weapon_guid" field.</summary>
    public const int TargetWeaponGuidFieldNumber = 5;
    private ulong targetWeaponGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetWeaponGuid {
      get { return targetWeaponGuid_; }
      set {
        targetWeaponGuid_ = value;
      }
    }

    /// <summary>Field number for the "item_guid" field.</summary>
    public const int ItemGuidFieldNumber = 6;
    private ulong itemGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ItemGuid {
      get { return itemGuid_; }
      set {
        itemGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WeaponAwakenReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WeaponAwakenReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!AffixLevelMap.Equals(other.AffixLevelMap)) return false;
      if (TargetWeaponGuid != other.TargetWeaponGuid) return false;
      if (ItemGuid != other.ItemGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= AffixLevelMap.GetHashCode();
      if (TargetWeaponGuid != 0UL) hash ^= TargetWeaponGuid.GetHashCode();
      if (ItemGuid != 0UL) hash ^= ItemGuid.GetHashCode();
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
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(TargetWeaponGuid);
      }
      if (ItemGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ItemGuid);
      }
      affixLevelMap_.WriteTo(output, _map_affixLevelMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(TargetWeaponGuid);
      }
      if (ItemGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ItemGuid);
      }
      affixLevelMap_.WriteTo(ref output, _map_affixLevelMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += affixLevelMap_.CalculateSize(_map_affixLevelMap_codec);
      if (TargetWeaponGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetWeaponGuid);
      }
      if (ItemGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ItemGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WeaponAwakenReq other) {
      if (other == null) {
        return;
      }
      affixLevelMap_.Add(other.affixLevelMap_);
      if (other.TargetWeaponGuid != 0UL) {
        TargetWeaponGuid = other.TargetWeaponGuid;
      }
      if (other.ItemGuid != 0UL) {
        ItemGuid = other.ItemGuid;
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
          case 40: {
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            ItemGuid = input.ReadUInt64();
            break;
          }
          case 106: {
            affixLevelMap_.AddEntriesFrom(input, _map_affixLevelMap_codec);
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
          case 40: {
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            ItemGuid = input.ReadUInt64();
            break;
          }
          case 106: {
            affixLevelMap_.AddEntriesFrom(ref input, _map_affixLevelMap_codec);
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
