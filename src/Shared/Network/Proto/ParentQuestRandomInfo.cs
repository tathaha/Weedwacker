// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ParentQuestRandomInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ParentQuestRandomInfo.proto</summary>
  public static partial class ParentQuestRandomInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ParentQuestRandomInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParentQuestRandomInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQYXJlbnRRdWVzdFJhbmRvbUluZm8ucHJvdG8iVgoVUGFyZW50UXVlc3RS",
            "YW5kb21JbmZvEhMKC2ZhY3Rvcl9saXN0GAEgAygNEhMKC2VudHJhbmNlX2lk",
            "GAggASgNEhMKC3RlbXBsYXRlX2lkGA8gASgNQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfo), global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfo.Parser, new[]{ "FactorList", "EntranceId", "TemplateId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ParentQuestRandomInfo : pb::IMessage<ParentQuestRandomInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ParentQuestRandomInfo> _parser = new pb::MessageParser<ParentQuestRandomInfo>(() => new ParentQuestRandomInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ParentQuestRandomInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ParentQuestRandomInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParentQuestRandomInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParentQuestRandomInfo(ParentQuestRandomInfo other) : this() {
      factorList_ = other.factorList_.Clone();
      entranceId_ = other.entranceId_;
      templateId_ = other.templateId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParentQuestRandomInfo Clone() {
      return new ParentQuestRandomInfo(this);
    }

    /// <summary>Field number for the "factor_list" field.</summary>
    public const int FactorListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_factorList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> factorList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FactorList {
      get { return factorList_; }
    }

    /// <summary>Field number for the "entrance_id" field.</summary>
    public const int EntranceIdFieldNumber = 8;
    private uint entranceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntranceId {
      get { return entranceId_; }
      set {
        entranceId_ = value;
      }
    }

    /// <summary>Field number for the "template_id" field.</summary>
    public const int TemplateIdFieldNumber = 15;
    private uint templateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TemplateId {
      get { return templateId_; }
      set {
        templateId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ParentQuestRandomInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ParentQuestRandomInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!factorList_.Equals(other.factorList_)) return false;
      if (EntranceId != other.EntranceId) return false;
      if (TemplateId != other.TemplateId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= factorList_.GetHashCode();
      if (EntranceId != 0) hash ^= EntranceId.GetHashCode();
      if (TemplateId != 0) hash ^= TemplateId.GetHashCode();
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
      factorList_.WriteTo(output, _repeated_factorList_codec);
      if (EntranceId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntranceId);
      }
      if (TemplateId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TemplateId);
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
      factorList_.WriteTo(ref output, _repeated_factorList_codec);
      if (EntranceId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntranceId);
      }
      if (TemplateId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TemplateId);
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
      size += factorList_.CalculateSize(_repeated_factorList_codec);
      if (EntranceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntranceId);
      }
      if (TemplateId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TemplateId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ParentQuestRandomInfo other) {
      if (other == null) {
        return;
      }
      factorList_.Add(other.factorList_);
      if (other.EntranceId != 0) {
        EntranceId = other.EntranceId;
      }
      if (other.TemplateId != 0) {
        TemplateId = other.TemplateId;
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
          case 10:
          case 8: {
            factorList_.AddEntriesFrom(input, _repeated_factorList_codec);
            break;
          }
          case 64: {
            EntranceId = input.ReadUInt32();
            break;
          }
          case 120: {
            TemplateId = input.ReadUInt32();
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
          case 10:
          case 8: {
            factorList_.AddEntriesFrom(ref input, _repeated_factorList_codec);
            break;
          }
          case 64: {
            EntranceId = input.ReadUInt32();
            break;
          }
          case 120: {
            TemplateId = input.ReadUInt32();
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
