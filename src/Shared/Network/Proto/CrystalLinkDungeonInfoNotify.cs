// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CrystalLinkDungeonInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CrystalLinkDungeonInfoNotify.proto</summary>
  public static partial class CrystalLinkDungeonInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CrystalLinkDungeonInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrystalLinkDungeonInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJDcnlzdGFsTGlua0R1bmdlb25JbmZvTm90aWZ5LnByb3RvGhlDcnlzdGFs",
            "TGlua0J1ZmZJbmZvLnByb3RvGiJDcnlzdGFsTGlua0R1bmdlb25BdmF0YXJJ",
            "bmZvLnByb3RvIuwBChxDcnlzdGFsTGlua0R1bmdlb25JbmZvTm90aWZ5EiwK",
            "DmJ1ZmZfaW5mb19saXN0GAsgAygLMhQuQ3J5c3RhbExpbmtCdWZmSW5mbxIQ",
            "CghsZXZlbF9pZBgFIAEoDRIVCg1pc191cHBlcl9wYXJ0GA0gASgIEhUKDWRp",
            "ZmZpY3VsdHlfaWQYDiABKA0SPwoYZHVuZ2Vvbl9hdmF0YXJfaW5mb19saXN0",
            "GAwgAygLMh0uQ3J5c3RhbExpbmtEdW5nZW9uQXZhdGFySW5mbxIdChVpbml0",
            "X2dhbGxlcnlfcHJvZ3Jlc3MYBCABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonAvatarInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonInfoNotify), global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonInfoNotify.Parser, new[]{ "BuffInfoList", "LevelId", "IsUpperPart", "DifficultyId", "DungeonAvatarInfoList", "InitGalleryProgress" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8408;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class CrystalLinkDungeonInfoNotify : pb::IMessage<CrystalLinkDungeonInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CrystalLinkDungeonInfoNotify> _parser = new pb::MessageParser<CrystalLinkDungeonInfoNotify>(() => new CrystalLinkDungeonInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CrystalLinkDungeonInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkDungeonInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkDungeonInfoNotify(CrystalLinkDungeonInfoNotify other) : this() {
      buffInfoList_ = other.buffInfoList_.Clone();
      levelId_ = other.levelId_;
      isUpperPart_ = other.isUpperPart_;
      difficultyId_ = other.difficultyId_;
      dungeonAvatarInfoList_ = other.dungeonAvatarInfoList_.Clone();
      initGalleryProgress_ = other.initGalleryProgress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkDungeonInfoNotify Clone() {
      return new CrystalLinkDungeonInfoNotify(this);
    }

    /// <summary>Field number for the "buff_info_list" field.</summary>
    public const int BuffInfoListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo> _repeated_buffInfoList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo> buffInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo> BuffInfoList {
      get { return buffInfoList_; }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 5;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "is_upper_part" field.</summary>
    public const int IsUpperPartFieldNumber = 13;
    private bool isUpperPart_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUpperPart {
      get { return isUpperPart_; }
      set {
        isUpperPart_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 14;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_avatar_info_list" field.</summary>
    public const int DungeonAvatarInfoListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonAvatarInfo> _repeated_dungeonAvatarInfoList_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonAvatarInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonAvatarInfo> dungeonAvatarInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonAvatarInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonAvatarInfo> DungeonAvatarInfoList {
      get { return dungeonAvatarInfoList_; }
    }

    /// <summary>Field number for the "init_gallery_progress" field.</summary>
    public const int InitGalleryProgressFieldNumber = 4;
    private uint initGalleryProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InitGalleryProgress {
      get { return initGalleryProgress_; }
      set {
        initGalleryProgress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CrystalLinkDungeonInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CrystalLinkDungeonInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!buffInfoList_.Equals(other.buffInfoList_)) return false;
      if (LevelId != other.LevelId) return false;
      if (IsUpperPart != other.IsUpperPart) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if(!dungeonAvatarInfoList_.Equals(other.dungeonAvatarInfoList_)) return false;
      if (InitGalleryProgress != other.InitGalleryProgress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= buffInfoList_.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (IsUpperPart != false) hash ^= IsUpperPart.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      hash ^= dungeonAvatarInfoList_.GetHashCode();
      if (InitGalleryProgress != 0) hash ^= InitGalleryProgress.GetHashCode();
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
      if (InitGalleryProgress != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(InitGalleryProgress);
      }
      if (LevelId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LevelId);
      }
      buffInfoList_.WriteTo(output, _repeated_buffInfoList_codec);
      dungeonAvatarInfoList_.WriteTo(output, _repeated_dungeonAvatarInfoList_codec);
      if (IsUpperPart != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsUpperPart);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DifficultyId);
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
      if (InitGalleryProgress != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(InitGalleryProgress);
      }
      if (LevelId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LevelId);
      }
      buffInfoList_.WriteTo(ref output, _repeated_buffInfoList_codec);
      dungeonAvatarInfoList_.WriteTo(ref output, _repeated_dungeonAvatarInfoList_codec);
      if (IsUpperPart != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsUpperPart);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DifficultyId);
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
      size += buffInfoList_.CalculateSize(_repeated_buffInfoList_codec);
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (IsUpperPart != false) {
        size += 1 + 1;
      }
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      size += dungeonAvatarInfoList_.CalculateSize(_repeated_dungeonAvatarInfoList_codec);
      if (InitGalleryProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InitGalleryProgress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CrystalLinkDungeonInfoNotify other) {
      if (other == null) {
        return;
      }
      buffInfoList_.Add(other.buffInfoList_);
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.IsUpperPart != false) {
        IsUpperPart = other.IsUpperPart;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      dungeonAvatarInfoList_.Add(other.dungeonAvatarInfoList_);
      if (other.InitGalleryProgress != 0) {
        InitGalleryProgress = other.InitGalleryProgress;
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
          case 32: {
            InitGalleryProgress = input.ReadUInt32();
            break;
          }
          case 40: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 90: {
            buffInfoList_.AddEntriesFrom(input, _repeated_buffInfoList_codec);
            break;
          }
          case 98: {
            dungeonAvatarInfoList_.AddEntriesFrom(input, _repeated_dungeonAvatarInfoList_codec);
            break;
          }
          case 104: {
            IsUpperPart = input.ReadBool();
            break;
          }
          case 112: {
            DifficultyId = input.ReadUInt32();
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
          case 32: {
            InitGalleryProgress = input.ReadUInt32();
            break;
          }
          case 40: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 90: {
            buffInfoList_.AddEntriesFrom(ref input, _repeated_buffInfoList_codec);
            break;
          }
          case 98: {
            dungeonAvatarInfoList_.AddEntriesFrom(ref input, _repeated_dungeonAvatarInfoList_codec);
            break;
          }
          case 104: {
            IsUpperPart = input.ReadBool();
            break;
          }
          case 112: {
            DifficultyId = input.ReadUInt32();
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
