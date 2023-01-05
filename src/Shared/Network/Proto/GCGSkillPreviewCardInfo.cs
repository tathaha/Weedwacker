// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewCardInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewCardInfo.proto</summary>
  public static partial class GCGSkillPreviewCardInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewCardInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewCardInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HQ0dTa2lsbFByZXZpZXdDYXJkSW5mby5wcm90bxoRR0NHWm9uZVR5cGUu",
            "cHJvdG8ioQEKF0dDR1NraWxsUHJldmlld0NhcmRJbmZvEhEKCWNhcmRfZ3Vp",
            "ZBgKIAEoDRIRCglmYWNlX3R5cGUYAiABKA0SFQoNY29udHJvbGxlcl9pZBgL",
            "IAEoDRIPCgdjYXJkX2lkGAggASgNEh8KCXpvbmVfdHlwZRgOIAEoDjIMLkdD",
            "R1pvbmVUeXBlEhcKD293bmVyX2NhcmRfZ3VpZBgDIAEoDUIiqgIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGZoneTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo), global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfo.Parser, new[]{ "CardGuid", "FaceType", "ControllerId", "CardId", "ZoneType", "OwnerCardGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGSkillPreviewCardInfo : pb::IMessage<GCGSkillPreviewCardInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewCardInfo> _parser = new pb::MessageParser<GCGSkillPreviewCardInfo>(() => new GCGSkillPreviewCardInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewCardInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewCardInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewCardInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewCardInfo(GCGSkillPreviewCardInfo other) : this() {
      cardGuid_ = other.cardGuid_;
      faceType_ = other.faceType_;
      controllerId_ = other.controllerId_;
      cardId_ = other.cardId_;
      zoneType_ = other.zoneType_;
      ownerCardGuid_ = other.ownerCardGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewCardInfo Clone() {
      return new GCGSkillPreviewCardInfo(this);
    }

    /// <summary>Field number for the "card_guid" field.</summary>
    public const int CardGuidFieldNumber = 10;
    private uint cardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardGuid {
      get { return cardGuid_; }
      set {
        cardGuid_ = value;
      }
    }

    /// <summary>Field number for the "face_type" field.</summary>
    public const int FaceTypeFieldNumber = 2;
    private uint faceType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FaceType {
      get { return faceType_; }
      set {
        faceType_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 11;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "card_id" field.</summary>
    public const int CardIdFieldNumber = 8;
    private uint cardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardId {
      get { return cardId_; }
      set {
        cardId_ = value;
      }
    }

    /// <summary>Field number for the "zone_type" field.</summary>
    public const int ZoneTypeFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.GCGZoneType zoneType_ = global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGZoneType ZoneType {
      get { return zoneType_; }
      set {
        zoneType_ = value;
      }
    }

    /// <summary>Field number for the "owner_card_guid" field.</summary>
    public const int OwnerCardGuidFieldNumber = 3;
    private uint ownerCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerCardGuid {
      get { return ownerCardGuid_; }
      set {
        ownerCardGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewCardInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewCardInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CardGuid != other.CardGuid) return false;
      if (FaceType != other.FaceType) return false;
      if (ControllerId != other.ControllerId) return false;
      if (CardId != other.CardId) return false;
      if (ZoneType != other.ZoneType) return false;
      if (OwnerCardGuid != other.OwnerCardGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CardGuid != 0) hash ^= CardGuid.GetHashCode();
      if (FaceType != 0) hash ^= FaceType.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      if (CardId != 0) hash ^= CardId.GetHashCode();
      if (ZoneType != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) hash ^= ZoneType.GetHashCode();
      if (OwnerCardGuid != 0) hash ^= OwnerCardGuid.GetHashCode();
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
      if (FaceType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FaceType);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OwnerCardGuid);
      }
      if (CardId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CardId);
      }
      if (CardGuid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CardGuid);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ControllerId);
      }
      if (ZoneType != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        output.WriteRawTag(112);
        output.WriteEnum((int) ZoneType);
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
      if (FaceType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FaceType);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OwnerCardGuid);
      }
      if (CardId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CardId);
      }
      if (CardGuid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CardGuid);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ControllerId);
      }
      if (ZoneType != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        output.WriteRawTag(112);
        output.WriteEnum((int) ZoneType);
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
      if (CardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardGuid);
      }
      if (FaceType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FaceType);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (CardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardId);
      }
      if (ZoneType != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ZoneType);
      }
      if (OwnerCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerCardGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewCardInfo other) {
      if (other == null) {
        return;
      }
      if (other.CardGuid != 0) {
        CardGuid = other.CardGuid;
      }
      if (other.FaceType != 0) {
        FaceType = other.FaceType;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      if (other.CardId != 0) {
        CardId = other.CardId;
      }
      if (other.ZoneType != global::Weedwacker.Shared.Network.Proto.GCGZoneType.Invalid) {
        ZoneType = other.ZoneType;
      }
      if (other.OwnerCardGuid != 0) {
        OwnerCardGuid = other.OwnerCardGuid;
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
            FaceType = input.ReadUInt32();
            break;
          }
          case 24: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 64: {
            CardId = input.ReadUInt32();
            break;
          }
          case 80: {
            CardGuid = input.ReadUInt32();
            break;
          }
          case 88: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 112: {
            ZoneType = (global::Weedwacker.Shared.Network.Proto.GCGZoneType) input.ReadEnum();
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
            FaceType = input.ReadUInt32();
            break;
          }
          case 24: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 64: {
            CardId = input.ReadUInt32();
            break;
          }
          case 80: {
            CardGuid = input.ReadUInt32();
            break;
          }
          case 88: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 112: {
            ZoneType = (global::Weedwacker.Shared.Network.Proto.GCGZoneType) input.ReadEnum();
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
