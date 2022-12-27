// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RacingGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RacingGallerySettleInfo.proto</summary>
  public static partial class RacingGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RacingGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RacingGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1SYWNpbmdHYWxsZXJ5U2V0dGxlSW5mby5wcm90bxoXR2FsbGVyeVN0b3BS",
            "ZWFzb24ucHJvdG8iYwoXUmFjaW5nR2FsbGVyeVNldHRsZUluZm8SEgoKd2lu",
            "bmVyX3VpZBgKIAEoDRIQCgh1c2VfdGltZRgPIAEoDRIiCgZyZWFzb24YCyAB",
            "KA4yEi5HYWxsZXJ5U3RvcFJlYXNvbkIiqgIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GalleryStopReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfo), global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfo.Parser, new[]{ "WinnerUid", "UseTime", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RacingGallerySettleInfo : pb::IMessage<RacingGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RacingGallerySettleInfo> _parser = new pb::MessageParser<RacingGallerySettleInfo>(() => new RacingGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RacingGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RacingGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RacingGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RacingGallerySettleInfo(RacingGallerySettleInfo other) : this() {
      winnerUid_ = other.winnerUid_;
      useTime_ = other.useTime_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RacingGallerySettleInfo Clone() {
      return new RacingGallerySettleInfo(this);
    }

    /// <summary>Field number for the "winner_uid" field.</summary>
    public const int WinnerUidFieldNumber = 10;
    private uint winnerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WinnerUid {
      get { return winnerUid_; }
      set {
        winnerUid_ = value;
      }
    }

    /// <summary>Field number for the "use_time" field.</summary>
    public const int UseTimeFieldNumber = 15;
    private uint useTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UseTime {
      get { return useTime_; }
      set {
        useTime_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.GalleryStopReason reason_ = global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GalleryStopReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RacingGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RacingGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WinnerUid != other.WinnerUid) return false;
      if (UseTime != other.UseTime) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WinnerUid != 0) hash ^= WinnerUid.GetHashCode();
      if (UseTime != 0) hash ^= UseTime.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) hash ^= Reason.GetHashCode();
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
      if (WinnerUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(WinnerUid);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (UseTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(UseTime);
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
      if (WinnerUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(WinnerUid);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Reason);
      }
      if (UseTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(UseTime);
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
      if (WinnerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WinnerUid);
      }
      if (UseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UseTime);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RacingGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.WinnerUid != 0) {
        WinnerUid = other.WinnerUid;
      }
      if (other.UseTime != 0) {
        UseTime = other.UseTime;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GalleryStopReason.None) {
        Reason = other.Reason;
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
            WinnerUid = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GalleryStopReason) input.ReadEnum();
            break;
          }
          case 120: {
            UseTime = input.ReadUInt32();
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
            WinnerUid = input.ReadUInt32();
            break;
          }
          case 88: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GalleryStopReason) input.ReadEnum();
            break;
          }
          case 120: {
            UseTime = input.ReadUInt32();
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
