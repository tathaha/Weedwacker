// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetBattlePassProductRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetBattlePassProductRsp.proto</summary>
  public static partial class GetBattlePassProductRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetBattlePassProductRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetBattlePassProductRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRCYXR0bGVQYXNzUHJvZHVjdFJzcC5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90byKSAQoXR2V0QmF0dGxlUGFzc1Byb2R1Y3RS",
            "c3ASFwoPY3VyX3NjaGVkdWxlX2lkGA4gASgNEhIKCnByb2R1Y3RfaWQYAiAB",
            "KAkSEgoKcHJpY2VfdGllchgJIAEoCRIPCgdyZXRjb2RlGAogASgFEiUKHWJh",
            "dHRsZV9wYXNzX3Byb2R1Y3RfcGxheV90eXBlGA8gASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetBattlePassProductRsp), global::Weedwacker.Shared.Network.Proto.GetBattlePassProductRsp.Parser, new[]{ "CurScheduleId", "ProductId", "PriceTier", "Retcode", "BattlePassProductPlayType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2634;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetBattlePassProductRsp : pb::IMessage<GetBattlePassProductRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetBattlePassProductRsp> _parser = new pb::MessageParser<GetBattlePassProductRsp>(() => new GetBattlePassProductRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetBattlePassProductRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetBattlePassProductRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBattlePassProductRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBattlePassProductRsp(GetBattlePassProductRsp other) : this() {
      curScheduleId_ = other.curScheduleId_;
      productId_ = other.productId_;
      priceTier_ = other.priceTier_;
      retcode_ = other.retcode_;
      battlePassProductPlayType_ = other.battlePassProductPlayType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetBattlePassProductRsp Clone() {
      return new GetBattlePassProductRsp(this);
    }

    /// <summary>Field number for the "cur_schedule_id" field.</summary>
    public const int CurScheduleIdFieldNumber = 14;
    private uint curScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScheduleId {
      get { return curScheduleId_; }
      set {
        curScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "product_id" field.</summary>
    public const int ProductIdFieldNumber = 2;
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
    public const int PriceTierFieldNumber = 9;
    private string priceTier_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PriceTier {
      get { return priceTier_; }
      set {
        priceTier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "battle_pass_product_play_type" field.</summary>
    public const int BattlePassProductPlayTypeFieldNumber = 15;
    private uint battlePassProductPlayType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattlePassProductPlayType {
      get { return battlePassProductPlayType_; }
      set {
        battlePassProductPlayType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetBattlePassProductRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetBattlePassProductRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurScheduleId != other.CurScheduleId) return false;
      if (ProductId != other.ProductId) return false;
      if (PriceTier != other.PriceTier) return false;
      if (Retcode != other.Retcode) return false;
      if (BattlePassProductPlayType != other.BattlePassProductPlayType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurScheduleId != 0) hash ^= CurScheduleId.GetHashCode();
      if (ProductId.Length != 0) hash ^= ProductId.GetHashCode();
      if (PriceTier.Length != 0) hash ^= PriceTier.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (BattlePassProductPlayType != 0) hash ^= BattlePassProductPlayType.GetHashCode();
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
        output.WriteRawTag(18);
        output.WriteString(ProductId);
      }
      if (PriceTier.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(PriceTier);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (CurScheduleId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurScheduleId);
      }
      if (BattlePassProductPlayType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattlePassProductPlayType);
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
        output.WriteRawTag(18);
        output.WriteString(ProductId);
      }
      if (PriceTier.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(PriceTier);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (CurScheduleId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurScheduleId);
      }
      if (BattlePassProductPlayType != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattlePassProductPlayType);
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
      if (CurScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScheduleId);
      }
      if (ProductId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductId);
      }
      if (PriceTier.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PriceTier);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (BattlePassProductPlayType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattlePassProductPlayType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetBattlePassProductRsp other) {
      if (other == null) {
        return;
      }
      if (other.CurScheduleId != 0) {
        CurScheduleId = other.CurScheduleId;
      }
      if (other.ProductId.Length != 0) {
        ProductId = other.ProductId;
      }
      if (other.PriceTier.Length != 0) {
        PriceTier = other.PriceTier;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.BattlePassProductPlayType != 0) {
        BattlePassProductPlayType = other.BattlePassProductPlayType;
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
          case 18: {
            ProductId = input.ReadString();
            break;
          }
          case 74: {
            PriceTier = input.ReadString();
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            CurScheduleId = input.ReadUInt32();
            break;
          }
          case 120: {
            BattlePassProductPlayType = input.ReadUInt32();
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
          case 18: {
            ProductId = input.ReadString();
            break;
          }
          case 74: {
            PriceTier = input.ReadString();
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            CurScheduleId = input.ReadUInt32();
            break;
          }
          case 120: {
            BattlePassProductPlayType = input.ReadUInt32();
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
