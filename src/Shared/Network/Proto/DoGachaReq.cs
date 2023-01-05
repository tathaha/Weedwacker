// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DoGachaReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DoGachaReq.proto</summary>
  public static partial class DoGachaReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DoGachaReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DoGachaReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBEb0dhY2hhUmVxLnByb3RvInkKCkRvR2FjaGFSZXESEQoJZ2FjaGFfdGFn",
            "GA4gASgJEhkKEWdhY2hhX3NjaGVkdWxlX2lkGAYgASgNEhIKCmdhY2hhX3R5",
            "cGUYASABKA0SFAoMZ2FjaGFfcmFuZG9tGAkgASgNEhMKC2dhY2hhX3RpbWVz",
            "GAMgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DoGachaReq), global::Weedwacker.Shared.Network.Proto.DoGachaReq.Parser, new[]{ "GachaTag", "GachaScheduleId", "GachaType", "GachaRandom", "GachaTimes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1556;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class DoGachaReq : pb::IMessage<DoGachaReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DoGachaReq> _parser = new pb::MessageParser<DoGachaReq>(() => new DoGachaReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DoGachaReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DoGachaReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaReq(DoGachaReq other) : this() {
      gachaTag_ = other.gachaTag_;
      gachaScheduleId_ = other.gachaScheduleId_;
      gachaType_ = other.gachaType_;
      gachaRandom_ = other.gachaRandom_;
      gachaTimes_ = other.gachaTimes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DoGachaReq Clone() {
      return new DoGachaReq(this);
    }

    /// <summary>Field number for the "gacha_tag" field.</summary>
    public const int GachaTagFieldNumber = 14;
    private string gachaTag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GachaTag {
      get { return gachaTag_; }
      set {
        gachaTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gacha_schedule_id" field.</summary>
    public const int GachaScheduleIdFieldNumber = 6;
    private uint gachaScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaScheduleId {
      get { return gachaScheduleId_; }
      set {
        gachaScheduleId_ = value;
      }
    }

    /// <summary>Field number for the "gacha_type" field.</summary>
    public const int GachaTypeFieldNumber = 1;
    private uint gachaType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaType {
      get { return gachaType_; }
      set {
        gachaType_ = value;
      }
    }

    /// <summary>Field number for the "gacha_random" field.</summary>
    public const int GachaRandomFieldNumber = 9;
    private uint gachaRandom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaRandom {
      get { return gachaRandom_; }
      set {
        gachaRandom_ = value;
      }
    }

    /// <summary>Field number for the "gacha_times" field.</summary>
    public const int GachaTimesFieldNumber = 3;
    private uint gachaTimes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaTimes {
      get { return gachaTimes_; }
      set {
        gachaTimes_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DoGachaReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DoGachaReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GachaTag != other.GachaTag) return false;
      if (GachaScheduleId != other.GachaScheduleId) return false;
      if (GachaType != other.GachaType) return false;
      if (GachaRandom != other.GachaRandom) return false;
      if (GachaTimes != other.GachaTimes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GachaTag.Length != 0) hash ^= GachaTag.GetHashCode();
      if (GachaScheduleId != 0) hash ^= GachaScheduleId.GetHashCode();
      if (GachaType != 0) hash ^= GachaType.GetHashCode();
      if (GachaRandom != 0) hash ^= GachaRandom.GetHashCode();
      if (GachaTimes != 0) hash ^= GachaTimes.GetHashCode();
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
      if (GachaType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GachaType);
      }
      if (GachaTimes != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GachaTimes);
      }
      if (GachaScheduleId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GachaScheduleId);
      }
      if (GachaRandom != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GachaRandom);
      }
      if (GachaTag.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(GachaTag);
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
      if (GachaType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GachaType);
      }
      if (GachaTimes != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GachaTimes);
      }
      if (GachaScheduleId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GachaScheduleId);
      }
      if (GachaRandom != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GachaRandom);
      }
      if (GachaTag.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(GachaTag);
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
      if (GachaTag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GachaTag);
      }
      if (GachaScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaScheduleId);
      }
      if (GachaType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaType);
      }
      if (GachaRandom != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaRandom);
      }
      if (GachaTimes != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaTimes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DoGachaReq other) {
      if (other == null) {
        return;
      }
      if (other.GachaTag.Length != 0) {
        GachaTag = other.GachaTag;
      }
      if (other.GachaScheduleId != 0) {
        GachaScheduleId = other.GachaScheduleId;
      }
      if (other.GachaType != 0) {
        GachaType = other.GachaType;
      }
      if (other.GachaRandom != 0) {
        GachaRandom = other.GachaRandom;
      }
      if (other.GachaTimes != 0) {
        GachaTimes = other.GachaTimes;
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
            GachaType = input.ReadUInt32();
            break;
          }
          case 24: {
            GachaTimes = input.ReadUInt32();
            break;
          }
          case 48: {
            GachaScheduleId = input.ReadUInt32();
            break;
          }
          case 72: {
            GachaRandom = input.ReadUInt32();
            break;
          }
          case 114: {
            GachaTag = input.ReadString();
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
            GachaType = input.ReadUInt32();
            break;
          }
          case 24: {
            GachaTimes = input.ReadUInt32();
            break;
          }
          case 48: {
            GachaScheduleId = input.ReadUInt32();
            break;
          }
          case 72: {
            GachaRandom = input.ReadUInt32();
            break;
          }
          case 114: {
            GachaTag = input.ReadString();
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
