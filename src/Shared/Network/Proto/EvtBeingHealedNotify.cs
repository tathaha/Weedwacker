// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtBeingHealedNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtBeingHealedNotify.proto</summary>
  public static partial class EvtBeingHealedNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtBeingHealedNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtBeingHealedNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFdnRCZWluZ0hlYWxlZE5vdGlmeS5wcm90byJrChRFdnRCZWluZ0hlYWxl",
            "ZE5vdGlmeRIYChByZWFsX2hlYWxfYW1vdW50GAIgASgCEhMKC2hlYWxfYW1v",
            "dW50GAMgASgCEhEKCXRhcmdldF9pZBgEIAEoDRIRCglzb3VyY2VfaWQYBiAB",
            "KA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtBeingHealedNotify), global::Weedwacker.Shared.Network.Proto.EvtBeingHealedNotify.Parser, new[]{ "RealHealAmount", "HealAmount", "TargetId", "SourceId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 366;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class EvtBeingHealedNotify : pb::IMessage<EvtBeingHealedNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtBeingHealedNotify> _parser = new pb::MessageParser<EvtBeingHealedNotify>(() => new EvtBeingHealedNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtBeingHealedNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtBeingHealedNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBeingHealedNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBeingHealedNotify(EvtBeingHealedNotify other) : this() {
      realHealAmount_ = other.realHealAmount_;
      healAmount_ = other.healAmount_;
      targetId_ = other.targetId_;
      sourceId_ = other.sourceId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBeingHealedNotify Clone() {
      return new EvtBeingHealedNotify(this);
    }

    /// <summary>Field number for the "real_heal_amount" field.</summary>
    public const int RealHealAmountFieldNumber = 2;
    private float realHealAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float RealHealAmount {
      get { return realHealAmount_; }
      set {
        realHealAmount_ = value;
      }
    }

    /// <summary>Field number for the "heal_amount" field.</summary>
    public const int HealAmountFieldNumber = 3;
    private float healAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float HealAmount {
      get { return healAmount_; }
      set {
        healAmount_ = value;
      }
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 4;
    private uint targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }

    /// <summary>Field number for the "source_id" field.</summary>
    public const int SourceIdFieldNumber = 6;
    private uint sourceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceId {
      get { return sourceId_; }
      set {
        sourceId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtBeingHealedNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtBeingHealedNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RealHealAmount, other.RealHealAmount)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HealAmount, other.HealAmount)) return false;
      if (TargetId != other.TargetId) return false;
      if (SourceId != other.SourceId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RealHealAmount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RealHealAmount);
      if (HealAmount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HealAmount);
      if (TargetId != 0) hash ^= TargetId.GetHashCode();
      if (SourceId != 0) hash ^= SourceId.GetHashCode();
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
      if (RealHealAmount != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(RealHealAmount);
      }
      if (HealAmount != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(HealAmount);
      }
      if (TargetId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetId);
      }
      if (SourceId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SourceId);
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
      if (RealHealAmount != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(RealHealAmount);
      }
      if (HealAmount != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(HealAmount);
      }
      if (TargetId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TargetId);
      }
      if (SourceId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SourceId);
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
      if (RealHealAmount != 0F) {
        size += 1 + 4;
      }
      if (HealAmount != 0F) {
        size += 1 + 4;
      }
      if (TargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetId);
      }
      if (SourceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtBeingHealedNotify other) {
      if (other == null) {
        return;
      }
      if (other.RealHealAmount != 0F) {
        RealHealAmount = other.RealHealAmount;
      }
      if (other.HealAmount != 0F) {
        HealAmount = other.HealAmount;
      }
      if (other.TargetId != 0) {
        TargetId = other.TargetId;
      }
      if (other.SourceId != 0) {
        SourceId = other.SourceId;
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
          case 21: {
            RealHealAmount = input.ReadFloat();
            break;
          }
          case 29: {
            HealAmount = input.ReadFloat();
            break;
          }
          case 32: {
            TargetId = input.ReadUInt32();
            break;
          }
          case 48: {
            SourceId = input.ReadUInt32();
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
          case 21: {
            RealHealAmount = input.ReadFloat();
            break;
          }
          case 29: {
            HealAmount = input.ReadFloat();
            break;
          }
          case 32: {
            TargetId = input.ReadUInt32();
            break;
          }
          case 48: {
            SourceId = input.ReadUInt32();
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
