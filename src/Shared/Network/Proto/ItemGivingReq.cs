// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ItemGivingReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ItemGivingReq.proto</summary>
  public static partial class ItemGivingReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ItemGivingReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemGivingReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNJdGVtR2l2aW5nUmVxLnByb3RvGg9JdGVtUGFyYW0ucHJvdG8ixwIKDUl0",
            "ZW1HaXZpbmdSZXESEQoJZ2l2aW5nX2lkGAYgASgNEjcKEGl0ZW1fZ2l2aW5n",
            "X3R5cGUYCCABKA4yHS5JdGVtR2l2aW5nUmVxLkl0ZW1HaXZpbmdUeXBlEiMK",
            "D2l0ZW1fcGFyYW1fbGlzdBgMIAMoCzIKLkl0ZW1QYXJhbRJBChNpdGVtX2d1",
            "aWRfY291bnRfbWFwGAsgAygLMiQuSXRlbUdpdmluZ1JlcS5JdGVtR3VpZENv",
            "dW50TWFwRW50cnkaNwoVSXRlbUd1aWRDb3VudE1hcEVudHJ5EgsKA2tleRgB",
            "IAEoBBINCgV2YWx1ZRgCIAEoDToCOAEiSQoOSXRlbUdpdmluZ1R5cGUSGgoW",
            "SVRFTV9HSVZJTkdfVFlQRV9RVUVTVBAAEhsKF0lURU1fR0lWSU5HX1RZUEVf",
            "R0FER0VUEAFCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ItemGivingReq), global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Parser, new[]{ "GivingId", "ItemGivingType", "ItemParamList", "ItemGuidCountMap" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 185;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class ItemGivingReq : pb::IMessage<ItemGivingReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ItemGivingReq> _parser = new pb::MessageParser<ItemGivingReq>(() => new ItemGivingReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ItemGivingReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ItemGivingReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemGivingReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemGivingReq(ItemGivingReq other) : this() {
      givingId_ = other.givingId_;
      itemGivingType_ = other.itemGivingType_;
      itemParamList_ = other.itemParamList_.Clone();
      itemGuidCountMap_ = other.itemGuidCountMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemGivingReq Clone() {
      return new ItemGivingReq(this);
    }

    /// <summary>Field number for the "giving_id" field.</summary>
    public const int GivingIdFieldNumber = 6;
    private uint givingId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GivingId {
      get { return givingId_; }
      set {
        givingId_ = value;
      }
    }

    /// <summary>Field number for the "item_giving_type" field.</summary>
    public const int ItemGivingTypeFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType itemGivingType_ = global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType.Quest;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType ItemGivingType {
      get { return itemGivingType_; }
      set {
        itemGivingType_ = value;
      }
    }

    /// <summary>Field number for the "item_param_list" field.</summary>
    public const int ItemParamListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_itemParamList_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> itemParamList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ItemParamList {
      get { return itemParamList_; }
    }

    /// <summary>Field number for the "item_guid_count_map" field.</summary>
    public const int ItemGuidCountMapFieldNumber = 11;
    private static readonly pbc::MapField<ulong, uint>.Codec _map_itemGuidCountMap_codec
        = new pbc::MapField<ulong, uint>.Codec(pb::FieldCodec.ForUInt64(8, 0UL), pb::FieldCodec.ForUInt32(16, 0), 90);
    private readonly pbc::MapField<ulong, uint> itemGuidCountMap_ = new pbc::MapField<ulong, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<ulong, uint> ItemGuidCountMap {
      get { return itemGuidCountMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ItemGivingReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ItemGivingReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GivingId != other.GivingId) return false;
      if (ItemGivingType != other.ItemGivingType) return false;
      if(!itemParamList_.Equals(other.itemParamList_)) return false;
      if (!ItemGuidCountMap.Equals(other.ItemGuidCountMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GivingId != 0) hash ^= GivingId.GetHashCode();
      if (ItemGivingType != global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType.Quest) hash ^= ItemGivingType.GetHashCode();
      hash ^= itemParamList_.GetHashCode();
      hash ^= ItemGuidCountMap.GetHashCode();
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
      if (GivingId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GivingId);
      }
      if (ItemGivingType != global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType.Quest) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ItemGivingType);
      }
      itemGuidCountMap_.WriteTo(output, _map_itemGuidCountMap_codec);
      itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GivingId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GivingId);
      }
      if (ItemGivingType != global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType.Quest) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ItemGivingType);
      }
      itemGuidCountMap_.WriteTo(ref output, _map_itemGuidCountMap_codec);
      itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GivingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GivingId);
      }
      if (ItemGivingType != global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType.Quest) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemGivingType);
      }
      size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
      size += itemGuidCountMap_.CalculateSize(_map_itemGuidCountMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ItemGivingReq other) {
      if (other == null) {
        return;
      }
      if (other.GivingId != 0) {
        GivingId = other.GivingId;
      }
      if (other.ItemGivingType != global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType.Quest) {
        ItemGivingType = other.ItemGivingType;
      }
      itemParamList_.Add(other.itemParamList_);
      itemGuidCountMap_.Add(other.itemGuidCountMap_);
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
          case 48: {
            GivingId = input.ReadUInt32();
            break;
          }
          case 64: {
            ItemGivingType = (global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType) input.ReadEnum();
            break;
          }
          case 90: {
            itemGuidCountMap_.AddEntriesFrom(input, _map_itemGuidCountMap_codec);
            break;
          }
          case 98: {
            itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
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
          case 48: {
            GivingId = input.ReadUInt32();
            break;
          }
          case 64: {
            ItemGivingType = (global::Weedwacker.Shared.Network.Proto.ItemGivingReq.Types.ItemGivingType) input.ReadEnum();
            break;
          }
          case 90: {
            itemGuidCountMap_.AddEntriesFrom(ref input, _map_itemGuidCountMap_codec);
            break;
          }
          case 98: {
            itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ItemGivingReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ItemGivingType {
        [pbr::OriginalName("ITEM_GIVING_TYPE_QUEST")] Quest = 0,
        [pbr::OriginalName("ITEM_GIVING_TYPE_GADGET")] Gadget = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
