// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeTransferData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeTransferData.proto</summary>
  public static partial class HomeTransferDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeTransferData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeTransferDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZIb21lVHJhbnNmZXJEYXRhLnByb3RvGgxWZWN0b3IucHJvdG8iPAoQSG9t",
            "ZVRyYW5zZmVyRGF0YRIaCglzcGF3bl9wb3MYASABKAsyBy5WZWN0b3ISDAoE",
            "Z3VpZBgFIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeTransferData), global::Weedwacker.Shared.Network.Proto.HomeTransferData.Parser, new[]{ "SpawnPos", "Guid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeTransferData : pb::IMessage<HomeTransferData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeTransferData> _parser = new pb::MessageParser<HomeTransferData>(() => new HomeTransferData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeTransferData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeTransferDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeTransferData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeTransferData(HomeTransferData other) : this() {
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      guid_ = other.guid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeTransferData Clone() {
      return new HomeTransferData(this);
    }

    /// <summary>Field number for the "spawn_pos" field.</summary>
    public const int SpawnPosFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.Vector spawnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector SpawnPos {
      get { return spawnPos_; }
      set {
        spawnPos_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 5;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeTransferData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeTransferData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      if (Guid != other.Guid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
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
      if (spawnPos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SpawnPos);
      }
      if (Guid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Guid);
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
      if (spawnPos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SpawnPos);
      }
      if (Guid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Guid);
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
      if (spawnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeTransferData other) {
      if (other == null) {
        return;
      }
      if (other.spawnPos_ != null) {
        if (spawnPos_ == null) {
          SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        SpawnPos.MergeFrom(other.SpawnPos);
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
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
          case 10: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 40: {
            Guid = input.ReadUInt32();
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
          case 10: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 40: {
            Guid = input.ReadUInt32();
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
