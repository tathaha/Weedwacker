// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassRewardTag.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BattlePassRewardTag.proto</summary>
  public static partial class BattlePassRewardTagReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassRewardTag.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassRewardTagReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlCYXR0bGVQYXNzUmV3YXJkVGFnLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvGhxCYXR0bGVQYXNzVW5sb2NrU3RhdHVzLnByb3Rv",
            "IocBChNCYXR0bGVQYXNzUmV3YXJkVGFnEk4KDXVubG9ja19zdGF0dXMYCyAB",
            "KA4yNy5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkJhdHRsZVBh",
            "c3NVbmxvY2tTdGF0dXMSEQoJcmV3YXJkX2lkGAQgASgNEg0KBWxldmVsGAEg",
            "ASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BattlePassRewardTag), global::Weedwacker.Shared.Network.Proto.BattlePassRewardTag.Parser, new[]{ "UnlockStatus", "RewardId", "Level" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattlePassRewardTag : pb::IMessage<BattlePassRewardTag>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassRewardTag> _parser = new pb::MessageParser<BattlePassRewardTag>(() => new BattlePassRewardTag());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassRewardTag> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BattlePassRewardTagReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassRewardTag() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassRewardTag(BattlePassRewardTag other) : this() {
      unlockStatus_ = other.unlockStatus_;
      rewardId_ = other.rewardId_;
      level_ = other.level_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassRewardTag Clone() {
      return new BattlePassRewardTag(this);
    }

    /// <summary>Field number for the "unlock_status" field.</summary>
    public const int UnlockStatusFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus unlockStatus_ = global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus UnlockStatus {
      get { return unlockStatus_; }
      set {
        unlockStatus_ = value;
      }
    }

    /// <summary>Field number for the "reward_id" field.</summary>
    public const int RewardIdFieldNumber = 4;
    private uint rewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassRewardTag);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassRewardTag other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnlockStatus != other.UnlockStatus) return false;
      if (RewardId != other.RewardId) return false;
      if (Level != other.Level) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UnlockStatus != global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus.Invalid) hash ^= UnlockStatus.GetHashCode();
      if (RewardId != 0) hash ^= RewardId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
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
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (RewardId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(RewardId);
      }
      if (UnlockStatus != global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus.Invalid) {
        output.WriteRawTag(88);
        output.WriteEnum((int) UnlockStatus);
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
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (RewardId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(RewardId);
      }
      if (UnlockStatus != global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus.Invalid) {
        output.WriteRawTag(88);
        output.WriteEnum((int) UnlockStatus);
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
      if (UnlockStatus != global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UnlockStatus);
      }
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassRewardTag other) {
      if (other == null) {
        return;
      }
      if (other.UnlockStatus != global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus.Invalid) {
        UnlockStatus = other.UnlockStatus;
      }
      if (other.RewardId != 0) {
        RewardId = other.RewardId;
      }
      if (other.Level != 0) {
        Level = other.Level;
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
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 88: {
            UnlockStatus = (global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus) input.ReadEnum();
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
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 88: {
            UnlockStatus = (global::Weedwacker.Shared.Network.Proto.BattlePassUnlockStatus) input.ReadEnum();
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
