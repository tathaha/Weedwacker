// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeonResultInfo.proto</summary>
  public static partial class CustomDungeonResultInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonResultInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonResultInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1DdXN0b21EdW5nZW9uUmVzdWx0SW5mby5wcm90bxoUQ2hhbGxlbmdlQnJp",
            "ZWYucHJvdG8aHUN1c3RvbUR1bmdlb25GaW5pc2hUeXBlLnByb3RvIvUBChdD",
            "dXN0b21EdW5nZW9uUmVzdWx0SW5mbxIQCghpc19saWtlZBgNIAEoCBIYChBp",
            "c19hcnJpdmVfZmluaXNoGAIgASgIEhQKDGR1bmdlb25fZ3VpZBgFIAEoBBIt",
            "CgtmaW5pc2hfdHlwZRgIIAEoDjIYLkN1c3RvbUR1bmdlb25GaW5pc2hUeXBl",
            "Ei0KFGNoaWxkX2NoYWxsZW5nZV9saXN0GAEgAygLMg8uQ2hhbGxlbmdlQnJp",
            "ZWYSEQoJaXNfc3RvcmVkGAYgASgIEhEKCXRpbWVfY29zdBgJIAEoDRIUCgxn",
            "b3RfY29pbl9udW0YBCABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ChallengeBriefReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeonResultInfo), global::Weedwacker.Shared.Network.Proto.CustomDungeonResultInfo.Parser, new[]{ "IsLiked", "IsArriveFinish", "DungeonGuid", "FinishType", "ChildChallengeList", "IsStored", "TimeCost", "GotCoinNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonResultInfo : pb::IMessage<CustomDungeonResultInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonResultInfo> _parser = new pb::MessageParser<CustomDungeonResultInfo>(() => new CustomDungeonResultInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonResultInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CustomDungeonResultInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonResultInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonResultInfo(CustomDungeonResultInfo other) : this() {
      isLiked_ = other.isLiked_;
      isArriveFinish_ = other.isArriveFinish_;
      dungeonGuid_ = other.dungeonGuid_;
      finishType_ = other.finishType_;
      childChallengeList_ = other.childChallengeList_.Clone();
      isStored_ = other.isStored_;
      timeCost_ = other.timeCost_;
      gotCoinNum_ = other.gotCoinNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonResultInfo Clone() {
      return new CustomDungeonResultInfo(this);
    }

    /// <summary>Field number for the "is_liked" field.</summary>
    public const int IsLikedFieldNumber = 13;
    private bool isLiked_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsLiked {
      get { return isLiked_; }
      set {
        isLiked_ = value;
      }
    }

    /// <summary>Field number for the "is_arrive_finish" field.</summary>
    public const int IsArriveFinishFieldNumber = 2;
    private bool isArriveFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsArriveFinish {
      get { return isArriveFinish_; }
      set {
        isArriveFinish_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_guid" field.</summary>
    public const int DungeonGuidFieldNumber = 5;
    private ulong dungeonGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DungeonGuid {
      get { return dungeonGuid_; }
      set {
        dungeonGuid_ = value;
      }
    }

    /// <summary>Field number for the "finish_type" field.</summary>
    public const int FinishTypeFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType finishType_ = global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType.PlayNormal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType FinishType {
      get { return finishType_; }
      set {
        finishType_ = value;
      }
    }

    /// <summary>Field number for the "child_challenge_list" field.</summary>
    public const int ChildChallengeListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ChallengeBrief> _repeated_childChallengeList_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Shared.Network.Proto.ChallengeBrief.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChallengeBrief> childChallengeList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChallengeBrief>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ChallengeBrief> ChildChallengeList {
      get { return childChallengeList_; }
    }

    /// <summary>Field number for the "is_stored" field.</summary>
    public const int IsStoredFieldNumber = 6;
    private bool isStored_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStored {
      get { return isStored_; }
      set {
        isStored_ = value;
      }
    }

    /// <summary>Field number for the "time_cost" field.</summary>
    public const int TimeCostFieldNumber = 9;
    private uint timeCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeCost {
      get { return timeCost_; }
      set {
        timeCost_ = value;
      }
    }

    /// <summary>Field number for the "got_coin_num" field.</summary>
    public const int GotCoinNumFieldNumber = 4;
    private uint gotCoinNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GotCoinNum {
      get { return gotCoinNum_; }
      set {
        gotCoinNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonResultInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonResultInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsLiked != other.IsLiked) return false;
      if (IsArriveFinish != other.IsArriveFinish) return false;
      if (DungeonGuid != other.DungeonGuid) return false;
      if (FinishType != other.FinishType) return false;
      if(!childChallengeList_.Equals(other.childChallengeList_)) return false;
      if (IsStored != other.IsStored) return false;
      if (TimeCost != other.TimeCost) return false;
      if (GotCoinNum != other.GotCoinNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsLiked != false) hash ^= IsLiked.GetHashCode();
      if (IsArriveFinish != false) hash ^= IsArriveFinish.GetHashCode();
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
      if (FinishType != global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType.PlayNormal) hash ^= FinishType.GetHashCode();
      hash ^= childChallengeList_.GetHashCode();
      if (IsStored != false) hash ^= IsStored.GetHashCode();
      if (TimeCost != 0) hash ^= TimeCost.GetHashCode();
      if (GotCoinNum != 0) hash ^= GotCoinNum.GetHashCode();
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
      childChallengeList_.WriteTo(output, _repeated_childChallengeList_codec);
      if (IsArriveFinish != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsArriveFinish);
      }
      if (GotCoinNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GotCoinNum);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(DungeonGuid);
      }
      if (IsStored != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsStored);
      }
      if (FinishType != global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType.PlayNormal) {
        output.WriteRawTag(64);
        output.WriteEnum((int) FinishType);
      }
      if (TimeCost != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TimeCost);
      }
      if (IsLiked != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsLiked);
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
      childChallengeList_.WriteTo(ref output, _repeated_childChallengeList_codec);
      if (IsArriveFinish != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsArriveFinish);
      }
      if (GotCoinNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GotCoinNum);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(DungeonGuid);
      }
      if (IsStored != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsStored);
      }
      if (FinishType != global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType.PlayNormal) {
        output.WriteRawTag(64);
        output.WriteEnum((int) FinishType);
      }
      if (TimeCost != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TimeCost);
      }
      if (IsLiked != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsLiked);
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
      if (IsLiked != false) {
        size += 1 + 1;
      }
      if (IsArriveFinish != false) {
        size += 1 + 1;
      }
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (FinishType != global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType.PlayNormal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FinishType);
      }
      size += childChallengeList_.CalculateSize(_repeated_childChallengeList_codec);
      if (IsStored != false) {
        size += 1 + 1;
      }
      if (TimeCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeCost);
      }
      if (GotCoinNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GotCoinNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonResultInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsLiked != false) {
        IsLiked = other.IsLiked;
      }
      if (other.IsArriveFinish != false) {
        IsArriveFinish = other.IsArriveFinish;
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
      }
      if (other.FinishType != global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType.PlayNormal) {
        FinishType = other.FinishType;
      }
      childChallengeList_.Add(other.childChallengeList_);
      if (other.IsStored != false) {
        IsStored = other.IsStored;
      }
      if (other.TimeCost != 0) {
        TimeCost = other.TimeCost;
      }
      if (other.GotCoinNum != 0) {
        GotCoinNum = other.GotCoinNum;
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
          case 10: {
            childChallengeList_.AddEntriesFrom(input, _repeated_childChallengeList_codec);
            break;
          }
          case 16: {
            IsArriveFinish = input.ReadBool();
            break;
          }
          case 32: {
            GotCoinNum = input.ReadUInt32();
            break;
          }
          case 40: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            IsStored = input.ReadBool();
            break;
          }
          case 64: {
            FinishType = (global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType) input.ReadEnum();
            break;
          }
          case 72: {
            TimeCost = input.ReadUInt32();
            break;
          }
          case 104: {
            IsLiked = input.ReadBool();
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
          case 10: {
            childChallengeList_.AddEntriesFrom(ref input, _repeated_childChallengeList_codec);
            break;
          }
          case 16: {
            IsArriveFinish = input.ReadBool();
            break;
          }
          case 32: {
            GotCoinNum = input.ReadUInt32();
            break;
          }
          case 40: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            IsStored = input.ReadBool();
            break;
          }
          case 64: {
            FinishType = (global::Weedwacker.Shared.Network.Proto.CustomDungeonFinishType) input.ReadEnum();
            break;
          }
          case 72: {
            TimeCost = input.ReadUInt32();
            break;
          }
          case 104: {
            IsLiked = input.ReadBool();
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
