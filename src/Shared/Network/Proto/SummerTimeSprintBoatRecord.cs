// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SummerTimeSprintBoatRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SummerTimeSprintBoatRecord.proto</summary>
  public static partial class SummerTimeSprintBoatRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for SummerTimeSprintBoatRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SummerTimeSprintBoatRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTdW1tZXJUaW1lU3ByaW50Qm9hdFJlY29yZC5wcm90byKDAQoaU3VtbWVy",
            "VGltZVNwcmludEJvYXRSZWNvcmQSEgoKc3RhcnRfdGltZRgMIAEoDRIQCghn",
            "cm91cF9pZBgFIAEoDRIXCg93YXRjaGVyX2lkX2xpc3QYAiADKA0SEgoKYmVz",
            "dF9zY29yZRgNIAEoDRISCgppc190b3VjaGVkGAYgASgIQiKqAh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SummerTimeSprintBoatRecord), global::Weedwacker.Shared.Network.Proto.SummerTimeSprintBoatRecord.Parser, new[]{ "StartTime", "GroupId", "WatcherIdList", "BestScore", "IsTouched" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SummerTimeSprintBoatRecord : pb::IMessage<SummerTimeSprintBoatRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SummerTimeSprintBoatRecord> _parser = new pb::MessageParser<SummerTimeSprintBoatRecord>(() => new SummerTimeSprintBoatRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SummerTimeSprintBoatRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SummerTimeSprintBoatRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeSprintBoatRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeSprintBoatRecord(SummerTimeSprintBoatRecord other) : this() {
      startTime_ = other.startTime_;
      groupId_ = other.groupId_;
      watcherIdList_ = other.watcherIdList_.Clone();
      bestScore_ = other.bestScore_;
      isTouched_ = other.isTouched_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SummerTimeSprintBoatRecord Clone() {
      return new SummerTimeSprintBoatRecord(this);
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 12;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 5;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "watcher_id_list" field.</summary>
    public const int WatcherIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_watcherIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> watcherIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> WatcherIdList {
      get { return watcherIdList_; }
    }

    /// <summary>Field number for the "best_score" field.</summary>
    public const int BestScoreFieldNumber = 13;
    private uint bestScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestScore {
      get { return bestScore_; }
      set {
        bestScore_ = value;
      }
    }

    /// <summary>Field number for the "is_touched" field.</summary>
    public const int IsTouchedFieldNumber = 6;
    private bool isTouched_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTouched {
      get { return isTouched_; }
      set {
        isTouched_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SummerTimeSprintBoatRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SummerTimeSprintBoatRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StartTime != other.StartTime) return false;
      if (GroupId != other.GroupId) return false;
      if(!watcherIdList_.Equals(other.watcherIdList_)) return false;
      if (BestScore != other.BestScore) return false;
      if (IsTouched != other.IsTouched) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      hash ^= watcherIdList_.GetHashCode();
      if (BestScore != 0) hash ^= BestScore.GetHashCode();
      if (IsTouched != false) hash ^= IsTouched.GetHashCode();
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
      watcherIdList_.WriteTo(output, _repeated_watcherIdList_codec);
      if (GroupId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GroupId);
      }
      if (IsTouched != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsTouched);
      }
      if (StartTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StartTime);
      }
      if (BestScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BestScore);
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
      watcherIdList_.WriteTo(ref output, _repeated_watcherIdList_codec);
      if (GroupId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GroupId);
      }
      if (IsTouched != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsTouched);
      }
      if (StartTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StartTime);
      }
      if (BestScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BestScore);
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
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      size += watcherIdList_.CalculateSize(_repeated_watcherIdList_codec);
      if (BestScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestScore);
      }
      if (IsTouched != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SummerTimeSprintBoatRecord other) {
      if (other == null) {
        return;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      watcherIdList_.Add(other.watcherIdList_);
      if (other.BestScore != 0) {
        BestScore = other.BestScore;
      }
      if (other.IsTouched != false) {
        IsTouched = other.IsTouched;
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
          case 18:
          case 16: {
            watcherIdList_.AddEntriesFrom(input, _repeated_watcherIdList_codec);
            break;
          }
          case 40: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsTouched = input.ReadBool();
            break;
          }
          case 96: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 104: {
            BestScore = input.ReadUInt32();
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
          case 18:
          case 16: {
            watcherIdList_.AddEntriesFrom(ref input, _repeated_watcherIdList_codec);
            break;
          }
          case 40: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsTouched = input.ReadBool();
            break;
          }
          case 96: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 104: {
            BestScore = input.ReadUInt32();
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
