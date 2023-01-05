// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FallSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FallSettleInfo.proto</summary>
  public static partial class FallSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FallSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FallSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGYWxsU2V0dGxlSW5mby5wcm90bxoWT25saW5lUGxheWVySW5mby5wcm90",
            "byKXAgoORmFsbFNldHRsZUluZm8SEwoLZmluYWxfc2NvcmUYDiABKA0SJgoL",
            "cGxheWVyX2luZm8YCSABKAsyES5PbmxpbmVQbGF5ZXJJbmZvElEKG2Zsb3dl",
            "cl9yaW5nX2NhdGNoX2NvdW50X21hcBgNIAMoCzIsLkZhbGxTZXR0bGVJbmZv",
            "LkZsb3dlclJpbmdDYXRjaENvdW50TWFwRW50cnkSCwoDdWlkGAIgASgNEhMK",
            "C2NhdGNoX2NvdW50GAEgASgNEhMKC3JlbWFpbl90aW1lGAYgASgNGj4KHEZs",
            "b3dlclJpbmdDYXRjaENvdW50TWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZh",
            "bHVlGAIgASgNOgI4AUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FallSettleInfo), global::Weedwacker.Shared.Network.Proto.FallSettleInfo.Parser, new[]{ "FinalScore", "PlayerInfo", "FlowerRingCatchCountMap", "Uid", "CatchCount", "RemainTime" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FallSettleInfo : pb::IMessage<FallSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FallSettleInfo> _parser = new pb::MessageParser<FallSettleInfo>(() => new FallSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FallSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FallSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo(FallSettleInfo other) : this() {
      finalScore_ = other.finalScore_;
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      flowerRingCatchCountMap_ = other.flowerRingCatchCountMap_.Clone();
      uid_ = other.uid_;
      catchCount_ = other.catchCount_;
      remainTime_ = other.remainTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo Clone() {
      return new FallSettleInfo(this);
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 14;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "flower_ring_catch_count_map" field.</summary>
    public const int FlowerRingCatchCountMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_flowerRingCatchCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> flowerRingCatchCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FlowerRingCatchCountMap {
      get { return flowerRingCatchCountMap_; }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 2;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "catch_count" field.</summary>
    public const int CatchCountFieldNumber = 1;
    private uint catchCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CatchCount {
      get { return catchCount_; }
      set {
        catchCount_ = value;
      }
    }

    /// <summary>Field number for the "remain_time" field.</summary>
    public const int RemainTimeFieldNumber = 6;
    private uint remainTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainTime {
      get { return remainTime_; }
      set {
        remainTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FallSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FallSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FinalScore != other.FinalScore) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (!FlowerRingCatchCountMap.Equals(other.FlowerRingCatchCountMap)) return false;
      if (Uid != other.Uid) return false;
      if (CatchCount != other.CatchCount) return false;
      if (RemainTime != other.RemainTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      hash ^= FlowerRingCatchCountMap.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (CatchCount != 0) hash ^= CatchCount.GetHashCode();
      if (RemainTime != 0) hash ^= RemainTime.GetHashCode();
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
      if (CatchCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CatchCount);
      }
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RemainTime);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PlayerInfo);
      }
      flowerRingCatchCountMap_.WriteTo(output, _map_flowerRingCatchCountMap_codec);
      if (FinalScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinalScore);
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
      if (CatchCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CatchCount);
      }
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RemainTime);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PlayerInfo);
      }
      flowerRingCatchCountMap_.WriteTo(ref output, _map_flowerRingCatchCountMap_codec);
      if (FinalScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinalScore);
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
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      size += flowerRingCatchCountMap_.CalculateSize(_map_flowerRingCatchCountMap_codec);
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (CatchCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CatchCount);
      }
      if (RemainTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FallSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      flowerRingCatchCountMap_.Add(other.flowerRingCatchCountMap_);
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.CatchCount != 0) {
        CatchCount = other.CatchCount;
      }
      if (other.RemainTime != 0) {
        RemainTime = other.RemainTime;
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
            CatchCount = input.ReadUInt32();
            break;
          }
          case 16: {
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 106: {
            flowerRingCatchCountMap_.AddEntriesFrom(input, _map_flowerRingCatchCountMap_codec);
            break;
          }
          case 112: {
            FinalScore = input.ReadUInt32();
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
            CatchCount = input.ReadUInt32();
            break;
          }
          case 16: {
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::Weedwacker.Shared.Network.Proto.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 106: {
            flowerRingCatchCountMap_.AddEntriesFrom(ref input, _map_flowerRingCatchCountMap_codec);
            break;
          }
          case 112: {
            FinalScore = input.ReadUInt32();
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
