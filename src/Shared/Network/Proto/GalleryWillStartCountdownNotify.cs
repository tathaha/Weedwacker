// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryWillStartCountdownNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GalleryWillStartCountdownNotify.proto</summary>
  public static partial class GalleryWillStartCountdownNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryWillStartCountdownNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryWillStartCountdownNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVHYWxsZXJ5V2lsbFN0YXJ0Q291bnRkb3duTm90aWZ5LnByb3RvGhhHYWxs",
            "ZXJ5U3RhcnRTb3VyY2UucHJvdG8iggEKH0dhbGxlcnlXaWxsU3RhcnRDb3Vu",
            "dGRvd25Ob3RpZnkSEgoKZ2FsbGVyeV9pZBgNIAEoDRIpCgxzdGFydF9zb3Vy",
            "Y2UYDiABKA4yEy5HYWxsZXJ5U3RhcnRTb3VyY2USEAoIZW5kX3RpbWUYDyAB",
            "KA0SDgoGaXNfZW5kGAYgASgIQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GalleryStartSourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GalleryWillStartCountdownNotify), global::Weedwacker.Shared.Network.Proto.GalleryWillStartCountdownNotify.Parser, new[]{ "GalleryId", "StartSource", "EndTime", "IsEnd" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5505;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GalleryWillStartCountdownNotify : pb::IMessage<GalleryWillStartCountdownNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GalleryWillStartCountdownNotify> _parser = new pb::MessageParser<GalleryWillStartCountdownNotify>(() => new GalleryWillStartCountdownNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GalleryWillStartCountdownNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GalleryWillStartCountdownNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryWillStartCountdownNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryWillStartCountdownNotify(GalleryWillStartCountdownNotify other) : this() {
      galleryId_ = other.galleryId_;
      startSource_ = other.startSource_;
      endTime_ = other.endTime_;
      isEnd_ = other.isEnd_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryWillStartCountdownNotify Clone() {
      return new GalleryWillStartCountdownNotify(this);
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 13;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "start_source" field.</summary>
    public const int StartSourceFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.GalleryStartSource startSource_ = global::Weedwacker.Shared.Network.Proto.GalleryStartSource.ByNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GalleryStartSource StartSource {
      get { return startSource_; }
      set {
        startSource_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 15;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "is_end" field.</summary>
    public const int IsEndFieldNumber = 6;
    private bool isEnd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEnd {
      get { return isEnd_; }
      set {
        isEnd_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GalleryWillStartCountdownNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GalleryWillStartCountdownNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GalleryId != other.GalleryId) return false;
      if (StartSource != other.StartSource) return false;
      if (EndTime != other.EndTime) return false;
      if (IsEnd != other.IsEnd) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (StartSource != global::Weedwacker.Shared.Network.Proto.GalleryStartSource.ByNone) hash ^= StartSource.GetHashCode();
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (IsEnd != false) hash ^= IsEnd.GetHashCode();
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
      if (IsEnd != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsEnd);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (StartSource != global::Weedwacker.Shared.Network.Proto.GalleryStartSource.ByNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) StartSource);
      }
      if (EndTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EndTime);
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
      if (IsEnd != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsEnd);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (StartSource != global::Weedwacker.Shared.Network.Proto.GalleryStartSource.ByNone) {
        output.WriteRawTag(112);
        output.WriteEnum((int) StartSource);
      }
      if (EndTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EndTime);
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
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (StartSource != global::Weedwacker.Shared.Network.Proto.GalleryStartSource.ByNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StartSource);
      }
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (IsEnd != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GalleryWillStartCountdownNotify other) {
      if (other == null) {
        return;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.StartSource != global::Weedwacker.Shared.Network.Proto.GalleryStartSource.ByNone) {
        StartSource = other.StartSource;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      if (other.IsEnd != false) {
        IsEnd = other.IsEnd;
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
          case 48: {
            IsEnd = input.ReadBool();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 112: {
            StartSource = (global::Weedwacker.Shared.Network.Proto.GalleryStartSource) input.ReadEnum();
            break;
          }
          case 120: {
            EndTime = input.ReadUInt32();
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
          case 48: {
            IsEnd = input.ReadBool();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 112: {
            StartSource = (global::Weedwacker.Shared.Network.Proto.GalleryStartSource) input.ReadEnum();
            break;
          }
          case 120: {
            EndTime = input.ReadUInt32();
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
