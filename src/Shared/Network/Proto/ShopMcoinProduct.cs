// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ShopMcoinProduct.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ShopMcoinProduct.proto</summary>
  public static partial class ShopMcoinProductReflection {

    #region Descriptor
    /// <summary>File descriptor for ShopMcoinProduct.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShopMcoinProductReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZTaG9wTWNvaW5Qcm9kdWN0LnByb3RvIqIBChBTaG9wTWNvaW5Qcm9kdWN0",
            "EhIKCnByb2R1Y3RfaWQYASABKAkSEgoKcHJpY2VfdGllchgCIAEoCRISCgpt",
            "Y29pbl9iYXNlGAMgASgNEhcKD21jb2luX25vbl9maXJzdBgEIAEoDRITCgtt",
            "Y29pbl9maXJzdBgFIAEoDRISCgpib3VnaHRfbnVtGAYgASgNEhAKCGlzX2F1",
            "ZGl0GAcgASgIQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ShopMcoinProduct), global::Weedwacker.Shared.Network.Proto.ShopMcoinProduct.Parser, new[]{ "ProductId", "PriceTier", "McoinBase", "McoinNonFirst", "McoinFirst", "BoughtNum", "IsAudit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ShopMcoinProduct : pb::IMessage<ShopMcoinProduct>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ShopMcoinProduct> _parser = new pb::MessageParser<ShopMcoinProduct>(() => new ShopMcoinProduct());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ShopMcoinProduct> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ShopMcoinProductReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShopMcoinProduct() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShopMcoinProduct(ShopMcoinProduct other) : this() {
      productId_ = other.productId_;
      priceTier_ = other.priceTier_;
      mcoinBase_ = other.mcoinBase_;
      mcoinNonFirst_ = other.mcoinNonFirst_;
      mcoinFirst_ = other.mcoinFirst_;
      boughtNum_ = other.boughtNum_;
      isAudit_ = other.isAudit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShopMcoinProduct Clone() {
      return new ShopMcoinProduct(this);
    }

    /// <summary>Field number for the "product_id" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private string productId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductId {
      get { return productId_; }
      set {
        productId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "price_tier" field.</summary>
    public const int PriceTierFieldNumber = 2;
    private string priceTier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PriceTier {
      get { return priceTier_; }
      set {
        priceTier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mcoin_base" field.</summary>
    public const int McoinBaseFieldNumber = 3;
    private uint mcoinBase_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint McoinBase {
      get { return mcoinBase_; }
      set {
        mcoinBase_ = value;
      }
    }

    /// <summary>Field number for the "mcoin_non_first" field.</summary>
    public const int McoinNonFirstFieldNumber = 4;
    private uint mcoinNonFirst_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint McoinNonFirst {
      get { return mcoinNonFirst_; }
      set {
        mcoinNonFirst_ = value;
      }
    }

    /// <summary>Field number for the "mcoin_first" field.</summary>
    public const int McoinFirstFieldNumber = 5;
    private uint mcoinFirst_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint McoinFirst {
      get { return mcoinFirst_; }
      set {
        mcoinFirst_ = value;
      }
    }

    /// <summary>Field number for the "bought_num" field.</summary>
    public const int BoughtNumFieldNumber = 6;
    private uint boughtNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BoughtNum {
      get { return boughtNum_; }
      set {
        boughtNum_ = value;
      }
    }

    /// <summary>Field number for the "is_audit" field.</summary>
    public const int IsAuditFieldNumber = 7;
    private bool isAudit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAudit {
      get { return isAudit_; }
      set {
        isAudit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ShopMcoinProduct);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ShopMcoinProduct other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (PriceTier != other.PriceTier) return false;
      if (McoinBase != other.McoinBase) return false;
      if (McoinNonFirst != other.McoinNonFirst) return false;
      if (McoinFirst != other.McoinFirst) return false;
      if (BoughtNum != other.BoughtNum) return false;
      if (IsAudit != other.IsAudit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ProductId.Length != 0) hash ^= ProductId.GetHashCode();
      if (PriceTier.Length != 0) hash ^= PriceTier.GetHashCode();
      if (McoinBase != 0) hash ^= McoinBase.GetHashCode();
      if (McoinNonFirst != 0) hash ^= McoinNonFirst.GetHashCode();
      if (McoinFirst != 0) hash ^= McoinFirst.GetHashCode();
      if (BoughtNum != 0) hash ^= BoughtNum.GetHashCode();
      if (IsAudit != false) hash ^= IsAudit.GetHashCode();
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
      if (ProductId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProductId);
      }
      if (PriceTier.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PriceTier);
      }
      if (McoinBase != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(McoinBase);
      }
      if (McoinNonFirst != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(McoinNonFirst);
      }
      if (McoinFirst != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(McoinFirst);
      }
      if (BoughtNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BoughtNum);
      }
      if (IsAudit != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsAudit);
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
      if (ProductId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ProductId);
      }
      if (PriceTier.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PriceTier);
      }
      if (McoinBase != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(McoinBase);
      }
      if (McoinNonFirst != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(McoinNonFirst);
      }
      if (McoinFirst != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(McoinFirst);
      }
      if (BoughtNum != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BoughtNum);
      }
      if (IsAudit != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsAudit);
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
      if (ProductId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductId);
      }
      if (PriceTier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PriceTier);
      }
      if (McoinBase != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(McoinBase);
      }
      if (McoinNonFirst != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(McoinNonFirst);
      }
      if (McoinFirst != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(McoinFirst);
      }
      if (BoughtNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BoughtNum);
      }
      if (IsAudit != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ShopMcoinProduct other) {
      if (other == null) {
        return;
      }
      if (other.ProductId.Length != 0) {
        ProductId = other.ProductId;
      }
      if (other.PriceTier.Length != 0) {
        PriceTier = other.PriceTier;
      }
      if (other.McoinBase != 0) {
        McoinBase = other.McoinBase;
      }
      if (other.McoinNonFirst != 0) {
        McoinNonFirst = other.McoinNonFirst;
      }
      if (other.McoinFirst != 0) {
        McoinFirst = other.McoinFirst;
      }
      if (other.BoughtNum != 0) {
        BoughtNum = other.BoughtNum;
      }
      if (other.IsAudit != false) {
        IsAudit = other.IsAudit;
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
          case 10: {
            ProductId = input.ReadString();
            break;
          }
          case 18: {
            PriceTier = input.ReadString();
            break;
          }
          case 24: {
            McoinBase = input.ReadUInt32();
            break;
          }
          case 32: {
            McoinNonFirst = input.ReadUInt32();
            break;
          }
          case 40: {
            McoinFirst = input.ReadUInt32();
            break;
          }
          case 48: {
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 56: {
            IsAudit = input.ReadBool();
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
          case 10: {
            ProductId = input.ReadString();
            break;
          }
          case 18: {
            PriceTier = input.ReadString();
            break;
          }
          case 24: {
            McoinBase = input.ReadUInt32();
            break;
          }
          case 32: {
            McoinNonFirst = input.ReadUInt32();
            break;
          }
          case 40: {
            McoinFirst = input.ReadUInt32();
            break;
          }
          case 48: {
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 56: {
            IsAudit = input.ReadBool();
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
