// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TryEnterHomeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TryEnterHomeReq.proto</summary>
  public static partial class TryEnterHomeReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TryEnterHomeReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TryEnterHomeReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVUcnlFbnRlckhvbWVSZXEucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8iXgoPVHJ5RW50ZXJIb21lUmVxEiEKGWlzX3RyYW5zZmVy",
            "X3RvX3NhZmVfcG9pbnQYDSABKAgSFAoMdGFyZ2V0X3BvaW50GAogASgNEhIK",
            "CnRhcmdldF91aWQYASABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TryEnterHomeReq), global::Weedwacker.Shared.Network.Proto.TryEnterHomeReq.Parser, new[]{ "IsTransferToSafePoint", "TargetPoint", "TargetUid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4648;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class TryEnterHomeReq : pb::IMessage<TryEnterHomeReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TryEnterHomeReq> _parser = new pb::MessageParser<TryEnterHomeReq>(() => new TryEnterHomeReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TryEnterHomeReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TryEnterHomeReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TryEnterHomeReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TryEnterHomeReq(TryEnterHomeReq other) : this() {
      isTransferToSafePoint_ = other.isTransferToSafePoint_;
      targetPoint_ = other.targetPoint_;
      targetUid_ = other.targetUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TryEnterHomeReq Clone() {
      return new TryEnterHomeReq(this);
    }

    /// <summary>Field number for the "is_transfer_to_safe_point" field.</summary>
    public const int IsTransferToSafePointFieldNumber = 13;
    private bool isTransferToSafePoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTransferToSafePoint {
      get { return isTransferToSafePoint_; }
      set {
        isTransferToSafePoint_ = value;
      }
    }

    /// <summary>Field number for the "target_point" field.</summary>
    public const int TargetPointFieldNumber = 10;
    private uint targetPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetPoint {
      get { return targetPoint_; }
      set {
        targetPoint_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 1;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TryEnterHomeReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TryEnterHomeReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsTransferToSafePoint != other.IsTransferToSafePoint) return false;
      if (TargetPoint != other.TargetPoint) return false;
      if (TargetUid != other.TargetUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsTransferToSafePoint != false) hash ^= IsTransferToSafePoint.GetHashCode();
      if (TargetPoint != 0) hash ^= TargetPoint.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
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
      if (TargetUid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TargetUid);
      }
      if (TargetPoint != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetPoint);
      }
      if (IsTransferToSafePoint != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsTransferToSafePoint);
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
      if (TargetUid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TargetUid);
      }
      if (TargetPoint != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetPoint);
      }
      if (IsTransferToSafePoint != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsTransferToSafePoint);
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
      if (IsTransferToSafePoint != false) {
        size += 1 + 1;
      }
      if (TargetPoint != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetPoint);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TryEnterHomeReq other) {
      if (other == null) {
        return;
      }
      if (other.IsTransferToSafePoint != false) {
        IsTransferToSafePoint = other.IsTransferToSafePoint;
      }
      if (other.TargetPoint != 0) {
        TargetPoint = other.TargetPoint;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
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
          case 8: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 80: {
            TargetPoint = input.ReadUInt32();
            break;
          }
          case 104: {
            IsTransferToSafePoint = input.ReadBool();
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
          case 8: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 80: {
            TargetPoint = input.ReadUInt32();
            break;
          }
          case 104: {
            IsTransferToSafePoint = input.ReadBool();
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
