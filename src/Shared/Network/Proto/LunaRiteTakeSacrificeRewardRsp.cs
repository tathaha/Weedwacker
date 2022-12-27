// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LunaRiteTakeSacrificeRewardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LunaRiteTakeSacrificeRewardRsp.proto</summary>
  public static partial class LunaRiteTakeSacrificeRewardRspReflection {

    #region Descriptor
    /// <summary>File descriptor for LunaRiteTakeSacrificeRewardRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LunaRiteTakeSacrificeRewardRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRMdW5hUml0ZVRha2VTYWNyaWZpY2VSZXdhcmRSc3AucHJvdG8ikAEKHkx1",
            "bmFSaXRlVGFrZVNhY3JpZmljZVJld2FyZFJzcBIPCgdhcmVhX2lkGA4gASgN",
            "Eg8KB3JldGNvZGUYASABKAUSHgoWc2FjcmlmaWNlX3Jld2FyZF9pbmRleBgG",
            "IAEoDRIdChVzYWNyaWZpY2VfcmV3YXJkX2xpc3QYCSADKA0SDQoFaW5kZXgY",
            "BCABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.LunaRiteTakeSacrificeRewardRsp), global::Weedwacker.Shared.Network.Proto.LunaRiteTakeSacrificeRewardRsp.Parser, new[]{ "AreaId", "Retcode", "SacrificeRewardIndex", "SacrificeRewardList", "Index" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8895;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class LunaRiteTakeSacrificeRewardRsp : pb::IMessage<LunaRiteTakeSacrificeRewardRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LunaRiteTakeSacrificeRewardRsp> _parser = new pb::MessageParser<LunaRiteTakeSacrificeRewardRsp>(() => new LunaRiteTakeSacrificeRewardRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LunaRiteTakeSacrificeRewardRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.LunaRiteTakeSacrificeRewardRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteTakeSacrificeRewardRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteTakeSacrificeRewardRsp(LunaRiteTakeSacrificeRewardRsp other) : this() {
      areaId_ = other.areaId_;
      retcode_ = other.retcode_;
      sacrificeRewardIndex_ = other.sacrificeRewardIndex_;
      sacrificeRewardList_ = other.sacrificeRewardList_.Clone();
      index_ = other.index_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteTakeSacrificeRewardRsp Clone() {
      return new LunaRiteTakeSacrificeRewardRsp(this);
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 14;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
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

    /// <summary>Field number for the "sacrifice_reward_index" field.</summary>
    public const int SacrificeRewardIndexFieldNumber = 6;
    private uint sacrificeRewardIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SacrificeRewardIndex {
      get { return sacrificeRewardIndex_; }
      set {
        sacrificeRewardIndex_ = value;
      }
    }

    /// <summary>Field number for the "sacrifice_reward_list" field.</summary>
    public const int SacrificeRewardListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_sacrificeRewardList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> sacrificeRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SacrificeRewardList {
      get { return sacrificeRewardList_; }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 4;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LunaRiteTakeSacrificeRewardRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LunaRiteTakeSacrificeRewardRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AreaId != other.AreaId) return false;
      if (Retcode != other.Retcode) return false;
      if (SacrificeRewardIndex != other.SacrificeRewardIndex) return false;
      if(!sacrificeRewardList_.Equals(other.sacrificeRewardList_)) return false;
      if (Index != other.Index) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (SacrificeRewardIndex != 0) hash ^= SacrificeRewardIndex.GetHashCode();
      hash ^= sacrificeRewardList_.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
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
      if (Index != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Index);
      }
      if (SacrificeRewardIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SacrificeRewardIndex);
      }
      sacrificeRewardList_.WriteTo(output, _repeated_sacrificeRewardList_codec);
      if (AreaId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AreaId);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (Index != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Index);
      }
      if (SacrificeRewardIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SacrificeRewardIndex);
      }
      sacrificeRewardList_.WriteTo(ref output, _repeated_sacrificeRewardList_codec);
      if (AreaId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AreaId);
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
      if (AreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (SacrificeRewardIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SacrificeRewardIndex);
      }
      size += sacrificeRewardList_.CalculateSize(_repeated_sacrificeRewardList_codec);
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LunaRiteTakeSacrificeRewardRsp other) {
      if (other == null) {
        return;
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.SacrificeRewardIndex != 0) {
        SacrificeRewardIndex = other.SacrificeRewardIndex;
      }
      sacrificeRewardList_.Add(other.sacrificeRewardList_);
      if (other.Index != 0) {
        Index = other.Index;
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
            Index = input.ReadUInt32();
            break;
          }
          case 48: {
            SacrificeRewardIndex = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            sacrificeRewardList_.AddEntriesFrom(input, _repeated_sacrificeRewardList_codec);
            break;
          }
          case 112: {
            AreaId = input.ReadUInt32();
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
            Index = input.ReadUInt32();
            break;
          }
          case 48: {
            SacrificeRewardIndex = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            sacrificeRewardList_.AddEntriesFrom(ref input, _repeated_sacrificeRewardList_codec);
            break;
          }
          case 112: {
            AreaId = input.ReadUInt32();
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
