// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldOwnerDailyTaskNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WorldOwnerDailyTaskNotify.proto</summary>
  public static partial class WorldOwnerDailyTaskNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WorldOwnerDailyTaskNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorldOwnerDailyTaskNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Xb3JsZE93bmVyRGFpbHlUYXNrTm90aWZ5LnByb3RvEh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvGhNEYWlseVRhc2tJbmZvLnByb3RvIpgB",
            "ChlXb3JsZE93bmVyRGFpbHlUYXNrTm90aWZ5EhsKE1VuazMzMDBfRkpPSkZQ",
            "UFBPRlAYBCABKA0SQQoJdGFza19saXN0GAIgAygLMi4uV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90by5EYWlseVRhc2tJbmZvEhsKE1VuazMzMDBf",
            "TkFESU9JSkdQSEUYCSABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.DailyTaskInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WorldOwnerDailyTaskNotify), global::Weedwacker.Shared.Network.Proto.WorldOwnerDailyTaskNotify.Parser, new[]{ "Unk3300FJOJFPPPOFP", "TaskList", "Unk3300NADIOIJGPHE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 193;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class WorldOwnerDailyTaskNotify : pb::IMessage<WorldOwnerDailyTaskNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorldOwnerDailyTaskNotify> _parser = new pb::MessageParser<WorldOwnerDailyTaskNotify>(() => new WorldOwnerDailyTaskNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorldOwnerDailyTaskNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WorldOwnerDailyTaskNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldOwnerDailyTaskNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldOwnerDailyTaskNotify(WorldOwnerDailyTaskNotify other) : this() {
      unk3300FJOJFPPPOFP_ = other.unk3300FJOJFPPPOFP_;
      taskList_ = other.taskList_.Clone();
      unk3300NADIOIJGPHE_ = other.unk3300NADIOIJGPHE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldOwnerDailyTaskNotify Clone() {
      return new WorldOwnerDailyTaskNotify(this);
    }

    /// <summary>Field number for the "Unk3300_FJOJFPPPOFP" field.</summary>
    public const int Unk3300FJOJFPPPOFPFieldNumber = 4;
    private uint unk3300FJOJFPPPOFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FJOJFPPPOFP {
      get { return unk3300FJOJFPPPOFP_; }
      set {
        unk3300FJOJFPPPOFP_ = value;
      }
    }

    /// <summary>Field number for the "task_list" field.</summary>
    public const int TaskListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo> _repeated_taskList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.DailyTaskInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo> taskList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.DailyTaskInfo> TaskList {
      get { return taskList_; }
    }

    /// <summary>Field number for the "Unk3300_NADIOIJGPHE" field.</summary>
    public const int Unk3300NADIOIJGPHEFieldNumber = 9;
    private uint unk3300NADIOIJGPHE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NADIOIJGPHE {
      get { return unk3300NADIOIJGPHE_; }
      set {
        unk3300NADIOIJGPHE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorldOwnerDailyTaskNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorldOwnerDailyTaskNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300FJOJFPPPOFP != other.Unk3300FJOJFPPPOFP) return false;
      if(!taskList_.Equals(other.taskList_)) return false;
      if (Unk3300NADIOIJGPHE != other.Unk3300NADIOIJGPHE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300FJOJFPPPOFP != 0) hash ^= Unk3300FJOJFPPPOFP.GetHashCode();
      hash ^= taskList_.GetHashCode();
      if (Unk3300NADIOIJGPHE != 0) hash ^= Unk3300NADIOIJGPHE.GetHashCode();
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
      taskList_.WriteTo(output, _repeated_taskList_codec);
      if (Unk3300FJOJFPPPOFP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300FJOJFPPPOFP);
      }
      if (Unk3300NADIOIJGPHE != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300NADIOIJGPHE);
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
      taskList_.WriteTo(ref output, _repeated_taskList_codec);
      if (Unk3300FJOJFPPPOFP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300FJOJFPPPOFP);
      }
      if (Unk3300NADIOIJGPHE != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300NADIOIJGPHE);
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
      if (Unk3300FJOJFPPPOFP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FJOJFPPPOFP);
      }
      size += taskList_.CalculateSize(_repeated_taskList_codec);
      if (Unk3300NADIOIJGPHE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NADIOIJGPHE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorldOwnerDailyTaskNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300FJOJFPPPOFP != 0) {
        Unk3300FJOJFPPPOFP = other.Unk3300FJOJFPPPOFP;
      }
      taskList_.Add(other.taskList_);
      if (other.Unk3300NADIOIJGPHE != 0) {
        Unk3300NADIOIJGPHE = other.Unk3300NADIOIJGPHE;
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
            taskList_.AddEntriesFrom(input, _repeated_taskList_codec);
            break;
          }
          case 32: {
            Unk3300FJOJFPPPOFP = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300NADIOIJGPHE = input.ReadUInt32();
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
            taskList_.AddEntriesFrom(ref input, _repeated_taskList_codec);
            break;
          }
          case 32: {
            Unk3300FJOJFPPPOFP = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300NADIOIJGPHE = input.ReadUInt32();
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
