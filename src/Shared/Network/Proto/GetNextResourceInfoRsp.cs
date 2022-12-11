// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetNextResourceInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetNextResourceInfoRsp.proto</summary>
  public static partial class GetNextResourceInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetNextResourceInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetNextResourceInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXROZXh0UmVzb3VyY2VJbmZvUnNwLnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvGhZSZXNWZXJzaW9uQ29uZmlnLnByb3RvIpgB",
            "ChZHZXROZXh0UmVzb3VyY2VJbmZvUnNwElIKF25leHRfcmVzX3ZlcnNpb25f",
            "Y29uZmlnGAYgASgLMjEuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "by5SZXNWZXJzaW9uQ29uZmlnEg8KB3JldGNvZGUYCCABKAUSGQoRbmV4dF9y",
            "ZXNvdXJjZV91cmwYDyABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ResVersionConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetNextResourceInfoRsp), global::Weedwacker.Shared.Network.Proto.GetNextResourceInfoRsp.Parser, new[]{ "NextResVersionConfig", "Retcode", "NextResourceUrl" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 102;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetNextResourceInfoRsp : pb::IMessage<GetNextResourceInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetNextResourceInfoRsp> _parser = new pb::MessageParser<GetNextResourceInfoRsp>(() => new GetNextResourceInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetNextResourceInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetNextResourceInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNextResourceInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNextResourceInfoRsp(GetNextResourceInfoRsp other) : this() {
      nextResVersionConfig_ = other.nextResVersionConfig_ != null ? other.nextResVersionConfig_.Clone() : null;
      retcode_ = other.retcode_;
      nextResourceUrl_ = other.nextResourceUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetNextResourceInfoRsp Clone() {
      return new GetNextResourceInfoRsp(this);
    }

    /// <summary>Field number for the "next_res_version_config" field.</summary>
    public const int NextResVersionConfigFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.ResVersionConfig nextResVersionConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ResVersionConfig NextResVersionConfig {
      get { return nextResVersionConfig_; }
      set {
        nextResVersionConfig_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "next_resource_url" field.</summary>
    public const int NextResourceUrlFieldNumber = 15;
    private string nextResourceUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NextResourceUrl {
      get { return nextResourceUrl_; }
      set {
        nextResourceUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetNextResourceInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetNextResourceInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(NextResVersionConfig, other.NextResVersionConfig)) return false;
      if (Retcode != other.Retcode) return false;
      if (NextResourceUrl != other.NextResourceUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (nextResVersionConfig_ != null) hash ^= NextResVersionConfig.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (NextResourceUrl.Length != 0) hash ^= NextResourceUrl.GetHashCode();
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
      if (nextResVersionConfig_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(NextResVersionConfig);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (NextResourceUrl.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(NextResourceUrl);
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
      if (nextResVersionConfig_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(NextResVersionConfig);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (NextResourceUrl.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(NextResourceUrl);
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
      if (nextResVersionConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NextResVersionConfig);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (NextResourceUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextResourceUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetNextResourceInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.nextResVersionConfig_ != null) {
        if (nextResVersionConfig_ == null) {
          NextResVersionConfig = new global::Weedwacker.Shared.Network.Proto.ResVersionConfig();
        }
        NextResVersionConfig.MergeFrom(other.NextResVersionConfig);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.NextResourceUrl.Length != 0) {
        NextResourceUrl = other.NextResourceUrl;
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
          case 50: {
            if (nextResVersionConfig_ == null) {
              NextResVersionConfig = new global::Weedwacker.Shared.Network.Proto.ResVersionConfig();
            }
            input.ReadMessage(NextResVersionConfig);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122: {
            NextResourceUrl = input.ReadString();
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
          case 50: {
            if (nextResVersionConfig_ == null) {
              NextResVersionConfig = new global::Weedwacker.Shared.Network.Proto.ResVersionConfig();
            }
            input.ReadMessage(NextResVersionConfig);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122: {
            NextResourceUrl = input.ReadString();
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
