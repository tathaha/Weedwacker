// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtBulletMoveNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtBulletMoveNotify.proto</summary>
  public static partial class EvtBulletMoveNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtBulletMoveNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtBulletMoveNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlFdnRCdWxsZXRNb3ZlTm90aWZ5LnByb3RvGhFGb3J3YXJkVHlwZS5wcm90",
            "bxoMVmVjdG9yLnByb3RvImYKE0V2dEJ1bGxldE1vdmVOb3RpZnkSIgoMZm9y",
            "d2FyZF90eXBlGAUgASgOMgwuRm9yd2FyZFR5cGUSGAoHY3VyX3BvcxgEIAEo",
            "CzIHLlZlY3RvchIRCgllbnRpdHlfaWQYDSABKA1CIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ForwardTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtBulletMoveNotify), global::Weedwacker.Shared.Network.Proto.EvtBulletMoveNotify.Parser, new[]{ "ForwardType", "CurPos", "EntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 389;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class EvtBulletMoveNotify : pb::IMessage<EvtBulletMoveNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtBulletMoveNotify> _parser = new pb::MessageParser<EvtBulletMoveNotify>(() => new EvtBulletMoveNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtBulletMoveNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtBulletMoveNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBulletMoveNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBulletMoveNotify(EvtBulletMoveNotify other) : this() {
      forwardType_ = other.forwardType_;
      curPos_ = other.curPos_ != null ? other.curPos_.Clone() : null;
      entityId_ = other.entityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBulletMoveNotify Clone() {
      return new EvtBulletMoveNotify(this);
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.ForwardType forwardType_ = global::Weedwacker.Shared.Network.Proto.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "cur_pos" field.</summary>
    public const int CurPosFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Vector curPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector CurPos {
      get { return curPos_; }
      set {
        curPos_ = value;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtBulletMoveNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtBulletMoveNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ForwardType != other.ForwardType) return false;
      if (!object.Equals(CurPos, other.CurPos)) return false;
      if (EntityId != other.EntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      if (curPos_ != null) hash ^= CurPos.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
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
      if (curPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CurPos);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ForwardType);
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
      if (curPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CurPos);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ForwardType);
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
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (curPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurPos);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtBulletMoveNotify other) {
      if (other == null) {
        return;
      }
      if (other.ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      if (other.curPos_ != null) {
        if (curPos_ == null) {
          CurPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        CurPos.MergeFrom(other.CurPos);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
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
          case 34: {
            if (curPos_ == null) {
              CurPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(CurPos);
            break;
          }
          case 40: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
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
          case 34: {
            if (curPos_ == null) {
              CurPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(CurPos);
            break;
          }
          case 40: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
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
