// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewTokenInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewTokenInfo.proto</summary>
  public static partial class GCGSkillPreviewTokenInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewTokenInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewTokenInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HQ0dTa2lsbFByZXZpZXdUb2tlbkluZm8ucHJvdG8SH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8iaAoYR0NHU2tpbGxQcmV2aWV3VG9rZW5J",
            "bmZvEhIKCnRva2VuX3R5cGUYCyABKA0SGwoTVW5rMzMwMF9NTUlLUFBKTUhB",
            "RBgKIAEoDRIbChNVbmszMzAwX0lLSUNKTUVGRU9OGAMgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenInfo), global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenInfo.Parser, new[]{ "TokenType", "Unk3300MMIKPPJMHAD", "Unk3300IKICJMEFEON" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGSkillPreviewTokenInfo : pb::IMessage<GCGSkillPreviewTokenInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewTokenInfo> _parser = new pb::MessageParser<GCGSkillPreviewTokenInfo>(() => new GCGSkillPreviewTokenInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewTokenInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewTokenInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewTokenInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewTokenInfo(GCGSkillPreviewTokenInfo other) : this() {
      tokenType_ = other.tokenType_;
      unk3300MMIKPPJMHAD_ = other.unk3300MMIKPPJMHAD_;
      unk3300IKICJMEFEON_ = other.unk3300IKICJMEFEON_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewTokenInfo Clone() {
      return new GCGSkillPreviewTokenInfo(this);
    }

    /// <summary>Field number for the "token_type" field.</summary>
    public const int TokenTypeFieldNumber = 11;
    private uint tokenType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TokenType {
      get { return tokenType_; }
      set {
        tokenType_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MMIKPPJMHAD" field.</summary>
    public const int Unk3300MMIKPPJMHADFieldNumber = 10;
    private uint unk3300MMIKPPJMHAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MMIKPPJMHAD {
      get { return unk3300MMIKPPJMHAD_; }
      set {
        unk3300MMIKPPJMHAD_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IKICJMEFEON" field.</summary>
    public const int Unk3300IKICJMEFEONFieldNumber = 3;
    private uint unk3300IKICJMEFEON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IKICJMEFEON {
      get { return unk3300IKICJMEFEON_; }
      set {
        unk3300IKICJMEFEON_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewTokenInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewTokenInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TokenType != other.TokenType) return false;
      if (Unk3300MMIKPPJMHAD != other.Unk3300MMIKPPJMHAD) return false;
      if (Unk3300IKICJMEFEON != other.Unk3300IKICJMEFEON) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TokenType != 0) hash ^= TokenType.GetHashCode();
      if (Unk3300MMIKPPJMHAD != 0) hash ^= Unk3300MMIKPPJMHAD.GetHashCode();
      if (Unk3300IKICJMEFEON != 0) hash ^= Unk3300IKICJMEFEON.GetHashCode();
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
      if (Unk3300IKICJMEFEON != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300IKICJMEFEON);
      }
      if (Unk3300MMIKPPJMHAD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300MMIKPPJMHAD);
      }
      if (TokenType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TokenType);
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
      if (Unk3300IKICJMEFEON != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300IKICJMEFEON);
      }
      if (Unk3300MMIKPPJMHAD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300MMIKPPJMHAD);
      }
      if (TokenType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TokenType);
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
      if (TokenType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TokenType);
      }
      if (Unk3300MMIKPPJMHAD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MMIKPPJMHAD);
      }
      if (Unk3300IKICJMEFEON != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IKICJMEFEON);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewTokenInfo other) {
      if (other == null) {
        return;
      }
      if (other.TokenType != 0) {
        TokenType = other.TokenType;
      }
      if (other.Unk3300MMIKPPJMHAD != 0) {
        Unk3300MMIKPPJMHAD = other.Unk3300MMIKPPJMHAD;
      }
      if (other.Unk3300IKICJMEFEON != 0) {
        Unk3300IKICJMEFEON = other.Unk3300IKICJMEFEON;
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
            Unk3300IKICJMEFEON = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300MMIKPPJMHAD = input.ReadUInt32();
            break;
          }
          case 88: {
            TokenType = input.ReadUInt32();
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
            Unk3300IKICJMEFEON = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300MMIKPPJMHAD = input.ReadUInt32();
            break;
          }
          case 88: {
            TokenType = input.ReadUInt32();
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
