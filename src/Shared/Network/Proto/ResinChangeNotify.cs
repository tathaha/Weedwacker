// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ResinChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ResinChangeNotify.proto</summary>
  public static partial class ResinChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ResinChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResinChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSZXNpbkNoYW5nZU5vdGlmeS5wcm90byJZChFSZXNpbkNoYW5nZU5vdGlm",
            "eRIVCg1jdXJfYnV5X2NvdW50GAsgASgNEhoKEm5leHRfYWRkX3RpbWVzdGFt",
            "cBgNIAEoDRIRCgljdXJfdmFsdWUYCiABKA1CIqoCH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ResinChangeNotify), global::Weedwacker.Shared.Network.Proto.ResinChangeNotify.Parser, new[]{ "CurBuyCount", "NextAddTimestamp", "CurValue" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 611;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ResinChangeNotify : pb::IMessage<ResinChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResinChangeNotify> _parser = new pb::MessageParser<ResinChangeNotify>(() => new ResinChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ResinChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ResinChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResinChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResinChangeNotify(ResinChangeNotify other) : this() {
      curBuyCount_ = other.curBuyCount_;
      nextAddTimestamp_ = other.nextAddTimestamp_;
      curValue_ = other.curValue_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ResinChangeNotify Clone() {
      return new ResinChangeNotify(this);
    }

    /// <summary>Field number for the "cur_buy_count" field.</summary>
    public const int CurBuyCountFieldNumber = 11;
    private uint curBuyCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurBuyCount {
      get { return curBuyCount_; }
      set {
        curBuyCount_ = value;
      }
    }

    /// <summary>Field number for the "next_add_timestamp" field.</summary>
    public const int NextAddTimestampFieldNumber = 13;
    private uint nextAddTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextAddTimestamp {
      get { return nextAddTimestamp_; }
      set {
        nextAddTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "cur_value" field.</summary>
    public const int CurValueFieldNumber = 10;
    private uint curValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurValue {
      get { return curValue_; }
      set {
        curValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ResinChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ResinChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurBuyCount != other.CurBuyCount) return false;
      if (NextAddTimestamp != other.NextAddTimestamp) return false;
      if (CurValue != other.CurValue) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurBuyCount != 0) hash ^= CurBuyCount.GetHashCode();
      if (NextAddTimestamp != 0) hash ^= NextAddTimestamp.GetHashCode();
      if (CurValue != 0) hash ^= CurValue.GetHashCode();
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
      if (CurValue != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurValue);
      }
      if (CurBuyCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurBuyCount);
      }
      if (NextAddTimestamp != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NextAddTimestamp);
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
      if (CurValue != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurValue);
      }
      if (CurBuyCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurBuyCount);
      }
      if (NextAddTimestamp != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NextAddTimestamp);
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
      if (CurBuyCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurBuyCount);
      }
      if (NextAddTimestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextAddTimestamp);
      }
      if (CurValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ResinChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.CurBuyCount != 0) {
        CurBuyCount = other.CurBuyCount;
      }
      if (other.NextAddTimestamp != 0) {
        NextAddTimestamp = other.NextAddTimestamp;
      }
      if (other.CurValue != 0) {
        CurValue = other.CurValue;
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
          case 80: {
            CurValue = input.ReadUInt32();
            break;
          }
          case 88: {
            CurBuyCount = input.ReadUInt32();
            break;
          }
          case 104: {
            NextAddTimestamp = input.ReadUInt32();
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
          case 80: {
            CurValue = input.ReadUInt32();
            break;
          }
          case 88: {
            CurBuyCount = input.ReadUInt32();
            break;
          }
          case 104: {
            NextAddTimestamp = input.ReadUInt32();
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
