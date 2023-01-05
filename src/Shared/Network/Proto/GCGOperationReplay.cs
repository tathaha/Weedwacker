// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGOperationReplay.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGOperationReplay.proto</summary>
  public static partial class GCGOperationReplayReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGOperationReplay.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGOperationReplayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHQ0dPcGVyYXRpb25SZXBsYXkucHJvdG8aHUdDR1JlcGxheUNvbnRyb2xs",
            "ZXJEYXRhLnByb3RvGhxHQ0dSZXBsYXlPcGVyYXRpb25EYXRhLnByb3RvGhlV",
            "bmszMzAwX1BQS1BDT0NPTURILnByb3RvItQBChJHQ0dPcGVyYXRpb25SZXBs",
            "YXkSMQoTVW5rMzMwMF9GS0JMSklNQkhFQRgGIAMoCzIULlVuazMzMDBfUFBL",
            "UENPQ09NREgSDAoEc2VlZBgBIAEoDRI0ChNvcGVyYXRpb25fZGF0YV9saXN0",
            "GAggAygLMhcuR0NHUmVwbGF5T3BlcmF0aW9uRGF0YRIPCgdnYW1lX2lkGAIg",
            "ASgNEjYKFGNvbnRyb2xsZXJfZGF0YV9saXN0GAcgAygLMhguR0NHUmVwbGF5",
            "Q29udHJvbGxlckRhdGFCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGReplayControllerDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGReplayOperationDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk3300PPKPCOCOMDHReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGOperationReplay), global::Weedwacker.Shared.Network.Proto.GCGOperationReplay.Parser, new[]{ "Unk3300FKBLJIMBHEA", "Seed", "OperationDataList", "GameId", "ControllerDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGOperationReplay : pb::IMessage<GCGOperationReplay>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGOperationReplay> _parser = new pb::MessageParser<GCGOperationReplay>(() => new GCGOperationReplay());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGOperationReplay> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGOperationReplayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationReplay() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationReplay(GCGOperationReplay other) : this() {
      unk3300FKBLJIMBHEA_ = other.unk3300FKBLJIMBHEA_.Clone();
      seed_ = other.seed_;
      operationDataList_ = other.operationDataList_.Clone();
      gameId_ = other.gameId_;
      controllerDataList_ = other.controllerDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationReplay Clone() {
      return new GCGOperationReplay(this);
    }

    /// <summary>Field number for the "Unk3300_FKBLJIMBHEA" field.</summary>
    public const int Unk3300FKBLJIMBHEAFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk3300_PPKPCOCOMDH> _repeated_unk3300FKBLJIMBHEA_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.Unk3300_PPKPCOCOMDH.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3300_PPKPCOCOMDH> unk3300FKBLJIMBHEA_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3300_PPKPCOCOMDH>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk3300_PPKPCOCOMDH> Unk3300FKBLJIMBHEA {
      get { return unk3300FKBLJIMBHEA_; }
    }

    /// <summary>Field number for the "seed" field.</summary>
    public const int SeedFieldNumber = 1;
    private uint seed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Seed {
      get { return seed_; }
      set {
        seed_ = value;
      }
    }

    /// <summary>Field number for the "operation_data_list" field.</summary>
    public const int OperationDataListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGReplayOperationData> _repeated_operationDataList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.GCGReplayOperationData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGReplayOperationData> operationDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGReplayOperationData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGReplayOperationData> OperationDataList {
      get { return operationDataList_; }
    }

    /// <summary>Field number for the "game_id" field.</summary>
    public const int GameIdFieldNumber = 2;
    private uint gameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameId {
      get { return gameId_; }
      set {
        gameId_ = value;
      }
    }

    /// <summary>Field number for the "controller_data_list" field.</summary>
    public const int ControllerDataListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGReplayControllerData> _repeated_controllerDataList_codec
        = pb::FieldCodec.ForMessage(58, global::Weedwacker.Shared.Network.Proto.GCGReplayControllerData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGReplayControllerData> controllerDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGReplayControllerData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGReplayControllerData> ControllerDataList {
      get { return controllerDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGOperationReplay);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGOperationReplay other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk3300FKBLJIMBHEA_.Equals(other.unk3300FKBLJIMBHEA_)) return false;
      if (Seed != other.Seed) return false;
      if(!operationDataList_.Equals(other.operationDataList_)) return false;
      if (GameId != other.GameId) return false;
      if(!controllerDataList_.Equals(other.controllerDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk3300FKBLJIMBHEA_.GetHashCode();
      if (Seed != 0) hash ^= Seed.GetHashCode();
      hash ^= operationDataList_.GetHashCode();
      if (GameId != 0) hash ^= GameId.GetHashCode();
      hash ^= controllerDataList_.GetHashCode();
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
      if (Seed != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Seed);
      }
      if (GameId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameId);
      }
      unk3300FKBLJIMBHEA_.WriteTo(output, _repeated_unk3300FKBLJIMBHEA_codec);
      controllerDataList_.WriteTo(output, _repeated_controllerDataList_codec);
      operationDataList_.WriteTo(output, _repeated_operationDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Seed != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Seed);
      }
      if (GameId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GameId);
      }
      unk3300FKBLJIMBHEA_.WriteTo(ref output, _repeated_unk3300FKBLJIMBHEA_codec);
      controllerDataList_.WriteTo(ref output, _repeated_controllerDataList_codec);
      operationDataList_.WriteTo(ref output, _repeated_operationDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk3300FKBLJIMBHEA_.CalculateSize(_repeated_unk3300FKBLJIMBHEA_codec);
      if (Seed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Seed);
      }
      size += operationDataList_.CalculateSize(_repeated_operationDataList_codec);
      if (GameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameId);
      }
      size += controllerDataList_.CalculateSize(_repeated_controllerDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGOperationReplay other) {
      if (other == null) {
        return;
      }
      unk3300FKBLJIMBHEA_.Add(other.unk3300FKBLJIMBHEA_);
      if (other.Seed != 0) {
        Seed = other.Seed;
      }
      operationDataList_.Add(other.operationDataList_);
      if (other.GameId != 0) {
        GameId = other.GameId;
      }
      controllerDataList_.Add(other.controllerDataList_);
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
            Seed = input.ReadUInt32();
            break;
          }
          case 16: {
            GameId = input.ReadUInt32();
            break;
          }
          case 50: {
            unk3300FKBLJIMBHEA_.AddEntriesFrom(input, _repeated_unk3300FKBLJIMBHEA_codec);
            break;
          }
          case 58: {
            controllerDataList_.AddEntriesFrom(input, _repeated_controllerDataList_codec);
            break;
          }
          case 66: {
            operationDataList_.AddEntriesFrom(input, _repeated_operationDataList_codec);
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
            Seed = input.ReadUInt32();
            break;
          }
          case 16: {
            GameId = input.ReadUInt32();
            break;
          }
          case 50: {
            unk3300FKBLJIMBHEA_.AddEntriesFrom(ref input, _repeated_unk3300FKBLJIMBHEA_codec);
            break;
          }
          case 58: {
            controllerDataList_.AddEntriesFrom(ref input, _repeated_controllerDataList_codec);
            break;
          }
          case 66: {
            operationDataList_.AddEntriesFrom(ref input, _repeated_operationDataList_codec);
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
