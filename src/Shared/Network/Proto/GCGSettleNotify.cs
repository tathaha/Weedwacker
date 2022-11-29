// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSettleNotify.proto</summary>
  public static partial class GCGSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHQ0dTZXR0bGVOb3RpZnkucHJvdG8aEkdDR0VuZFJlYXNvbi5wcm90bxoZ",
            "R0NHR2FtZUJ1c2luZXNzVHlwZS5wcm90bxoPSXRlbVBhcmFtLnByb3RvIsgB",
            "Cg9HQ0dTZXR0bGVOb3RpZnkSDwoHZ2FtZV9pZBgHIAEoDRIrCg1idXNpbmVz",
            "c190eXBlGAIgASgOMhQuR0NHR2FtZUJ1c2luZXNzVHlwZRIOCgZpc193aW4Y",
            "DSABKAgSJAoQcmV3YXJkX2l0ZW1fbGlzdBgJIAMoCzIKLkl0ZW1QYXJhbRIi",
            "ChpmaW5pc2hlZF9jaGFsbGVuZ2VfaWRfbGlzdBgGIAMoDRIdCgZyZWFzb24Y",
            "AyABKA4yDS5HQ0dFbmRSZWFzb25CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGEndReasonReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGGameBusinessTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSettleNotify), global::Weedwacker.Shared.Network.Proto.GCGSettleNotify.Parser, new[]{ "GameId", "BusinessType", "IsWin", "RewardItemList", "FinishedChallengeIdList", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 7769
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GCGSettleNotify : pb::IMessage<GCGSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSettleNotify> _parser = new pb::MessageParser<GCGSettleNotify>(() => new GCGSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSettleNotify(GCGSettleNotify other) : this() {
      gameId_ = other.gameId_;
      businessType_ = other.businessType_;
      isWin_ = other.isWin_;
      rewardItemList_ = other.rewardItemList_.Clone();
      finishedChallengeIdList_ = other.finishedChallengeIdList_.Clone();
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSettleNotify Clone() {
      return new GCGSettleNotify(this);
    }

    /// <summary>Field number for the "game_id" field.</summary>
    public const int GameIdFieldNumber = 7;
    private uint gameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameId {
      get { return gameId_; }
      set {
        gameId_ = value;
      }
    }

    /// <summary>Field number for the "business_type" field.</summary>
    public const int BusinessTypeFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType businessType_ = global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType BusinessType {
      get { return businessType_; }
      set {
        businessType_ = value;
      }
    }

    /// <summary>Field number for the "is_win" field.</summary>
    public const int IsWinFieldNumber = 13;
    private bool isWin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsWin {
      get { return isWin_; }
      set {
        isWin_ = value;
      }
    }

    /// <summary>Field number for the "reward_item_list" field.</summary>
    public const int RewardItemListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_rewardItemList_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> rewardItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> RewardItemList {
      get { return rewardItemList_; }
    }

    /// <summary>Field number for the "finished_challenge_id_list" field.</summary>
    public const int FinishedChallengeIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_finishedChallengeIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> finishedChallengeIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedChallengeIdList {
      get { return finishedChallengeIdList_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.GCGEndReason reason_ = global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGEndReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GameId != other.GameId) return false;
      if (BusinessType != other.BusinessType) return false;
      if (IsWin != other.IsWin) return false;
      if(!rewardItemList_.Equals(other.rewardItemList_)) return false;
      if(!finishedChallengeIdList_.Equals(other.finishedChallengeIdList_)) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GameId != 0) hash ^= GameId.GetHashCode();
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) hash ^= BusinessType.GetHashCode();
      if (IsWin != false) hash ^= IsWin.GetHashCode();
      hash ^= rewardItemList_.GetHashCode();
      hash ^= finishedChallengeIdList_.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) hash ^= Reason.GetHashCode();
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
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BusinessType);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      finishedChallengeIdList_.WriteTo(output, _repeated_finishedChallengeIdList_codec);
      if (GameId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GameId);
      }
      rewardItemList_.WriteTo(output, _repeated_rewardItemList_codec);
      if (IsWin != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsWin);
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
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BusinessType);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      finishedChallengeIdList_.WriteTo(ref output, _repeated_finishedChallengeIdList_codec);
      if (GameId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GameId);
      }
      rewardItemList_.WriteTo(ref output, _repeated_rewardItemList_codec);
      if (IsWin != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsWin);
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
      if (GameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameId);
      }
      if (BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BusinessType);
      }
      if (IsWin != false) {
        size += 1 + 1;
      }
      size += rewardItemList_.CalculateSize(_repeated_rewardItemList_codec);
      size += finishedChallengeIdList_.CalculateSize(_repeated_finishedChallengeIdList_codec);
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.GameId != 0) {
        GameId = other.GameId;
      }
      if (other.BusinessType != global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType.None) {
        BusinessType = other.BusinessType;
      }
      if (other.IsWin != false) {
        IsWin = other.IsWin;
      }
      rewardItemList_.Add(other.rewardItemList_);
      finishedChallengeIdList_.Add(other.finishedChallengeIdList_);
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GCGEndReason.Default) {
        Reason = other.Reason;
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
          case 16: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 24: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGEndReason) input.ReadEnum();
            break;
          }
          case 50:
          case 48: {
            finishedChallengeIdList_.AddEntriesFrom(input, _repeated_finishedChallengeIdList_codec);
            break;
          }
          case 56: {
            GameId = input.ReadUInt32();
            break;
          }
          case 74: {
            rewardItemList_.AddEntriesFrom(input, _repeated_rewardItemList_codec);
            break;
          }
          case 104: {
            IsWin = input.ReadBool();
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
          case 16: {
            BusinessType = (global::Weedwacker.Shared.Network.Proto.GCGGameBusinessType) input.ReadEnum();
            break;
          }
          case 24: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGEndReason) input.ReadEnum();
            break;
          }
          case 50:
          case 48: {
            finishedChallengeIdList_.AddEntriesFrom(ref input, _repeated_finishedChallengeIdList_codec);
            break;
          }
          case 56: {
            GameId = input.ReadUInt32();
            break;
          }
          case 74: {
            rewardItemList_.AddEntriesFrom(ref input, _repeated_rewardItemList_codec);
            break;
          }
          case 104: {
            IsWin = input.ReadBool();
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