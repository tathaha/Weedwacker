// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBasicInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeBasicInfo.proto</summary>
  public static partial class HomeBasicInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBasicInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBasicInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNIb21lQmFzaWNJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvGhlIb21lTGltaXRlZFNob3BJbmZvLnByb3RvIvgBCg1Ib21l",
            "QmFzaWNJbmZvEgsKA2V4cBgDIAEoBBIWCg5ob21lX293bmVyX3VpZBgLIAEo",
            "DRIZChFjdXJfcm9vbV9zY2VuZV9pZBgOIAEoDRIXCg9vd25lcl9uaWNrX25h",
            "bWUYBiABKAkSFQoNY3VyX21vZHVsZV9pZBgEIAEoDRJPChFsaW1pdGVkX3No",
            "b3BfaW5mbxgNIAEoCzI0LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG8uSG9tZUxpbWl0ZWRTaG9wSW5mbxIXCg9pc19pbl9lZGl0X21vZGUYByAB",
            "KAgSDQoFbGV2ZWwYCSABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeLimitedShopInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeBasicInfo), global::Weedwacker.Shared.Network.Proto.HomeBasicInfo.Parser, new[]{ "Exp", "HomeOwnerUid", "CurRoomSceneId", "OwnerNickName", "CurModuleId", "LimitedShopInfo", "IsInEditMode", "Level" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBasicInfo : pb::IMessage<HomeBasicInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBasicInfo> _parser = new pb::MessageParser<HomeBasicInfo>(() => new HomeBasicInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBasicInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeBasicInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBasicInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBasicInfo(HomeBasicInfo other) : this() {
      exp_ = other.exp_;
      homeOwnerUid_ = other.homeOwnerUid_;
      curRoomSceneId_ = other.curRoomSceneId_;
      ownerNickName_ = other.ownerNickName_;
      curModuleId_ = other.curModuleId_;
      limitedShopInfo_ = other.limitedShopInfo_ != null ? other.limitedShopInfo_.Clone() : null;
      isInEditMode_ = other.isInEditMode_;
      level_ = other.level_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBasicInfo Clone() {
      return new HomeBasicInfo(this);
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 3;
    private ulong exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "home_owner_uid" field.</summary>
    public const int HomeOwnerUidFieldNumber = 11;
    private uint homeOwnerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HomeOwnerUid {
      get { return homeOwnerUid_; }
      set {
        homeOwnerUid_ = value;
      }
    }

    /// <summary>Field number for the "cur_room_scene_id" field.</summary>
    public const int CurRoomSceneIdFieldNumber = 14;
    private uint curRoomSceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurRoomSceneId {
      get { return curRoomSceneId_; }
      set {
        curRoomSceneId_ = value;
      }
    }

    /// <summary>Field number for the "owner_nick_name" field.</summary>
    public const int OwnerNickNameFieldNumber = 6;
    private string ownerNickName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OwnerNickName {
      get { return ownerNickName_; }
      set {
        ownerNickName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cur_module_id" field.</summary>
    public const int CurModuleIdFieldNumber = 4;
    private uint curModuleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurModuleId {
      get { return curModuleId_; }
      set {
        curModuleId_ = value;
      }
    }

    /// <summary>Field number for the "limited_shop_info" field.</summary>
    public const int LimitedShopInfoFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.HomeLimitedShopInfo limitedShopInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HomeLimitedShopInfo LimitedShopInfo {
      get { return limitedShopInfo_; }
      set {
        limitedShopInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_in_edit_mode" field.</summary>
    public const int IsInEditModeFieldNumber = 7;
    private bool isInEditMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInEditMode {
      get { return isInEditMode_; }
      set {
        isInEditMode_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 9;
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
      return Equals(other as HomeBasicInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBasicInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Exp != other.Exp) return false;
      if (HomeOwnerUid != other.HomeOwnerUid) return false;
      if (CurRoomSceneId != other.CurRoomSceneId) return false;
      if (OwnerNickName != other.OwnerNickName) return false;
      if (CurModuleId != other.CurModuleId) return false;
      if (!object.Equals(LimitedShopInfo, other.LimitedShopInfo)) return false;
      if (IsInEditMode != other.IsInEditMode) return false;
      if (Level != other.Level) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Exp != 0UL) hash ^= Exp.GetHashCode();
      if (HomeOwnerUid != 0) hash ^= HomeOwnerUid.GetHashCode();
      if (CurRoomSceneId != 0) hash ^= CurRoomSceneId.GetHashCode();
      if (OwnerNickName.Length != 0) hash ^= OwnerNickName.GetHashCode();
      if (CurModuleId != 0) hash ^= CurModuleId.GetHashCode();
      if (limitedShopInfo_ != null) hash ^= LimitedShopInfo.GetHashCode();
      if (IsInEditMode != false) hash ^= IsInEditMode.GetHashCode();
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
      if (Exp != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Exp);
      }
      if (CurModuleId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CurModuleId);
      }
      if (OwnerNickName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OwnerNickName);
      }
      if (IsInEditMode != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsInEditMode);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (HomeOwnerUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HomeOwnerUid);
      }
      if (limitedShopInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LimitedShopInfo);
      }
      if (CurRoomSceneId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurRoomSceneId);
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
      if (Exp != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Exp);
      }
      if (CurModuleId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CurModuleId);
      }
      if (OwnerNickName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(OwnerNickName);
      }
      if (IsInEditMode != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsInEditMode);
      }
      if (Level != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Level);
      }
      if (HomeOwnerUid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(HomeOwnerUid);
      }
      if (limitedShopInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LimitedShopInfo);
      }
      if (CurRoomSceneId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurRoomSceneId);
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
      if (Exp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Exp);
      }
      if (HomeOwnerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HomeOwnerUid);
      }
      if (CurRoomSceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurRoomSceneId);
      }
      if (OwnerNickName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerNickName);
      }
      if (CurModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurModuleId);
      }
      if (limitedShopInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LimitedShopInfo);
      }
      if (IsInEditMode != false) {
        size += 1 + 1;
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
    public void MergeFrom(HomeBasicInfo other) {
      if (other == null) {
        return;
      }
      if (other.Exp != 0UL) {
        Exp = other.Exp;
      }
      if (other.HomeOwnerUid != 0) {
        HomeOwnerUid = other.HomeOwnerUid;
      }
      if (other.CurRoomSceneId != 0) {
        CurRoomSceneId = other.CurRoomSceneId;
      }
      if (other.OwnerNickName.Length != 0) {
        OwnerNickName = other.OwnerNickName;
      }
      if (other.CurModuleId != 0) {
        CurModuleId = other.CurModuleId;
      }
      if (other.limitedShopInfo_ != null) {
        if (limitedShopInfo_ == null) {
          LimitedShopInfo = new global::Weedwacker.Shared.Network.Proto.HomeLimitedShopInfo();
        }
        LimitedShopInfo.MergeFrom(other.LimitedShopInfo);
      }
      if (other.IsInEditMode != false) {
        IsInEditMode = other.IsInEditMode;
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
          case 24: {
            Exp = input.ReadUInt64();
            break;
          }
          case 32: {
            CurModuleId = input.ReadUInt32();
            break;
          }
          case 50: {
            OwnerNickName = input.ReadString();
            break;
          }
          case 56: {
            IsInEditMode = input.ReadBool();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 88: {
            HomeOwnerUid = input.ReadUInt32();
            break;
          }
          case 106: {
            if (limitedShopInfo_ == null) {
              LimitedShopInfo = new global::Weedwacker.Shared.Network.Proto.HomeLimitedShopInfo();
            }
            input.ReadMessage(LimitedShopInfo);
            break;
          }
          case 112: {
            CurRoomSceneId = input.ReadUInt32();
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
          case 24: {
            Exp = input.ReadUInt64();
            break;
          }
          case 32: {
            CurModuleId = input.ReadUInt32();
            break;
          }
          case 50: {
            OwnerNickName = input.ReadString();
            break;
          }
          case 56: {
            IsInEditMode = input.ReadBool();
            break;
          }
          case 72: {
            Level = input.ReadUInt32();
            break;
          }
          case 88: {
            HomeOwnerUid = input.ReadUInt32();
            break;
          }
          case 106: {
            if (limitedShopInfo_ == null) {
              LimitedShopInfo = new global::Weedwacker.Shared.Network.Proto.HomeLimitedShopInfo();
            }
            input.ReadMessage(LimitedShopInfo);
            break;
          }
          case 112: {
            CurRoomSceneId = input.ReadUInt32();
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
