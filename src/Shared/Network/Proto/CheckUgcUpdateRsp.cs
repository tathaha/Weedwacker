// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheckUgcUpdateRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CheckUgcUpdateRsp.proto</summary>
  public static partial class CheckUgcUpdateRspReflection {

    #region Descriptor
    /// <summary>File descriptor for CheckUgcUpdateRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckUgcUpdateRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDaGVja1VnY1VwZGF0ZVJzcC5wcm90bxoNVWdjVHlwZS5wcm90byJeChFD",
            "aGVja1VnY1VwZGF0ZVJzcBIaCgh1Z2NfdHlwZRgGIAEoDjIILlVnY1R5cGUS",
            "HAoUdXBkYXRlX3VnY19ndWlkX2xpc3QYAyADKAQSDwoHcmV0Y29kZRgHIAEo",
            "BUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.UgcTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CheckUgcUpdateRsp), global::Weedwacker.Shared.Network.Proto.CheckUgcUpdateRsp.Parser, new[]{ "UgcType", "UpdateUgcGuidList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6318;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class CheckUgcUpdateRsp : pb::IMessage<CheckUgcUpdateRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheckUgcUpdateRsp> _parser = new pb::MessageParser<CheckUgcUpdateRsp>(() => new CheckUgcUpdateRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheckUgcUpdateRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CheckUgcUpdateRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckUgcUpdateRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckUgcUpdateRsp(CheckUgcUpdateRsp other) : this() {
      ugcType_ = other.ugcType_;
      updateUgcGuidList_ = other.updateUgcGuidList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckUgcUpdateRsp Clone() {
      return new CheckUgcUpdateRsp(this);
    }

    /// <summary>Field number for the "ugc_type" field.</summary>
    public const int UgcTypeFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.UgcType ugcType_ = global::Weedwacker.Shared.Network.Proto.UgcType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.UgcType UgcType {
      get { return ugcType_; }
      set {
        ugcType_ = value;
      }
    }

    /// <summary>Field number for the "update_ugc_guid_list" field.</summary>
    public const int UpdateUgcGuidListFieldNumber = 3;
    private static readonly pb::FieldCodec<ulong> _repeated_updateUgcGuidList_codec
        = pb::FieldCodec.ForUInt64(26);
    private readonly pbc::RepeatedField<ulong> updateUgcGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> UpdateUgcGuidList {
      get { return updateUgcGuidList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
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
      return Equals(other as CheckUgcUpdateRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheckUgcUpdateRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UgcType != other.UgcType) return false;
      if(!updateUgcGuidList_.Equals(other.updateUgcGuidList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UgcType != global::Weedwacker.Shared.Network.Proto.UgcType.None) hash ^= UgcType.GetHashCode();
      hash ^= updateUgcGuidList_.GetHashCode();
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
      updateUgcGuidList_.WriteTo(output, _repeated_updateUgcGuidList_codec);
      if (UgcType != global::Weedwacker.Shared.Network.Proto.UgcType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) UgcType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
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
      updateUgcGuidList_.WriteTo(ref output, _repeated_updateUgcGuidList_codec);
      if (UgcType != global::Weedwacker.Shared.Network.Proto.UgcType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) UgcType);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
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
      if (UgcType != global::Weedwacker.Shared.Network.Proto.UgcType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UgcType);
      }
      size += updateUgcGuidList_.CalculateSize(_repeated_updateUgcGuidList_codec);
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
    public void MergeFrom(CheckUgcUpdateRsp other) {
      if (other == null) {
        return;
      }
      if (other.UgcType != global::Weedwacker.Shared.Network.Proto.UgcType.None) {
        UgcType = other.UgcType;
      }
      updateUgcGuidList_.Add(other.updateUgcGuidList_);
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
          case 26:
          case 24: {
            updateUgcGuidList_.AddEntriesFrom(input, _repeated_updateUgcGuidList_codec);
            break;
          }
          case 48: {
            UgcType = (global::Weedwacker.Shared.Network.Proto.UgcType) input.ReadEnum();
            break;
          }
          case 56: {
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
          case 26:
          case 24: {
            updateUgcGuidList_.AddEntriesFrom(ref input, _repeated_updateUgcGuidList_codec);
            break;
          }
          case 48: {
            UgcType = (global::Weedwacker.Shared.Network.Proto.UgcType) input.ReadEnum();
            break;
          }
          case 56: {
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
