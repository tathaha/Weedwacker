// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from SumoActivityDetailInfo.proto</summary>
  public static partial class SumoActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SumoActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SumoActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTdW1vQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGhNTdW1vU3RhZ2VEYXRh",
            "LnByb3RvItQBChZTdW1vQWN0aXZpdHlEZXRhaWxJbmZvEhUKDWRpZmZpY3Vs",
            "dHlfaWQYCyABKA0SQQoOc3Vtb19zdGFnZV9tYXAYDSADKAsyKS5TdW1vQWN0",
            "aXZpdHlEZXRhaWxJbmZvLlN1bW9TdGFnZU1hcEVudHJ5EhsKE1VuazI3MDBf",
            "TklKSUFKTUZMTEQYDiABKA0aQwoRU3Vtb1N0YWdlTWFwRW50cnkSCwoDa2V5",
            "GAEgASgNEh0KBXZhbHVlGAIgASgLMg4uU3Vtb1N0YWdlRGF0YToCOAFCGqoC",
            "F1dlZWR3YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.SumoStageDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.SumoActivityDetailInfo), global::Weedwacker.Server.Proto.SumoActivityDetailInfo.Parser, new[]{ "DifficultyId", "SumoStageMap", "Unk2700NIJIAJMFLLD" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SumoActivityDetailInfo : pb::IMessage<SumoActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SumoActivityDetailInfo> _parser = new pb::MessageParser<SumoActivityDetailInfo>(() => new SumoActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SumoActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.SumoActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoActivityDetailInfo(SumoActivityDetailInfo other) : this() {
      difficultyId_ = other.difficultyId_;
      sumoStageMap_ = other.sumoStageMap_.Clone();
      unk2700NIJIAJMFLLD_ = other.unk2700NIJIAJMFLLD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoActivityDetailInfo Clone() {
      return new SumoActivityDetailInfo(this);
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 11;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "sumo_stage_map" field.</summary>
    public const int SumoStageMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, global::Weedwacker.Server.Proto.SumoStageData>.Codec _map_sumoStageMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Server.Proto.SumoStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Server.Proto.SumoStageData.Parser), 106);
    private readonly pbc::MapField<uint, global::Weedwacker.Server.Proto.SumoStageData> sumoStageMap_ = new pbc::MapField<uint, global::Weedwacker.Server.Proto.SumoStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Server.Proto.SumoStageData> SumoStageMap {
      get { return sumoStageMap_; }
    }

    /// <summary>Field number for the "Unk2700_NIJIAJMFLLD" field.</summary>
    public const int Unk2700NIJIAJMFLLDFieldNumber = 14;
    private uint unk2700NIJIAJMFLLD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700NIJIAJMFLLD {
      get { return unk2700NIJIAJMFLLD_; }
      set {
        unk2700NIJIAJMFLLD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SumoActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SumoActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DifficultyId != other.DifficultyId) return false;
      if (!SumoStageMap.Equals(other.SumoStageMap)) return false;
      if (Unk2700NIJIAJMFLLD != other.Unk2700NIJIAJMFLLD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      hash ^= SumoStageMap.GetHashCode();
      if (Unk2700NIJIAJMFLLD != 0) hash ^= Unk2700NIJIAJMFLLD.GetHashCode();
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
      if (DifficultyId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DifficultyId);
      }
      sumoStageMap_.WriteTo(output, _map_sumoStageMap_codec);
      if (Unk2700NIJIAJMFLLD != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2700NIJIAJMFLLD);
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
      if (DifficultyId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DifficultyId);
      }
      sumoStageMap_.WriteTo(ref output, _map_sumoStageMap_codec);
      if (Unk2700NIJIAJMFLLD != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk2700NIJIAJMFLLD);
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
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      size += sumoStageMap_.CalculateSize(_map_sumoStageMap_codec);
      if (Unk2700NIJIAJMFLLD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700NIJIAJMFLLD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SumoActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      sumoStageMap_.Add(other.sumoStageMap_);
      if (other.Unk2700NIJIAJMFLLD != 0) {
        Unk2700NIJIAJMFLLD = other.Unk2700NIJIAJMFLLD;
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
          case 88: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 106: {
            sumoStageMap_.AddEntriesFrom(input, _map_sumoStageMap_codec);
            break;
          }
          case 112: {
            Unk2700NIJIAJMFLLD = input.ReadUInt32();
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
          case 88: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 106: {
            sumoStageMap_.AddEntriesFrom(ref input, _map_sumoStageMap_codec);
            break;
          }
          case 112: {
            Unk2700NIJIAJMFLLD = input.ReadUInt32();
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