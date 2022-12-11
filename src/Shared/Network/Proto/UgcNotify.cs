// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UgcNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from UgcNotify.proto</summary>
  public static partial class UgcNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for UgcNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UgcNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9VZ2NOb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8iZAoJVWdjTm90aWZ5EhsKE1VuazMzMDBfSUJMRElOR0pKRkkYCCAB",
            "KAgSHQoVaXNfdWdjX2ZlYXR1cmVfY2xvc2VkGAYgASgIEhsKE1VuazMzMDBf",
            "S1BBQkpQTUxIQ0QYCSABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.UgcNotify), global::Weedwacker.Shared.Network.Proto.UgcNotify.Parser, new[]{ "Unk3300IBLDINGJJFI", "IsUgcFeatureClosed", "Unk3300KPABJPMLHCD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6308;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class UgcNotify : pb::IMessage<UgcNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UgcNotify> _parser = new pb::MessageParser<UgcNotify>(() => new UgcNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UgcNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.UgcNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcNotify(UgcNotify other) : this() {
      unk3300IBLDINGJJFI_ = other.unk3300IBLDINGJJFI_;
      isUgcFeatureClosed_ = other.isUgcFeatureClosed_;
      unk3300KPABJPMLHCD_ = other.unk3300KPABJPMLHCD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UgcNotify Clone() {
      return new UgcNotify(this);
    }

    /// <summary>Field number for the "Unk3300_IBLDINGJJFI" field.</summary>
    public const int Unk3300IBLDINGJJFIFieldNumber = 8;
    private bool unk3300IBLDINGJJFI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300IBLDINGJJFI {
      get { return unk3300IBLDINGJJFI_; }
      set {
        unk3300IBLDINGJJFI_ = value;
      }
    }

    /// <summary>Field number for the "is_ugc_feature_closed" field.</summary>
    public const int IsUgcFeatureClosedFieldNumber = 6;
    private bool isUgcFeatureClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUgcFeatureClosed {
      get { return isUgcFeatureClosed_; }
      set {
        isUgcFeatureClosed_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KPABJPMLHCD" field.</summary>
    public const int Unk3300KPABJPMLHCDFieldNumber = 9;
    private bool unk3300KPABJPMLHCD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300KPABJPMLHCD {
      get { return unk3300KPABJPMLHCD_; }
      set {
        unk3300KPABJPMLHCD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UgcNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UgcNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300IBLDINGJJFI != other.Unk3300IBLDINGJJFI) return false;
      if (IsUgcFeatureClosed != other.IsUgcFeatureClosed) return false;
      if (Unk3300KPABJPMLHCD != other.Unk3300KPABJPMLHCD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300IBLDINGJJFI != false) hash ^= Unk3300IBLDINGJJFI.GetHashCode();
      if (IsUgcFeatureClosed != false) hash ^= IsUgcFeatureClosed.GetHashCode();
      if (Unk3300KPABJPMLHCD != false) hash ^= Unk3300KPABJPMLHCD.GetHashCode();
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
      if (IsUgcFeatureClosed != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsUgcFeatureClosed);
      }
      if (Unk3300IBLDINGJJFI != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300IBLDINGJJFI);
      }
      if (Unk3300KPABJPMLHCD != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300KPABJPMLHCD);
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
      if (IsUgcFeatureClosed != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsUgcFeatureClosed);
      }
      if (Unk3300IBLDINGJJFI != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300IBLDINGJJFI);
      }
      if (Unk3300KPABJPMLHCD != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300KPABJPMLHCD);
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
      if (Unk3300IBLDINGJJFI != false) {
        size += 1 + 1;
      }
      if (IsUgcFeatureClosed != false) {
        size += 1 + 1;
      }
      if (Unk3300KPABJPMLHCD != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UgcNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300IBLDINGJJFI != false) {
        Unk3300IBLDINGJJFI = other.Unk3300IBLDINGJJFI;
      }
      if (other.IsUgcFeatureClosed != false) {
        IsUgcFeatureClosed = other.IsUgcFeatureClosed;
      }
      if (other.Unk3300KPABJPMLHCD != false) {
        Unk3300KPABJPMLHCD = other.Unk3300KPABJPMLHCD;
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
            IsUgcFeatureClosed = input.ReadBool();
            break;
          }
          case 64: {
            Unk3300IBLDINGJJFI = input.ReadBool();
            break;
          }
          case 72: {
            Unk3300KPABJPMLHCD = input.ReadBool();
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
            IsUgcFeatureClosed = input.ReadBool();
            break;
          }
          case 64: {
            Unk3300IBLDINGJJFI = input.ReadBool();
            break;
          }
          case 72: {
            Unk3300KPABJPMLHCD = input.ReadBool();
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
