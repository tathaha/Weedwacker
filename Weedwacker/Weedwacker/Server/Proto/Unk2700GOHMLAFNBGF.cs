// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_GOHMLAFNBGF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_GOHMLAFNBGF.proto</summary>
  public static partial class Unk2700GOHMLAFNBGFReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_GOHMLAFNBGF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700GOHMLAFNBGFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0dPSE1MQUZOQkdGLnByb3RvGhdIb21lRnVybml0dXJlRGF0",
            "YS5wcm90byJjChNVbmsyNzAwX0dPSE1MQUZOQkdGEhsKE1VuazI3MDBfT0FM",
            "Q0ZFR0lCT0wYCCABKA0SLwoTVW5rMjcwMF9DS1BOQ0tESUpNQhgDIAMoCzIS",
            "LkhvbWVGdXJuaXR1cmVEYXRhQhqqAhdXZWVkd2Fja2VyLlNlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.HomeFurnitureDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_GOHMLAFNBGF), global::Weedwacker.Server.Proto.Unk2700_GOHMLAFNBGF.Parser, new[]{ "Unk2700OALCFEGIBOL", "Unk2700CKPNCKDIJMB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_GOHMLAFNBGF : pb::IMessage<Unk2700_GOHMLAFNBGF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_GOHMLAFNBGF> _parser = new pb::MessageParser<Unk2700_GOHMLAFNBGF>(() => new Unk2700_GOHMLAFNBGF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_GOHMLAFNBGF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700GOHMLAFNBGFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GOHMLAFNBGF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GOHMLAFNBGF(Unk2700_GOHMLAFNBGF other) : this() {
      unk2700OALCFEGIBOL_ = other.unk2700OALCFEGIBOL_;
      unk2700CKPNCKDIJMB_ = other.unk2700CKPNCKDIJMB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_GOHMLAFNBGF Clone() {
      return new Unk2700_GOHMLAFNBGF(this);
    }

    /// <summary>Field number for the "Unk2700_OALCFEGIBOL" field.</summary>
    public const int Unk2700OALCFEGIBOLFieldNumber = 8;
    private uint unk2700OALCFEGIBOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk2700OALCFEGIBOL {
      get { return unk2700OALCFEGIBOL_; }
      set {
        unk2700OALCFEGIBOL_ = value;
      }
    }

    /// <summary>Field number for the "Unk2700_CKPNCKDIJMB" field.</summary>
    public const int Unk2700CKPNCKDIJMBFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.HomeFurnitureData> _repeated_unk2700CKPNCKDIJMB_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Server.Proto.HomeFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData> unk2700CKPNCKDIJMB_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.HomeFurnitureData> Unk2700CKPNCKDIJMB {
      get { return unk2700CKPNCKDIJMB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_GOHMLAFNBGF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_GOHMLAFNBGF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700OALCFEGIBOL != other.Unk2700OALCFEGIBOL) return false;
      if(!unk2700CKPNCKDIJMB_.Equals(other.unk2700CKPNCKDIJMB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700OALCFEGIBOL != 0) hash ^= Unk2700OALCFEGIBOL.GetHashCode();
      hash ^= unk2700CKPNCKDIJMB_.GetHashCode();
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
      unk2700CKPNCKDIJMB_.WriteTo(output, _repeated_unk2700CKPNCKDIJMB_codec);
      if (Unk2700OALCFEGIBOL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2700OALCFEGIBOL);
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
      unk2700CKPNCKDIJMB_.WriteTo(ref output, _repeated_unk2700CKPNCKDIJMB_codec);
      if (Unk2700OALCFEGIBOL != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk2700OALCFEGIBOL);
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
      if (Unk2700OALCFEGIBOL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk2700OALCFEGIBOL);
      }
      size += unk2700CKPNCKDIJMB_.CalculateSize(_repeated_unk2700CKPNCKDIJMB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_GOHMLAFNBGF other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700OALCFEGIBOL != 0) {
        Unk2700OALCFEGIBOL = other.Unk2700OALCFEGIBOL;
      }
      unk2700CKPNCKDIJMB_.Add(other.unk2700CKPNCKDIJMB_);
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
          case 26: {
            unk2700CKPNCKDIJMB_.AddEntriesFrom(input, _repeated_unk2700CKPNCKDIJMB_codec);
            break;
          }
          case 64: {
            Unk2700OALCFEGIBOL = input.ReadUInt32();
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
          case 26: {
            unk2700CKPNCKDIJMB_.AddEntriesFrom(ref input, _repeated_unk2700CKPNCKDIJMB_codec);
            break;
          }
          case 64: {
            Unk2700OALCFEGIBOL = input.ReadUInt32();
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