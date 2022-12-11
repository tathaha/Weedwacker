// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TanukiTravelActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TanukiTravelActivityDetailInfo.proto</summary>
  public static partial class TanukiTravelActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TanukiTravelActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TanukiTravelActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRUYW51a2lUcmF2ZWxBY3Rpdml0eURldGFpbEluZm8ucHJvdG8SH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8aG1RhbnVraVRyYXZlbExldmVs",
            "RGF0YS5wcm90byK4AQoeVGFudWtpVHJhdmVsQWN0aXZpdHlEZXRhaWxJbmZv",
            "El0KHXRhbnVraV90cmF2ZWxfbGV2ZWxfZGF0YV9saXN0GAUgAygLMjYuV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5UYW51a2lUcmF2ZWxMZXZl",
            "bERhdGESGQoRaXNfY29udGVudF9jbG9zZWQYDCABKAgSHAoUZmluaXNoZWRf",
            "bGV2ZWxfaW5kZXgYDyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TanukiTravelActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.TanukiTravelActivityDetailInfo.Parser, new[]{ "TanukiTravelLevelDataList", "IsContentClosed", "FinishedLevelIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TanukiTravelActivityDetailInfo : pb::IMessage<TanukiTravelActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TanukiTravelActivityDetailInfo> _parser = new pb::MessageParser<TanukiTravelActivityDetailInfo>(() => new TanukiTravelActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TanukiTravelActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TanukiTravelActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelActivityDetailInfo(TanukiTravelActivityDetailInfo other) : this() {
      tanukiTravelLevelDataList_ = other.tanukiTravelLevelDataList_.Clone();
      isContentClosed_ = other.isContentClosed_;
      finishedLevelIndex_ = other.finishedLevelIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TanukiTravelActivityDetailInfo Clone() {
      return new TanukiTravelActivityDetailInfo(this);
    }

    /// <summary>Field number for the "tanuki_travel_level_data_list" field.</summary>
    public const int TanukiTravelLevelDataListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelData> _repeated_tanukiTravelLevelDataList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelData> tanukiTravelLevelDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.TanukiTravelLevelData> TanukiTravelLevelDataList {
      get { return tanukiTravelLevelDataList_; }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 12;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "finished_level_index" field.</summary>
    public const int FinishedLevelIndexFieldNumber = 15;
    private uint finishedLevelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishedLevelIndex {
      get { return finishedLevelIndex_; }
      set {
        finishedLevelIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TanukiTravelActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TanukiTravelActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!tanukiTravelLevelDataList_.Equals(other.tanukiTravelLevelDataList_)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (FinishedLevelIndex != other.FinishedLevelIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= tanukiTravelLevelDataList_.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (FinishedLevelIndex != 0) hash ^= FinishedLevelIndex.GetHashCode();
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
      tanukiTravelLevelDataList_.WriteTo(output, _repeated_tanukiTravelLevelDataList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
      }
      if (FinishedLevelIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinishedLevelIndex);
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
      tanukiTravelLevelDataList_.WriteTo(ref output, _repeated_tanukiTravelLevelDataList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsContentClosed);
      }
      if (FinishedLevelIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinishedLevelIndex);
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
      size += tanukiTravelLevelDataList_.CalculateSize(_repeated_tanukiTravelLevelDataList_codec);
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (FinishedLevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishedLevelIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TanukiTravelActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      tanukiTravelLevelDataList_.Add(other.tanukiTravelLevelDataList_);
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.FinishedLevelIndex != 0) {
        FinishedLevelIndex = other.FinishedLevelIndex;
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
          case 42: {
            tanukiTravelLevelDataList_.AddEntriesFrom(input, _repeated_tanukiTravelLevelDataList_codec);
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 120: {
            FinishedLevelIndex = input.ReadUInt32();
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
          case 42: {
            tanukiTravelLevelDataList_.AddEntriesFrom(ref input, _repeated_tanukiTravelLevelDataList_codec);
            break;
          }
          case 96: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 120: {
            FinishedLevelIndex = input.ReadUInt32();
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
