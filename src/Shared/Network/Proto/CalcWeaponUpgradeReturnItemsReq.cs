// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CalcWeaponUpgradeReturnItemsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CalcWeaponUpgradeReturnItemsReq.proto</summary>
  public static partial class CalcWeaponUpgradeReturnItemsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for CalcWeaponUpgradeReturnItemsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CalcWeaponUpgradeReturnItemsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVDYWxjV2VhcG9uVXBncmFkZVJldHVybkl0ZW1zUmVxLnByb3RvEh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGg9JdGVtUGFyYW0ucHJvdG8i",
            "oQEKH0NhbGNXZWFwb25VcGdyYWRlUmV0dXJuSXRlbXNSZXESHQoVZm9vZF93",
            "ZWFwb25fZ3VpZF9saXN0GAwgAygEEkMKD2l0ZW1fcGFyYW1fbGlzdBgIIAMo",
            "CzIqLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSXRlbVBhcmFt",
            "EhoKEnRhcmdldF93ZWFwb25fZ3VpZBgCIAEoBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CalcWeaponUpgradeReturnItemsReq), global::Weedwacker.Shared.Network.Proto.CalcWeaponUpgradeReturnItemsReq.Parser, new[]{ "FoodWeaponGuidList", "ItemParamList", "TargetWeaponGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 666;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class CalcWeaponUpgradeReturnItemsReq : pb::IMessage<CalcWeaponUpgradeReturnItemsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CalcWeaponUpgradeReturnItemsReq> _parser = new pb::MessageParser<CalcWeaponUpgradeReturnItemsReq>(() => new CalcWeaponUpgradeReturnItemsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CalcWeaponUpgradeReturnItemsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CalcWeaponUpgradeReturnItemsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CalcWeaponUpgradeReturnItemsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CalcWeaponUpgradeReturnItemsReq(CalcWeaponUpgradeReturnItemsReq other) : this() {
      foodWeaponGuidList_ = other.foodWeaponGuidList_.Clone();
      itemParamList_ = other.itemParamList_.Clone();
      targetWeaponGuid_ = other.targetWeaponGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CalcWeaponUpgradeReturnItemsReq Clone() {
      return new CalcWeaponUpgradeReturnItemsReq(this);
    }

    /// <summary>Field number for the "food_weapon_guid_list" field.</summary>
    public const int FoodWeaponGuidListFieldNumber = 12;
    private static readonly pb::FieldCodec<ulong> _repeated_foodWeaponGuidList_codec
        = pb::FieldCodec.ForUInt64(98);
    private readonly pbc::RepeatedField<ulong> foodWeaponGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> FoodWeaponGuidList {
      get { return foodWeaponGuidList_; }
    }

    /// <summary>Field number for the "item_param_list" field.</summary>
    public const int ItemParamListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_itemParamList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> itemParamList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ItemParamList {
      get { return itemParamList_; }
    }

    /// <summary>Field number for the "target_weapon_guid" field.</summary>
    public const int TargetWeaponGuidFieldNumber = 2;
    private ulong targetWeaponGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetWeaponGuid {
      get { return targetWeaponGuid_; }
      set {
        targetWeaponGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CalcWeaponUpgradeReturnItemsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CalcWeaponUpgradeReturnItemsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!foodWeaponGuidList_.Equals(other.foodWeaponGuidList_)) return false;
      if(!itemParamList_.Equals(other.itemParamList_)) return false;
      if (TargetWeaponGuid != other.TargetWeaponGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= foodWeaponGuidList_.GetHashCode();
      hash ^= itemParamList_.GetHashCode();
      if (TargetWeaponGuid != 0UL) hash ^= TargetWeaponGuid.GetHashCode();
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
        output.WriteRawTag(16);
        output.WriteUInt64(TargetWeaponGuid);
      }
      itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
      foodWeaponGuidList_.WriteTo(output, _repeated_foodWeaponGuidList_codec);
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
        output.WriteRawTag(16);
        output.WriteUInt64(TargetWeaponGuid);
      }
      itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
      foodWeaponGuidList_.WriteTo(ref output, _repeated_foodWeaponGuidList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += foodWeaponGuidList_.CalculateSize(_repeated_foodWeaponGuidList_codec);
      size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
      if (TargetWeaponGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetWeaponGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CalcWeaponUpgradeReturnItemsReq other) {
      if (other == null) {
        return;
      }
      foodWeaponGuidList_.Add(other.foodWeaponGuidList_);
      itemParamList_.Add(other.itemParamList_);
      if (other.TargetWeaponGuid != 0UL) {
        TargetWeaponGuid = other.TargetWeaponGuid;
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
          case 16: {
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 66: {
            itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
            break;
          }
          case 98:
          case 96: {
            foodWeaponGuidList_.AddEntriesFrom(input, _repeated_foodWeaponGuidList_codec);
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
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 66: {
            itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
            break;
          }
          case 98:
          case 96: {
            foodWeaponGuidList_.AddEntriesFrom(ref input, _repeated_foodWeaponGuidList_codec);
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
