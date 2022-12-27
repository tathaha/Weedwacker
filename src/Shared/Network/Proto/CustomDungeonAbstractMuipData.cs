// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonAbstractMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeonAbstractMuipData.proto</summary>
  public static partial class CustomDungeonAbstractMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonAbstractMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonAbstractMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNDdXN0b21EdW5nZW9uQWJzdHJhY3RNdWlwRGF0YS5wcm90byLnAQodQ3Vz",
            "dG9tRHVuZ2VvbkFic3RyYWN0TXVpcERhdGESGgoSZmlyc3RfcHVibGlzaF90",
            "aW1lGAEgASgNEhkKEWxhc3RfcHVibGlzaF90aW1lGAIgASgNElQKFGJyaWNr",
            "X3N0YXRpc3RpY3NfbWFwGAMgAygLMjYuQ3VzdG9tRHVuZ2VvbkFic3RyYWN0",
            "TXVpcERhdGEuQnJpY2tTdGF0aXN0aWNzTWFwRW50cnkaOQoXQnJpY2tTdGF0",
            "aXN0aWNzTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4",
            "AUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipData), global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipData.Parser, new[]{ "FirstPublishTime", "LastPublishTime", "BrickStatisticsMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonAbstractMuipData : pb::IMessage<CustomDungeonAbstractMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonAbstractMuipData> _parser = new pb::MessageParser<CustomDungeonAbstractMuipData>(() => new CustomDungeonAbstractMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonAbstractMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CustomDungeonAbstractMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonAbstractMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonAbstractMuipData(CustomDungeonAbstractMuipData other) : this() {
      firstPublishTime_ = other.firstPublishTime_;
      lastPublishTime_ = other.lastPublishTime_;
      brickStatisticsMap_ = other.brickStatisticsMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonAbstractMuipData Clone() {
      return new CustomDungeonAbstractMuipData(this);
    }

    /// <summary>Field number for the "first_publish_time" field.</summary>
    public const int FirstPublishTimeFieldNumber = 1;
    private uint firstPublishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FirstPublishTime {
      get { return firstPublishTime_; }
      set {
        firstPublishTime_ = value;
      }
    }

    /// <summary>Field number for the "last_publish_time" field.</summary>
    public const int LastPublishTimeFieldNumber = 2;
    private uint lastPublishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastPublishTime {
      get { return lastPublishTime_; }
      set {
        lastPublishTime_ = value;
      }
    }

    /// <summary>Field number for the "brick_statistics_map" field.</summary>
    public const int BrickStatisticsMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_brickStatisticsMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> brickStatisticsMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> BrickStatisticsMap {
      get { return brickStatisticsMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonAbstractMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonAbstractMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FirstPublishTime != other.FirstPublishTime) return false;
      if (LastPublishTime != other.LastPublishTime) return false;
      if (!BrickStatisticsMap.Equals(other.BrickStatisticsMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FirstPublishTime != 0) hash ^= FirstPublishTime.GetHashCode();
      if (LastPublishTime != 0) hash ^= LastPublishTime.GetHashCode();
      hash ^= BrickStatisticsMap.GetHashCode();
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
      if (FirstPublishTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FirstPublishTime);
      }
      if (LastPublishTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LastPublishTime);
      }
      brickStatisticsMap_.WriteTo(output, _map_brickStatisticsMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FirstPublishTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FirstPublishTime);
      }
      if (LastPublishTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LastPublishTime);
      }
      brickStatisticsMap_.WriteTo(ref output, _map_brickStatisticsMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (FirstPublishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FirstPublishTime);
      }
      if (LastPublishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastPublishTime);
      }
      size += brickStatisticsMap_.CalculateSize(_map_brickStatisticsMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonAbstractMuipData other) {
      if (other == null) {
        return;
      }
      if (other.FirstPublishTime != 0) {
        FirstPublishTime = other.FirstPublishTime;
      }
      if (other.LastPublishTime != 0) {
        LastPublishTime = other.LastPublishTime;
      }
      brickStatisticsMap_.Add(other.brickStatisticsMap_);
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
            FirstPublishTime = input.ReadUInt32();
            break;
          }
          case 16: {
            LastPublishTime = input.ReadUInt32();
            break;
          }
          case 26: {
            brickStatisticsMap_.AddEntriesFrom(input, _map_brickStatisticsMap_codec);
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
            FirstPublishTime = input.ReadUInt32();
            break;
          }
          case 16: {
            LastPublishTime = input.ReadUInt32();
            break;
          }
          case 26: {
            brickStatisticsMap_.AddEntriesFrom(ref input, _map_brickStatisticsMap_codec);
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
