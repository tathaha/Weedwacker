// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: H5ActivityIdsNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from H5ActivityIdsNotify.proto</summary>
  public static partial class H5ActivityIdsNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for H5ActivityIdsNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static H5ActivityIdsNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlINUFjdGl2aXR5SWRzTm90aWZ5LnByb3RvIq8BChNINUFjdGl2aXR5SWRz",
            "Tm90aWZ5EiAKGGNsaWVudF9yZWRfZG90X3RpbWVzdGFtcBgFIAEoDRJACg9o",
            "NV9hY3Rpdml0eV9tYXAYDCADKAsyJy5INUFjdGl2aXR5SWRzTm90aWZ5Lkg1",
            "QWN0aXZpdHlNYXBFbnRyeRo0ChJINUFjdGl2aXR5TWFwRW50cnkSCwoDa2V5",
            "GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIiqgIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.H5ActivityIdsNotify), global::Weedwacker.Shared.Network.Proto.H5ActivityIdsNotify.Parser, new[]{ "ClientRedDotTimestamp", "H5ActivityMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5672;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class H5ActivityIdsNotify : pb::IMessage<H5ActivityIdsNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<H5ActivityIdsNotify> _parser = new pb::MessageParser<H5ActivityIdsNotify>(() => new H5ActivityIdsNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<H5ActivityIdsNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.H5ActivityIdsNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public H5ActivityIdsNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public H5ActivityIdsNotify(H5ActivityIdsNotify other) : this() {
      clientRedDotTimestamp_ = other.clientRedDotTimestamp_;
      h5ActivityMap_ = other.h5ActivityMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public H5ActivityIdsNotify Clone() {
      return new H5ActivityIdsNotify(this);
    }

    /// <summary>Field number for the "client_red_dot_timestamp" field.</summary>
    public const int ClientRedDotTimestampFieldNumber = 5;
    private uint clientRedDotTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientRedDotTimestamp {
      get { return clientRedDotTimestamp_; }
      set {
        clientRedDotTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "h5_activity_map" field.</summary>
    public const int H5ActivityMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_h5ActivityMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> h5ActivityMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> H5ActivityMap {
      get { return h5ActivityMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as H5ActivityIdsNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(H5ActivityIdsNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientRedDotTimestamp != other.ClientRedDotTimestamp) return false;
      if (!H5ActivityMap.Equals(other.H5ActivityMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientRedDotTimestamp != 0) hash ^= ClientRedDotTimestamp.GetHashCode();
      hash ^= H5ActivityMap.GetHashCode();
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
      if (ClientRedDotTimestamp != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ClientRedDotTimestamp);
      }
      h5ActivityMap_.WriteTo(output, _map_h5ActivityMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClientRedDotTimestamp != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ClientRedDotTimestamp);
      }
      h5ActivityMap_.WriteTo(ref output, _map_h5ActivityMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ClientRedDotTimestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientRedDotTimestamp);
      }
      size += h5ActivityMap_.CalculateSize(_map_h5ActivityMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(H5ActivityIdsNotify other) {
      if (other == null) {
        return;
      }
      if (other.ClientRedDotTimestamp != 0) {
        ClientRedDotTimestamp = other.ClientRedDotTimestamp;
      }
      h5ActivityMap_.Add(other.h5ActivityMap_);
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
          case 40: {
            ClientRedDotTimestamp = input.ReadUInt32();
            break;
          }
          case 98: {
            h5ActivityMap_.AddEntriesFrom(input, _map_h5ActivityMap_codec);
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
          case 40: {
            ClientRedDotTimestamp = input.ReadUInt32();
            break;
          }
          case 98: {
            h5ActivityMap_.AddEntriesFrom(ref input, _map_h5ActivityMap_codec);
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
