// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetGachaInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetGachaInfoRsp.proto</summary>
  public static partial class GetGachaInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetGachaInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetGachaInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHZXRHYWNoYUluZm9Sc3AucHJvdG8aD0dhY2hhSW5mby5wcm90byKyAQoP",
            "R2V0R2FjaGFJbmZvUnNwEg8KB3JldGNvZGUYDiABKAUSGQoRZGFpbHlfZ2Fj",
            "aGFfdGltZXMYBiABKA0SIwoPZ2FjaGFfaW5mb19saXN0GAogAygLMgouR2Fj",
            "aGFJbmZvEhsKE1VuazMzMDBfT0hGTUhJSEpIUEoYBCABKAgSFAoMZ2FjaGFf",
            "cmFuZG9tGAkgASgNEhsKE1VuazMzMDBfSEJJTElBRUlITksYAyABKAhCIqoC",
            "H1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GachaInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetGachaInfoRsp), global::Weedwacker.Shared.Network.Proto.GetGachaInfoRsp.Parser, new[]{ "Retcode", "DailyGachaTimes", "GachaInfoList", "Unk3300OHFMHIHJHPJ", "GachaRandom", "Unk3300HBILIAEIHNK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1530;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetGachaInfoRsp : pb::IMessage<GetGachaInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetGachaInfoRsp> _parser = new pb::MessageParser<GetGachaInfoRsp>(() => new GetGachaInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetGachaInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetGachaInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGachaInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGachaInfoRsp(GetGachaInfoRsp other) : this() {
      retcode_ = other.retcode_;
      dailyGachaTimes_ = other.dailyGachaTimes_;
      gachaInfoList_ = other.gachaInfoList_.Clone();
      unk3300OHFMHIHJHPJ_ = other.unk3300OHFMHIHJHPJ_;
      gachaRandom_ = other.gachaRandom_;
      unk3300HBILIAEIHNK_ = other.unk3300HBILIAEIHNK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetGachaInfoRsp Clone() {
      return new GetGachaInfoRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "daily_gacha_times" field.</summary>
    public const int DailyGachaTimesFieldNumber = 6;
    private uint dailyGachaTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DailyGachaTimes {
      get { return dailyGachaTimes_; }
      set {
        dailyGachaTimes_ = value;
      }
    }

    /// <summary>Field number for the "gacha_info_list" field.</summary>
    public const int GachaInfoListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GachaInfo> _repeated_gachaInfoList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.GachaInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaInfo> gachaInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GachaInfo> GachaInfoList {
      get { return gachaInfoList_; }
    }

    /// <summary>Field number for the "Unk3300_OHFMHIHJHPJ" field.</summary>
    public const int Unk3300OHFMHIHJHPJFieldNumber = 4;
    private bool unk3300OHFMHIHJHPJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300OHFMHIHJHPJ {
      get { return unk3300OHFMHIHJHPJ_; }
      set {
        unk3300OHFMHIHJHPJ_ = value;
      }
    }

    /// <summary>Field number for the "gacha_random" field.</summary>
    public const int GachaRandomFieldNumber = 9;
    private uint gachaRandom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaRandom {
      get { return gachaRandom_; }
      set {
        gachaRandom_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HBILIAEIHNK" field.</summary>
    public const int Unk3300HBILIAEIHNKFieldNumber = 3;
    private bool unk3300HBILIAEIHNK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300HBILIAEIHNK {
      get { return unk3300HBILIAEIHNK_; }
      set {
        unk3300HBILIAEIHNK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetGachaInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetGachaInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (DailyGachaTimes != other.DailyGachaTimes) return false;
      if(!gachaInfoList_.Equals(other.gachaInfoList_)) return false;
      if (Unk3300OHFMHIHJHPJ != other.Unk3300OHFMHIHJHPJ) return false;
      if (GachaRandom != other.GachaRandom) return false;
      if (Unk3300HBILIAEIHNK != other.Unk3300HBILIAEIHNK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (DailyGachaTimes != 0) hash ^= DailyGachaTimes.GetHashCode();
      hash ^= gachaInfoList_.GetHashCode();
      if (Unk3300OHFMHIHJHPJ != false) hash ^= Unk3300OHFMHIHJHPJ.GetHashCode();
      if (GachaRandom != 0) hash ^= GachaRandom.GetHashCode();
      if (Unk3300HBILIAEIHNK != false) hash ^= Unk3300HBILIAEIHNK.GetHashCode();
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
      if (Unk3300HBILIAEIHNK != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300HBILIAEIHNK);
      }
      if (Unk3300OHFMHIHJHPJ != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300OHFMHIHJHPJ);
      }
      if (DailyGachaTimes != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DailyGachaTimes);
      }
      if (GachaRandom != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GachaRandom);
      }
      gachaInfoList_.WriteTo(output, _repeated_gachaInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (Unk3300HBILIAEIHNK != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300HBILIAEIHNK);
      }
      if (Unk3300OHFMHIHJHPJ != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300OHFMHIHJHPJ);
      }
      if (DailyGachaTimes != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DailyGachaTimes);
      }
      if (GachaRandom != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GachaRandom);
      }
      gachaInfoList_.WriteTo(ref output, _repeated_gachaInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (DailyGachaTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DailyGachaTimes);
      }
      size += gachaInfoList_.CalculateSize(_repeated_gachaInfoList_codec);
      if (Unk3300OHFMHIHJHPJ != false) {
        size += 1 + 1;
      }
      if (GachaRandom != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaRandom);
      }
      if (Unk3300HBILIAEIHNK != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetGachaInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.DailyGachaTimes != 0) {
        DailyGachaTimes = other.DailyGachaTimes;
      }
      gachaInfoList_.Add(other.gachaInfoList_);
      if (other.Unk3300OHFMHIHJHPJ != false) {
        Unk3300OHFMHIHJHPJ = other.Unk3300OHFMHIHJHPJ;
      }
      if (other.GachaRandom != 0) {
        GachaRandom = other.GachaRandom;
      }
      if (other.Unk3300HBILIAEIHNK != false) {
        Unk3300HBILIAEIHNK = other.Unk3300HBILIAEIHNK;
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
            Unk3300HBILIAEIHNK = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300OHFMHIHJHPJ = input.ReadBool();
            break;
          }
          case 48: {
            DailyGachaTimes = input.ReadUInt32();
            break;
          }
          case 72: {
            GachaRandom = input.ReadUInt32();
            break;
          }
          case 82: {
            gachaInfoList_.AddEntriesFrom(input, _repeated_gachaInfoList_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
            Unk3300HBILIAEIHNK = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300OHFMHIHJHPJ = input.ReadBool();
            break;
          }
          case 48: {
            DailyGachaTimes = input.ReadUInt32();
            break;
          }
          case 72: {
            GachaRandom = input.ReadUInt32();
            break;
          }
          case 82: {
            gachaInfoList_.AddEntriesFrom(ref input, _repeated_gachaInfoList_codec);
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
