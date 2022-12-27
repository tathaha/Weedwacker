// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DragonSpineChapterProgressChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DragonSpineChapterProgressChangeNotify.proto</summary>
  public static partial class DragonSpineChapterProgressChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DragonSpineChapterProgressChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DragonSpineChapterProgressChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixEcmFnb25TcGluZUNoYXB0ZXJQcm9ncmVzc0NoYW5nZU5vdGlmeS5wcm90",
            "byJnCiZEcmFnb25TcGluZUNoYXB0ZXJQcm9ncmVzc0NoYW5nZU5vdGlmeRIS",
            "CgpjaGFwdGVyX2lkGAkgASgNEhMKC3NjaGVkdWxlX2lkGAMgASgNEhQKDGN1",
            "cl9wcm9ncmVzcxgLIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DragonSpineChapterProgressChangeNotify), global::Weedwacker.Shared.Network.Proto.DragonSpineChapterProgressChangeNotify.Parser, new[]{ "ChapterId", "ScheduleId", "CurProgress" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2035;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class DragonSpineChapterProgressChangeNotify : pb::IMessage<DragonSpineChapterProgressChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DragonSpineChapterProgressChangeNotify> _parser = new pb::MessageParser<DragonSpineChapterProgressChangeNotify>(() => new DragonSpineChapterProgressChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DragonSpineChapterProgressChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DragonSpineChapterProgressChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineChapterProgressChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineChapterProgressChangeNotify(DragonSpineChapterProgressChangeNotify other) : this() {
      chapterId_ = other.chapterId_;
      scheduleId_ = other.scheduleId_;
      curProgress_ = other.curProgress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DragonSpineChapterProgressChangeNotify Clone() {
      return new DragonSpineChapterProgressChangeNotify(this);
    }

    /// <summary>Field number for the "chapter_id" field.</summary>
    public const int ChapterIdFieldNumber = 9;
    private uint chapterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChapterId {
      get { return chapterId_; }
      set {
        chapterId_ = value;
      }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 3;
    private uint scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    /// <summary>Field number for the "cur_progress" field.</summary>
    public const int CurProgressFieldNumber = 11;
    private uint curProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurProgress {
      get { return curProgress_; }
      set {
        curProgress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DragonSpineChapterProgressChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DragonSpineChapterProgressChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChapterId != other.ChapterId) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if (CurProgress != other.CurProgress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChapterId != 0) hash ^= ChapterId.GetHashCode();
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      if (CurProgress != 0) hash ^= CurProgress.GetHashCode();
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
      if (ScheduleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ScheduleId);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChapterId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurProgress);
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
      if (ScheduleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ScheduleId);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ChapterId);
      }
      if (CurProgress != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurProgress);
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
      if (ChapterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChapterId);
      }
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
      }
      if (CurProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurProgress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DragonSpineChapterProgressChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.ChapterId != 0) {
        ChapterId = other.ChapterId;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.CurProgress != 0) {
        CurProgress = other.CurProgress;
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
          case 24: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 72: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 88: {
            CurProgress = input.ReadUInt32();
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
          case 24: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 72: {
            ChapterId = input.ReadUInt32();
            break;
          }
          case 88: {
            CurProgress = input.ReadUInt32();
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
