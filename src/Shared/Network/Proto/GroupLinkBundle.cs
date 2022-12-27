// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupLinkBundle.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GroupLinkBundle.proto</summary>
  public static partial class GroupLinkBundleReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupLinkBundle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupLinkBundleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHcm91cExpbmtCdW5kbGUucHJvdG8aDFZlY3Rvci5wcm90byKLAQoPR3Jv",
            "dXBMaW5rQnVuZGxlEhEKCWJ1bmRsZV9pZBgBIAEoDRIXCgZjZW50ZXIYDCAB",
            "KAsyBy5WZWN0b3ISFAoMaXNfc2hvd19tYXJrGAsgASgIEhAKCHNjZW5lX2lk",
            "GAIgASgNEhQKDGlzX2FjdGl2YXRlZBgKIAEoCBIOCgZyYWRpdXMYBCABKA1C",
            "IqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GroupLinkBundle), global::Weedwacker.Shared.Network.Proto.GroupLinkBundle.Parser, new[]{ "BundleId", "Center", "IsShowMark", "SceneId", "IsActivated", "Radius" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroupLinkBundle : pb::IMessage<GroupLinkBundle>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GroupLinkBundle> _parser = new pb::MessageParser<GroupLinkBundle>(() => new GroupLinkBundle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GroupLinkBundle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GroupLinkBundleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupLinkBundle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupLinkBundle(GroupLinkBundle other) : this() {
      bundleId_ = other.bundleId_;
      center_ = other.center_ != null ? other.center_.Clone() : null;
      isShowMark_ = other.isShowMark_;
      sceneId_ = other.sceneId_;
      isActivated_ = other.isActivated_;
      radius_ = other.radius_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GroupLinkBundle Clone() {
      return new GroupLinkBundle(this);
    }

    /// <summary>Field number for the "bundle_id" field.</summary>
    public const int BundleIdFieldNumber = 1;
    private uint bundleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BundleId {
      get { return bundleId_; }
      set {
        bundleId_ = value;
      }
    }

    /// <summary>Field number for the "center" field.</summary>
    public const int CenterFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Vector center_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Center {
      get { return center_; }
      set {
        center_ = value;
      }
    }

    /// <summary>Field number for the "is_show_mark" field.</summary>
    public const int IsShowMarkFieldNumber = 11;
    private bool isShowMark_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsShowMark {
      get { return isShowMark_; }
      set {
        isShowMark_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "is_activated" field.</summary>
    public const int IsActivatedFieldNumber = 10;
    private bool isActivated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsActivated {
      get { return isActivated_; }
      set {
        isActivated_ = value;
      }
    }

    /// <summary>Field number for the "radius" field.</summary>
    public const int RadiusFieldNumber = 4;
    private uint radius_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Radius {
      get { return radius_; }
      set {
        radius_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GroupLinkBundle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GroupLinkBundle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BundleId != other.BundleId) return false;
      if (!object.Equals(Center, other.Center)) return false;
      if (IsShowMark != other.IsShowMark) return false;
      if (SceneId != other.SceneId) return false;
      if (IsActivated != other.IsActivated) return false;
      if (Radius != other.Radius) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BundleId != 0) hash ^= BundleId.GetHashCode();
      if (center_ != null) hash ^= Center.GetHashCode();
      if (IsShowMark != false) hash ^= IsShowMark.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (IsActivated != false) hash ^= IsActivated.GetHashCode();
      if (Radius != 0) hash ^= Radius.GetHashCode();
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
      if (BundleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BundleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (Radius != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Radius);
      }
      if (IsActivated != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsActivated);
      }
      if (IsShowMark != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsShowMark);
      }
      if (center_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Center);
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
      if (BundleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BundleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (Radius != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Radius);
      }
      if (IsActivated != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsActivated);
      }
      if (IsShowMark != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsShowMark);
      }
      if (center_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Center);
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
      if (BundleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BundleId);
      }
      if (center_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Center);
      }
      if (IsShowMark != false) {
        size += 1 + 1;
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (IsActivated != false) {
        size += 1 + 1;
      }
      if (Radius != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Radius);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GroupLinkBundle other) {
      if (other == null) {
        return;
      }
      if (other.BundleId != 0) {
        BundleId = other.BundleId;
      }
      if (other.center_ != null) {
        if (center_ == null) {
          Center = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Center.MergeFrom(other.Center);
      }
      if (other.IsShowMark != false) {
        IsShowMark = other.IsShowMark;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.IsActivated != false) {
        IsActivated = other.IsActivated;
      }
      if (other.Radius != 0) {
        Radius = other.Radius;
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
            BundleId = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 32: {
            Radius = input.ReadUInt32();
            break;
          }
          case 80: {
            IsActivated = input.ReadBool();
            break;
          }
          case 88: {
            IsShowMark = input.ReadBool();
            break;
          }
          case 98: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
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
            BundleId = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 32: {
            Radius = input.ReadUInt32();
            break;
          }
          case 80: {
            IsActivated = input.ReadBool();
            break;
          }
          case 88: {
            IsShowMark = input.ReadBool();
            break;
          }
          case 98: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
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
