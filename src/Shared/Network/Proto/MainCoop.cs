// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MainCoop.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MainCoop.proto</summary>
  public static partial class MainCoopReflection {

    #region Descriptor
    /// <summary>File descriptor for MainCoop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MainCoopReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5NYWluQ29vcC5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90byKXBQoITWFpbkNvb3ASQAoGc3RhdHVzGAYgASgOMjAuV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90by5NYWluQ29vcC5TdGF0dXMSXgoTVW5r",
            "MzMwMF9KRlBMRURMTkpQRhgFIAMoCzJBLldlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8uTWFpbkNvb3AuVW5rMzMwMEpGUExFRExOSlBGRW50cnkS",
            "XgoTVW5rMzMwMF9PTUVFTUZKRktCSBgHIAMoCzJBLldlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8uTWFpbkNvb3AuVW5rMzMwME9NRUVNRkpGS0JI",
            "RW50cnkSFwoPc2VsZl9jb25maWRlbmNlGAkgASgNEgoKAmlkGAEgASgNEhoK",
            "EnNhdmVfcG9pbnRfaWRfbGlzdBgKIAMoDRJVCg9zZWVuX2VuZGluZ19tYXAY",
            "DSADKAsyPC5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLk1haW5D",
            "b29wLlNlZW5FbmRpbmdNYXBFbnRyeRo5ChdVbmszMzAwSkZQTEVETE5KUEZF",
            "bnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKAU6AjgBGjkKF1VuazMz",
            "MDBPTUVFTUZKRktCSEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEo",
            "BToCOAEaNAoSU2VlbkVuZGluZ01hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2",
            "YWx1ZRgCIAEoDToCOAEiRQoGU3RhdHVzEhIKDlNUQVRVU19JTlZBTElEEAAS",
            "EgoOU1RBVFVTX1JVTk5JTkcQARITCg9TVEFUVVNfRklOSVNIRUQQAmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MainCoop), global::Weedwacker.Shared.Network.Proto.MainCoop.Parser, new[]{ "Status", "Unk3300JFPLEDLNJPF", "Unk3300OMEEMFJFKBH", "SelfConfidence", "Id", "SavePointIdList", "SeenEndingMap" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status) }, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MainCoop : pb::IMessage<MainCoop>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MainCoop> _parser = new pb::MessageParser<MainCoop>(() => new MainCoop());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MainCoop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MainCoopReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainCoop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainCoop(MainCoop other) : this() {
      status_ = other.status_;
      unk3300JFPLEDLNJPF_ = other.unk3300JFPLEDLNJPF_.Clone();
      unk3300OMEEMFJFKBH_ = other.unk3300OMEEMFJFKBH_.Clone();
      selfConfidence_ = other.selfConfidence_;
      id_ = other.id_;
      savePointIdList_ = other.savePointIdList_.Clone();
      seenEndingMap_ = other.seenEndingMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainCoop Clone() {
      return new MainCoop(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status status_ = global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JFPLEDLNJPF" field.</summary>
    public const int Unk3300JFPLEDLNJPFFieldNumber = 5;
    private static readonly pbc::MapField<uint, int>.Codec _map_unk3300JFPLEDLNJPF_codec
        = new pbc::MapField<uint, int>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 42);
    private readonly pbc::MapField<uint, int> unk3300JFPLEDLNJPF_ = new pbc::MapField<uint, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, int> Unk3300JFPLEDLNJPF {
      get { return unk3300JFPLEDLNJPF_; }
    }

    /// <summary>Field number for the "Unk3300_OMEEMFJFKBH" field.</summary>
    public const int Unk3300OMEEMFJFKBHFieldNumber = 7;
    private static readonly pbc::MapField<uint, int>.Codec _map_unk3300OMEEMFJFKBH_codec
        = new pbc::MapField<uint, int>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 58);
    private readonly pbc::MapField<uint, int> unk3300OMEEMFJFKBH_ = new pbc::MapField<uint, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, int> Unk3300OMEEMFJFKBH {
      get { return unk3300OMEEMFJFKBH_; }
    }

    /// <summary>Field number for the "self_confidence" field.</summary>
    public const int SelfConfidenceFieldNumber = 9;
    private uint selfConfidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelfConfidence {
      get { return selfConfidence_; }
      set {
        selfConfidence_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "save_point_id_list" field.</summary>
    public const int SavePointIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_savePointIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> savePointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SavePointIdList {
      get { return savePointIdList_; }
    }

    /// <summary>Field number for the "seen_ending_map" field.</summary>
    public const int SeenEndingMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_seenEndingMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> seenEndingMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SeenEndingMap {
      get { return seenEndingMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MainCoop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MainCoop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!Unk3300JFPLEDLNJPF.Equals(other.Unk3300JFPLEDLNJPF)) return false;
      if (!Unk3300OMEEMFJFKBH.Equals(other.Unk3300OMEEMFJFKBH)) return false;
      if (SelfConfidence != other.SelfConfidence) return false;
      if (Id != other.Id) return false;
      if(!savePointIdList_.Equals(other.savePointIdList_)) return false;
      if (!SeenEndingMap.Equals(other.SeenEndingMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status.Invalid) hash ^= Status.GetHashCode();
      hash ^= Unk3300JFPLEDLNJPF.GetHashCode();
      hash ^= Unk3300OMEEMFJFKBH.GetHashCode();
      if (SelfConfidence != 0) hash ^= SelfConfidence.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= savePointIdList_.GetHashCode();
      hash ^= SeenEndingMap.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      unk3300JFPLEDLNJPF_.WriteTo(output, _map_unk3300JFPLEDLNJPF_codec);
      if (Status != global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status.Invalid) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      unk3300OMEEMFJFKBH_.WriteTo(output, _map_unk3300OMEEMFJFKBH_codec);
      if (SelfConfidence != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SelfConfidence);
      }
      savePointIdList_.WriteTo(output, _repeated_savePointIdList_codec);
      seenEndingMap_.WriteTo(output, _map_seenEndingMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      unk3300JFPLEDLNJPF_.WriteTo(ref output, _map_unk3300JFPLEDLNJPF_codec);
      if (Status != global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status.Invalid) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      unk3300OMEEMFJFKBH_.WriteTo(ref output, _map_unk3300OMEEMFJFKBH_codec);
      if (SelfConfidence != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SelfConfidence);
      }
      savePointIdList_.WriteTo(ref output, _repeated_savePointIdList_codec);
      seenEndingMap_.WriteTo(ref output, _map_seenEndingMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Status != global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += unk3300JFPLEDLNJPF_.CalculateSize(_map_unk3300JFPLEDLNJPF_codec);
      size += unk3300OMEEMFJFKBH_.CalculateSize(_map_unk3300OMEEMFJFKBH_codec);
      if (SelfConfidence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelfConfidence);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += savePointIdList_.CalculateSize(_repeated_savePointIdList_codec);
      size += seenEndingMap_.CalculateSize(_map_seenEndingMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MainCoop other) {
      if (other == null) {
        return;
      }
      if (other.Status != global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status.Invalid) {
        Status = other.Status;
      }
      unk3300JFPLEDLNJPF_.Add(other.unk3300JFPLEDLNJPF_);
      unk3300OMEEMFJFKBH_.Add(other.unk3300OMEEMFJFKBH_);
      if (other.SelfConfidence != 0) {
        SelfConfidence = other.SelfConfidence;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      savePointIdList_.Add(other.savePointIdList_);
      seenEndingMap_.Add(other.seenEndingMap_);
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
            Id = input.ReadUInt32();
            break;
          }
          case 42: {
            unk3300JFPLEDLNJPF_.AddEntriesFrom(input, _map_unk3300JFPLEDLNJPF_codec);
            break;
          }
          case 48: {
            Status = (global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status) input.ReadEnum();
            break;
          }
          case 58: {
            unk3300OMEEMFJFKBH_.AddEntriesFrom(input, _map_unk3300OMEEMFJFKBH_codec);
            break;
          }
          case 72: {
            SelfConfidence = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            savePointIdList_.AddEntriesFrom(input, _repeated_savePointIdList_codec);
            break;
          }
          case 106: {
            seenEndingMap_.AddEntriesFrom(input, _map_seenEndingMap_codec);
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
            Id = input.ReadUInt32();
            break;
          }
          case 42: {
            unk3300JFPLEDLNJPF_.AddEntriesFrom(ref input, _map_unk3300JFPLEDLNJPF_codec);
            break;
          }
          case 48: {
            Status = (global::Weedwacker.Shared.Network.Proto.MainCoop.Types.Status) input.ReadEnum();
            break;
          }
          case 58: {
            unk3300OMEEMFJFKBH_.AddEntriesFrom(ref input, _map_unk3300OMEEMFJFKBH_codec);
            break;
          }
          case 72: {
            SelfConfidence = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            savePointIdList_.AddEntriesFrom(ref input, _repeated_savePointIdList_codec);
            break;
          }
          case 106: {
            seenEndingMap_.AddEntriesFrom(ref input, _map_seenEndingMap_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MainCoop message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("STATUS_INVALID")] Invalid = 0,
        [pbr::OriginalName("STATUS_RUNNING")] Running = 1,
        [pbr::OriginalName("STATUS_FINISHED")] Finished = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
