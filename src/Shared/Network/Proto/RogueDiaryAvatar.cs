// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryAvatar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RogueDiaryAvatar.proto</summary>
  public static partial class RogueDiaryAvatarReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryAvatar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryAvatarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSb2d1ZURpYXJ5QXZhdGFyLnByb3RvGhtBY3Rpdml0eUR1bmdlb25BdmF0",
            "YXIucHJvdG8aI1JvZ3VlRGlhcnlBdmF0YXJEaXNhYmxlU3RhdHVzLnByb3Rv",
            "IpsBChBSb2d1ZURpYXJ5QXZhdGFyEg0KBWxldmVsGAogASgNEjsKE2Rpc2Fi",
            "bGVfc3RhdHVzX2xpc3QYByADKA4yHi5Sb2d1ZURpYXJ5QXZhdGFyRGlzYWJs",
            "ZVN0YXR1cxITCgt0aXJlZF9yb3VuZBgCIAEoDRImCgZhdmF0YXIYDiABKAsy",
            "Fi5BY3Rpdml0eUR1bmdlb25BdmF0YXJCIqoCH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ActivityDungeonAvatarReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarDisableStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar), global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatar.Parser, new[]{ "Level", "DisableStatusList", "TiredRound", "Avatar" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueDiaryAvatar : pb::IMessage<RogueDiaryAvatar>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryAvatar> _parser = new pb::MessageParser<RogueDiaryAvatar>(() => new RogueDiaryAvatar());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryAvatar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryAvatar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryAvatar(RogueDiaryAvatar other) : this() {
      level_ = other.level_;
      disableStatusList_ = other.disableStatusList_.Clone();
      tiredRound_ = other.tiredRound_;
      avatar_ = other.avatar_ != null ? other.avatar_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryAvatar Clone() {
      return new RogueDiaryAvatar(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 10;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "disable_status_list" field.</summary>
    public const int DisableStatusListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarDisableStatus> _repeated_disableStatusList_codec
        = pb::FieldCodec.ForEnum(58, x => (int) x, x => (global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarDisableStatus) x);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarDisableStatus> disableStatusList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarDisableStatus>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueDiaryAvatarDisableStatus> DisableStatusList {
      get { return disableStatusList_; }
    }

    /// <summary>Field number for the "tired_round" field.</summary>
    public const int TiredRoundFieldNumber = 2;
    private uint tiredRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TiredRound {
      get { return tiredRound_; }
      set {
        tiredRound_ = value;
      }
    }

    /// <summary>Field number for the "avatar" field.</summary>
    public const int AvatarFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.ActivityDungeonAvatar avatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ActivityDungeonAvatar Avatar {
      get { return avatar_; }
      set {
        avatar_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryAvatar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryAvatar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if(!disableStatusList_.Equals(other.disableStatusList_)) return false;
      if (TiredRound != other.TiredRound) return false;
      if (!object.Equals(Avatar, other.Avatar)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= disableStatusList_.GetHashCode();
      if (TiredRound != 0) hash ^= TiredRound.GetHashCode();
      if (avatar_ != null) hash ^= Avatar.GetHashCode();
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
      if (TiredRound != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TiredRound);
      }
      disableStatusList_.WriteTo(output, _repeated_disableStatusList_codec);
      if (Level != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Level);
      }
      if (avatar_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Avatar);
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
      if (TiredRound != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TiredRound);
      }
      disableStatusList_.WriteTo(ref output, _repeated_disableStatusList_codec);
      if (Level != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Level);
      }
      if (avatar_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Avatar);
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
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      size += disableStatusList_.CalculateSize(_repeated_disableStatusList_codec);
      if (TiredRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TiredRound);
      }
      if (avatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryAvatar other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      disableStatusList_.Add(other.disableStatusList_);
      if (other.TiredRound != 0) {
        TiredRound = other.TiredRound;
      }
      if (other.avatar_ != null) {
        if (avatar_ == null) {
          Avatar = new global::Weedwacker.Shared.Network.Proto.ActivityDungeonAvatar();
        }
        Avatar.MergeFrom(other.Avatar);
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
            TiredRound = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            disableStatusList_.AddEntriesFrom(input, _repeated_disableStatusList_codec);
            break;
          }
          case 80: {
            Level = input.ReadUInt32();
            break;
          }
          case 114: {
            if (avatar_ == null) {
              Avatar = new global::Weedwacker.Shared.Network.Proto.ActivityDungeonAvatar();
            }
            input.ReadMessage(Avatar);
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
            TiredRound = input.ReadUInt32();
            break;
          }
          case 58:
          case 56: {
            disableStatusList_.AddEntriesFrom(ref input, _repeated_disableStatusList_codec);
            break;
          }
          case 80: {
            Level = input.ReadUInt32();
            break;
          }
          case 114: {
            if (avatar_ == null) {
              Avatar = new global::Weedwacker.Shared.Network.Proto.ActivityDungeonAvatar();
            }
            input.ReadMessage(Avatar);
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
