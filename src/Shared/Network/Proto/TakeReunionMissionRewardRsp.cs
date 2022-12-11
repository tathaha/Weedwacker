// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TakeReunionMissionRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TakeReunionMissionRewardRsp.proto</summary>
  public static partial class TakeReunionMissionRewardRspReflection {

    #region Descriptor
    /// <summary>File descriptor for TakeReunionMissionRewardRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TakeReunionMissionRewardRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFUYWtlUmV1bmlvbk1pc3Npb25SZXdhcmRSc3AucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8aGFJldW5pb25NaXNzaW9uSW5mby5w",
            "cm90byKiAQobVGFrZVJldW5pb25NaXNzaW9uUmV3YXJkUnNwEhEKCXJld2Fy",
            "ZF9pZBgNIAEoDRJJCgxtaXNzaW9uX2luZm8YAiABKAsyMy5XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvLlJldW5pb25NaXNzaW9uSW5mbxIUCgxy",
            "ZXdhcmRfaW5kZXgYBiABKA0SDwoHcmV0Y29kZRgDIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ReunionMissionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TakeReunionMissionRewardRsp), global::Weedwacker.Shared.Network.Proto.TakeReunionMissionRewardRsp.Parser, new[]{ "RewardId", "MissionInfo", "RewardIndex", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5052;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class TakeReunionMissionRewardRsp : pb::IMessage<TakeReunionMissionRewardRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TakeReunionMissionRewardRsp> _parser = new pb::MessageParser<TakeReunionMissionRewardRsp>(() => new TakeReunionMissionRewardRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TakeReunionMissionRewardRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TakeReunionMissionRewardRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeReunionMissionRewardRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeReunionMissionRewardRsp(TakeReunionMissionRewardRsp other) : this() {
      rewardId_ = other.rewardId_;
      missionInfo_ = other.missionInfo_ != null ? other.missionInfo_.Clone() : null;
      rewardIndex_ = other.rewardIndex_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TakeReunionMissionRewardRsp Clone() {
      return new TakeReunionMissionRewardRsp(this);
    }

    /// <summary>Field number for the "reward_id" field.</summary>
    public const int RewardIdFieldNumber = 13;
    private uint rewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    /// <summary>Field number for the "mission_info" field.</summary>
    public const int MissionInfoFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.ReunionMissionInfo missionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ReunionMissionInfo MissionInfo {
      get { return missionInfo_; }
      set {
        missionInfo_ = value;
      }
    }

    /// <summary>Field number for the "reward_index" field.</summary>
    public const int RewardIndexFieldNumber = 6;
    private uint rewardIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardIndex {
      get { return rewardIndex_; }
      set {
        rewardIndex_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TakeReunionMissionRewardRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TakeReunionMissionRewardRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RewardId != other.RewardId) return false;
      if (!object.Equals(MissionInfo, other.MissionInfo)) return false;
      if (RewardIndex != other.RewardIndex) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RewardId != 0) hash ^= RewardId.GetHashCode();
      if (missionInfo_ != null) hash ^= MissionInfo.GetHashCode();
      if (RewardIndex != 0) hash ^= RewardIndex.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (missionInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MissionInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Retcode);
      }
      if (RewardIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RewardIndex);
      }
      if (RewardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RewardId);
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
      if (missionInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MissionInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Retcode);
      }
      if (RewardIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RewardIndex);
      }
      if (RewardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RewardId);
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
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (missionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionInfo);
      }
      if (RewardIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardIndex);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TakeReunionMissionRewardRsp other) {
      if (other == null) {
        return;
      }
      if (other.RewardId != 0) {
        RewardId = other.RewardId;
      }
      if (other.missionInfo_ != null) {
        if (missionInfo_ == null) {
          MissionInfo = new global::Weedwacker.Shared.Network.Proto.ReunionMissionInfo();
        }
        MissionInfo.MergeFrom(other.MissionInfo);
      }
      if (other.RewardIndex != 0) {
        RewardIndex = other.RewardIndex;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 18: {
            if (missionInfo_ == null) {
              MissionInfo = new global::Weedwacker.Shared.Network.Proto.ReunionMissionInfo();
            }
            input.ReadMessage(MissionInfo);
            break;
          }
          case 24: {
            Retcode = input.ReadInt32();
            break;
          }
          case 48: {
            RewardIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            RewardId = input.ReadUInt32();
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
          case 18: {
            if (missionInfo_ == null) {
              MissionInfo = new global::Weedwacker.Shared.Network.Proto.ReunionMissionInfo();
            }
            input.ReadMessage(MissionInfo);
            break;
          }
          case 24: {
            Retcode = input.ReadInt32();
            break;
          }
          case 48: {
            RewardIndex = input.ReadUInt32();
            break;
          }
          case 104: {
            RewardId = input.ReadUInt32();
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
