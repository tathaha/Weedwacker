// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerLevelStarCondData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TowerLevelStarCondData.proto</summary>
  public static partial class TowerLevelStarCondDataReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerLevelStarCondData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerLevelStarCondDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxUb3dlckxldmVsU3RhckNvbmREYXRhLnByb3RvIoMBChZUb3dlckxldmVs",
            "U3RhckNvbmREYXRhEhsKE1VuazMzMDBfS0JDRkRGT0FKTU0YDiABKAgSGwoT",
            "VW5rMzMwMF9DUEJDTkFDS0FBSxgFIAEoCBIbChNVbmszMzAwX0pHT0xCRk1K",
            "QkNMGAsgASgNEhIKCmNvbmRfdmFsdWUYDCABKA1CIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TowerLevelStarCondData), global::Weedwacker.Shared.Network.Proto.TowerLevelStarCondData.Parser, new[]{ "Unk3300KBCFDFOAJMM", "Unk3300CPBCNACKAAK", "Unk3300JGOLBFMJBCL", "CondValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerLevelStarCondData : pb::IMessage<TowerLevelStarCondData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerLevelStarCondData> _parser = new pb::MessageParser<TowerLevelStarCondData>(() => new TowerLevelStarCondData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerLevelStarCondData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TowerLevelStarCondDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondData(TowerLevelStarCondData other) : this() {
      unk3300KBCFDFOAJMM_ = other.unk3300KBCFDFOAJMM_;
      unk3300CPBCNACKAAK_ = other.unk3300CPBCNACKAAK_;
      unk3300JGOLBFMJBCL_ = other.unk3300JGOLBFMJBCL_;
      condValue_ = other.condValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondData Clone() {
      return new TowerLevelStarCondData(this);
    }

    /// <summary>Field number for the "Unk3300_KBCFDFOAJMM" field.</summary>
    public const int Unk3300KBCFDFOAJMMFieldNumber = 14;
    private bool unk3300KBCFDFOAJMM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300KBCFDFOAJMM {
      get { return unk3300KBCFDFOAJMM_; }
      set {
        unk3300KBCFDFOAJMM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_CPBCNACKAAK" field.</summary>
    public const int Unk3300CPBCNACKAAKFieldNumber = 5;
    private bool unk3300CPBCNACKAAK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300CPBCNACKAAK {
      get { return unk3300CPBCNACKAAK_; }
      set {
        unk3300CPBCNACKAAK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JGOLBFMJBCL" field.</summary>
    public const int Unk3300JGOLBFMJBCLFieldNumber = 11;
    private uint unk3300JGOLBFMJBCL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JGOLBFMJBCL {
      get { return unk3300JGOLBFMJBCL_; }
      set {
        unk3300JGOLBFMJBCL_ = value;
      }
    }

    /// <summary>Field number for the "cond_value" field.</summary>
    public const int CondValueFieldNumber = 12;
    private uint condValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CondValue {
      get { return condValue_; }
      set {
        condValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerLevelStarCondData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerLevelStarCondData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300KBCFDFOAJMM != other.Unk3300KBCFDFOAJMM) return false;
      if (Unk3300CPBCNACKAAK != other.Unk3300CPBCNACKAAK) return false;
      if (Unk3300JGOLBFMJBCL != other.Unk3300JGOLBFMJBCL) return false;
      if (CondValue != other.CondValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300KBCFDFOAJMM != false) hash ^= Unk3300KBCFDFOAJMM.GetHashCode();
      if (Unk3300CPBCNACKAAK != false) hash ^= Unk3300CPBCNACKAAK.GetHashCode();
      if (Unk3300JGOLBFMJBCL != 0) hash ^= Unk3300JGOLBFMJBCL.GetHashCode();
      if (CondValue != 0) hash ^= CondValue.GetHashCode();
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
      if (Unk3300CPBCNACKAAK != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300CPBCNACKAAK);
      }
      if (Unk3300JGOLBFMJBCL != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300JGOLBFMJBCL);
      }
      if (CondValue != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CondValue);
      }
      if (Unk3300KBCFDFOAJMM != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk3300KBCFDFOAJMM);
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
      if (Unk3300CPBCNACKAAK != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300CPBCNACKAAK);
      }
      if (Unk3300JGOLBFMJBCL != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300JGOLBFMJBCL);
      }
      if (CondValue != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CondValue);
      }
      if (Unk3300KBCFDFOAJMM != false) {
        output.WriteRawTag(112);
        output.WriteBool(Unk3300KBCFDFOAJMM);
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
      if (Unk3300KBCFDFOAJMM != false) {
        size += 1 + 1;
      }
      if (Unk3300CPBCNACKAAK != false) {
        size += 1 + 1;
      }
      if (Unk3300JGOLBFMJBCL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JGOLBFMJBCL);
      }
      if (CondValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CondValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerLevelStarCondData other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300KBCFDFOAJMM != false) {
        Unk3300KBCFDFOAJMM = other.Unk3300KBCFDFOAJMM;
      }
      if (other.Unk3300CPBCNACKAAK != false) {
        Unk3300CPBCNACKAAK = other.Unk3300CPBCNACKAAK;
      }
      if (other.Unk3300JGOLBFMJBCL != 0) {
        Unk3300JGOLBFMJBCL = other.Unk3300JGOLBFMJBCL;
      }
      if (other.CondValue != 0) {
        CondValue = other.CondValue;
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
          case 40: {
            Unk3300CPBCNACKAAK = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300JGOLBFMJBCL = input.ReadUInt32();
            break;
          }
          case 96: {
            CondValue = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300KBCFDFOAJMM = input.ReadBool();
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
          case 40: {
            Unk3300CPBCNACKAAK = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300JGOLBFMJBCL = input.ReadUInt32();
            break;
          }
          case 96: {
            CondValue = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300KBCFDFOAJMM = input.ReadBool();
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
