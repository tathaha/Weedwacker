// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtGrapplingHookMove.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtGrapplingHookMove.proto</summary>
  public static partial class EvtGrapplingHookMoveReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtGrapplingHookMove.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtGrapplingHookMoveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFdnRHcmFwcGxpbmdIb29rTW92ZS5wcm90bxoMVmVjdG9yLnByb3RvIoQC",
            "ChRFdnRHcmFwcGxpbmdIb29rTW92ZRIbCgp0YXJnZXRfcG9zGAQgASgLMgcu",
            "VmVjdG9yEhEKCWVudGl0eV9pZBgKIAEoDRINCgVzcGVlZBgCIAEoAhIbChNV",
            "bmszMzAwX05ETUhLTkZNUENKGAUgASgCEh4KFmFuaW1hdG9yX3N0YXRlX2lk",
            "X2xpc3QYCyADKA0SGwoTVW5rMzMwMF9CR09MUExIR0dQTxgBIAEoCBIbChNV",
            "bmszMzAwX01KQU9BTFBDSk1MGAkgASgCEhsKE1VuazMzMDBfQktFRUxDR09M",
            "TE4YDyABKAgSGQoRb3ZlcnJpZGVfY29sbGlkZXIYAyABKAlCIqoCH1dlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtGrapplingHookMove), global::Weedwacker.Shared.Network.Proto.EvtGrapplingHookMove.Parser, new[]{ "TargetPos", "EntityId", "Speed", "Unk3300NDMHKNFMPCJ", "AnimatorStateIdList", "Unk3300BGOLPLHGGPO", "Unk3300MJAOALPCJML", "Unk3300BKEELCGOLLN", "OverrideCollider" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtGrapplingHookMove : pb::IMessage<EvtGrapplingHookMove>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtGrapplingHookMove> _parser = new pb::MessageParser<EvtGrapplingHookMove>(() => new EvtGrapplingHookMove());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtGrapplingHookMove> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtGrapplingHookMoveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtGrapplingHookMove() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtGrapplingHookMove(EvtGrapplingHookMove other) : this() {
      targetPos_ = other.targetPos_ != null ? other.targetPos_.Clone() : null;
      entityId_ = other.entityId_;
      speed_ = other.speed_;
      unk3300NDMHKNFMPCJ_ = other.unk3300NDMHKNFMPCJ_;
      animatorStateIdList_ = other.animatorStateIdList_.Clone();
      unk3300BGOLPLHGGPO_ = other.unk3300BGOLPLHGGPO_;
      unk3300MJAOALPCJML_ = other.unk3300MJAOALPCJML_;
      unk3300BKEELCGOLLN_ = other.unk3300BKEELCGOLLN_;
      overrideCollider_ = other.overrideCollider_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtGrapplingHookMove Clone() {
      return new EvtGrapplingHookMove(this);
    }

    /// <summary>Field number for the "target_pos" field.</summary>
    public const int TargetPosFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Vector targetPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector TargetPos {
      get { return targetPos_; }
      set {
        targetPos_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 10;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 2;
    private float speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NDMHKNFMPCJ" field.</summary>
    public const int Unk3300NDMHKNFMPCJFieldNumber = 5;
    private float unk3300NDMHKNFMPCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300NDMHKNFMPCJ {
      get { return unk3300NDMHKNFMPCJ_; }
      set {
        unk3300NDMHKNFMPCJ_ = value;
      }
    }

    /// <summary>Field number for the "animator_state_id_list" field.</summary>
    public const int AnimatorStateIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_animatorStateIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> animatorStateIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AnimatorStateIdList {
      get { return animatorStateIdList_; }
    }

    /// <summary>Field number for the "Unk3300_BGOLPLHGGPO" field.</summary>
    public const int Unk3300BGOLPLHGGPOFieldNumber = 1;
    private bool unk3300BGOLPLHGGPO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300BGOLPLHGGPO {
      get { return unk3300BGOLPLHGGPO_; }
      set {
        unk3300BGOLPLHGGPO_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MJAOALPCJML" field.</summary>
    public const int Unk3300MJAOALPCJMLFieldNumber = 9;
    private float unk3300MJAOALPCJML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300MJAOALPCJML {
      get { return unk3300MJAOALPCJML_; }
      set {
        unk3300MJAOALPCJML_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BKEELCGOLLN" field.</summary>
    public const int Unk3300BKEELCGOLLNFieldNumber = 15;
    private bool unk3300BKEELCGOLLN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300BKEELCGOLLN {
      get { return unk3300BKEELCGOLLN_; }
      set {
        unk3300BKEELCGOLLN_ = value;
      }
    }

    /// <summary>Field number for the "override_collider" field.</summary>
    public const int OverrideColliderFieldNumber = 3;
    private string overrideCollider_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OverrideCollider {
      get { return overrideCollider_; }
      set {
        overrideCollider_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtGrapplingHookMove);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtGrapplingHookMove other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TargetPos, other.TargetPos)) return false;
      if (EntityId != other.EntityId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Speed, other.Speed)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300NDMHKNFMPCJ, other.Unk3300NDMHKNFMPCJ)) return false;
      if(!animatorStateIdList_.Equals(other.animatorStateIdList_)) return false;
      if (Unk3300BGOLPLHGGPO != other.Unk3300BGOLPLHGGPO) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300MJAOALPCJML, other.Unk3300MJAOALPCJML)) return false;
      if (Unk3300BKEELCGOLLN != other.Unk3300BKEELCGOLLN) return false;
      if (OverrideCollider != other.OverrideCollider) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (targetPos_ != null) hash ^= TargetPos.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (Speed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Speed);
      if (Unk3300NDMHKNFMPCJ != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300NDMHKNFMPCJ);
      hash ^= animatorStateIdList_.GetHashCode();
      if (Unk3300BGOLPLHGGPO != false) hash ^= Unk3300BGOLPLHGGPO.GetHashCode();
      if (Unk3300MJAOALPCJML != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300MJAOALPCJML);
      if (Unk3300BKEELCGOLLN != false) hash ^= Unk3300BKEELCGOLLN.GetHashCode();
      if (OverrideCollider.Length != 0) hash ^= OverrideCollider.GetHashCode();
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
      if (Unk3300BGOLPLHGGPO != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300BGOLPLHGGPO);
      }
      if (Speed != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Speed);
      }
      if (OverrideCollider.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OverrideCollider);
      }
      if (targetPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TargetPos);
      }
      if (Unk3300NDMHKNFMPCJ != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Unk3300NDMHKNFMPCJ);
      }
      if (Unk3300MJAOALPCJML != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(Unk3300MJAOALPCJML);
      }
      if (EntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EntityId);
      }
      animatorStateIdList_.WriteTo(output, _repeated_animatorStateIdList_codec);
      if (Unk3300BKEELCGOLLN != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300BKEELCGOLLN);
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
      if (Unk3300BGOLPLHGGPO != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300BGOLPLHGGPO);
      }
      if (Speed != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Speed);
      }
      if (OverrideCollider.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(OverrideCollider);
      }
      if (targetPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TargetPos);
      }
      if (Unk3300NDMHKNFMPCJ != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Unk3300NDMHKNFMPCJ);
      }
      if (Unk3300MJAOALPCJML != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(Unk3300MJAOALPCJML);
      }
      if (EntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EntityId);
      }
      animatorStateIdList_.WriteTo(ref output, _repeated_animatorStateIdList_codec);
      if (Unk3300BKEELCGOLLN != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300BKEELCGOLLN);
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
      if (targetPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetPos);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (Speed != 0F) {
        size += 1 + 4;
      }
      if (Unk3300NDMHKNFMPCJ != 0F) {
        size += 1 + 4;
      }
      size += animatorStateIdList_.CalculateSize(_repeated_animatorStateIdList_codec);
      if (Unk3300BGOLPLHGGPO != false) {
        size += 1 + 1;
      }
      if (Unk3300MJAOALPCJML != 0F) {
        size += 1 + 4;
      }
      if (Unk3300BKEELCGOLLN != false) {
        size += 1 + 1;
      }
      if (OverrideCollider.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OverrideCollider);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtGrapplingHookMove other) {
      if (other == null) {
        return;
      }
      if (other.targetPos_ != null) {
        if (targetPos_ == null) {
          TargetPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        TargetPos.MergeFrom(other.TargetPos);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.Speed != 0F) {
        Speed = other.Speed;
      }
      if (other.Unk3300NDMHKNFMPCJ != 0F) {
        Unk3300NDMHKNFMPCJ = other.Unk3300NDMHKNFMPCJ;
      }
      animatorStateIdList_.Add(other.animatorStateIdList_);
      if (other.Unk3300BGOLPLHGGPO != false) {
        Unk3300BGOLPLHGGPO = other.Unk3300BGOLPLHGGPO;
      }
      if (other.Unk3300MJAOALPCJML != 0F) {
        Unk3300MJAOALPCJML = other.Unk3300MJAOALPCJML;
      }
      if (other.Unk3300BKEELCGOLLN != false) {
        Unk3300BKEELCGOLLN = other.Unk3300BKEELCGOLLN;
      }
      if (other.OverrideCollider.Length != 0) {
        OverrideCollider = other.OverrideCollider;
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
            Unk3300BGOLPLHGGPO = input.ReadBool();
            break;
          }
          case 21: {
            Speed = input.ReadFloat();
            break;
          }
          case 26: {
            OverrideCollider = input.ReadString();
            break;
          }
          case 34: {
            if (targetPos_ == null) {
              TargetPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(TargetPos);
            break;
          }
          case 45: {
            Unk3300NDMHKNFMPCJ = input.ReadFloat();
            break;
          }
          case 77: {
            Unk3300MJAOALPCJML = input.ReadFloat();
            break;
          }
          case 80: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            animatorStateIdList_.AddEntriesFrom(input, _repeated_animatorStateIdList_codec);
            break;
          }
          case 120: {
            Unk3300BKEELCGOLLN = input.ReadBool();
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
            Unk3300BGOLPLHGGPO = input.ReadBool();
            break;
          }
          case 21: {
            Speed = input.ReadFloat();
            break;
          }
          case 26: {
            OverrideCollider = input.ReadString();
            break;
          }
          case 34: {
            if (targetPos_ == null) {
              TargetPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(TargetPos);
            break;
          }
          case 45: {
            Unk3300NDMHKNFMPCJ = input.ReadFloat();
            break;
          }
          case 77: {
            Unk3300MJAOALPCJML = input.ReadFloat();
            break;
          }
          case 80: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            animatorStateIdList_.AddEntriesFrom(ref input, _repeated_animatorStateIdList_codec);
            break;
          }
          case 120: {
            Unk3300BKEELCGOLLN = input.ReadBool();
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
