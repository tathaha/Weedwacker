// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseItemRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from UseItemRsp.proto</summary>
  public static partial class UseItemRspReflection {

    #region Descriptor
    /// <summary>File descriptor for UseItemRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBVc2VJdGVtUnNwLnByb3RvImUKClVzZUl0ZW1Sc3ASDAoEZ3VpZBgFIAEo",
            "BBITCgt0YXJnZXRfZ3VpZBgBIAEoBBIPCgdpdGVtX2lkGAQgASgNEhIKCm9w",
            "dGlvbl9pZHgYCCABKA0SDwoHcmV0Y29kZRgOIAEoBUIaqgIXV2VlZHdhY2tl",
            "ci5TZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.UseItemRsp), global::Weedwacker.Server.Proto.UseItemRsp.Parser, new[]{ "Guid", "TargetGuid", "ItemId", "OptionIdx", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 673
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class UseItemRsp : pb::IMessage<UseItemRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseItemRsp> _parser = new pb::MessageParser<UseItemRsp>(() => new UseItemRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseItemRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.UseItemRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemRsp(UseItemRsp other) : this() {
      guid_ = other.guid_;
      targetGuid_ = other.targetGuid_;
      itemId_ = other.itemId_;
      optionIdx_ = other.optionIdx_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemRsp Clone() {
      return new UseItemRsp(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 5;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "target_guid" field.</summary>
    public const int TargetGuidFieldNumber = 1;
    private ulong targetGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetGuid {
      get { return targetGuid_; }
      set {
        targetGuid_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 4;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "option_idx" field.</summary>
    public const int OptionIdxFieldNumber = 8;
    private uint optionIdx_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionIdx {
      get { return optionIdx_; }
      set {
        optionIdx_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UseItemRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseItemRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (TargetGuid != other.TargetGuid) return false;
      if (ItemId != other.ItemId) return false;
      if (OptionIdx != other.OptionIdx) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (TargetGuid != 0UL) hash ^= TargetGuid.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (OptionIdx != 0) hash ^= OptionIdx.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (TargetGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TargetGuid);
      }
      if (ItemId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Guid);
      }
      if (OptionIdx != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OptionIdx);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (TargetGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TargetGuid);
      }
      if (ItemId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Guid);
      }
      if (OptionIdx != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OptionIdx);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (TargetGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetGuid);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (OptionIdx != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionIdx);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UseItemRsp other) {
      if (other == null) {
        return;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.TargetGuid != 0UL) {
        TargetGuid = other.TargetGuid;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.OptionIdx != 0) {
        OptionIdx = other.OptionIdx;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            TargetGuid = input.ReadUInt64();
            break;
          }
          case 32: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 40: {
            Guid = input.ReadUInt64();
            break;
          }
          case 64: {
            OptionIdx = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
            TargetGuid = input.ReadUInt64();
            break;
          }
          case 32: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 40: {
            Guid = input.ReadUInt64();
            break;
          }
          case 64: {
            OptionIdx = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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