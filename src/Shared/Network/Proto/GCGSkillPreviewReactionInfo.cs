// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewReactionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewReactionInfo.proto</summary>
  public static partial class GCGSkillPreviewReactionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewReactionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewReactionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFHQ0dTa2lsbFByZXZpZXdSZWFjdGlvbkluZm8ucHJvdG8iVwobR0NHU2tp",
            "bGxQcmV2aWV3UmVhY3Rpb25JbmZvEhsKE1VuazMzMDBfQUVOUExFRFBNSkgY",
            "AyABKA0SGwoTVW5rMzMwMF9QREVIUEhKRkFLRBgCIAEoDUIiqgIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewReactionInfo), global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewReactionInfo.Parser, new[]{ "Unk3300AENPLEDPMJH", "Unk3300PDEHPHJFAKD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGSkillPreviewReactionInfo : pb::IMessage<GCGSkillPreviewReactionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewReactionInfo> _parser = new pb::MessageParser<GCGSkillPreviewReactionInfo>(() => new GCGSkillPreviewReactionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewReactionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewReactionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewReactionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewReactionInfo(GCGSkillPreviewReactionInfo other) : this() {
      unk3300AENPLEDPMJH_ = other.unk3300AENPLEDPMJH_;
      unk3300PDEHPHJFAKD_ = other.unk3300PDEHPHJFAKD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewReactionInfo Clone() {
      return new GCGSkillPreviewReactionInfo(this);
    }

    /// <summary>Field number for the "Unk3300_AENPLEDPMJH" field.</summary>
    public const int Unk3300AENPLEDPMJHFieldNumber = 3;
    private uint unk3300AENPLEDPMJH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AENPLEDPMJH {
      get { return unk3300AENPLEDPMJH_; }
      set {
        unk3300AENPLEDPMJH_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PDEHPHJFAKD" field.</summary>
    public const int Unk3300PDEHPHJFAKDFieldNumber = 2;
    private uint unk3300PDEHPHJFAKD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PDEHPHJFAKD {
      get { return unk3300PDEHPHJFAKD_; }
      set {
        unk3300PDEHPHJFAKD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewReactionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewReactionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300AENPLEDPMJH != other.Unk3300AENPLEDPMJH) return false;
      if (Unk3300PDEHPHJFAKD != other.Unk3300PDEHPHJFAKD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300AENPLEDPMJH != 0) hash ^= Unk3300AENPLEDPMJH.GetHashCode();
      if (Unk3300PDEHPHJFAKD != 0) hash ^= Unk3300PDEHPHJFAKD.GetHashCode();
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
      if (Unk3300PDEHPHJFAKD != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300PDEHPHJFAKD);
      }
      if (Unk3300AENPLEDPMJH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300AENPLEDPMJH);
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
      if (Unk3300PDEHPHJFAKD != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300PDEHPHJFAKD);
      }
      if (Unk3300AENPLEDPMJH != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300AENPLEDPMJH);
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
      if (Unk3300AENPLEDPMJH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AENPLEDPMJH);
      }
      if (Unk3300PDEHPHJFAKD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PDEHPHJFAKD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewReactionInfo other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300AENPLEDPMJH != 0) {
        Unk3300AENPLEDPMJH = other.Unk3300AENPLEDPMJH;
      }
      if (other.Unk3300PDEHPHJFAKD != 0) {
        Unk3300PDEHPHJFAKD = other.Unk3300PDEHPHJFAKD;
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
            Unk3300PDEHPHJFAKD = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300AENPLEDPMJH = input.ReadUInt32();
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
            Unk3300PDEHPHJFAKD = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300AENPLEDPMJH = input.ReadUInt32();
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
