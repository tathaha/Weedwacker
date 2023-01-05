// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyChallengeV2LevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EffigyChallengeV2LevelData.proto</summary>
  public static partial class EffigyChallengeV2LevelDataReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyChallengeV2LevelData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyChallengeV2LevelDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBFZmZpZ3lDaGFsbGVuZ2VWMkxldmVsRGF0YS5wcm90byK5AQoaRWZmaWd5",
            "Q2hhbGxlbmdlVjJMZXZlbERhdGESGwoTVW5rMzMwMF9QUE9FTUVJTEJJQRgN",
            "IAEoDRIVCg1pc19sZXZlbF9vcGVuGAQgASgIEhsKE1VuazMzMDBfS0pFT0FE",
            "RE1KTUkYCSABKA0SGwoTVW5rMzMwMF9KTUdBQ09ETUpMRxgCIAEoDRIbChNV",
            "bmszMzAwX0lKQUdPQUtPQUJIGAcgASgNEhAKCGxldmVsX2lkGAwgASgNQiKq",
            "Ah9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EffigyChallengeV2LevelData), global::Weedwacker.Shared.Network.Proto.EffigyChallengeV2LevelData.Parser, new[]{ "Unk3300PPOEMEILBIA", "IsLevelOpen", "Unk3300KJEOADDMJMI", "Unk3300JMGACODMJLG", "Unk3300IJAGOAKOABH", "LevelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EffigyChallengeV2LevelData : pb::IMessage<EffigyChallengeV2LevelData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyChallengeV2LevelData> _parser = new pb::MessageParser<EffigyChallengeV2LevelData>(() => new EffigyChallengeV2LevelData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyChallengeV2LevelData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EffigyChallengeV2LevelDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2LevelData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2LevelData(EffigyChallengeV2LevelData other) : this() {
      unk3300PPOEMEILBIA_ = other.unk3300PPOEMEILBIA_;
      isLevelOpen_ = other.isLevelOpen_;
      unk3300KJEOADDMJMI_ = other.unk3300KJEOADDMJMI_;
      unk3300JMGACODMJLG_ = other.unk3300JMGACODMJLG_;
      unk3300IJAGOAKOABH_ = other.unk3300IJAGOAKOABH_;
      levelId_ = other.levelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2LevelData Clone() {
      return new EffigyChallengeV2LevelData(this);
    }

    /// <summary>Field number for the "Unk3300_PPOEMEILBIA" field.</summary>
    public const int Unk3300PPOEMEILBIAFieldNumber = 13;
    private uint unk3300PPOEMEILBIA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PPOEMEILBIA {
      get { return unk3300PPOEMEILBIA_; }
      set {
        unk3300PPOEMEILBIA_ = value;
      }
    }

    /// <summary>Field number for the "is_level_open" field.</summary>
    public const int IsLevelOpenFieldNumber = 4;
    private bool isLevelOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsLevelOpen {
      get { return isLevelOpen_; }
      set {
        isLevelOpen_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KJEOADDMJMI" field.</summary>
    public const int Unk3300KJEOADDMJMIFieldNumber = 9;
    private uint unk3300KJEOADDMJMI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KJEOADDMJMI {
      get { return unk3300KJEOADDMJMI_; }
      set {
        unk3300KJEOADDMJMI_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JMGACODMJLG" field.</summary>
    public const int Unk3300JMGACODMJLGFieldNumber = 2;
    private uint unk3300JMGACODMJLG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JMGACODMJLG {
      get { return unk3300JMGACODMJLG_; }
      set {
        unk3300JMGACODMJLG_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IJAGOAKOABH" field.</summary>
    public const int Unk3300IJAGOAKOABHFieldNumber = 7;
    private uint unk3300IJAGOAKOABH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IJAGOAKOABH {
      get { return unk3300IJAGOAKOABH_; }
      set {
        unk3300IJAGOAKOABH_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 12;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EffigyChallengeV2LevelData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyChallengeV2LevelData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300PPOEMEILBIA != other.Unk3300PPOEMEILBIA) return false;
      if (IsLevelOpen != other.IsLevelOpen) return false;
      if (Unk3300KJEOADDMJMI != other.Unk3300KJEOADDMJMI) return false;
      if (Unk3300JMGACODMJLG != other.Unk3300JMGACODMJLG) return false;
      if (Unk3300IJAGOAKOABH != other.Unk3300IJAGOAKOABH) return false;
      if (LevelId != other.LevelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300PPOEMEILBIA != 0) hash ^= Unk3300PPOEMEILBIA.GetHashCode();
      if (IsLevelOpen != false) hash ^= IsLevelOpen.GetHashCode();
      if (Unk3300KJEOADDMJMI != 0) hash ^= Unk3300KJEOADDMJMI.GetHashCode();
      if (Unk3300JMGACODMJLG != 0) hash ^= Unk3300JMGACODMJLG.GetHashCode();
      if (Unk3300IJAGOAKOABH != 0) hash ^= Unk3300IJAGOAKOABH.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
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
      if (Unk3300JMGACODMJLG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300JMGACODMJLG);
      }
      if (IsLevelOpen != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsLevelOpen);
      }
      if (Unk3300IJAGOAKOABH != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300IJAGOAKOABH);
      }
      if (Unk3300KJEOADDMJMI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300KJEOADDMJMI);
      }
      if (LevelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LevelId);
      }
      if (Unk3300PPOEMEILBIA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300PPOEMEILBIA);
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
      if (Unk3300JMGACODMJLG != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300JMGACODMJLG);
      }
      if (IsLevelOpen != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsLevelOpen);
      }
      if (Unk3300IJAGOAKOABH != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300IJAGOAKOABH);
      }
      if (Unk3300KJEOADDMJMI != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300KJEOADDMJMI);
      }
      if (LevelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LevelId);
      }
      if (Unk3300PPOEMEILBIA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300PPOEMEILBIA);
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
      if (Unk3300PPOEMEILBIA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PPOEMEILBIA);
      }
      if (IsLevelOpen != false) {
        size += 1 + 1;
      }
      if (Unk3300KJEOADDMJMI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KJEOADDMJMI);
      }
      if (Unk3300JMGACODMJLG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JMGACODMJLG);
      }
      if (Unk3300IJAGOAKOABH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IJAGOAKOABH);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EffigyChallengeV2LevelData other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300PPOEMEILBIA != 0) {
        Unk3300PPOEMEILBIA = other.Unk3300PPOEMEILBIA;
      }
      if (other.IsLevelOpen != false) {
        IsLevelOpen = other.IsLevelOpen;
      }
      if (other.Unk3300KJEOADDMJMI != 0) {
        Unk3300KJEOADDMJMI = other.Unk3300KJEOADDMJMI;
      }
      if (other.Unk3300JMGACODMJLG != 0) {
        Unk3300JMGACODMJLG = other.Unk3300JMGACODMJLG;
      }
      if (other.Unk3300IJAGOAKOABH != 0) {
        Unk3300IJAGOAKOABH = other.Unk3300IJAGOAKOABH;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
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
            Unk3300JMGACODMJLG = input.ReadUInt32();
            break;
          }
          case 32: {
            IsLevelOpen = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300IJAGOAKOABH = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300KJEOADDMJMI = input.ReadUInt32();
            break;
          }
          case 96: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300PPOEMEILBIA = input.ReadUInt32();
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
            Unk3300JMGACODMJLG = input.ReadUInt32();
            break;
          }
          case 32: {
            IsLevelOpen = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300IJAGOAKOABH = input.ReadUInt32();
            break;
          }
          case 72: {
            Unk3300KJEOADDMJMI = input.ReadUInt32();
            break;
          }
          case 96: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300PPOEMEILBIA = input.ReadUInt32();
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
