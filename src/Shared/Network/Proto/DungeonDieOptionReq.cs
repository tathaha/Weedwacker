// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonDieOptionReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DungeonDieOptionReq.proto</summary>
  public static partial class DungeonDieOptionReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonDieOptionReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonDieOptionReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlEdW5nZW9uRGllT3B0aW9uUmVxLnByb3RvGhVQbGF5ZXJEaWVPcHRpb24u",
            "cHJvdG8iWAoTRHVuZ2VvbkRpZU9wdGlvblJlcRIkCgpkaWVfb3B0aW9uGAUg",
            "ASgOMhAuUGxheWVyRGllT3B0aW9uEhsKE2lzX3F1aXRfaW1tZWRpYXRlbHkY",
            "DiABKAhCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.PlayerDieOptionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DungeonDieOptionReq), global::Weedwacker.Shared.Network.Proto.DungeonDieOptionReq.Parser, new[]{ "DieOption", "IsQuitImmediately" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 939;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class DungeonDieOptionReq : pb::IMessage<DungeonDieOptionReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonDieOptionReq> _parser = new pb::MessageParser<DungeonDieOptionReq>(() => new DungeonDieOptionReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonDieOptionReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DungeonDieOptionReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonDieOptionReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonDieOptionReq(DungeonDieOptionReq other) : this() {
      dieOption_ = other.dieOption_;
      isQuitImmediately_ = other.isQuitImmediately_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonDieOptionReq Clone() {
      return new DungeonDieOptionReq(this);
    }

    /// <summary>Field number for the "die_option" field.</summary>
    public const int DieOptionFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.PlayerDieOption dieOption_ = global::Weedwacker.Shared.Network.Proto.PlayerDieOption.OptNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PlayerDieOption DieOption {
      get { return dieOption_; }
      set {
        dieOption_ = value;
      }
    }

    /// <summary>Field number for the "is_quit_immediately" field.</summary>
    public const int IsQuitImmediatelyFieldNumber = 14;
    private bool isQuitImmediately_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsQuitImmediately {
      get { return isQuitImmediately_; }
      set {
        isQuitImmediately_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonDieOptionReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonDieOptionReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DieOption != other.DieOption) return false;
      if (IsQuitImmediately != other.IsQuitImmediately) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DieOption != global::Weedwacker.Shared.Network.Proto.PlayerDieOption.OptNone) hash ^= DieOption.GetHashCode();
      if (IsQuitImmediately != false) hash ^= IsQuitImmediately.GetHashCode();
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
      if (DieOption != global::Weedwacker.Shared.Network.Proto.PlayerDieOption.OptNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DieOption);
      }
      if (IsQuitImmediately != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsQuitImmediately);
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
      if (DieOption != global::Weedwacker.Shared.Network.Proto.PlayerDieOption.OptNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DieOption);
      }
      if (IsQuitImmediately != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsQuitImmediately);
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
      if (DieOption != global::Weedwacker.Shared.Network.Proto.PlayerDieOption.OptNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DieOption);
      }
      if (IsQuitImmediately != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonDieOptionReq other) {
      if (other == null) {
        return;
      }
      if (other.DieOption != global::Weedwacker.Shared.Network.Proto.PlayerDieOption.OptNone) {
        DieOption = other.DieOption;
      }
      if (other.IsQuitImmediately != false) {
        IsQuitImmediately = other.IsQuitImmediately;
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
            DieOption = (global::Weedwacker.Shared.Network.Proto.PlayerDieOption) input.ReadEnum();
            break;
          }
          case 112: {
            IsQuitImmediately = input.ReadBool();
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
            DieOption = (global::Weedwacker.Shared.Network.Proto.PlayerDieOption) input.ReadEnum();
            break;
          }
          case 112: {
            IsQuitImmediately = input.ReadBool();
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
