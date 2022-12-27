// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarPropChangeReasonNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AvatarPropChangeReasonNotify.proto</summary>
  public static partial class AvatarPropChangeReasonNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarPropChangeReasonNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarPropChangeReasonNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJBdmF0YXJQcm9wQ2hhbmdlUmVhc29uTm90aWZ5LnByb3RvGhZQcm9wQ2hh",
            "bmdlUmVhc29uLnByb3RvIo8BChxBdmF0YXJQcm9wQ2hhbmdlUmVhc29uTm90",
            "aWZ5EhEKCXByb3BfdHlwZRgHIAEoDRIhCgZyZWFzb24YDyABKA4yES5Qcm9w",
            "Q2hhbmdlUmVhc29uEhEKCWN1cl92YWx1ZRgOIAEoAhITCgthdmF0YXJfZ3Vp",
            "ZBgDIAEoBBIRCglvbGRfdmFsdWUYDSABKAJCIqoCH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.PropChangeReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AvatarPropChangeReasonNotify), global::Weedwacker.Shared.Network.Proto.AvatarPropChangeReasonNotify.Parser, new[]{ "PropType", "Reason", "CurValue", "AvatarGuid", "OldValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1278;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AvatarPropChangeReasonNotify : pb::IMessage<AvatarPropChangeReasonNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarPropChangeReasonNotify> _parser = new pb::MessageParser<AvatarPropChangeReasonNotify>(() => new AvatarPropChangeReasonNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarPropChangeReasonNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AvatarPropChangeReasonNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarPropChangeReasonNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarPropChangeReasonNotify(AvatarPropChangeReasonNotify other) : this() {
      propType_ = other.propType_;
      reason_ = other.reason_;
      curValue_ = other.curValue_;
      avatarGuid_ = other.avatarGuid_;
      oldValue_ = other.oldValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarPropChangeReasonNotify Clone() {
      return new AvatarPropChangeReasonNotify(this);
    }

    /// <summary>Field number for the "prop_type" field.</summary>
    public const int PropTypeFieldNumber = 7;
    private uint propType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropType {
      get { return propType_; }
      set {
        propType_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.PropChangeReason reason_ = global::Weedwacker.Shared.Network.Proto.PropChangeReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PropChangeReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "cur_value" field.</summary>
    public const int CurValueFieldNumber = 14;
    private float curValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CurValue {
      get { return curValue_; }
      set {
        curValue_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 3;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "old_value" field.</summary>
    public const int OldValueFieldNumber = 13;
    private float oldValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float OldValue {
      get { return oldValue_; }
      set {
        oldValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarPropChangeReasonNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarPropChangeReasonNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PropType != other.PropType) return false;
      if (Reason != other.Reason) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CurValue, other.CurValue)) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(OldValue, other.OldValue)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PropType != 0) hash ^= PropType.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.PropChangeReason.None) hash ^= Reason.GetHashCode();
      if (CurValue != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CurValue);
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (OldValue != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(OldValue);
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
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(AvatarGuid);
      }
      if (PropType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PropType);
      }
      if (OldValue != 0F) {
        output.WriteRawTag(109);
        output.WriteFloat(OldValue);
      }
      if (CurValue != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(CurValue);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.PropChangeReason.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Reason);
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
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(AvatarGuid);
      }
      if (PropType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PropType);
      }
      if (OldValue != 0F) {
        output.WriteRawTag(109);
        output.WriteFloat(OldValue);
      }
      if (CurValue != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(CurValue);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.PropChangeReason.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Reason);
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
      if (PropType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropType);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.PropChangeReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (CurValue != 0F) {
        size += 1 + 4;
      }
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (OldValue != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarPropChangeReasonNotify other) {
      if (other == null) {
        return;
      }
      if (other.PropType != 0) {
        PropType = other.PropType;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.PropChangeReason.None) {
        Reason = other.Reason;
      }
      if (other.CurValue != 0F) {
        CurValue = other.CurValue;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.OldValue != 0F) {
        OldValue = other.OldValue;
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
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 56: {
            PropType = input.ReadUInt32();
            break;
          }
          case 109: {
            OldValue = input.ReadFloat();
            break;
          }
          case 117: {
            CurValue = input.ReadFloat();
            break;
          }
          case 120: {
            Reason = (global::Weedwacker.Shared.Network.Proto.PropChangeReason) input.ReadEnum();
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
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 56: {
            PropType = input.ReadUInt32();
            break;
          }
          case 109: {
            OldValue = input.ReadFloat();
            break;
          }
          case 117: {
            CurValue = input.ReadFloat();
            break;
          }
          case 120: {
            Reason = (global::Weedwacker.Shared.Network.Proto.PropChangeReason) input.ReadEnum();
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
