// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeAvatarRewardEventInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeAvatarRewardEventInfo.proto</summary>
  public static partial class HomeAvatarRewardEventInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeAvatarRewardEventInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeAvatarRewardEventInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Ib21lQXZhdGFyUmV3YXJkRXZlbnRJbmZvLnByb3RvInkKGUhvbWVBdmF0",
            "YXJSZXdhcmRFdmVudEluZm8SFwoPcmFuZG9tX3Bvc2l0aW9uGAkgASgNEhAK",
            "CHN1aXRlX2lkGAsgASgNEgwKBGd1aWQYBiABKA0SEAoIZXZlbnRfaWQYBSAB",
            "KA0SEQoJYXZhdGFyX2lkGAcgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeAvatarRewardEventInfo), global::Weedwacker.Shared.Network.Proto.HomeAvatarRewardEventInfo.Parser, new[]{ "RandomPosition", "SuiteId", "Guid", "EventId", "AvatarId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeAvatarRewardEventInfo : pb::IMessage<HomeAvatarRewardEventInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeAvatarRewardEventInfo> _parser = new pb::MessageParser<HomeAvatarRewardEventInfo>(() => new HomeAvatarRewardEventInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeAvatarRewardEventInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeAvatarRewardEventInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarRewardEventInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarRewardEventInfo(HomeAvatarRewardEventInfo other) : this() {
      randomPosition_ = other.randomPosition_;
      suiteId_ = other.suiteId_;
      guid_ = other.guid_;
      eventId_ = other.eventId_;
      avatarId_ = other.avatarId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeAvatarRewardEventInfo Clone() {
      return new HomeAvatarRewardEventInfo(this);
    }

    /// <summary>Field number for the "random_position" field.</summary>
    public const int RandomPositionFieldNumber = 9;
    private uint randomPosition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RandomPosition {
      get { return randomPosition_; }
      set {
        randomPosition_ = value;
      }
    }

    /// <summary>Field number for the "suite_id" field.</summary>
    public const int SuiteIdFieldNumber = 11;
    private uint suiteId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SuiteId {
      get { return suiteId_; }
      set {
        suiteId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 6;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 5;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 7;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeAvatarRewardEventInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeAvatarRewardEventInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RandomPosition != other.RandomPosition) return false;
      if (SuiteId != other.SuiteId) return false;
      if (Guid != other.Guid) return false;
      if (EventId != other.EventId) return false;
      if (AvatarId != other.AvatarId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RandomPosition != 0) hash ^= RandomPosition.GetHashCode();
      if (SuiteId != 0) hash ^= SuiteId.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
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
      if (EventId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EventId);
      }
      if (Guid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Guid);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AvatarId);
      }
      if (RandomPosition != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RandomPosition);
      }
      if (SuiteId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SuiteId);
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
      if (EventId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(EventId);
      }
      if (Guid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Guid);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AvatarId);
      }
      if (RandomPosition != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(RandomPosition);
      }
      if (SuiteId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SuiteId);
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
      if (RandomPosition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RandomPosition);
      }
      if (SuiteId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SuiteId);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeAvatarRewardEventInfo other) {
      if (other == null) {
        return;
      }
      if (other.RandomPosition != 0) {
        RandomPosition = other.RandomPosition;
      }
      if (other.SuiteId != 0) {
        SuiteId = other.SuiteId;
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
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
            EventId = input.ReadUInt32();
            break;
          }
          case 48: {
            Guid = input.ReadUInt32();
            break;
          }
          case 56: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 72: {
            RandomPosition = input.ReadUInt32();
            break;
          }
          case 88: {
            SuiteId = input.ReadUInt32();
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
            EventId = input.ReadUInt32();
            break;
          }
          case 48: {
            Guid = input.ReadUInt32();
            break;
          }
          case 56: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 72: {
            RandomPosition = input.ReadUInt32();
            break;
          }
          case 88: {
            SuiteId = input.ReadUInt32();
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
