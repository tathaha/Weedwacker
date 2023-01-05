// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterScenePeerNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EnterScenePeerNotify.proto</summary>
  public static partial class EnterScenePeerNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterScenePeerNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterScenePeerNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFbnRlclNjZW5lUGVlck5vdGlmeS5wcm90byJvChRFbnRlclNjZW5lUGVl",
            "ck5vdGlmeRIZChFlbnRlcl9zY2VuZV90b2tlbhgHIAEoDRIUCgxob3N0X3Bl",
            "ZXJfaWQYDCABKA0SDwoHcGVlcl9pZBgOIAEoDRIVCg1kZXN0X3NjZW5lX2lk",
            "GAIgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EnterScenePeerNotify), global::Weedwacker.Shared.Network.Proto.EnterScenePeerNotify.Parser, new[]{ "EnterSceneToken", "HostPeerId", "PeerId", "DestSceneId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 271;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class EnterScenePeerNotify : pb::IMessage<EnterScenePeerNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterScenePeerNotify> _parser = new pb::MessageParser<EnterScenePeerNotify>(() => new EnterScenePeerNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterScenePeerNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EnterScenePeerNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterScenePeerNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterScenePeerNotify(EnterScenePeerNotify other) : this() {
      enterSceneToken_ = other.enterSceneToken_;
      hostPeerId_ = other.hostPeerId_;
      peerId_ = other.peerId_;
      destSceneId_ = other.destSceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterScenePeerNotify Clone() {
      return new EnterScenePeerNotify(this);
    }

    /// <summary>Field number for the "enter_scene_token" field.</summary>
    public const int EnterSceneTokenFieldNumber = 7;
    private uint enterSceneToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterSceneToken {
      get { return enterSceneToken_; }
      set {
        enterSceneToken_ = value;
      }
    }

    /// <summary>Field number for the "host_peer_id" field.</summary>
    public const int HostPeerIdFieldNumber = 12;
    private uint hostPeerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HostPeerId {
      get { return hostPeerId_; }
      set {
        hostPeerId_ = value;
      }
    }

    /// <summary>Field number for the "peer_id" field.</summary>
    public const int PeerIdFieldNumber = 14;
    private uint peerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PeerId {
      get { return peerId_; }
      set {
        peerId_ = value;
      }
    }

    /// <summary>Field number for the "dest_scene_id" field.</summary>
    public const int DestSceneIdFieldNumber = 2;
    private uint destSceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DestSceneId {
      get { return destSceneId_; }
      set {
        destSceneId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterScenePeerNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterScenePeerNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnterSceneToken != other.EnterSceneToken) return false;
      if (HostPeerId != other.HostPeerId) return false;
      if (PeerId != other.PeerId) return false;
      if (DestSceneId != other.DestSceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EnterSceneToken != 0) hash ^= EnterSceneToken.GetHashCode();
      if (HostPeerId != 0) hash ^= HostPeerId.GetHashCode();
      if (PeerId != 0) hash ^= PeerId.GetHashCode();
      if (DestSceneId != 0) hash ^= DestSceneId.GetHashCode();
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
      if (DestSceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DestSceneId);
      }
      if (EnterSceneToken != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterSceneToken);
      }
      if (HostPeerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HostPeerId);
      }
      if (PeerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PeerId);
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
      if (DestSceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DestSceneId);
      }
      if (EnterSceneToken != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EnterSceneToken);
      }
      if (HostPeerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HostPeerId);
      }
      if (PeerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PeerId);
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
      if (EnterSceneToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterSceneToken);
      }
      if (HostPeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HostPeerId);
      }
      if (PeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PeerId);
      }
      if (DestSceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DestSceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterScenePeerNotify other) {
      if (other == null) {
        return;
      }
      if (other.EnterSceneToken != 0) {
        EnterSceneToken = other.EnterSceneToken;
      }
      if (other.HostPeerId != 0) {
        HostPeerId = other.HostPeerId;
      }
      if (other.PeerId != 0) {
        PeerId = other.PeerId;
      }
      if (other.DestSceneId != 0) {
        DestSceneId = other.DestSceneId;
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
            DestSceneId = input.ReadUInt32();
            break;
          }
          case 56: {
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 96: {
            HostPeerId = input.ReadUInt32();
            break;
          }
          case 112: {
            PeerId = input.ReadUInt32();
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
            DestSceneId = input.ReadUInt32();
            break;
          }
          case 56: {
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 96: {
            HostPeerId = input.ReadUInt32();
            break;
          }
          case 112: {
            PeerId = input.ReadUInt32();
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
