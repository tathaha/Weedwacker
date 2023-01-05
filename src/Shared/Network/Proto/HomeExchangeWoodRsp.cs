// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeExchangeWoodRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeExchangeWoodRsp.proto</summary>
  public static partial class HomeExchangeWoodRspReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeExchangeWoodRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeExchangeWoodRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlIb21lRXhjaGFuZ2VXb29kUnNwLnByb3RvImQKE0hvbWVFeGNoYW5nZVdv",
            "b2RSc3ASDwoHcmV0Y29kZRgPIAEoBRIXCg9leGNoYW5nZWRfY291bnQYCCAB",
            "KA0SEgoKd29vZF9jb3VudBgFIAEoDRIPCgd3b29kX2lkGAkgASgNQiKqAh9X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeExchangeWoodRsp), global::Weedwacker.Shared.Network.Proto.HomeExchangeWoodRsp.Parser, new[]{ "Retcode", "ExchangedCount", "WoodCount", "WoodId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4885;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class HomeExchangeWoodRsp : pb::IMessage<HomeExchangeWoodRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeExchangeWoodRsp> _parser = new pb::MessageParser<HomeExchangeWoodRsp>(() => new HomeExchangeWoodRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeExchangeWoodRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeExchangeWoodRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeExchangeWoodRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeExchangeWoodRsp(HomeExchangeWoodRsp other) : this() {
      retcode_ = other.retcode_;
      exchangedCount_ = other.exchangedCount_;
      woodCount_ = other.woodCount_;
      woodId_ = other.woodId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeExchangeWoodRsp Clone() {
      return new HomeExchangeWoodRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "exchanged_count" field.</summary>
    public const int ExchangedCountFieldNumber = 8;
    private uint exchangedCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExchangedCount {
      get { return exchangedCount_; }
      set {
        exchangedCount_ = value;
      }
    }

    /// <summary>Field number for the "wood_count" field.</summary>
    public const int WoodCountFieldNumber = 5;
    private uint woodCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WoodCount {
      get { return woodCount_; }
      set {
        woodCount_ = value;
      }
    }

    /// <summary>Field number for the "wood_id" field.</summary>
    public const int WoodIdFieldNumber = 9;
    private uint woodId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WoodId {
      get { return woodId_; }
      set {
        woodId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeExchangeWoodRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeExchangeWoodRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (ExchangedCount != other.ExchangedCount) return false;
      if (WoodCount != other.WoodCount) return false;
      if (WoodId != other.WoodId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ExchangedCount != 0) hash ^= ExchangedCount.GetHashCode();
      if (WoodCount != 0) hash ^= WoodCount.GetHashCode();
      if (WoodId != 0) hash ^= WoodId.GetHashCode();
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
      if (WoodCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(WoodCount);
      }
      if (ExchangedCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ExchangedCount);
      }
      if (WoodId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(WoodId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      if (WoodCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(WoodCount);
      }
      if (ExchangedCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ExchangedCount);
      }
      if (WoodId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(WoodId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      if (ExchangedCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExchangedCount);
      }
      if (WoodCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WoodCount);
      }
      if (WoodId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WoodId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeExchangeWoodRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ExchangedCount != 0) {
        ExchangedCount = other.ExchangedCount;
      }
      if (other.WoodCount != 0) {
        WoodCount = other.WoodCount;
      }
      if (other.WoodId != 0) {
        WoodId = other.WoodId;
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
          case 40: {
            WoodCount = input.ReadUInt32();
            break;
          }
          case 64: {
            ExchangedCount = input.ReadUInt32();
            break;
          }
          case 72: {
            WoodId = input.ReadUInt32();
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
            WoodCount = input.ReadUInt32();
            break;
          }
          case 64: {
            ExchangedCount = input.ReadUInt32();
            break;
          }
          case 72: {
            WoodId = input.ReadUInt32();
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
