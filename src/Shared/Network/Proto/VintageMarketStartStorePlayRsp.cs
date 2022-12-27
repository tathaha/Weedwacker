// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageMarketStartStorePlayRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageMarketStartStorePlayRsp.proto</summary>
  public static partial class VintageMarketStartStorePlayRspReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageMarketStartStorePlayRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageMarketStartStorePlayRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRWaW50YWdlTWFya2V0U3RhcnRTdG9yZVBsYXlSc3AucHJvdG8igAEKHlZp",
            "bnRhZ2VNYXJrZXRTdGFydFN0b3JlUGxheVJzcBITCgtzdG9yZV9yb3VuZBgK",
            "IAEoDRIbChNVbmszMzAwX0xDQ05FS0dPTkZHGAkgASgNEg8KB3JldGNvZGUY",
            "ASABKAUSGwoTVW5rMzMwMF9BREpLSUlKRk5NRRgPIAEoDUIiqgIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageMarketStartStorePlayRsp), global::Weedwacker.Shared.Network.Proto.VintageMarketStartStorePlayRsp.Parser, new[]{ "StoreRound", "Unk3300LCCNEKGONFG", "Retcode", "Unk3300ADJKIIJFNME" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 23017;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class VintageMarketStartStorePlayRsp : pb::IMessage<VintageMarketStartStorePlayRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageMarketStartStorePlayRsp> _parser = new pb::MessageParser<VintageMarketStartStorePlayRsp>(() => new VintageMarketStartStorePlayRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageMarketStartStorePlayRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageMarketStartStorePlayRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStartStorePlayRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStartStorePlayRsp(VintageMarketStartStorePlayRsp other) : this() {
      storeRound_ = other.storeRound_;
      unk3300LCCNEKGONFG_ = other.unk3300LCCNEKGONFG_;
      retcode_ = other.retcode_;
      unk3300ADJKIIJFNME_ = other.unk3300ADJKIIJFNME_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageMarketStartStorePlayRsp Clone() {
      return new VintageMarketStartStorePlayRsp(this);
    }

    /// <summary>Field number for the "store_round" field.</summary>
    public const int StoreRoundFieldNumber = 10;
    private uint storeRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreRound {
      get { return storeRound_; }
      set {
        storeRound_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LCCNEKGONFG" field.</summary>
    public const int Unk3300LCCNEKGONFGFieldNumber = 9;
    private uint unk3300LCCNEKGONFG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LCCNEKGONFG {
      get { return unk3300LCCNEKGONFG_; }
      set {
        unk3300LCCNEKGONFG_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ADJKIIJFNME" field.</summary>
    public const int Unk3300ADJKIIJFNMEFieldNumber = 15;
    private uint unk3300ADJKIIJFNME_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300ADJKIIJFNME {
      get { return unk3300ADJKIIJFNME_; }
      set {
        unk3300ADJKIIJFNME_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageMarketStartStorePlayRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageMarketStartStorePlayRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StoreRound != other.StoreRound) return false;
      if (Unk3300LCCNEKGONFG != other.Unk3300LCCNEKGONFG) return false;
      if (Retcode != other.Retcode) return false;
      if (Unk3300ADJKIIJFNME != other.Unk3300ADJKIIJFNME) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StoreRound != 0) hash ^= StoreRound.GetHashCode();
      if (Unk3300LCCNEKGONFG != 0) hash ^= Unk3300LCCNEKGONFG.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3300ADJKIIJFNME != 0) hash ^= Unk3300ADJKIIJFNME.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Unk3300LCCNEKGONFG != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300LCCNEKGONFG);
      }
      if (StoreRound != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StoreRound);
      }
      if (Unk3300ADJKIIJFNME != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300ADJKIIJFNME);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Unk3300LCCNEKGONFG != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300LCCNEKGONFG);
      }
      if (StoreRound != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StoreRound);
      }
      if (Unk3300ADJKIIJFNME != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300ADJKIIJFNME);
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
      if (StoreRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreRound);
      }
      if (Unk3300LCCNEKGONFG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LCCNEKGONFG);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3300ADJKIIJFNME != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300ADJKIIJFNME);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageMarketStartStorePlayRsp other) {
      if (other == null) {
        return;
      }
      if (other.StoreRound != 0) {
        StoreRound = other.StoreRound;
      }
      if (other.Unk3300LCCNEKGONFG != 0) {
        Unk3300LCCNEKGONFG = other.Unk3300LCCNEKGONFG;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3300ADJKIIJFNME != 0) {
        Unk3300ADJKIIJFNME = other.Unk3300ADJKIIJFNME;
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
          case 8: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            Unk3300LCCNEKGONFG = input.ReadUInt32();
            break;
          }
          case 80: {
            StoreRound = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300ADJKIIJFNME = input.ReadUInt32();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            Unk3300LCCNEKGONFG = input.ReadUInt32();
            break;
          }
          case 80: {
            StoreRound = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300ADJKIIJFNME = input.ReadUInt32();
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
