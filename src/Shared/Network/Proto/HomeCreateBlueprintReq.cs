// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeCreateBlueprintReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeCreateBlueprintReq.proto</summary>
  public static partial class HomeCreateBlueprintReqReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeCreateBlueprintReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeCreateBlueprintReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxIb21lQ3JlYXRlQmx1ZXByaW50UmVxLnByb3RvGh5Ib21lU2NlbmVBcnJh",
            "bmdlbWVudEluZm8ucHJvdG8inQEKFkhvbWVDcmVhdGVCbHVlcHJpbnRSZXES",
            "OQoWc2NlbmVfYXJyYW5nZW1lbnRfaW5mbxgEIAEoCzIZLkhvbWVTY2VuZUFy",
            "cmFuZ2VtZW50SW5mbxIcChRnZW5fc2hhcmVfY29kZV9jb3VudBgJIAEoDRIZ",
            "ChFzZXJ2ZXJfc2hhcmVfY29kZRgFIAEoCRIPCgdzbG90X2lkGA8gASgNQiKq",
            "Ah9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeCreateBlueprintReq), global::Weedwacker.Shared.Network.Proto.HomeCreateBlueprintReq.Parser, new[]{ "SceneArrangementInfo", "GenShareCodeCount", "ServerShareCode", "SlotId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4539;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class HomeCreateBlueprintReq : pb::IMessage<HomeCreateBlueprintReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeCreateBlueprintReq> _parser = new pb::MessageParser<HomeCreateBlueprintReq>(() => new HomeCreateBlueprintReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeCreateBlueprintReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeCreateBlueprintReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCreateBlueprintReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCreateBlueprintReq(HomeCreateBlueprintReq other) : this() {
      sceneArrangementInfo_ = other.sceneArrangementInfo_ != null ? other.sceneArrangementInfo_.Clone() : null;
      genShareCodeCount_ = other.genShareCodeCount_;
      serverShareCode_ = other.serverShareCode_;
      slotId_ = other.slotId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeCreateBlueprintReq Clone() {
      return new HomeCreateBlueprintReq(this);
    }

    /// <summary>Field number for the "scene_arrangement_info" field.</summary>
    public const int SceneArrangementInfoFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfo sceneArrangementInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfo SceneArrangementInfo {
      get { return sceneArrangementInfo_; }
      set {
        sceneArrangementInfo_ = value;
      }
    }

    /// <summary>Field number for the "gen_share_code_count" field.</summary>
    public const int GenShareCodeCountFieldNumber = 9;
    private uint genShareCodeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GenShareCodeCount {
      get { return genShareCodeCount_; }
      set {
        genShareCodeCount_ = value;
      }
    }

    /// <summary>Field number for the "server_share_code" field.</summary>
    public const int ServerShareCodeFieldNumber = 5;
    private string serverShareCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServerShareCode {
      get { return serverShareCode_; }
      set {
        serverShareCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "slot_id" field.</summary>
    public const int SlotIdFieldNumber = 15;
    private uint slotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SlotId {
      get { return slotId_; }
      set {
        slotId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeCreateBlueprintReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeCreateBlueprintReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SceneArrangementInfo, other.SceneArrangementInfo)) return false;
      if (GenShareCodeCount != other.GenShareCodeCount) return false;
      if (ServerShareCode != other.ServerShareCode) return false;
      if (SlotId != other.SlotId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (sceneArrangementInfo_ != null) hash ^= SceneArrangementInfo.GetHashCode();
      if (GenShareCodeCount != 0) hash ^= GenShareCodeCount.GetHashCode();
      if (ServerShareCode.Length != 0) hash ^= ServerShareCode.GetHashCode();
      if (SlotId != 0) hash ^= SlotId.GetHashCode();
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
      if (sceneArrangementInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SceneArrangementInfo);
      }
      if (ServerShareCode.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ServerShareCode);
      }
      if (GenShareCodeCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GenShareCodeCount);
      }
      if (SlotId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SlotId);
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
      if (sceneArrangementInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SceneArrangementInfo);
      }
      if (ServerShareCode.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ServerShareCode);
      }
      if (GenShareCodeCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(GenShareCodeCount);
      }
      if (SlotId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SlotId);
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
      if (sceneArrangementInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SceneArrangementInfo);
      }
      if (GenShareCodeCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GenShareCodeCount);
      }
      if (ServerShareCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerShareCode);
      }
      if (SlotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SlotId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeCreateBlueprintReq other) {
      if (other == null) {
        return;
      }
      if (other.sceneArrangementInfo_ != null) {
        if (sceneArrangementInfo_ == null) {
          SceneArrangementInfo = new global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfo();
        }
        SceneArrangementInfo.MergeFrom(other.SceneArrangementInfo);
      }
      if (other.GenShareCodeCount != 0) {
        GenShareCodeCount = other.GenShareCodeCount;
      }
      if (other.ServerShareCode.Length != 0) {
        ServerShareCode = other.ServerShareCode;
      }
      if (other.SlotId != 0) {
        SlotId = other.SlotId;
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
          case 34: {
            if (sceneArrangementInfo_ == null) {
              SceneArrangementInfo = new global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfo();
            }
            input.ReadMessage(SceneArrangementInfo);
            break;
          }
          case 42: {
            ServerShareCode = input.ReadString();
            break;
          }
          case 72: {
            GenShareCodeCount = input.ReadUInt32();
            break;
          }
          case 120: {
            SlotId = input.ReadUInt32();
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
          case 34: {
            if (sceneArrangementInfo_ == null) {
              SceneArrangementInfo = new global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementInfo();
            }
            input.ReadMessage(SceneArrangementInfo);
            break;
          }
          case 42: {
            ServerShareCode = input.ReadString();
            break;
          }
          case 72: {
            GenShareCodeCount = input.ReadUInt32();
            break;
          }
          case 120: {
            SlotId = input.ReadUInt32();
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
