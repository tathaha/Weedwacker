// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from GachaActivityDetailInfo.proto</summary>
  public static partial class GachaActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GachaActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GachaActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HYWNoYUFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxoQR2FjaGFTdGFnZS5w",
            "cm90byKrAwoXR2FjaGFBY3Rpdml0eURldGFpbEluZm8SGwoTVW5rMjcwMF9Q",
            "SURIS05MREFMQhgGIAMoDRIlChBnYWNoYV9zdGFnZV9saXN0GAQgAygLMgsu",
            "R2FjaGFTdGFnZRJNChNVbmsyNzAwX0tPSEtCQ0FCSUNEGAggAygLMjAuR2Fj",
            "aGFBY3Rpdml0eURldGFpbEluZm8uVW5rMjcwMEtPSEtCQ0FCSUNERW50cnkS",
            "GwoTVW5rMjcwMF9DRFBBUEJJT1BDQRgDIAEoDRJNChNVbmsyNzAwX0RBQ0hI",
            "SU5MRERKGAUgAygLMjAuR2FjaGFBY3Rpdml0eURldGFpbEluZm8uVW5rMjcw",
            "MERBQ0hISU5MRERKRW50cnkSGwoTVW5rMjcwMF9GR0ZHTERJSkpFSxgMIAEo",
            "DRo5ChdVbmsyNzAwS09IS0JDQUJJQ0RFbnRyeRILCgNrZXkYASABKA0SDQoF",
            "dmFsdWUYAiABKA06AjgBGjkKF1VuazI3MDBEQUNISElOTERESkVudHJ5EgsK",
            "A2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCGqoCF1dlZWR3YWNrZXIu",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.GachaStageReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.GachaActivityDetailInfo), global::Weedwacker.Server.Proto.GachaActivityDetailInfo.Parser, new[]{ "Unk2700PIDHKNLDALB", "GachaStageList", "Unk2700KOHKBCABICD", "Unk2700CDPAPBIOPCA", "Unk2700DACHHINLDDJ", "Unk2700FGFGLDIJJEK" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GachaActivityDetailInfo : pb::IMessage<GachaActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaActivityDetailInfo> _parser = new pb::MessageParser<GachaActivityDetailInfo>(() => new GachaActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.GachaActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityDetailInfo(GachaActivityDetailInfo other) : this() {
      unk2700PIDHKNLDALB_ = other.unk2700PIDHKNLDALB_.Clone();
      gachaStageList_ = other.gachaStageList_.Clone();
      unk2700KOHKBCABICD_ = other.unk2700KOHKBCABICD_.Clone();
      unk2700CDPAPBIOPCA_ = other.unk2700CDPAPBIOPCA_;
      unk2700DACHHINLDDJ_ = other.unk2700DACHHINLDDJ_.Clone();
      unk2700FGFGLDIJJEK_ = other.unk2700FGFGLDIJJEK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityDetailInfo Clone() {
      return new GachaActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk2700_PIDHKNLDALB" field.</summary>
    public const int Unk2700PIDHKNLDALBFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_unk2700PIDHKNLDALB_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> unk2700PIDHKNLDALB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk2700PIDHKNLDALB {
      get { return unk2700PIDHKNLDALB_; }
    }

    /// <summary>Field number for the "gacha_stage_list" field.</summary>
    public const int GachaStageListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.GachaStage> _repeated_gachaStageList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Server.Proto.GachaStage.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.GachaStage> gachaStageList_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.GachaStage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.GachaStage> GachaStageList {
      get { return gachaStageList_; }
    }

    /// <summary>Field number for the "Unk2700_KOHKBCABICD" field.</summary>
    public const int Unk2700KOHKBCABICDFieldNumber = 8;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk2700KOHKBCABICD_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 66);
    private readonly pbc::MapField<uint, uint> unk2700KOHKBCABICD_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk2700KOHKBCABICD {
      get { return unk2700KOHKBCABICD_; }
    }

    /// <summary>Field number for the "Unk2700_CDPAPBIOPCA" field.</summary>
    public const int Unk2700CDPAPBIOPCAFieldNumber = 3;
    private uint unk2700CDPAPBIOPCA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700CDPAPBIOPCA {
      get { return unk2700CDPAPBIOPCA_; }
      set {
        unk2700CDPAPBIOPCA_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_DACHHINLDDJ" field.</summary>
    public const int Unk2700DACHHINLDDJFieldNumber = 5;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk2700DACHHINLDDJ_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 42);
    private readonly pbc::MapField<uint, uint> unk2700DACHHINLDDJ_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk2700DACHHINLDDJ {
      get { return unk2700DACHHINLDDJ_; }
    }

    /// <summary>Field number for the "Unk2700_FGFGLDIJJEK" field.</summary>
    public const int Unk2700FGFGLDIJJEKFieldNumber = 12;
    private uint unk2700FGFGLDIJJEK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700FGFGLDIJJEK {
      get { return unk2700FGFGLDIJJEK_; }
      set {
        unk2700FGFGLDIJJEK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700PIDHKNLDALB_.Equals(other.unk2700PIDHKNLDALB_)) return false;
      if(!gachaStageList_.Equals(other.gachaStageList_)) return false;
      if (!Unk2700KOHKBCABICD.Equals(other.Unk2700KOHKBCABICD)) return false;
      if (Unk2700CDPAPBIOPCA != other.Unk2700CDPAPBIOPCA) return false;
      if (!Unk2700DACHHINLDDJ.Equals(other.Unk2700DACHHINLDDJ)) return false;
      if (Unk2700FGFGLDIJJEK != other.Unk2700FGFGLDIJJEK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700PIDHKNLDALB_.GetHashCode();
      hash ^= gachaStageList_.GetHashCode();
      hash ^= Unk2700KOHKBCABICD.GetHashCode();
      if (Unk2700CDPAPBIOPCA != 0) hash ^= Unk2700CDPAPBIOPCA.GetHashCode();
      hash ^= Unk2700DACHHINLDDJ.GetHashCode();
      if (Unk2700FGFGLDIJJEK != 0) hash ^= Unk2700FGFGLDIJJEK.GetHashCode();
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
      if (Unk2700CDPAPBIOPCA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk2700CDPAPBIOPCA);
      }
      gachaStageList_.WriteTo(output, _repeated_gachaStageList_codec);
      unk2700DACHHINLDDJ_.WriteTo(output, _map_unk2700DACHHINLDDJ_codec);
      unk2700PIDHKNLDALB_.WriteTo(output, _repeated_unk2700PIDHKNLDALB_codec);
      unk2700KOHKBCABICD_.WriteTo(output, _map_unk2700KOHKBCABICD_codec);
      if (Unk2700FGFGLDIJJEK != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk2700FGFGLDIJJEK);
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
      if (Unk2700CDPAPBIOPCA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk2700CDPAPBIOPCA);
      }
      gachaStageList_.WriteTo(ref output, _repeated_gachaStageList_codec);
      unk2700DACHHINLDDJ_.WriteTo(ref output, _map_unk2700DACHHINLDDJ_codec);
      unk2700PIDHKNLDALB_.WriteTo(ref output, _repeated_unk2700PIDHKNLDALB_codec);
      unk2700KOHKBCABICD_.WriteTo(ref output, _map_unk2700KOHKBCABICD_codec);
      if (Unk2700FGFGLDIJJEK != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk2700FGFGLDIJJEK);
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
      size += unk2700PIDHKNLDALB_.CalculateSize(_repeated_unk2700PIDHKNLDALB_codec);
      size += gachaStageList_.CalculateSize(_repeated_gachaStageList_codec);
      size += unk2700KOHKBCABICD_.CalculateSize(_map_unk2700KOHKBCABICD_codec);
      if (Unk2700CDPAPBIOPCA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700CDPAPBIOPCA);
      }
      size += unk2700DACHHINLDDJ_.CalculateSize(_map_unk2700DACHHINLDDJ_codec);
      if (Unk2700FGFGLDIJJEK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700FGFGLDIJJEK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      unk2700PIDHKNLDALB_.Add(other.unk2700PIDHKNLDALB_);
      gachaStageList_.Add(other.gachaStageList_);
      unk2700KOHKBCABICD_.Add(other.unk2700KOHKBCABICD_);
      if (other.Unk2700CDPAPBIOPCA != 0) {
        Unk2700CDPAPBIOPCA = other.Unk2700CDPAPBIOPCA;
      }
      unk2700DACHHINLDDJ_.Add(other.unk2700DACHHINLDDJ_);
      if (other.Unk2700FGFGLDIJJEK != 0) {
        Unk2700FGFGLDIJJEK = other.Unk2700FGFGLDIJJEK;
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
            Unk2700CDPAPBIOPCA = input.ReadUInt32();
            break;
          }
          case 34: {
            gachaStageList_.AddEntriesFrom(input, _repeated_gachaStageList_codec);
            break;
          }
          case 42: {
            unk2700DACHHINLDDJ_.AddEntriesFrom(input, _map_unk2700DACHHINLDDJ_codec);
            break;
          }
          case 50:
          case 48: {
            unk2700PIDHKNLDALB_.AddEntriesFrom(input, _repeated_unk2700PIDHKNLDALB_codec);
            break;
          }
          case 66: {
            unk2700KOHKBCABICD_.AddEntriesFrom(input, _map_unk2700KOHKBCABICD_codec);
            break;
          }
          case 96: {
            Unk2700FGFGLDIJJEK = input.ReadUInt32();
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
            Unk2700CDPAPBIOPCA = input.ReadUInt32();
            break;
          }
          case 34: {
            gachaStageList_.AddEntriesFrom(ref input, _repeated_gachaStageList_codec);
            break;
          }
          case 42: {
            unk2700DACHHINLDDJ_.AddEntriesFrom(ref input, _map_unk2700DACHHINLDDJ_codec);
            break;
          }
          case 50:
          case 48: {
            unk2700PIDHKNLDALB_.AddEntriesFrom(ref input, _repeated_unk2700PIDHKNLDALB_codec);
            break;
          }
          case 66: {
            unk2700KOHKBCABICD_.AddEntriesFrom(ref input, _map_unk2700KOHKBCABICD_codec);
            break;
          }
          case 96: {
            Unk2700FGFGLDIJJEK = input.ReadUInt32();
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