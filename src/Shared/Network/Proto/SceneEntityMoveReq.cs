// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneEntityMoveReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneEntityMoveReq.proto</summary>
  public static partial class SceneEntityMoveReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneEntityMoveReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneEntityMoveReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhTY2VuZUVudGl0eU1vdmVSZXEucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8aEE1vdGlvbkluZm8ucHJvdG8ikwEKElNjZW5lRW50",
            "aXR5TW92ZVJlcRISCgpzY2VuZV90aW1lGAUgASgNEkAKC21vdGlvbl9pbmZv",
            "GAQgASgLMisuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5Nb3Rp",
            "b25JbmZvEhEKCWVudGl0eV9pZBgNIAEoDRIUCgxyZWxpYWJsZV9zZXEYAyAB",
            "KA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneEntityMoveReq), global::Weedwacker.Shared.Network.Proto.SceneEntityMoveReq.Parser, new[]{ "SceneTime", "MotionInfo", "EntityId", "ReliableSeq" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 247;
  ///   ENET_CHANNEL_ID = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class SceneEntityMoveReq : pb::IMessage<SceneEntityMoveReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneEntityMoveReq> _parser = new pb::MessageParser<SceneEntityMoveReq>(() => new SceneEntityMoveReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneEntityMoveReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneEntityMoveReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityMoveReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityMoveReq(SceneEntityMoveReq other) : this() {
      sceneTime_ = other.sceneTime_;
      motionInfo_ = other.motionInfo_ != null ? other.motionInfo_.Clone() : null;
      entityId_ = other.entityId_;
      reliableSeq_ = other.reliableSeq_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityMoveReq Clone() {
      return new SceneEntityMoveReq(this);
    }

    /// <summary>Field number for the "scene_time" field.</summary>
    public const int SceneTimeFieldNumber = 5;
    private uint sceneTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneTime {
      get { return sceneTime_; }
      set {
        sceneTime_ = value;
      }
    }

    /// <summary>Field number for the "motion_info" field.</summary>
    public const int MotionInfoFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.MotionInfo motionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MotionInfo MotionInfo {
      get { return motionInfo_; }
      set {
        motionInfo_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 13;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "reliable_seq" field.</summary>
    public const int ReliableSeqFieldNumber = 3;
    private uint reliableSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ReliableSeq {
      get { return reliableSeq_; }
      set {
        reliableSeq_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneEntityMoveReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneEntityMoveReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneTime != other.SceneTime) return false;
      if (!object.Equals(MotionInfo, other.MotionInfo)) return false;
      if (EntityId != other.EntityId) return false;
      if (ReliableSeq != other.ReliableSeq) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneTime != 0) hash ^= SceneTime.GetHashCode();
      if (motionInfo_ != null) hash ^= MotionInfo.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (ReliableSeq != 0) hash ^= ReliableSeq.GetHashCode();
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
      if (ReliableSeq != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ReliableSeq);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MotionInfo);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneTime);
      }
      if (EntityId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EntityId);
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
      if (ReliableSeq != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ReliableSeq);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MotionInfo);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneTime);
      }
      if (EntityId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EntityId);
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
      if (SceneTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneTime);
      }
      if (motionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MotionInfo);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (ReliableSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ReliableSeq);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneEntityMoveReq other) {
      if (other == null) {
        return;
      }
      if (other.SceneTime != 0) {
        SceneTime = other.SceneTime;
      }
      if (other.motionInfo_ != null) {
        if (motionInfo_ == null) {
          MotionInfo = new global::Weedwacker.Shared.Network.Proto.MotionInfo();
        }
        MotionInfo.MergeFrom(other.MotionInfo);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.ReliableSeq != 0) {
        ReliableSeq = other.ReliableSeq;
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
            ReliableSeq = input.ReadUInt32();
            break;
          }
          case 34: {
            if (motionInfo_ == null) {
              MotionInfo = new global::Weedwacker.Shared.Network.Proto.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 40: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 104: {
            EntityId = input.ReadUInt32();
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
            ReliableSeq = input.ReadUInt32();
            break;
          }
          case 34: {
            if (motionInfo_ == null) {
              MotionInfo = new global::Weedwacker.Shared.Network.Proto.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 40: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 104: {
            EntityId = input.ReadUInt32();
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
