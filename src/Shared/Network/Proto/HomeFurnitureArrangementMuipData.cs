// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeFurnitureArrangementMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeFurnitureArrangementMuipData.proto</summary>
  public static partial class HomeFurnitureArrangementMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeFurnitureArrangementMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeFurnitureArrangementMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZIb21lRnVybml0dXJlQXJyYW5nZW1lbnRNdWlwRGF0YS5wcm90bxoMVmVj",
            "dG9yLnByb3RvInAKIEhvbWVGdXJuaXR1cmVBcnJhbmdlbWVudE11aXBEYXRh",
            "EhQKDGZ1cm5pdHVyZV9pZBgBIAEoDRIaCglzcGF3bl9wb3MYAiABKAsyBy5W",
            "ZWN0b3ISGgoJc3Bhd25fcm90GAMgASgLMgcuVmVjdG9yQiKqAh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeFurnitureArrangementMuipData), global::Weedwacker.Shared.Network.Proto.HomeFurnitureArrangementMuipData.Parser, new[]{ "FurnitureId", "SpawnPos", "SpawnRot" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeFurnitureArrangementMuipData : pb::IMessage<HomeFurnitureArrangementMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeFurnitureArrangementMuipData> _parser = new pb::MessageParser<HomeFurnitureArrangementMuipData>(() => new HomeFurnitureArrangementMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeFurnitureArrangementMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeFurnitureArrangementMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureArrangementMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureArrangementMuipData(HomeFurnitureArrangementMuipData other) : this() {
      furnitureId_ = other.furnitureId_;
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      spawnRot_ = other.spawnRot_ != null ? other.spawnRot_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureArrangementMuipData Clone() {
      return new HomeFurnitureArrangementMuipData(this);
    }

    /// <summary>Field number for the "furniture_id" field.</summary>
    public const int FurnitureIdFieldNumber = 1;
    private uint furnitureId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureId {
      get { return furnitureId_; }
      set {
        furnitureId_ = value;
      }
    }

    /// <summary>Field number for the "spawn_pos" field.</summary>
    public const int SpawnPosFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.Vector spawnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector SpawnPos {
      get { return spawnPos_; }
      set {
        spawnPos_ = value;
      }
    }

    /// <summary>Field number for the "spawn_rot" field.</summary>
    public const int SpawnRotFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.Vector spawnRot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector SpawnRot {
      get { return spawnRot_; }
      set {
        spawnRot_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeFurnitureArrangementMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeFurnitureArrangementMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FurnitureId != other.FurnitureId) return false;
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      if (!object.Equals(SpawnRot, other.SpawnRot)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FurnitureId != 0) hash ^= FurnitureId.GetHashCode();
      if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
      if (spawnRot_ != null) hash ^= SpawnRot.GetHashCode();
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
      if (FurnitureId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FurnitureId);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SpawnPos);
      }
      if (spawnRot_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpawnRot);
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
      if (FurnitureId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FurnitureId);
      }
      if (spawnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SpawnPos);
      }
      if (spawnRot_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpawnRot);
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
      if (FurnitureId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureId);
      }
      if (spawnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
      }
      if (spawnRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnRot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeFurnitureArrangementMuipData other) {
      if (other == null) {
        return;
      }
      if (other.FurnitureId != 0) {
        FurnitureId = other.FurnitureId;
      }
      if (other.spawnPos_ != null) {
        if (spawnPos_ == null) {
          SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        SpawnPos.MergeFrom(other.SpawnPos);
      }
      if (other.spawnRot_ != null) {
        if (spawnRot_ == null) {
          SpawnRot = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        SpawnRot.MergeFrom(other.SpawnRot);
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
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 26: {
            if (spawnRot_ == null) {
              SpawnRot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnRot);
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
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 18: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 26: {
            if (spawnRot_ == null) {
              SpawnRot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnRot);
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
