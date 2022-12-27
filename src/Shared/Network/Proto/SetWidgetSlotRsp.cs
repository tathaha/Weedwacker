// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetWidgetSlotRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SetWidgetSlotRsp.proto</summary>
  public static partial class SetWidgetSlotRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SetWidgetSlotRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetWidgetSlotRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZTZXRXaWRnZXRTbG90UnNwLnByb3RvGhJXaWRnZXRTbG90T3AucHJvdG8a",
            "E1dpZGdldFNsb3RUYWcucHJvdG8idQoQU2V0V2lkZ2V0U2xvdFJzcBITCgtt",
            "YXRlcmlhbF9pZBgEIAEoDRIPCgdyZXRjb2RlGAEgASgFEiAKCHRhZ19saXN0",
            "GA8gAygOMg4uV2lkZ2V0U2xvdFRhZxIZCgJvcBgFIAEoDjINLldpZGdldFNs",
            "b3RPcEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.WidgetSlotOpReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WidgetSlotTagReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SetWidgetSlotRsp), global::Weedwacker.Shared.Network.Proto.SetWidgetSlotRsp.Parser, new[]{ "MaterialId", "Retcode", "TagList", "Op" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4261;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SetWidgetSlotRsp : pb::IMessage<SetWidgetSlotRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetWidgetSlotRsp> _parser = new pb::MessageParser<SetWidgetSlotRsp>(() => new SetWidgetSlotRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetWidgetSlotRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SetWidgetSlotRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetWidgetSlotRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetWidgetSlotRsp(SetWidgetSlotRsp other) : this() {
      materialId_ = other.materialId_;
      retcode_ = other.retcode_;
      tagList_ = other.tagList_.Clone();
      op_ = other.op_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetWidgetSlotRsp Clone() {
      return new SetWidgetSlotRsp(this);
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 4;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "tag_list" field.</summary>
    public const int TagListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.WidgetSlotTag> _repeated_tagList_codec
        = pb::FieldCodec.ForEnum(122, x => (int) x, x => (global::Weedwacker.Shared.Network.Proto.WidgetSlotTag) x);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetSlotTag> tagList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetSlotTag>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.WidgetSlotTag> TagList {
      get { return tagList_; }
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.WidgetSlotOp op_ = global::Weedwacker.Shared.Network.Proto.WidgetSlotOp.Attach;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WidgetSlotOp Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetWidgetSlotRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetWidgetSlotRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaterialId != other.MaterialId) return false;
      if (Retcode != other.Retcode) return false;
      if(!tagList_.Equals(other.tagList_)) return false;
      if (Op != other.Op) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= tagList_.GetHashCode();
      if (Op != global::Weedwacker.Shared.Network.Proto.WidgetSlotOp.Attach) hash ^= Op.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaterialId);
      }
      if (Op != global::Weedwacker.Shared.Network.Proto.WidgetSlotOp.Attach) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Op);
      }
      tagList_.WriteTo(output, _repeated_tagList_codec);
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
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (MaterialId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaterialId);
      }
      if (Op != global::Weedwacker.Shared.Network.Proto.WidgetSlotOp.Attach) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Op);
      }
      tagList_.WriteTo(ref output, _repeated_tagList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += tagList_.CalculateSize(_repeated_tagList_codec);
      if (Op != global::Weedwacker.Shared.Network.Proto.WidgetSlotOp.Attach) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Op);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetWidgetSlotRsp other) {
      if (other == null) {
        return;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      tagList_.Add(other.tagList_);
      if (other.Op != global::Weedwacker.Shared.Network.Proto.WidgetSlotOp.Attach) {
        Op = other.Op;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 32: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 40: {
            Op = (global::Weedwacker.Shared.Network.Proto.WidgetSlotOp) input.ReadEnum();
            break;
          }
          case 122:
          case 120: {
            tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
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
            Retcode = input.ReadInt32();
            break;
          }
          case 32: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 40: {
            Op = (global::Weedwacker.Shared.Network.Proto.WidgetSlotOp) input.ReadEnum();
            break;
          }
          case 122:
          case 120: {
            tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
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
