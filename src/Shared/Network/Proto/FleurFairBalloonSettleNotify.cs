// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairBalloonSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FleurFairBalloonSettleNotify.proto</summary>
  public static partial class FleurFairBalloonSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairBalloonSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairBalloonSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJGbGV1ckZhaXJCYWxsb29uU2V0dGxlTm90aWZ5LnByb3RvGiBGbGV1ckZh",
            "aXJCYWxsb29uU2V0dGxlSW5mby5wcm90byLRAQocRmxldXJGYWlyQmFsbG9v",
            "blNldHRsZU5vdGlmeRITCgttaW5pZ2FtZV9pZBgBIAEoDRJJCg9zZXR0bGVf",
            "aW5mb19tYXAYBiADKAsyMC5GbGV1ckZhaXJCYWxsb29uU2V0dGxlTm90aWZ5",
            "LlNldHRsZUluZm9NYXBFbnRyeRpRChJTZXR0bGVJbmZvTWFwRW50cnkSCwoD",
            "a2V5GAEgASgNEioKBXZhbHVlGAIgASgLMhsuRmxldXJGYWlyQmFsbG9vblNl",
            "dHRsZUluZm86AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleNotify), global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleNotify.Parser, new[]{ "MinigameId", "SettleInfoMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2159;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class FleurFairBalloonSettleNotify : pb::IMessage<FleurFairBalloonSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairBalloonSettleNotify> _parser = new pb::MessageParser<FleurFairBalloonSettleNotify>(() => new FleurFairBalloonSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairBalloonSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairBalloonSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairBalloonSettleNotify(FleurFairBalloonSettleNotify other) : this() {
      minigameId_ = other.minigameId_;
      settleInfoMap_ = other.settleInfoMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairBalloonSettleNotify Clone() {
      return new FleurFairBalloonSettleNotify(this);
    }

    /// <summary>Field number for the "minigame_id" field.</summary>
    public const int MinigameIdFieldNumber = 1;
    private uint minigameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinigameId {
      get { return minigameId_; }
      set {
        minigameId_ = value;
      }
    }

    /// <summary>Field number for the "settle_info_map" field.</summary>
    public const int SettleInfoMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleInfo>.Codec _map_settleInfoMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleInfo.Parser), 50);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleInfo> settleInfoMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.FleurFairBalloonSettleInfo> SettleInfoMap {
      get { return settleInfoMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FleurFairBalloonSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairBalloonSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinigameId != other.MinigameId) return false;
      if (!SettleInfoMap.Equals(other.SettleInfoMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MinigameId != 0) hash ^= MinigameId.GetHashCode();
      hash ^= SettleInfoMap.GetHashCode();
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
      if (MinigameId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MinigameId);
      }
      settleInfoMap_.WriteTo(output, _map_settleInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MinigameId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MinigameId);
      }
      settleInfoMap_.WriteTo(ref output, _map_settleInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MinigameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinigameId);
      }
      size += settleInfoMap_.CalculateSize(_map_settleInfoMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairBalloonSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.MinigameId != 0) {
        MinigameId = other.MinigameId;
      }
      settleInfoMap_.Add(other.settleInfoMap_);
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
            MinigameId = input.ReadUInt32();
            break;
          }
          case 50: {
            settleInfoMap_.AddEntriesFrom(input, _map_settleInfoMap_codec);
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
            MinigameId = input.ReadUInt32();
            break;
          }
          case 50: {
            settleInfoMap_.AddEntriesFrom(ref input, _map_settleInfoMap_codec);
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
