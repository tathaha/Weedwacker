// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BartenderCompleteOrderReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BartenderCompleteOrderReq.proto</summary>
  public static partial class BartenderCompleteOrderReqReflection {

    #region Descriptor
    /// <summary>File descriptor for BartenderCompleteOrderReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BartenderCompleteOrderReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9CYXJ0ZW5kZXJDb21wbGV0ZU9yZGVyUmVxLnByb3RvGg9JdGVtUGFyYW0u",
            "cHJvdG8i2QEKGUJhcnRlbmRlckNvbXBsZXRlT3JkZXJSZXESEAoIcXVlc3Rf",
            "aWQYDiABKA0SGwoTb3B0aW9uYWxfb3JkZXJfbGlzdBgPIAMoDRIbChNVbmsz",
            "MzAwX05LTUhISEhHSElGGAYgASgNEhsKE1VuazMzMDBfTE9OSEtKRkRPTkQY",
            "BSABKA0SGwoTVW5rMzMwMF9QT0VHUEZKTE5HQhgLIAEoDRIXCg9pc192aWV3",
            "X2Zvcm11bGEYCCABKAgSHQoJaXRlbV9saXN0GAwgAygLMgouSXRlbVBhcmFt",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BartenderCompleteOrderReq), global::Weedwacker.Shared.Network.Proto.BartenderCompleteOrderReq.Parser, new[]{ "QuestId", "OptionalOrderList", "Unk3300NKMHHHHGHIF", "Unk3300LONHKJFDOND", "Unk3300POEGPFJLNGB", "IsViewFormula", "ItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8880;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class BartenderCompleteOrderReq : pb::IMessage<BartenderCompleteOrderReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BartenderCompleteOrderReq> _parser = new pb::MessageParser<BartenderCompleteOrderReq>(() => new BartenderCompleteOrderReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BartenderCompleteOrderReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BartenderCompleteOrderReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BartenderCompleteOrderReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BartenderCompleteOrderReq(BartenderCompleteOrderReq other) : this() {
      questId_ = other.questId_;
      optionalOrderList_ = other.optionalOrderList_.Clone();
      unk3300NKMHHHHGHIF_ = other.unk3300NKMHHHHGHIF_;
      unk3300LONHKJFDOND_ = other.unk3300LONHKJFDOND_;
      unk3300POEGPFJLNGB_ = other.unk3300POEGPFJLNGB_;
      isViewFormula_ = other.isViewFormula_;
      itemList_ = other.itemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BartenderCompleteOrderReq Clone() {
      return new BartenderCompleteOrderReq(this);
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 14;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "optional_order_list" field.</summary>
    public const int OptionalOrderListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_optionalOrderList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> optionalOrderList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OptionalOrderList {
      get { return optionalOrderList_; }
    }

    /// <summary>Field number for the "Unk3300_NKMHHHHGHIF" field.</summary>
    public const int Unk3300NKMHHHHGHIFFieldNumber = 6;
    private uint unk3300NKMHHHHGHIF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NKMHHHHGHIF {
      get { return unk3300NKMHHHHGHIF_; }
      set {
        unk3300NKMHHHHGHIF_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LONHKJFDOND" field.</summary>
    public const int Unk3300LONHKJFDONDFieldNumber = 5;
    private uint unk3300LONHKJFDOND_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LONHKJFDOND {
      get { return unk3300LONHKJFDOND_; }
      set {
        unk3300LONHKJFDOND_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_POEGPFJLNGB" field.</summary>
    public const int Unk3300POEGPFJLNGBFieldNumber = 11;
    private uint unk3300POEGPFJLNGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300POEGPFJLNGB {
      get { return unk3300POEGPFJLNGB_; }
      set {
        unk3300POEGPFJLNGB_ = value;
      }
    }

    /// <summary>Field number for the "is_view_formula" field.</summary>
    public const int IsViewFormulaFieldNumber = 8;
    private bool isViewFormula_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsViewFormula {
      get { return isViewFormula_; }
      set {
        isViewFormula_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> itemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ItemList {
      get { return itemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BartenderCompleteOrderReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BartenderCompleteOrderReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestId != other.QuestId) return false;
      if(!optionalOrderList_.Equals(other.optionalOrderList_)) return false;
      if (Unk3300NKMHHHHGHIF != other.Unk3300NKMHHHHGHIF) return false;
      if (Unk3300LONHKJFDOND != other.Unk3300LONHKJFDOND) return false;
      if (Unk3300POEGPFJLNGB != other.Unk3300POEGPFJLNGB) return false;
      if (IsViewFormula != other.IsViewFormula) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
      hash ^= optionalOrderList_.GetHashCode();
      if (Unk3300NKMHHHHGHIF != 0) hash ^= Unk3300NKMHHHHGHIF.GetHashCode();
      if (Unk3300LONHKJFDOND != 0) hash ^= Unk3300LONHKJFDOND.GetHashCode();
      if (Unk3300POEGPFJLNGB != 0) hash ^= Unk3300POEGPFJLNGB.GetHashCode();
      if (IsViewFormula != false) hash ^= IsViewFormula.GetHashCode();
      hash ^= itemList_.GetHashCode();
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
      if (Unk3300LONHKJFDOND != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300LONHKJFDOND);
      }
      if (Unk3300NKMHHHHGHIF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300NKMHHHHGHIF);
      }
      if (IsViewFormula != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsViewFormula);
      }
      if (Unk3300POEGPFJLNGB != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300POEGPFJLNGB);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (QuestId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(QuestId);
      }
      optionalOrderList_.WriteTo(output, _repeated_optionalOrderList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk3300LONHKJFDOND != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300LONHKJFDOND);
      }
      if (Unk3300NKMHHHHGHIF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300NKMHHHHGHIF);
      }
      if (IsViewFormula != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsViewFormula);
      }
      if (Unk3300POEGPFJLNGB != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300POEGPFJLNGB);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (QuestId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(QuestId);
      }
      optionalOrderList_.WriteTo(ref output, _repeated_optionalOrderList_codec);
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
      size += optionalOrderList_.CalculateSize(_repeated_optionalOrderList_codec);
      if (Unk3300NKMHHHHGHIF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NKMHHHHGHIF);
      }
      if (Unk3300LONHKJFDOND != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LONHKJFDOND);
      }
      if (Unk3300POEGPFJLNGB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300POEGPFJLNGB);
      }
      if (IsViewFormula != false) {
        size += 1 + 1;
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BartenderCompleteOrderReq other) {
      if (other == null) {
        return;
      }
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
      }
      optionalOrderList_.Add(other.optionalOrderList_);
      if (other.Unk3300NKMHHHHGHIF != 0) {
        Unk3300NKMHHHHGHIF = other.Unk3300NKMHHHHGHIF;
      }
      if (other.Unk3300LONHKJFDOND != 0) {
        Unk3300LONHKJFDOND = other.Unk3300LONHKJFDOND;
      }
      if (other.Unk3300POEGPFJLNGB != 0) {
        Unk3300POEGPFJLNGB = other.Unk3300POEGPFJLNGB;
      }
      if (other.IsViewFormula != false) {
        IsViewFormula = other.IsViewFormula;
      }
      itemList_.Add(other.itemList_);
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
            Unk3300LONHKJFDOND = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300NKMHHHHGHIF = input.ReadUInt32();
            break;
          }
          case 64: {
            IsViewFormula = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300POEGPFJLNGB = input.ReadUInt32();
            break;
          }
          case 98: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 112: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            optionalOrderList_.AddEntriesFrom(input, _repeated_optionalOrderList_codec);
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
            Unk3300LONHKJFDOND = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300NKMHHHHGHIF = input.ReadUInt32();
            break;
          }
          case 64: {
            IsViewFormula = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300POEGPFJLNGB = input.ReadUInt32();
            break;
          }
          case 98: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 112: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            optionalOrderList_.AddEntriesFrom(ref input, _repeated_optionalOrderList_codec);
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
