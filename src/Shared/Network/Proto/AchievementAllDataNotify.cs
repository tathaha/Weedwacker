// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AchievementAllDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AchievementAllDataNotify.proto</summary>
  public static partial class AchievementAllDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AchievementAllDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AchievementAllDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5BY2hpZXZlbWVudEFsbERhdGFOb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8aEUFjaGlldmVtZW50LnByb3RvIoUBChhB",
            "Y2hpZXZlbWVudEFsbERhdGFOb3RpZnkSIQoZcmV3YXJkX3Rha2VuX2dvYWxf",
            "aWRfbGlzdBgNIAMoDRJGChBhY2hpZXZlbWVudF9saXN0GAggAygLMiwuV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5BY2hpZXZlbWVudGIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AchievementReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AchievementAllDataNotify), global::Weedwacker.Shared.Network.Proto.AchievementAllDataNotify.Parser, new[]{ "RewardTakenGoalIdList", "AchievementList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2692;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AchievementAllDataNotify : pb::IMessage<AchievementAllDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AchievementAllDataNotify> _parser = new pb::MessageParser<AchievementAllDataNotify>(() => new AchievementAllDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AchievementAllDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AchievementAllDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AchievementAllDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AchievementAllDataNotify(AchievementAllDataNotify other) : this() {
      rewardTakenGoalIdList_ = other.rewardTakenGoalIdList_.Clone();
      achievementList_ = other.achievementList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AchievementAllDataNotify Clone() {
      return new AchievementAllDataNotify(this);
    }

    /// <summary>Field number for the "reward_taken_goal_id_list" field.</summary>
    public const int RewardTakenGoalIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_rewardTakenGoalIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> rewardTakenGoalIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RewardTakenGoalIdList {
      get { return rewardTakenGoalIdList_; }
    }

    /// <summary>Field number for the "achievement_list" field.</summary>
    public const int AchievementListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Achievement> _repeated_achievementList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.Achievement.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Achievement> achievementList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Achievement>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Achievement> AchievementList {
      get { return achievementList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AchievementAllDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AchievementAllDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rewardTakenGoalIdList_.Equals(other.rewardTakenGoalIdList_)) return false;
      if(!achievementList_.Equals(other.achievementList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rewardTakenGoalIdList_.GetHashCode();
      hash ^= achievementList_.GetHashCode();
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
      achievementList_.WriteTo(output, _repeated_achievementList_codec);
      rewardTakenGoalIdList_.WriteTo(output, _repeated_rewardTakenGoalIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      achievementList_.WriteTo(ref output, _repeated_achievementList_codec);
      rewardTakenGoalIdList_.WriteTo(ref output, _repeated_rewardTakenGoalIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += rewardTakenGoalIdList_.CalculateSize(_repeated_rewardTakenGoalIdList_codec);
      size += achievementList_.CalculateSize(_repeated_achievementList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AchievementAllDataNotify other) {
      if (other == null) {
        return;
      }
      rewardTakenGoalIdList_.Add(other.rewardTakenGoalIdList_);
      achievementList_.Add(other.achievementList_);
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
          case 66: {
            achievementList_.AddEntriesFrom(input, _repeated_achievementList_codec);
            break;
          }
          case 106:
          case 104: {
            rewardTakenGoalIdList_.AddEntriesFrom(input, _repeated_rewardTakenGoalIdList_codec);
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
          case 66: {
            achievementList_.AddEntriesFrom(ref input, _repeated_achievementList_codec);
            break;
          }
          case 106:
          case 104: {
            rewardTakenGoalIdList_.AddEntriesFrom(ref input, _repeated_rewardTakenGoalIdList_codec);
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
