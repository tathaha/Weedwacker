// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Shop.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Shop.proto</summary>
  public static partial class ShopReflection {

    #region Descriptor
    /// <summary>File descriptor for Shop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShopReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpTaG9wLnByb3RvGhVTaG9wQ2FyZFByb2R1Y3QucHJvdG8aGFNob3BDb25j",
            "ZXJ0UHJvZHVjdC5wcm90bxoPU2hvcEdvb2RzLnByb3RvGhZTaG9wTWNvaW5Q",
            "cm9kdWN0LnByb3RvIpMCCgRTaG9wEhEKCXNob3BfdHlwZRgBIAEoDRIZChFu",
            "ZXh0X3JlZnJlc2hfdGltZRgFIAEoDRIPCgdjaXR5X2lkGAwgASgNEh0KFWNp",
            "dHlfcmVwdXRhdGlvbl9sZXZlbBgIIAEoDRIeCgpnb29kc19saXN0GAMgAygL",
            "MgouU2hvcEdvb2RzEisKEWNhcmRfcHJvZHVjdF9saXN0GAsgAygLMhAuU2hv",
            "cENhcmRQcm9kdWN0EjEKFGNvbmNlcnRfcHJvZHVjdF9saXN0GAkgAygLMhMu",
            "U2hvcENvbmNlcnRQcm9kdWN0Ei0KEm1jb2luX3Byb2R1Y3RfbGlzdBgHIAMo",
            "CzIRLlNob3BNY29pblByb2R1Y3RCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ShopCardProductReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ShopConcertProductReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ShopGoodsReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ShopMcoinProductReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Shop), global::Weedwacker.Shared.Network.Proto.Shop.Parser, new[]{ "ShopType", "NextRefreshTime", "CityId", "CityReputationLevel", "GoodsList", "CardProductList", "ConcertProductList", "McoinProductList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Shop : pb::IMessage<Shop>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Shop> _parser = new pb::MessageParser<Shop>(() => new Shop());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Shop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ShopReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop(Shop other) : this() {
      shopType_ = other.shopType_;
      nextRefreshTime_ = other.nextRefreshTime_;
      cityId_ = other.cityId_;
      cityReputationLevel_ = other.cityReputationLevel_;
      goodsList_ = other.goodsList_.Clone();
      cardProductList_ = other.cardProductList_.Clone();
      concertProductList_ = other.concertProductList_.Clone();
      mcoinProductList_ = other.mcoinProductList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop Clone() {
      return new Shop(this);
    }

    /// <summary>Field number for the "shop_type" field.</summary>
    public const int ShopTypeFieldNumber = 1;
    private uint shopType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopType {
      get { return shopType_; }
      set {
        shopType_ = value;
      }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 5;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "city_id" field.</summary>
    public const int CityIdFieldNumber = 12;
    private uint cityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityId {
      get { return cityId_; }
      set {
        cityId_ = value;
      }
    }

    /// <summary>Field number for the "city_reputation_level" field.</summary>
    public const int CityReputationLevelFieldNumber = 8;
    private uint cityReputationLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityReputationLevel {
      get { return cityReputationLevel_; }
      set {
        cityReputationLevel_ = value;
      }
    }

    /// <summary>Field number for the "goods_list" field.</summary>
    public const int GoodsListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ShopGoods> _repeated_goodsList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.ShopGoods.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopGoods> goodsList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopGoods>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopGoods> GoodsList {
      get { return goodsList_; }
    }

    /// <summary>Field number for the "card_product_list" field.</summary>
    public const int CardProductListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ShopCardProduct> _repeated_cardProductList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.ShopCardProduct.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopCardProduct> cardProductList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopCardProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopCardProduct> CardProductList {
      get { return cardProductList_; }
    }

    /// <summary>Field number for the "concert_product_list" field.</summary>
    public const int ConcertProductListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ShopConcertProduct> _repeated_concertProductList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.ShopConcertProduct.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopConcertProduct> concertProductList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopConcertProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopConcertProduct> ConcertProductList {
      get { return concertProductList_; }
    }

    /// <summary>Field number for the "mcoin_product_list" field.</summary>
    public const int McoinProductListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ShopMcoinProduct> _repeated_mcoinProductList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.ShopMcoinProduct.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopMcoinProduct> mcoinProductList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopMcoinProduct>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopMcoinProduct> McoinProductList {
      get { return mcoinProductList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Shop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Shop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShopType != other.ShopType) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (CityId != other.CityId) return false;
      if (CityReputationLevel != other.CityReputationLevel) return false;
      if(!goodsList_.Equals(other.goodsList_)) return false;
      if(!cardProductList_.Equals(other.cardProductList_)) return false;
      if(!concertProductList_.Equals(other.concertProductList_)) return false;
      if(!mcoinProductList_.Equals(other.mcoinProductList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShopType != 0) hash ^= ShopType.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (CityId != 0) hash ^= CityId.GetHashCode();
      if (CityReputationLevel != 0) hash ^= CityReputationLevel.GetHashCode();
      hash ^= goodsList_.GetHashCode();
      hash ^= cardProductList_.GetHashCode();
      hash ^= concertProductList_.GetHashCode();
      hash ^= mcoinProductList_.GetHashCode();
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
      if (ShopType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ShopType);
      }
      goodsList_.WriteTo(output, _repeated_goodsList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextRefreshTime);
      }
      mcoinProductList_.WriteTo(output, _repeated_mcoinProductList_codec);
      if (CityReputationLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityReputationLevel);
      }
      concertProductList_.WriteTo(output, _repeated_concertProductList_codec);
      cardProductList_.WriteTo(output, _repeated_cardProductList_codec);
      if (CityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CityId);
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
      if (ShopType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ShopType);
      }
      goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
      if (NextRefreshTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(NextRefreshTime);
      }
      mcoinProductList_.WriteTo(ref output, _repeated_mcoinProductList_codec);
      if (CityReputationLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityReputationLevel);
      }
      concertProductList_.WriteTo(ref output, _repeated_concertProductList_codec);
      cardProductList_.WriteTo(ref output, _repeated_cardProductList_codec);
      if (CityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CityId);
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
      if (ShopType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopType);
      }
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (CityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
      }
      if (CityReputationLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityReputationLevel);
      }
      size += goodsList_.CalculateSize(_repeated_goodsList_codec);
      size += cardProductList_.CalculateSize(_repeated_cardProductList_codec);
      size += concertProductList_.CalculateSize(_repeated_concertProductList_codec);
      size += mcoinProductList_.CalculateSize(_repeated_mcoinProductList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Shop other) {
      if (other == null) {
        return;
      }
      if (other.ShopType != 0) {
        ShopType = other.ShopType;
      }
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.CityId != 0) {
        CityId = other.CityId;
      }
      if (other.CityReputationLevel != 0) {
        CityReputationLevel = other.CityReputationLevel;
      }
      goodsList_.Add(other.goodsList_);
      cardProductList_.Add(other.cardProductList_);
      concertProductList_.Add(other.concertProductList_);
      mcoinProductList_.Add(other.mcoinProductList_);
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
            ShopType = input.ReadUInt32();
            break;
          }
          case 26: {
            goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
            break;
          }
          case 40: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 58: {
            mcoinProductList_.AddEntriesFrom(input, _repeated_mcoinProductList_codec);
            break;
          }
          case 64: {
            CityReputationLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            concertProductList_.AddEntriesFrom(input, _repeated_concertProductList_codec);
            break;
          }
          case 90: {
            cardProductList_.AddEntriesFrom(input, _repeated_cardProductList_codec);
            break;
          }
          case 96: {
            CityId = input.ReadUInt32();
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
            ShopType = input.ReadUInt32();
            break;
          }
          case 26: {
            goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
            break;
          }
          case 40: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 58: {
            mcoinProductList_.AddEntriesFrom(ref input, _repeated_mcoinProductList_codec);
            break;
          }
          case 64: {
            CityReputationLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            concertProductList_.AddEntriesFrom(ref input, _repeated_concertProductList_codec);
            break;
          }
          case 90: {
            cardProductList_.AddEntriesFrom(ref input, _repeated_cardProductList_codec);
            break;
          }
          case 96: {
            CityId = input.ReadUInt32();
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
