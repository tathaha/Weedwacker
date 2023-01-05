// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarExpeditionGetRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AvatarExpeditionGetRewardRsp.proto</summary>
  public static partial class AvatarExpeditionGetRewardRspReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarExpeditionGetRewardRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarExpeditionGetRewardRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBdmF0YXJFeHBlZGl0aW9uR2V0UmV3YXJkUnNwLnByb3RvGhpBdmF0YXJF",
            "eHBlZGl0aW9uSW5mby5wcm90bxoPSXRlbVBhcmFtLnByb3RvIpcCChxBdmF0",
            "YXJFeHBlZGl0aW9uR2V0UmV3YXJkUnNwEh0KCWl0ZW1fbGlzdBgHIAMoCzIK",
            "Lkl0ZW1QYXJhbRIjCg9leHRyYV9pdGVtX2xpc3QYCyADKAsyCi5JdGVtUGFy",
            "YW0SUQoTZXhwZWRpdGlvbl9pbmZvX21hcBgNIAMoCzI0LkF2YXRhckV4cGVk",
            "aXRpb25HZXRSZXdhcmRSc3AuRXhwZWRpdGlvbkluZm9NYXBFbnRyeRIPCgdy",
            "ZXRjb2RlGAggASgFGk8KFkV4cGVkaXRpb25JbmZvTWFwRW50cnkSCwoDa2V5",
            "GAEgASgEEiQKBXZhbHVlGAIgASgLMhUuQXZhdGFyRXhwZWRpdGlvbkluZm86",
            "AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AvatarExpeditionInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AvatarExpeditionGetRewardRsp), global::Weedwacker.Shared.Network.Proto.AvatarExpeditionGetRewardRsp.Parser, new[]{ "ItemList", "ExtraItemList", "ExpeditionInfoMap", "Retcode" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1715;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AvatarExpeditionGetRewardRsp : pb::IMessage<AvatarExpeditionGetRewardRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarExpeditionGetRewardRsp> _parser = new pb::MessageParser<AvatarExpeditionGetRewardRsp>(() => new AvatarExpeditionGetRewardRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarExpeditionGetRewardRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AvatarExpeditionGetRewardRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExpeditionGetRewardRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExpeditionGetRewardRsp(AvatarExpeditionGetRewardRsp other) : this() {
      itemList_ = other.itemList_.Clone();
      extraItemList_ = other.extraItemList_.Clone();
      expeditionInfoMap_ = other.expeditionInfoMap_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarExpeditionGetRewardRsp Clone() {
      return new AvatarExpeditionGetRewardRsp(this);
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> itemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "extra_item_list" field.</summary>
    public const int ExtraItemListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_extraItemList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> extraItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ExtraItemList {
      get { return extraItemList_; }
    }

    /// <summary>Field number for the "expedition_info_map" field.</summary>
    public const int ExpeditionInfoMapFieldNumber = 13;
    private static readonly pbc::MapField<ulong, global::Weedwacker.Shared.Network.Proto.AvatarExpeditionInfo>.Codec _map_expeditionInfoMap_codec
        = new pbc::MapField<ulong, global::Weedwacker.Shared.Network.Proto.AvatarExpeditionInfo>.Codec(pb::FieldCodec.ForUInt64(8, 0UL), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.AvatarExpeditionInfo.Parser), 106);
    private readonly pbc::MapField<ulong, global::Weedwacker.Shared.Network.Proto.AvatarExpeditionInfo> expeditionInfoMap_ = new pbc::MapField<ulong, global::Weedwacker.Shared.Network.Proto.AvatarExpeditionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<ulong, global::Weedwacker.Shared.Network.Proto.AvatarExpeditionInfo> ExpeditionInfoMap {
      get { return expeditionInfoMap_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarExpeditionGetRewardRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarExpeditionGetRewardRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!itemList_.Equals(other.itemList_)) return false;
      if(!extraItemList_.Equals(other.extraItemList_)) return false;
      if (!ExpeditionInfoMap.Equals(other.ExpeditionInfoMap)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= itemList_.GetHashCode();
      hash ^= extraItemList_.GetHashCode();
      hash ^= ExpeditionInfoMap.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      extraItemList_.WriteTo(output, _repeated_extraItemList_codec);
      expeditionInfoMap_.WriteTo(output, _map_expeditionInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      extraItemList_.WriteTo(ref output, _repeated_extraItemList_codec);
      expeditionInfoMap_.WriteTo(ref output, _map_expeditionInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      size += extraItemList_.CalculateSize(_repeated_extraItemList_codec);
      size += expeditionInfoMap_.CalculateSize(_map_expeditionInfoMap_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarExpeditionGetRewardRsp other) {
      if (other == null) {
        return;
      }
      itemList_.Add(other.itemList_);
      extraItemList_.Add(other.extraItemList_);
      expeditionInfoMap_.Add(other.expeditionInfoMap_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 58: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 90: {
            extraItemList_.AddEntriesFrom(input, _repeated_extraItemList_codec);
            break;
          }
          case 106: {
            expeditionInfoMap_.AddEntriesFrom(input, _map_expeditionInfoMap_codec);
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
          case 58: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 90: {
            extraItemList_.AddEntriesFrom(ref input, _repeated_extraItemList_codec);
            break;
          }
          case 106: {
            expeditionInfoMap_.AddEntriesFrom(ref input, _map_expeditionInfoMap_codec);
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
