// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SeaLampContributeItemRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SeaLampContributeItemRsp.proto</summary>
  public static partial class SeaLampContributeItemRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SeaLampContributeItemRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SeaLampContributeItemRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5TZWFMYW1wQ29udHJpYnV0ZUl0ZW1Sc3AucHJvdG8iewoYU2VhTGFtcENv",
            "bnRyaWJ1dGVJdGVtUnNwEg8KB3JldGNvZGUYBCABKAUSGwoTVW5rMzMwMF9B",
            "SUlOSEJITkhPSRgLIAEoDRIUCgxhZGRfcHJvZ3Jlc3MYBSABKA0SGwoTVW5r",
            "MzMwMF9MUEhBTE9HTEdBTBgJIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SeaLampContributeItemRsp), global::Weedwacker.Shared.Network.Proto.SeaLampContributeItemRsp.Parser, new[]{ "Retcode", "Unk3300AIINHBHNHOI", "AddProgress", "Unk3300LPHALOGLGAL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2116;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SeaLampContributeItemRsp : pb::IMessage<SeaLampContributeItemRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SeaLampContributeItemRsp> _parser = new pb::MessageParser<SeaLampContributeItemRsp>(() => new SeaLampContributeItemRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SeaLampContributeItemRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SeaLampContributeItemRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampContributeItemRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampContributeItemRsp(SeaLampContributeItemRsp other) : this() {
      retcode_ = other.retcode_;
      unk3300AIINHBHNHOI_ = other.unk3300AIINHBHNHOI_;
      addProgress_ = other.addProgress_;
      unk3300LPHALOGLGAL_ = other.unk3300LPHALOGLGAL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SeaLampContributeItemRsp Clone() {
      return new SeaLampContributeItemRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AIINHBHNHOI" field.</summary>
    public const int Unk3300AIINHBHNHOIFieldNumber = 11;
    private uint unk3300AIINHBHNHOI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AIINHBHNHOI {
      get { return unk3300AIINHBHNHOI_; }
      set {
        unk3300AIINHBHNHOI_ = value;
      }
    }

    /// <summary>Field number for the "add_progress" field.</summary>
    public const int AddProgressFieldNumber = 5;
    private uint addProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddProgress {
      get { return addProgress_; }
      set {
        addProgress_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LPHALOGLGAL" field.</summary>
    public const int Unk3300LPHALOGLGALFieldNumber = 9;
    private uint unk3300LPHALOGLGAL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LPHALOGLGAL {
      get { return unk3300LPHALOGLGAL_; }
      set {
        unk3300LPHALOGLGAL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SeaLampContributeItemRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SeaLampContributeItemRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Unk3300AIINHBHNHOI != other.Unk3300AIINHBHNHOI) return false;
      if (AddProgress != other.AddProgress) return false;
      if (Unk3300LPHALOGLGAL != other.Unk3300LPHALOGLGAL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3300AIINHBHNHOI != 0) hash ^= Unk3300AIINHBHNHOI.GetHashCode();
      if (AddProgress != 0) hash ^= AddProgress.GetHashCode();
      if (Unk3300LPHALOGLGAL != 0) hash ^= Unk3300LPHALOGLGAL.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      if (AddProgress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AddProgress);
      }
      if (Unk3300LPHALOGLGAL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300LPHALOGLGAL);
      }
      if (Unk3300AIINHBHNHOI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300AIINHBHNHOI);
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      if (AddProgress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AddProgress);
      }
      if (Unk3300LPHALOGLGAL != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300LPHALOGLGAL);
      }
      if (Unk3300AIINHBHNHOI != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300AIINHBHNHOI);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3300AIINHBHNHOI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AIINHBHNHOI);
      }
      if (AddProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddProgress);
      }
      if (Unk3300LPHALOGLGAL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LPHALOGLGAL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SeaLampContributeItemRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3300AIINHBHNHOI != 0) {
        Unk3300AIINHBHNHOI = other.Unk3300AIINHBHNHOI;
      }
      if (other.AddProgress != 0) {
        AddProgress = other.AddProgress;
      }
      if (other.Unk3300LPHALOGLGAL != 0) {
        Unk3300LPHALOGLGAL = other.Unk3300LPHALOGLGAL;
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
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 40: {
            AddProgress = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300LPHALOGLGAL = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300AIINHBHNHOI = input.ReadUInt32();
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
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 40: {
            AddProgress = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300LPHALOGLGAL = input.ReadUInt32();
            break;
          }
          case 88: {
            Unk3300AIINHBHNHOI = input.ReadUInt32();
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
