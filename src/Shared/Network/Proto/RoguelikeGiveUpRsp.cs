// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoguelikeGiveUpRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RoguelikeGiveUpRsp.proto</summary>
  public static partial class RoguelikeGiveUpRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RoguelikeGiveUpRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoguelikeGiveUpRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZWxpa2VHaXZlVXBSc3AucHJvdG8aIFJvZ3VlbGlrZUR1bmdlb25T",
            "ZXR0bGVJbmZvLnByb3RvInMKElJvZ3VlbGlrZUdpdmVVcFJzcBIPCgdyZXRj",
            "b2RlGAYgASgFEhAKCHN0YWdlX2lkGA4gASgNEjIKC3NldHRsZV9pbmZvGAIg",
            "ASgLMhsuUm9ndWVsaWtlRHVuZ2VvblNldHRsZUluZm9IAEIGCgRpbmZvQiKq",
            "Ah9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RoguelikeGiveUpRsp), global::Weedwacker.Shared.Network.Proto.RoguelikeGiveUpRsp.Parser, new[]{ "Retcode", "StageId", "SettleInfo" }, new[]{ "Info" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8905;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class RoguelikeGiveUpRsp : pb::IMessage<RoguelikeGiveUpRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RoguelikeGiveUpRsp> _parser = new pb::MessageParser<RoguelikeGiveUpRsp>(() => new RoguelikeGiveUpRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RoguelikeGiveUpRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RoguelikeGiveUpRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeGiveUpRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeGiveUpRsp(RoguelikeGiveUpRsp other) : this() {
      retcode_ = other.retcode_;
      stageId_ = other.stageId_;
      switch (other.InfoCase) {
        case InfoOneofCase.SettleInfo:
          SettleInfo = other.SettleInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeGiveUpRsp Clone() {
      return new RoguelikeGiveUpRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 14;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "settle_info" field.</summary>
    public const int SettleInfoFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfo SettleInfo {
      get { return infoCase_ == InfoOneofCase.SettleInfo ? (global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfo) info_ : null; }
      set {
        info_ = value;
        infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.SettleInfo;
      }
    }

    private object info_;
    /// <summary>Enum of possible cases for the "info" oneof.</summary>
    public enum InfoOneofCase {
      None = 0,
      SettleInfo = 2,
    }
    private InfoOneofCase infoCase_ = InfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InfoOneofCase InfoCase {
      get { return infoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInfo() {
      infoCase_ = InfoOneofCase.None;
      info_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RoguelikeGiveUpRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RoguelikeGiveUpRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (StageId != other.StageId) return false;
      if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
      if (InfoCase != other.InfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (infoCase_ == InfoOneofCase.SettleInfo) hash ^= SettleInfo.GetHashCode();
      hash ^= (int) infoCase_;
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
      if (infoCase_ == InfoOneofCase.SettleInfo) {
        output.WriteRawTag(18);
        output.WriteMessage(SettleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (StageId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(StageId);
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
      if (infoCase_ == InfoOneofCase.SettleInfo) {
        output.WriteRawTag(18);
        output.WriteMessage(SettleInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      if (StageId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(StageId);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (infoCase_ == InfoOneofCase.SettleInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RoguelikeGiveUpRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      switch (other.InfoCase) {
        case InfoOneofCase.SettleInfo:
          if (SettleInfo == null) {
            SettleInfo = new global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfo();
          }
          SettleInfo.MergeFrom(other.SettleInfo);
          break;
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
          case 18: {
            global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfo();
            if (infoCase_ == InfoOneofCase.SettleInfo) {
              subBuilder.MergeFrom(SettleInfo);
            }
            input.ReadMessage(subBuilder);
            SettleInfo = subBuilder;
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            StageId = input.ReadUInt32();
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
          case 18: {
            global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonSettleInfo();
            if (infoCase_ == InfoOneofCase.SettleInfo) {
              subBuilder.MergeFrom(SettleInfo);
            }
            input.ReadMessage(subBuilder);
            SettleInfo = subBuilder;
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            StageId = input.ReadUInt32();
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
