// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetCityReputationInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetCityReputationInfoRsp.proto</summary>
  public static partial class GetCityReputationInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetCityReputationInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetCityReputationInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HZXRDaXR5UmVwdXRhdGlvbkluZm9Sc3AucHJvdG8aGENpdHlSZXB1dGF0",
            "aW9uSW5mby5wcm90byJvChhHZXRDaXR5UmVwdXRhdGlvbkluZm9Sc3ASMQoU",
            "Y2l0eV9yZXB1dGF0aW9uX2luZm8YCyABKAsyEy5DaXR5UmVwdXRhdGlvbklu",
            "Zm8SDwoHY2l0eV9pZBgHIAEoDRIPCgdyZXRjb2RlGAIgASgFQiKqAh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CityReputationInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetCityReputationInfoRsp), global::Weedwacker.Shared.Network.Proto.GetCityReputationInfoRsp.Parser, new[]{ "CityReputationInfo", "CityId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 2830;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetCityReputationInfoRsp : pb::IMessage<GetCityReputationInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetCityReputationInfoRsp> _parser = new pb::MessageParser<GetCityReputationInfoRsp>(() => new GetCityReputationInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetCityReputationInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetCityReputationInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCityReputationInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCityReputationInfoRsp(GetCityReputationInfoRsp other) : this() {
      cityReputationInfo_ = other.cityReputationInfo_ != null ? other.cityReputationInfo_.Clone() : null;
      cityId_ = other.cityId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCityReputationInfoRsp Clone() {
      return new GetCityReputationInfoRsp(this);
    }

    /// <summary>Field number for the "city_reputation_info" field.</summary>
    public const int CityReputationInfoFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.CityReputationInfo cityReputationInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.CityReputationInfo CityReputationInfo {
      get { return cityReputationInfo_; }
      set {
        cityReputationInfo_ = value;
      }
    }

    /// <summary>Field number for the "city_id" field.</summary>
    public const int CityIdFieldNumber = 7;
    private uint cityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityId {
      get { return cityId_; }
      set {
        cityId_ = value;
      }
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetCityReputationInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetCityReputationInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CityReputationInfo, other.CityReputationInfo)) return false;
      if (CityId != other.CityId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cityReputationInfo_ != null) hash ^= CityReputationInfo.GetHashCode();
      if (CityId != 0) hash ^= CityId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (CityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CityId);
      }
      if (cityReputationInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CityReputationInfo);
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
        output.WriteRawTag(16);
        output.WriteInt32(Retcode);
      }
      if (CityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CityId);
      }
      if (cityReputationInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CityReputationInfo);
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
      if (cityReputationInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CityReputationInfo);
      }
      if (CityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetCityReputationInfoRsp other) {
      if (other == null) {
        return;
      }
      if (other.cityReputationInfo_ != null) {
        if (cityReputationInfo_ == null) {
          CityReputationInfo = new global::Weedwacker.Shared.Network.Proto.CityReputationInfo();
        }
        CityReputationInfo.MergeFrom(other.CityReputationInfo);
      }
      if (other.CityId != 0) {
        CityId = other.CityId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 16: {
            Retcode = input.ReadInt32();
            break;
          }
          case 56: {
            CityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (cityReputationInfo_ == null) {
              CityReputationInfo = new global::Weedwacker.Shared.Network.Proto.CityReputationInfo();
            }
            input.ReadMessage(CityReputationInfo);
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
          case 56: {
            CityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (cityReputationInfo_ == null) {
              CityReputationInfo = new global::Weedwacker.Shared.Network.Proto.CityReputationInfo();
            }
            input.ReadMessage(CityReputationInfo);
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
