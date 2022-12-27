// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PhotoActivityFinishReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PhotoActivityFinishReq.proto</summary>
  public static partial class PhotoActivityFinishReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PhotoActivityFinishReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PhotoActivityFinishReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQaG90b0FjdGl2aXR5RmluaXNoUmVxLnByb3RvIlAKFlBob3RvQWN0aXZp",
            "dHlGaW5pc2hSZXESDgoGcG9zX2lkGAggASgNEhUKDWNoZWNrX3Jvb3RfaWQY",
            "CyABKA0SDwoHaXNfc3VjYxgPIAEoCEIiqgIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PhotoActivityFinishReq), global::Weedwacker.Shared.Network.Proto.PhotoActivityFinishReq.Parser, new[]{ "PosId", "CheckRootId", "IsSucc" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8395;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class PhotoActivityFinishReq : pb::IMessage<PhotoActivityFinishReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PhotoActivityFinishReq> _parser = new pb::MessageParser<PhotoActivityFinishReq>(() => new PhotoActivityFinishReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PhotoActivityFinishReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PhotoActivityFinishReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoActivityFinishReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoActivityFinishReq(PhotoActivityFinishReq other) : this() {
      posId_ = other.posId_;
      checkRootId_ = other.checkRootId_;
      isSucc_ = other.isSucc_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoActivityFinishReq Clone() {
      return new PhotoActivityFinishReq(this);
    }

    /// <summary>Field number for the "pos_id" field.</summary>
    public const int PosIdFieldNumber = 8;
    private uint posId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PosId {
      get { return posId_; }
      set {
        posId_ = value;
      }
    }

    /// <summary>Field number for the "check_root_id" field.</summary>
    public const int CheckRootIdFieldNumber = 11;
    private uint checkRootId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CheckRootId {
      get { return checkRootId_; }
      set {
        checkRootId_ = value;
      }
    }

    /// <summary>Field number for the "is_succ" field.</summary>
    public const int IsSuccFieldNumber = 15;
    private bool isSucc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSucc {
      get { return isSucc_; }
      set {
        isSucc_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PhotoActivityFinishReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PhotoActivityFinishReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PosId != other.PosId) return false;
      if (CheckRootId != other.CheckRootId) return false;
      if (IsSucc != other.IsSucc) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PosId != 0) hash ^= PosId.GetHashCode();
      if (CheckRootId != 0) hash ^= CheckRootId.GetHashCode();
      if (IsSucc != false) hash ^= IsSucc.GetHashCode();
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
      if (PosId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PosId);
      }
      if (CheckRootId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CheckRootId);
      }
      if (IsSucc != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsSucc);
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
      if (PosId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PosId);
      }
      if (CheckRootId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CheckRootId);
      }
      if (IsSucc != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsSucc);
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
      if (PosId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PosId);
      }
      if (CheckRootId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CheckRootId);
      }
      if (IsSucc != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PhotoActivityFinishReq other) {
      if (other == null) {
        return;
      }
      if (other.PosId != 0) {
        PosId = other.PosId;
      }
      if (other.CheckRootId != 0) {
        CheckRootId = other.CheckRootId;
      }
      if (other.IsSucc != false) {
        IsSucc = other.IsSucc;
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
          case 64: {
            PosId = input.ReadUInt32();
            break;
          }
          case 88: {
            CheckRootId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsSucc = input.ReadBool();
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
          case 64: {
            PosId = input.ReadUInt32();
            break;
          }
          case 88: {
            CheckRootId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsSucc = input.ReadBool();
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
