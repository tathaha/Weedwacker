// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DataResVersionNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DataResVersionNotify.proto</summary>
  public static partial class DataResVersionNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DataResVersionNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataResVersionNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpEYXRhUmVzVmVyc2lvbk5vdGlmeS5wcm90bxoWUmVzVmVyc2lvbkNvbmZp",
            "Zy5wcm90byLjAwoURGF0YVJlc1ZlcnNpb25Ob3RpZnkSIwobY2xpZW50X3Np",
            "bGVuY2VfZGF0YV92ZXJzaW9uGA0gASgNEjsKB29wX3R5cGUYBiABKA4yKi5E",
            "YXRhUmVzVmVyc2lvbk5vdGlmeS5EYXRhUmVzVmVyc2lvbk9wVHlwZRIlCh1j",
            "bGllbnRfc2lsZW5jZV92ZXJzaW9uX3N1ZmZpeBgDIAEoCRIdChVjbGllbnRf",
            "dmVyc2lvbl9zdWZmaXgYCSABKAkSHAoUaXNfZGF0YV9uZWVkX3JlbG9naW4Y",
            "DyABKAgSGgoSY2xpZW50X3NpbGVuY2VfbWQ1GAwgASgJEhsKE2NsaWVudF9k",
            "YXRhX3ZlcnNpb24YBSABKA0SEgoKY2xpZW50X21kNRgCIAEoCRItChJyZXNf",
            "dmVyc2lvbl9jb25maWcYByABKAsyES5SZXNWZXJzaW9uQ29uZmlnIogBChRE",
            "YXRhUmVzVmVyc2lvbk9wVHlwZRIhCh1EQVRBX1JFU19WRVJTSU9OX09QX1RZ",
            "UEVfTk9ORRAAEiQKIERBVEFfUkVTX1ZFUlNJT05fT1BfVFlQRV9SRUxPR0lO",
            "EAESJwojREFUQV9SRVNfVkVSU0lPTl9PUF9UWVBFX01QX1JFTE9HSU4QAkIi",
            "qgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ResVersionConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DataResVersionNotify), global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Parser, new[]{ "ClientSilenceDataVersion", "OpType", "ClientSilenceVersionSuffix", "ClientVersionSuffix", "IsDataNeedRelogin", "ClientSilenceMd5", "ClientDataVersion", "ClientMd5", "ResVersionConfig" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 153;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class DataResVersionNotify : pb::IMessage<DataResVersionNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataResVersionNotify> _parser = new pb::MessageParser<DataResVersionNotify>(() => new DataResVersionNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DataResVersionNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DataResVersionNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataResVersionNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataResVersionNotify(DataResVersionNotify other) : this() {
      clientSilenceDataVersion_ = other.clientSilenceDataVersion_;
      opType_ = other.opType_;
      clientSilenceVersionSuffix_ = other.clientSilenceVersionSuffix_;
      clientVersionSuffix_ = other.clientVersionSuffix_;
      isDataNeedRelogin_ = other.isDataNeedRelogin_;
      clientSilenceMd5_ = other.clientSilenceMd5_;
      clientDataVersion_ = other.clientDataVersion_;
      clientMd5_ = other.clientMd5_;
      resVersionConfig_ = other.resVersionConfig_ != null ? other.resVersionConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataResVersionNotify Clone() {
      return new DataResVersionNotify(this);
    }

    /// <summary>Field number for the "client_silence_data_version" field.</summary>
    public const int ClientSilenceDataVersionFieldNumber = 13;
    private uint clientSilenceDataVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientSilenceDataVersion {
      get { return clientSilenceDataVersion_; }
      set {
        clientSilenceDataVersion_ = value;
      }
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType opType_ = global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "client_silence_version_suffix" field.</summary>
    public const int ClientSilenceVersionSuffixFieldNumber = 3;
    private string clientSilenceVersionSuffix_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientSilenceVersionSuffix {
      get { return clientSilenceVersionSuffix_; }
      set {
        clientSilenceVersionSuffix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_version_suffix" field.</summary>
    public const int ClientVersionSuffixFieldNumber = 9;
    private string clientVersionSuffix_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientVersionSuffix {
      get { return clientVersionSuffix_; }
      set {
        clientVersionSuffix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_data_need_relogin" field.</summary>
    public const int IsDataNeedReloginFieldNumber = 15;
    private bool isDataNeedRelogin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDataNeedRelogin {
      get { return isDataNeedRelogin_; }
      set {
        isDataNeedRelogin_ = value;
      }
    }

    /// <summary>Field number for the "client_silence_md5" field.</summary>
    public const int ClientSilenceMd5FieldNumber = 12;
    private string clientSilenceMd5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientSilenceMd5 {
      get { return clientSilenceMd5_; }
      set {
        clientSilenceMd5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_data_version" field.</summary>
    public const int ClientDataVersionFieldNumber = 5;
    private uint clientDataVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientDataVersion {
      get { return clientDataVersion_; }
      set {
        clientDataVersion_ = value;
      }
    }

    /// <summary>Field number for the "client_md5" field.</summary>
    public const int ClientMd5FieldNumber = 2;
    private string clientMd5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientMd5 {
      get { return clientMd5_; }
      set {
        clientMd5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "res_version_config" field.</summary>
    public const int ResVersionConfigFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.ResVersionConfig resVersionConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ResVersionConfig ResVersionConfig {
      get { return resVersionConfig_; }
      set {
        resVersionConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DataResVersionNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DataResVersionNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientSilenceDataVersion != other.ClientSilenceDataVersion) return false;
      if (OpType != other.OpType) return false;
      if (ClientSilenceVersionSuffix != other.ClientSilenceVersionSuffix) return false;
      if (ClientVersionSuffix != other.ClientVersionSuffix) return false;
      if (IsDataNeedRelogin != other.IsDataNeedRelogin) return false;
      if (ClientSilenceMd5 != other.ClientSilenceMd5) return false;
      if (ClientDataVersion != other.ClientDataVersion) return false;
      if (ClientMd5 != other.ClientMd5) return false;
      if (!object.Equals(ResVersionConfig, other.ResVersionConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientSilenceDataVersion != 0) hash ^= ClientSilenceDataVersion.GetHashCode();
      if (OpType != global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType.None) hash ^= OpType.GetHashCode();
      if (ClientSilenceVersionSuffix.Length != 0) hash ^= ClientSilenceVersionSuffix.GetHashCode();
      if (ClientVersionSuffix.Length != 0) hash ^= ClientVersionSuffix.GetHashCode();
      if (IsDataNeedRelogin != false) hash ^= IsDataNeedRelogin.GetHashCode();
      if (ClientSilenceMd5.Length != 0) hash ^= ClientSilenceMd5.GetHashCode();
      if (ClientDataVersion != 0) hash ^= ClientDataVersion.GetHashCode();
      if (ClientMd5.Length != 0) hash ^= ClientMd5.GetHashCode();
      if (resVersionConfig_ != null) hash ^= ResVersionConfig.GetHashCode();
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
      if (ClientMd5.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ClientMd5);
      }
      if (ClientSilenceVersionSuffix.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ClientSilenceVersionSuffix);
      }
      if (ClientDataVersion != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ClientDataVersion);
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) OpType);
      }
      if (resVersionConfig_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ResVersionConfig);
      }
      if (ClientVersionSuffix.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ClientVersionSuffix);
      }
      if (ClientSilenceMd5.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ClientSilenceMd5);
      }
      if (ClientSilenceDataVersion != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ClientSilenceDataVersion);
      }
      if (IsDataNeedRelogin != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsDataNeedRelogin);
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
      if (ClientMd5.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ClientMd5);
      }
      if (ClientSilenceVersionSuffix.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ClientSilenceVersionSuffix);
      }
      if (ClientDataVersion != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ClientDataVersion);
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType.None) {
        output.WriteRawTag(48);
        output.WriteEnum((int) OpType);
      }
      if (resVersionConfig_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ResVersionConfig);
      }
      if (ClientVersionSuffix.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ClientVersionSuffix);
      }
      if (ClientSilenceMd5.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(ClientSilenceMd5);
      }
      if (ClientSilenceDataVersion != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ClientSilenceDataVersion);
      }
      if (IsDataNeedRelogin != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsDataNeedRelogin);
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
      if (ClientSilenceDataVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientSilenceDataVersion);
      }
      if (OpType != global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (ClientSilenceVersionSuffix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientSilenceVersionSuffix);
      }
      if (ClientVersionSuffix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientVersionSuffix);
      }
      if (IsDataNeedRelogin != false) {
        size += 1 + 1;
      }
      if (ClientSilenceMd5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientSilenceMd5);
      }
      if (ClientDataVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientDataVersion);
      }
      if (ClientMd5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientMd5);
      }
      if (resVersionConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResVersionConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DataResVersionNotify other) {
      if (other == null) {
        return;
      }
      if (other.ClientSilenceDataVersion != 0) {
        ClientSilenceDataVersion = other.ClientSilenceDataVersion;
      }
      if (other.OpType != global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType.None) {
        OpType = other.OpType;
      }
      if (other.ClientSilenceVersionSuffix.Length != 0) {
        ClientSilenceVersionSuffix = other.ClientSilenceVersionSuffix;
      }
      if (other.ClientVersionSuffix.Length != 0) {
        ClientVersionSuffix = other.ClientVersionSuffix;
      }
      if (other.IsDataNeedRelogin != false) {
        IsDataNeedRelogin = other.IsDataNeedRelogin;
      }
      if (other.ClientSilenceMd5.Length != 0) {
        ClientSilenceMd5 = other.ClientSilenceMd5;
      }
      if (other.ClientDataVersion != 0) {
        ClientDataVersion = other.ClientDataVersion;
      }
      if (other.ClientMd5.Length != 0) {
        ClientMd5 = other.ClientMd5;
      }
      if (other.resVersionConfig_ != null) {
        if (resVersionConfig_ == null) {
          ResVersionConfig = new global::Weedwacker.Shared.Network.Proto.ResVersionConfig();
        }
        ResVersionConfig.MergeFrom(other.ResVersionConfig);
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
            ClientMd5 = input.ReadString();
            break;
          }
          case 26: {
            ClientSilenceVersionSuffix = input.ReadString();
            break;
          }
          case 40: {
            ClientDataVersion = input.ReadUInt32();
            break;
          }
          case 48: {
            OpType = (global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType) input.ReadEnum();
            break;
          }
          case 58: {
            if (resVersionConfig_ == null) {
              ResVersionConfig = new global::Weedwacker.Shared.Network.Proto.ResVersionConfig();
            }
            input.ReadMessage(ResVersionConfig);
            break;
          }
          case 74: {
            ClientVersionSuffix = input.ReadString();
            break;
          }
          case 98: {
            ClientSilenceMd5 = input.ReadString();
            break;
          }
          case 104: {
            ClientSilenceDataVersion = input.ReadUInt32();
            break;
          }
          case 120: {
            IsDataNeedRelogin = input.ReadBool();
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
            ClientMd5 = input.ReadString();
            break;
          }
          case 26: {
            ClientSilenceVersionSuffix = input.ReadString();
            break;
          }
          case 40: {
            ClientDataVersion = input.ReadUInt32();
            break;
          }
          case 48: {
            OpType = (global::Weedwacker.Shared.Network.Proto.DataResVersionNotify.Types.DataResVersionOpType) input.ReadEnum();
            break;
          }
          case 58: {
            if (resVersionConfig_ == null) {
              ResVersionConfig = new global::Weedwacker.Shared.Network.Proto.ResVersionConfig();
            }
            input.ReadMessage(ResVersionConfig);
            break;
          }
          case 74: {
            ClientVersionSuffix = input.ReadString();
            break;
          }
          case 98: {
            ClientSilenceMd5 = input.ReadString();
            break;
          }
          case 104: {
            ClientSilenceDataVersion = input.ReadUInt32();
            break;
          }
          case 120: {
            IsDataNeedRelogin = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DataResVersionNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum DataResVersionOpType {
        [pbr::OriginalName("DATA_RES_VERSION_OP_TYPE_NONE")] None = 0,
        [pbr::OriginalName("DATA_RES_VERSION_OP_TYPE_RELOGIN")] Relogin = 1,
        [pbr::OriginalName("DATA_RES_VERSION_OP_TYPE_MP_RELOGIN")] MpRelogin = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
