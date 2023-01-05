// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FungusFighterMonsterDetail.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FungusFighterMonsterDetail.proto</summary>
  public static partial class FungusFighterMonsterDetailReflection {

    #region Descriptor
    /// <summary>File descriptor for FungusFighterMonsterDetail.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FungusFighterMonsterDetailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBGdW5ndXNGaWdodGVyTW9uc3RlckRldGFpbC5wcm90byJcChpGdW5ndXNG",
            "aWdodGVyTW9uc3RlckRldGFpbBIZChFjdXJfaHBfcGVyY2VudGFnZRgJIAEo",
            "AhIQCghpc19hbGl2ZRgKIAEoCBIRCglmdW5ndXNfaWQYDSABKA1CIqoCH1dl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FungusFighterMonsterDetail), global::Weedwacker.Shared.Network.Proto.FungusFighterMonsterDetail.Parser, new[]{ "CurHpPercentage", "IsAlive", "FungusId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FungusFighterMonsterDetail : pb::IMessage<FungusFighterMonsterDetail>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FungusFighterMonsterDetail> _parser = new pb::MessageParser<FungusFighterMonsterDetail>(() => new FungusFighterMonsterDetail());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FungusFighterMonsterDetail> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FungusFighterMonsterDetailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterMonsterDetail() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterMonsterDetail(FungusFighterMonsterDetail other) : this() {
      curHpPercentage_ = other.curHpPercentage_;
      isAlive_ = other.isAlive_;
      fungusId_ = other.fungusId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterMonsterDetail Clone() {
      return new FungusFighterMonsterDetail(this);
    }

    /// <summary>Field number for the "cur_hp_percentage" field.</summary>
    public const int CurHpPercentageFieldNumber = 9;
    private float curHpPercentage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CurHpPercentage {
      get { return curHpPercentage_; }
      set {
        curHpPercentage_ = value;
      }
    }

    /// <summary>Field number for the "is_alive" field.</summary>
    public const int IsAliveFieldNumber = 10;
    private bool isAlive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAlive {
      get { return isAlive_; }
      set {
        isAlive_ = value;
      }
    }

    /// <summary>Field number for the "fungus_id" field.</summary>
    public const int FungusIdFieldNumber = 13;
    private uint fungusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FungusId {
      get { return fungusId_; }
      set {
        fungusId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FungusFighterMonsterDetail);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FungusFighterMonsterDetail other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CurHpPercentage, other.CurHpPercentage)) return false;
      if (IsAlive != other.IsAlive) return false;
      if (FungusId != other.FungusId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurHpPercentage != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CurHpPercentage);
      if (IsAlive != false) hash ^= IsAlive.GetHashCode();
      if (FungusId != 0) hash ^= FungusId.GetHashCode();
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
      if (CurHpPercentage != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(CurHpPercentage);
      }
      if (IsAlive != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsAlive);
      }
      if (FungusId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FungusId);
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
      if (CurHpPercentage != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(CurHpPercentage);
      }
      if (IsAlive != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsAlive);
      }
      if (FungusId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FungusId);
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
      if (CurHpPercentage != 0F) {
        size += 1 + 4;
      }
      if (IsAlive != false) {
        size += 1 + 1;
      }
      if (FungusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FungusId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FungusFighterMonsterDetail other) {
      if (other == null) {
        return;
      }
      if (other.CurHpPercentage != 0F) {
        CurHpPercentage = other.CurHpPercentage;
      }
      if (other.IsAlive != false) {
        IsAlive = other.IsAlive;
      }
      if (other.FungusId != 0) {
        FungusId = other.FungusId;
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
          case 77: {
            CurHpPercentage = input.ReadFloat();
            break;
          }
          case 80: {
            IsAlive = input.ReadBool();
            break;
          }
          case 104: {
            FungusId = input.ReadUInt32();
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
          case 77: {
            CurHpPercentage = input.ReadFloat();
            break;
          }
          case 80: {
            IsAlive = input.ReadBool();
            break;
          }
          case 104: {
            FungusId = input.ReadUInt32();
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
