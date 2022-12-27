// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QueryRegionListHttpRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from QueryRegionListHttpRsp.proto</summary>
  public static partial class QueryRegionListHttpRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QueryRegionListHttpRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryRegionListHttpRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxRdWVyeVJlZ2lvbkxpc3RIdHRwUnNwLnByb3RvGhZSZWdpb25TaW1wbGVJ",
            "bmZvLnByb3RvIq0BChZRdWVyeVJlZ2lvbkxpc3RIdHRwUnNwEg8KB3JldGNv",
            "ZGUYASABKAUSJgoLcmVnaW9uX2xpc3QYAiADKAsyES5SZWdpb25TaW1wbGVJ",
            "bmZvEhkKEWNsaWVudF9zZWNyZXRfa2V5GAUgASgMEiYKHmNsaWVudF9jdXN0",
            "b21fY29uZmlnX2VuY3J5cHRlZBgGIAEoDBIXCg9lbmFibGVfbG9naW5fcGMY",
            "ByABKAhCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RegionSimpleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.QueryRegionListHttpRsp), global::Weedwacker.Shared.Network.Proto.QueryRegionListHttpRsp.Parser, new[]{ "Retcode", "RegionList", "ClientSecretKey", "ClientCustomConfigEncrypted", "EnableLoginPc" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QueryRegionListHttpRsp : pb::IMessage<QueryRegionListHttpRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryRegionListHttpRsp> _parser = new pb::MessageParser<QueryRegionListHttpRsp>(() => new QueryRegionListHttpRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryRegionListHttpRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.QueryRegionListHttpRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryRegionListHttpRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryRegionListHttpRsp(QueryRegionListHttpRsp other) : this() {
      retcode_ = other.retcode_;
      regionList_ = other.regionList_.Clone();
      clientSecretKey_ = other.clientSecretKey_;
      clientCustomConfigEncrypted_ = other.clientCustomConfigEncrypted_;
      enableLoginPc_ = other.enableLoginPc_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryRegionListHttpRsp Clone() {
      return new QueryRegionListHttpRsp(this);
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

    /// <summary>Field number for the "region_list" field.</summary>
    public const int RegionListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RegionSimpleInfo> _repeated_regionList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.RegionSimpleInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RegionSimpleInfo> regionList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RegionSimpleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RegionSimpleInfo> RegionList {
      get { return regionList_; }
    }

    /// <summary>Field number for the "client_secret_key" field.</summary>
    public const int ClientSecretKeyFieldNumber = 5;
    private pb::ByteString clientSecretKey_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ClientSecretKey {
      get { return clientSecretKey_; }
      set {
        clientSecretKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_custom_config_encrypted" field.</summary>
    public const int ClientCustomConfigEncryptedFieldNumber = 6;
    private pb::ByteString clientCustomConfigEncrypted_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString ClientCustomConfigEncrypted {
      get { return clientCustomConfigEncrypted_; }
      set {
        clientCustomConfigEncrypted_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "enable_login_pc" field.</summary>
    public const int EnableLoginPcFieldNumber = 7;
    private bool enableLoginPc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnableLoginPc {
      get { return enableLoginPc_; }
      set {
        enableLoginPc_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QueryRegionListHttpRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryRegionListHttpRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!regionList_.Equals(other.regionList_)) return false;
      if (ClientSecretKey != other.ClientSecretKey) return false;
      if (ClientCustomConfigEncrypted != other.ClientCustomConfigEncrypted) return false;
      if (EnableLoginPc != other.EnableLoginPc) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= regionList_.GetHashCode();
      if (ClientSecretKey.Length != 0) hash ^= ClientSecretKey.GetHashCode();
      if (ClientCustomConfigEncrypted.Length != 0) hash ^= ClientCustomConfigEncrypted.GetHashCode();
      if (EnableLoginPc != false) hash ^= EnableLoginPc.GetHashCode();
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
      regionList_.WriteTo(output, _repeated_regionList_codec);
      if (ClientSecretKey.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(ClientSecretKey);
      }
      if (ClientCustomConfigEncrypted.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(ClientCustomConfigEncrypted);
      }
      if (EnableLoginPc != false) {
        output.WriteRawTag(56);
        output.WriteBool(EnableLoginPc);
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
      regionList_.WriteTo(ref output, _repeated_regionList_codec);
      if (ClientSecretKey.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(ClientSecretKey);
      }
      if (ClientCustomConfigEncrypted.Length != 0) {
        output.WriteRawTag(50);
        output.WriteBytes(ClientCustomConfigEncrypted);
      }
      if (EnableLoginPc != false) {
        output.WriteRawTag(56);
        output.WriteBool(EnableLoginPc);
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
      size += regionList_.CalculateSize(_repeated_regionList_codec);
      if (ClientSecretKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ClientSecretKey);
      }
      if (ClientCustomConfigEncrypted.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ClientCustomConfigEncrypted);
      }
      if (EnableLoginPc != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QueryRegionListHttpRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      regionList_.Add(other.regionList_);
      if (other.ClientSecretKey.Length != 0) {
        ClientSecretKey = other.ClientSecretKey;
      }
      if (other.ClientCustomConfigEncrypted.Length != 0) {
        ClientCustomConfigEncrypted = other.ClientCustomConfigEncrypted;
      }
      if (other.EnableLoginPc != false) {
        EnableLoginPc = other.EnableLoginPc;
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
          case 18: {
            regionList_.AddEntriesFrom(input, _repeated_regionList_codec);
            break;
          }
          case 42: {
            ClientSecretKey = input.ReadBytes();
            break;
          }
          case 50: {
            ClientCustomConfigEncrypted = input.ReadBytes();
            break;
          }
          case 56: {
            EnableLoginPc = input.ReadBool();
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
          case 18: {
            regionList_.AddEntriesFrom(ref input, _repeated_regionList_codec);
            break;
          }
          case 42: {
            ClientSecretKey = input.ReadBytes();
            break;
          }
          case 50: {
            ClientCustomConfigEncrypted = input.ReadBytes();
            break;
          }
          case 56: {
            EnableLoginPc = input.ReadBool();
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
