// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EffigyActivityDetailInfo.proto</summary>
  public static partial class EffigyActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5FZmZpZ3lBY3Rpdml0eURldGFpbEluZm8ucHJvdG8aFUVmZmlneURhaWx5",
            "SW5mby5wcm90byKVAQoYRWZmaWd5QWN0aXZpdHlEZXRhaWxJbmZvEhoKEmxh",
            "c3RfZGlmZmljdWx0eV9pZBgIIAEoDRIfChd0YWtlbl9yZXdhcmRfaW5kZXhf",
            "bGlzdBgNIAMoDRIRCgljdXJfc2NvcmUYBSABKA0SKQoPZGFpbHlfaW5mb19s",
            "aXN0GAQgAygLMhAuRWZmaWd5RGFpbHlJbmZvQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.EffigyDailyInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EffigyActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.EffigyActivityDetailInfo.Parser, new[]{ "LastDifficultyId", "TakenRewardIndexList", "CurScore", "DailyInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EffigyActivityDetailInfo : pb::IMessage<EffigyActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyActivityDetailInfo> _parser = new pb::MessageParser<EffigyActivityDetailInfo>(() => new EffigyActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EffigyActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyActivityDetailInfo(EffigyActivityDetailInfo other) : this() {
      lastDifficultyId_ = other.lastDifficultyId_;
      takenRewardIndexList_ = other.takenRewardIndexList_.Clone();
      curScore_ = other.curScore_;
      dailyInfoList_ = other.dailyInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyActivityDetailInfo Clone() {
      return new EffigyActivityDetailInfo(this);
    }

    /// <summary>Field number for the "last_difficulty_id" field.</summary>
    public const int LastDifficultyIdFieldNumber = 8;
    private uint lastDifficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastDifficultyId {
      get { return lastDifficultyId_; }
      set {
        lastDifficultyId_ = value;
      }
    }

    /// <summary>Field number for the "taken_reward_index_list" field.</summary>
    public const int TakenRewardIndexListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_takenRewardIndexList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> takenRewardIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenRewardIndexList {
      get { return takenRewardIndexList_; }
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 5;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    /// <summary>Field number for the "daily_info_list" field.</summary>
    public const int DailyInfoListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.EffigyDailyInfo> _repeated_dailyInfoList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.EffigyDailyInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.EffigyDailyInfo> dailyInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.EffigyDailyInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.EffigyDailyInfo> DailyInfoList {
      get { return dailyInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EffigyActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LastDifficultyId != other.LastDifficultyId) return false;
      if(!takenRewardIndexList_.Equals(other.takenRewardIndexList_)) return false;
      if (CurScore != other.CurScore) return false;
      if(!dailyInfoList_.Equals(other.dailyInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LastDifficultyId != 0) hash ^= LastDifficultyId.GetHashCode();
      hash ^= takenRewardIndexList_.GetHashCode();
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
      hash ^= dailyInfoList_.GetHashCode();
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
      dailyInfoList_.WriteTo(output, _repeated_dailyInfoList_codec);
      if (CurScore != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurScore);
      }
      if (LastDifficultyId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LastDifficultyId);
      }
      takenRewardIndexList_.WriteTo(output, _repeated_takenRewardIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      dailyInfoList_.WriteTo(ref output, _repeated_dailyInfoList_codec);
      if (CurScore != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CurScore);
      }
      if (LastDifficultyId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(LastDifficultyId);
      }
      takenRewardIndexList_.WriteTo(ref output, _repeated_takenRewardIndexList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LastDifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastDifficultyId);
      }
      size += takenRewardIndexList_.CalculateSize(_repeated_takenRewardIndexList_codec);
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      size += dailyInfoList_.CalculateSize(_repeated_dailyInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EffigyActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.LastDifficultyId != 0) {
        LastDifficultyId = other.LastDifficultyId;
      }
      takenRewardIndexList_.Add(other.takenRewardIndexList_);
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
      }
      dailyInfoList_.Add(other.dailyInfoList_);
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
          case 34: {
            dailyInfoList_.AddEntriesFrom(input, _repeated_dailyInfoList_codec);
            break;
          }
          case 40: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 64: {
            LastDifficultyId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            takenRewardIndexList_.AddEntriesFrom(input, _repeated_takenRewardIndexList_codec);
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
          case 34: {
            dailyInfoList_.AddEntriesFrom(ref input, _repeated_dailyInfoList_codec);
            break;
          }
          case 40: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 64: {
            LastDifficultyId = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            takenRewardIndexList_.AddEntriesFrom(ref input, _repeated_takenRewardIndexList_codec);
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
