// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QueryCodexMonsterBeKilledNumRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from QueryCodexMonsterBeKilledNumRsp.proto</summary>
  public static partial class QueryCodexMonsterBeKilledNumRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QueryCodexMonsterBeKilledNumRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryCodexMonsterBeKilledNumRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVRdWVyeUNvZGV4TW9uc3RlckJlS2lsbGVkTnVtUnNwLnByb3RvEh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvIoMBCh9RdWVyeUNvZGV4TW9u",
            "c3RlckJlS2lsbGVkTnVtUnNwEhsKE1VuazMzMDBfQUxFTE5MSU9EQU8YCyAD",
            "KA0SGwoTVW5rMzMwMF9JTkhBR0VFTE5OQxgFIAMoDRIPCgdyZXRjb2RlGAIg",
            "ASgFEhUKDWNvZGV4X2lkX2xpc3QYCiADKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.QueryCodexMonsterBeKilledNumRsp), global::Weedwacker.Shared.Network.Proto.QueryCodexMonsterBeKilledNumRsp.Parser, new[]{ "Unk3300ALELNLIODAO", "Unk3300INHAGEELNNC", "Retcode", "CodexIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4202;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class QueryCodexMonsterBeKilledNumRsp : pb::IMessage<QueryCodexMonsterBeKilledNumRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryCodexMonsterBeKilledNumRsp> _parser = new pb::MessageParser<QueryCodexMonsterBeKilledNumRsp>(() => new QueryCodexMonsterBeKilledNumRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryCodexMonsterBeKilledNumRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.QueryCodexMonsterBeKilledNumRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp(QueryCodexMonsterBeKilledNumRsp other) : this() {
      unk3300ALELNLIODAO_ = other.unk3300ALELNLIODAO_.Clone();
      unk3300INHAGEELNNC_ = other.unk3300INHAGEELNNC_.Clone();
      retcode_ = other.retcode_;
      codexIdList_ = other.codexIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp Clone() {
      return new QueryCodexMonsterBeKilledNumRsp(this);
    }

    /// <summary>Field number for the "Unk3300_ALELNLIODAO" field.</summary>
    public const int Unk3300ALELNLIODAOFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300ALELNLIODAO_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> unk3300ALELNLIODAO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300ALELNLIODAO {
      get { return unk3300ALELNLIODAO_; }
    }

    /// <summary>Field number for the "Unk3300_INHAGEELNNC" field.</summary>
    public const int Unk3300INHAGEELNNCFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300INHAGEELNNC_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> unk3300INHAGEELNNC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300INHAGEELNNC {
      get { return unk3300INHAGEELNNC_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 2;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "codex_id_list" field.</summary>
    public const int CodexIdListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_codexIdList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> codexIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CodexIdList {
      get { return codexIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryCodexMonsterBeKilledNumRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryCodexMonsterBeKilledNumRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk3300ALELNLIODAO_.Equals(other.unk3300ALELNLIODAO_)) return false;
      if(!unk3300INHAGEELNNC_.Equals(other.unk3300INHAGEELNNC_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!codexIdList_.Equals(other.codexIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk3300ALELNLIODAO_.GetHashCode();
      hash ^= unk3300INHAGEELNNC_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= codexIdList_.GetHashCode();
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
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      unk3300INHAGEELNNC_.WriteTo(output, _repeated_unk3300INHAGEELNNC_codec);
      codexIdList_.WriteTo(output, _repeated_codexIdList_codec);
      unk3300ALELNLIODAO_.WriteTo(output, _repeated_unk3300ALELNLIODAO_codec);
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
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      unk3300INHAGEELNNC_.WriteTo(ref output, _repeated_unk3300INHAGEELNNC_codec);
      codexIdList_.WriteTo(ref output, _repeated_codexIdList_codec);
      unk3300ALELNLIODAO_.WriteTo(ref output, _repeated_unk3300ALELNLIODAO_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk3300ALELNLIODAO_.CalculateSize(_repeated_unk3300ALELNLIODAO_codec);
      size += unk3300INHAGEELNNC_.CalculateSize(_repeated_unk3300INHAGEELNNC_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += codexIdList_.CalculateSize(_repeated_codexIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryCodexMonsterBeKilledNumRsp other) {
      if (other == null) {
        return;
      }
      unk3300ALELNLIODAO_.Add(other.unk3300ALELNLIODAO_);
      unk3300INHAGEELNNC_.Add(other.unk3300INHAGEELNNC_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      codexIdList_.Add(other.codexIdList_);
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
            Retcode = input.ReadInt32();
            break;
          }
          case 42:
          case 40: {
            unk3300INHAGEELNNC_.AddEntriesFrom(input, _repeated_unk3300INHAGEELNNC_codec);
            break;
          }
          case 82:
          case 80: {
            codexIdList_.AddEntriesFrom(input, _repeated_codexIdList_codec);
            break;
          }
          case 90:
          case 88: {
            unk3300ALELNLIODAO_.AddEntriesFrom(input, _repeated_unk3300ALELNLIODAO_codec);
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
            Retcode = input.ReadInt32();
            break;
          }
          case 42:
          case 40: {
            unk3300INHAGEELNNC_.AddEntriesFrom(ref input, _repeated_unk3300INHAGEELNNC_codec);
            break;
          }
          case 82:
          case 80: {
            codexIdList_.AddEntriesFrom(ref input, _repeated_codexIdList_codec);
            break;
          }
          case 90:
          case 88: {
            unk3300ALELNLIODAO_.AddEntriesFrom(ref input, _repeated_unk3300ALELNLIODAO_codec);
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
