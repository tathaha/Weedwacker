// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SumoDungeonSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SumoDungeonSettleNotify.proto</summary>
  public static partial class SumoDungeonSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SumoDungeonSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SumoDungeonSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TdW1vRHVuZ2VvblNldHRsZU5vdGlmeS5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90byKoAQoXU3Vtb0R1bmdlb25TZXR0bGVOb3Rp",
            "ZnkSFQoNaXNfbmV3X3JlY29yZBgEIAEoCBIYChBraWxsX21vbnN0ZXJfbnVt",
            "GAwgASgNEhUKDWRpZmZpY3VsdHlfaWQYAyABKA0SEwoLZmluYWxfc2NvcmUY",
            "AiABKA0SHgoWa2lsbF9lbGl0ZV9tb25zdGVyX251bRgPIAEoDRIQCghzdGFn",
            "ZV9pZBgLIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SumoDungeonSettleNotify), global::Weedwacker.Shared.Network.Proto.SumoDungeonSettleNotify.Parser, new[]{ "IsNewRecord", "KillMonsterNum", "DifficultyId", "FinalScore", "KillEliteMonsterNum", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8434;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SumoDungeonSettleNotify : pb::IMessage<SumoDungeonSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SumoDungeonSettleNotify> _parser = new pb::MessageParser<SumoDungeonSettleNotify>(() => new SumoDungeonSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SumoDungeonSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SumoDungeonSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoDungeonSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoDungeonSettleNotify(SumoDungeonSettleNotify other) : this() {
      isNewRecord_ = other.isNewRecord_;
      killMonsterNum_ = other.killMonsterNum_;
      difficultyId_ = other.difficultyId_;
      finalScore_ = other.finalScore_;
      killEliteMonsterNum_ = other.killEliteMonsterNum_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SumoDungeonSettleNotify Clone() {
      return new SumoDungeonSettleNotify(this);
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 4;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "kill_monster_num" field.</summary>
    public const int KillMonsterNumFieldNumber = 12;
    private uint killMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillMonsterNum {
      get { return killMonsterNum_; }
      set {
        killMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 3;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 2;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "kill_elite_monster_num" field.</summary>
    public const int KillEliteMonsterNumFieldNumber = 15;
    private uint killEliteMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillEliteMonsterNum {
      get { return killEliteMonsterNum_; }
      set {
        killEliteMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 11;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SumoDungeonSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SumoDungeonSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsNewRecord != other.IsNewRecord) return false;
      if (KillMonsterNum != other.KillMonsterNum) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if (FinalScore != other.FinalScore) return false;
      if (KillEliteMonsterNum != other.KillEliteMonsterNum) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (KillMonsterNum != 0) hash ^= KillMonsterNum.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (KillEliteMonsterNum != 0) hash ^= KillEliteMonsterNum.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (FinalScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FinalScore);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DifficultyId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewRecord);
      }
      if (StageId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(StageId);
      }
      if (KillMonsterNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KillMonsterNum);
      }
      if (KillEliteMonsterNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KillEliteMonsterNum);
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
      if (FinalScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FinalScore);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DifficultyId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewRecord);
      }
      if (StageId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(StageId);
      }
      if (KillMonsterNum != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(KillMonsterNum);
      }
      if (KillEliteMonsterNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KillEliteMonsterNum);
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
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (KillMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillMonsterNum);
      }
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (KillEliteMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillEliteMonsterNum);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SumoDungeonSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.KillMonsterNum != 0) {
        KillMonsterNum = other.KillMonsterNum;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.KillEliteMonsterNum != 0) {
        KillEliteMonsterNum = other.KillEliteMonsterNum;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
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
            FinalScore = input.ReadUInt32();
            break;
          }
          case 24: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 32: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 88: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            KillMonsterNum = input.ReadUInt32();
            break;
          }
          case 120: {
            KillEliteMonsterNum = input.ReadUInt32();
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
            FinalScore = input.ReadUInt32();
            break;
          }
          case 24: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 32: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 88: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            KillMonsterNum = input.ReadUInt32();
            break;
          }
          case 120: {
            KillEliteMonsterNum = input.ReadUInt32();
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
