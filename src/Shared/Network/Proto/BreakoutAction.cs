// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BreakoutAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BreakoutAction.proto</summary>
  public static partial class BreakoutActionReflection {

    #region Descriptor
    /// <summary>File descriptor for BreakoutAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BreakoutActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRCcmVha291dEFjdGlvbi5wcm90bxoVQnJlYWtvdXRWZWN0b3IyLnByb3Rv",
            "IsMFCg5CcmVha291dEFjdGlvbhI3CgthY3Rpb25fdHlwZRgBIAEoDjIiLkJy",
            "ZWFrb3V0QWN0aW9uLkJyZWFrb3V0QWN0aW9uVHlwZRIYChBjbGllbnRfZ2Ft",
            "ZV90aW1lGAIgASgEEhgKEHNlcnZlcl9nYW1lX3RpbWUYAyABKAQSEQoJaXNf",
            "ZmFpbGVkGAQgASgIEhEKCXByZV9pbmRleBgFIAEoDRIRCgluZXdfaW5kZXgY",
            "BiABKA0SHQoDcG9zGAcgASgLMhAuQnJlYWtvdXRWZWN0b3IyEiIKCG1vdmVf",
            "ZGlyGAggASgLMhAuQnJlYWtvdXRWZWN0b3IyEg0KBXNwZWVkGAkgASgFEg8K",
            "B3BlZXJfaWQYCiABKA0SFAoMZWxlbWVudF90eXBlGAsgASgNEh0KFWVsZW1l",
            "bnRfcmVhY3Rpb25fYnVmZhgMIAEoDRIcChRzcGVlZF9pbmNyZWFzZV9jb3Vu",
            "dBgNIAEoDRIWCg5oYXNfZXh0cmFfYmFsbBgOIAEoCBIoCg5leHRyYV9iYWxs",
            "X2RpchgPIAEoCzIQLkJyZWFrb3V0VmVjdG9yMhIYChBleHRyYV9iYWxsX2lu",
            "ZGV4GBAgASgNEg4KBm9mZnNldBgRIAEoBRIbChNVbmszMzAwX0FJRUJHSkhC",
            "T0hMGBIgASgEIssBChJCcmVha291dEFjdGlvblR5cGUSHQoZQlJFQUtPVVRf",
            "QUNUSU9OX1RZUEVfTk9ORRAAEiQKIEJSRUFLT1VUX0FDVElPTl9UWVBFX0xB",
            "VU5DSF9CQUxMEAESJQohQlJFQUtPVVRfQUNUSU9OX1RZUEVfREVTVFJPWV9C",
            "QUxMEAISJwojQlJFQUtPVVRfQUNUSU9OX1RZUEVfRkFMTElOR19PQkpFQ1QQ",
            "AxIgChxCUkVBS09VVF9BQ1RJT05fVFlQRV9NSVNTSUxFEARCIqoCH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BreakoutVector2Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BreakoutAction), global::Weedwacker.Shared.Network.Proto.BreakoutAction.Parser, new[]{ "ActionType", "ClientGameTime", "ServerGameTime", "IsFailed", "PreIndex", "NewIndex", "Pos", "MoveDir", "Speed", "PeerId", "ElementType", "ElementReactionBuff", "SpeedIncreaseCount", "HasExtraBall", "ExtraBallDir", "ExtraBallIndex", "Offset", "Unk3300AIEBGJHBOHL" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BreakoutAction : pb::IMessage<BreakoutAction>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BreakoutAction> _parser = new pb::MessageParser<BreakoutAction>(() => new BreakoutAction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BreakoutAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BreakoutActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutAction(BreakoutAction other) : this() {
      actionType_ = other.actionType_;
      clientGameTime_ = other.clientGameTime_;
      serverGameTime_ = other.serverGameTime_;
      isFailed_ = other.isFailed_;
      preIndex_ = other.preIndex_;
      newIndex_ = other.newIndex_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      moveDir_ = other.moveDir_ != null ? other.moveDir_.Clone() : null;
      speed_ = other.speed_;
      peerId_ = other.peerId_;
      elementType_ = other.elementType_;
      elementReactionBuff_ = other.elementReactionBuff_;
      speedIncreaseCount_ = other.speedIncreaseCount_;
      hasExtraBall_ = other.hasExtraBall_;
      extraBallDir_ = other.extraBallDir_ != null ? other.extraBallDir_.Clone() : null;
      extraBallIndex_ = other.extraBallIndex_;
      offset_ = other.offset_;
      unk3300AIEBGJHBOHL_ = other.unk3300AIEBGJHBOHL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutAction Clone() {
      return new BreakoutAction(this);
    }

    /// <summary>Field number for the "action_type" field.</summary>
    public const int ActionTypeFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType actionType_ = global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType ActionType {
      get { return actionType_; }
      set {
        actionType_ = value;
      }
    }

    /// <summary>Field number for the "client_game_time" field.</summary>
    public const int ClientGameTimeFieldNumber = 2;
    private ulong clientGameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ClientGameTime {
      get { return clientGameTime_; }
      set {
        clientGameTime_ = value;
      }
    }

    /// <summary>Field number for the "server_game_time" field.</summary>
    public const int ServerGameTimeFieldNumber = 3;
    private ulong serverGameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ServerGameTime {
      get { return serverGameTime_; }
      set {
        serverGameTime_ = value;
      }
    }

    /// <summary>Field number for the "is_failed" field.</summary>
    public const int IsFailedFieldNumber = 4;
    private bool isFailed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFailed {
      get { return isFailed_; }
      set {
        isFailed_ = value;
      }
    }

    /// <summary>Field number for the "pre_index" field.</summary>
    public const int PreIndexFieldNumber = 5;
    private uint preIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PreIndex {
      get { return preIndex_; }
      set {
        preIndex_ = value;
      }
    }

    /// <summary>Field number for the "new_index" field.</summary>
    public const int NewIndexFieldNumber = 6;
    private uint newIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NewIndex {
      get { return newIndex_; }
      set {
        newIndex_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.BreakoutVector2 pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BreakoutVector2 Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "move_dir" field.</summary>
    public const int MoveDirFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.BreakoutVector2 moveDir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BreakoutVector2 MoveDir {
      get { return moveDir_; }
      set {
        moveDir_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 9;
    private int speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "peer_id" field.</summary>
    public const int PeerIdFieldNumber = 10;
    private uint peerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PeerId {
      get { return peerId_; }
      set {
        peerId_ = value;
      }
    }

    /// <summary>Field number for the "element_type" field.</summary>
    public const int ElementTypeFieldNumber = 11;
    private uint elementType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ElementType {
      get { return elementType_; }
      set {
        elementType_ = value;
      }
    }

    /// <summary>Field number for the "element_reaction_buff" field.</summary>
    public const int ElementReactionBuffFieldNumber = 12;
    private uint elementReactionBuff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ElementReactionBuff {
      get { return elementReactionBuff_; }
      set {
        elementReactionBuff_ = value;
      }
    }

    /// <summary>Field number for the "speed_increase_count" field.</summary>
    public const int SpeedIncreaseCountFieldNumber = 13;
    private uint speedIncreaseCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SpeedIncreaseCount {
      get { return speedIncreaseCount_; }
      set {
        speedIncreaseCount_ = value;
      }
    }

    /// <summary>Field number for the "has_extra_ball" field.</summary>
    public const int HasExtraBallFieldNumber = 14;
    private bool hasExtraBall_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasExtraBall {
      get { return hasExtraBall_; }
      set {
        hasExtraBall_ = value;
      }
    }

    /// <summary>Field number for the "extra_ball_dir" field.</summary>
    public const int ExtraBallDirFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.BreakoutVector2 extraBallDir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BreakoutVector2 ExtraBallDir {
      get { return extraBallDir_; }
      set {
        extraBallDir_ = value;
      }
    }

    /// <summary>Field number for the "extra_ball_index" field.</summary>
    public const int ExtraBallIndexFieldNumber = 16;
    private uint extraBallIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraBallIndex {
      get { return extraBallIndex_; }
      set {
        extraBallIndex_ = value;
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 17;
    private int offset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AIEBGJHBOHL" field.</summary>
    public const int Unk3300AIEBGJHBOHLFieldNumber = 18;
    private ulong unk3300AIEBGJHBOHL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk3300AIEBGJHBOHL {
      get { return unk3300AIEBGJHBOHL_; }
      set {
        unk3300AIEBGJHBOHL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BreakoutAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BreakoutAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActionType != other.ActionType) return false;
      if (ClientGameTime != other.ClientGameTime) return false;
      if (ServerGameTime != other.ServerGameTime) return false;
      if (IsFailed != other.IsFailed) return false;
      if (PreIndex != other.PreIndex) return false;
      if (NewIndex != other.NewIndex) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(MoveDir, other.MoveDir)) return false;
      if (Speed != other.Speed) return false;
      if (PeerId != other.PeerId) return false;
      if (ElementType != other.ElementType) return false;
      if (ElementReactionBuff != other.ElementReactionBuff) return false;
      if (SpeedIncreaseCount != other.SpeedIncreaseCount) return false;
      if (HasExtraBall != other.HasExtraBall) return false;
      if (!object.Equals(ExtraBallDir, other.ExtraBallDir)) return false;
      if (ExtraBallIndex != other.ExtraBallIndex) return false;
      if (Offset != other.Offset) return false;
      if (Unk3300AIEBGJHBOHL != other.Unk3300AIEBGJHBOHL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActionType != global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType.None) hash ^= ActionType.GetHashCode();
      if (ClientGameTime != 0UL) hash ^= ClientGameTime.GetHashCode();
      if (ServerGameTime != 0UL) hash ^= ServerGameTime.GetHashCode();
      if (IsFailed != false) hash ^= IsFailed.GetHashCode();
      if (PreIndex != 0) hash ^= PreIndex.GetHashCode();
      if (NewIndex != 0) hash ^= NewIndex.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (moveDir_ != null) hash ^= MoveDir.GetHashCode();
      if (Speed != 0) hash ^= Speed.GetHashCode();
      if (PeerId != 0) hash ^= PeerId.GetHashCode();
      if (ElementType != 0) hash ^= ElementType.GetHashCode();
      if (ElementReactionBuff != 0) hash ^= ElementReactionBuff.GetHashCode();
      if (SpeedIncreaseCount != 0) hash ^= SpeedIncreaseCount.GetHashCode();
      if (HasExtraBall != false) hash ^= HasExtraBall.GetHashCode();
      if (extraBallDir_ != null) hash ^= ExtraBallDir.GetHashCode();
      if (ExtraBallIndex != 0) hash ^= ExtraBallIndex.GetHashCode();
      if (Offset != 0) hash ^= Offset.GetHashCode();
      if (Unk3300AIEBGJHBOHL != 0UL) hash ^= Unk3300AIEBGJHBOHL.GetHashCode();
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
      if (ActionType != global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ActionType);
      }
      if (ClientGameTime != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ClientGameTime);
      }
      if (ServerGameTime != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ServerGameTime);
      }
      if (IsFailed != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsFailed);
      }
      if (PreIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PreIndex);
      }
      if (NewIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NewIndex);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (moveDir_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MoveDir);
      }
      if (Speed != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Speed);
      }
      if (PeerId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PeerId);
      }
      if (ElementType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ElementType);
      }
      if (ElementReactionBuff != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ElementReactionBuff);
      }
      if (SpeedIncreaseCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SpeedIncreaseCount);
      }
      if (HasExtraBall != false) {
        output.WriteRawTag(112);
        output.WriteBool(HasExtraBall);
      }
      if (extraBallDir_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(ExtraBallDir);
      }
      if (ExtraBallIndex != 0) {
        output.WriteRawTag(128, 1);
        output.WriteUInt32(ExtraBallIndex);
      }
      if (Offset != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(Offset);
      }
      if (Unk3300AIEBGJHBOHL != 0UL) {
        output.WriteRawTag(144, 1);
        output.WriteUInt64(Unk3300AIEBGJHBOHL);
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
      if (ActionType != global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ActionType);
      }
      if (ClientGameTime != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ClientGameTime);
      }
      if (ServerGameTime != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ServerGameTime);
      }
      if (IsFailed != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsFailed);
      }
      if (PreIndex != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PreIndex);
      }
      if (NewIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NewIndex);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (moveDir_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(MoveDir);
      }
      if (Speed != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Speed);
      }
      if (PeerId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PeerId);
      }
      if (ElementType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ElementType);
      }
      if (ElementReactionBuff != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ElementReactionBuff);
      }
      if (SpeedIncreaseCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SpeedIncreaseCount);
      }
      if (HasExtraBall != false) {
        output.WriteRawTag(112);
        output.WriteBool(HasExtraBall);
      }
      if (extraBallDir_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(ExtraBallDir);
      }
      if (ExtraBallIndex != 0) {
        output.WriteRawTag(128, 1);
        output.WriteUInt32(ExtraBallIndex);
      }
      if (Offset != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(Offset);
      }
      if (Unk3300AIEBGJHBOHL != 0UL) {
        output.WriteRawTag(144, 1);
        output.WriteUInt64(Unk3300AIEBGJHBOHL);
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
      if (ActionType != global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ActionType);
      }
      if (ClientGameTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ClientGameTime);
      }
      if (ServerGameTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ServerGameTime);
      }
      if (IsFailed != false) {
        size += 1 + 1;
      }
      if (PreIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PreIndex);
      }
      if (NewIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NewIndex);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (moveDir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveDir);
      }
      if (Speed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Speed);
      }
      if (PeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PeerId);
      }
      if (ElementType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementType);
      }
      if (ElementReactionBuff != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementReactionBuff);
      }
      if (SpeedIncreaseCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SpeedIncreaseCount);
      }
      if (HasExtraBall != false) {
        size += 1 + 1;
      }
      if (extraBallDir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExtraBallDir);
      }
      if (ExtraBallIndex != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ExtraBallIndex);
      }
      if (Offset != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Offset);
      }
      if (Unk3300AIEBGJHBOHL != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(Unk3300AIEBGJHBOHL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BreakoutAction other) {
      if (other == null) {
        return;
      }
      if (other.ActionType != global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType.None) {
        ActionType = other.ActionType;
      }
      if (other.ClientGameTime != 0UL) {
        ClientGameTime = other.ClientGameTime;
      }
      if (other.ServerGameTime != 0UL) {
        ServerGameTime = other.ServerGameTime;
      }
      if (other.IsFailed != false) {
        IsFailed = other.IsFailed;
      }
      if (other.PreIndex != 0) {
        PreIndex = other.PreIndex;
      }
      if (other.NewIndex != 0) {
        NewIndex = other.NewIndex;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.moveDir_ != null) {
        if (moveDir_ == null) {
          MoveDir = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
        }
        MoveDir.MergeFrom(other.MoveDir);
      }
      if (other.Speed != 0) {
        Speed = other.Speed;
      }
      if (other.PeerId != 0) {
        PeerId = other.PeerId;
      }
      if (other.ElementType != 0) {
        ElementType = other.ElementType;
      }
      if (other.ElementReactionBuff != 0) {
        ElementReactionBuff = other.ElementReactionBuff;
      }
      if (other.SpeedIncreaseCount != 0) {
        SpeedIncreaseCount = other.SpeedIncreaseCount;
      }
      if (other.HasExtraBall != false) {
        HasExtraBall = other.HasExtraBall;
      }
      if (other.extraBallDir_ != null) {
        if (extraBallDir_ == null) {
          ExtraBallDir = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
        }
        ExtraBallDir.MergeFrom(other.ExtraBallDir);
      }
      if (other.ExtraBallIndex != 0) {
        ExtraBallIndex = other.ExtraBallIndex;
      }
      if (other.Offset != 0) {
        Offset = other.Offset;
      }
      if (other.Unk3300AIEBGJHBOHL != 0UL) {
        Unk3300AIEBGJHBOHL = other.Unk3300AIEBGJHBOHL;
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
          case 8: {
            ActionType = (global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType) input.ReadEnum();
            break;
          }
          case 16: {
            ClientGameTime = input.ReadUInt64();
            break;
          }
          case 24: {
            ServerGameTime = input.ReadUInt64();
            break;
          }
          case 32: {
            IsFailed = input.ReadBool();
            break;
          }
          case 40: {
            PreIndex = input.ReadUInt32();
            break;
          }
          case 48: {
            NewIndex = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 66: {
            if (moveDir_ == null) {
              MoveDir = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
            }
            input.ReadMessage(MoveDir);
            break;
          }
          case 72: {
            Speed = input.ReadInt32();
            break;
          }
          case 80: {
            PeerId = input.ReadUInt32();
            break;
          }
          case 88: {
            ElementType = input.ReadUInt32();
            break;
          }
          case 96: {
            ElementReactionBuff = input.ReadUInt32();
            break;
          }
          case 104: {
            SpeedIncreaseCount = input.ReadUInt32();
            break;
          }
          case 112: {
            HasExtraBall = input.ReadBool();
            break;
          }
          case 122: {
            if (extraBallDir_ == null) {
              ExtraBallDir = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
            }
            input.ReadMessage(ExtraBallDir);
            break;
          }
          case 128: {
            ExtraBallIndex = input.ReadUInt32();
            break;
          }
          case 136: {
            Offset = input.ReadInt32();
            break;
          }
          case 144: {
            Unk3300AIEBGJHBOHL = input.ReadUInt64();
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
          case 8: {
            ActionType = (global::Weedwacker.Shared.Network.Proto.BreakoutAction.Types.BreakoutActionType) input.ReadEnum();
            break;
          }
          case 16: {
            ClientGameTime = input.ReadUInt64();
            break;
          }
          case 24: {
            ServerGameTime = input.ReadUInt64();
            break;
          }
          case 32: {
            IsFailed = input.ReadBool();
            break;
          }
          case 40: {
            PreIndex = input.ReadUInt32();
            break;
          }
          case 48: {
            NewIndex = input.ReadUInt32();
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 66: {
            if (moveDir_ == null) {
              MoveDir = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
            }
            input.ReadMessage(MoveDir);
            break;
          }
          case 72: {
            Speed = input.ReadInt32();
            break;
          }
          case 80: {
            PeerId = input.ReadUInt32();
            break;
          }
          case 88: {
            ElementType = input.ReadUInt32();
            break;
          }
          case 96: {
            ElementReactionBuff = input.ReadUInt32();
            break;
          }
          case 104: {
            SpeedIncreaseCount = input.ReadUInt32();
            break;
          }
          case 112: {
            HasExtraBall = input.ReadBool();
            break;
          }
          case 122: {
            if (extraBallDir_ == null) {
              ExtraBallDir = new global::Weedwacker.Shared.Network.Proto.BreakoutVector2();
            }
            input.ReadMessage(ExtraBallDir);
            break;
          }
          case 128: {
            ExtraBallIndex = input.ReadUInt32();
            break;
          }
          case 136: {
            Offset = input.ReadInt32();
            break;
          }
          case 144: {
            Unk3300AIEBGJHBOHL = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BreakoutAction message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum BreakoutActionType {
        [pbr::OriginalName("BREAKOUT_ACTION_TYPE_NONE")] None = 0,
        [pbr::OriginalName("BREAKOUT_ACTION_TYPE_LAUNCH_BALL")] LaunchBall = 1,
        [pbr::OriginalName("BREAKOUT_ACTION_TYPE_DESTROY_BALL")] DestroyBall = 2,
        [pbr::OriginalName("BREAKOUT_ACTION_TYPE_FALLING_OBJECT")] FallingObject = 3,
        [pbr::OriginalName("BREAKOUT_ACTION_TYPE_MISSILE")] Missile = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
