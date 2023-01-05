// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MistTrialLevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MistTrialLevelData.proto</summary>
  public static partial class MistTrialLevelDataReflection {

    #region Descriptor
    /// <summary>File descriptor for MistTrialLevelData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MistTrialLevelDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhNaXN0VHJpYWxMZXZlbERhdGEucHJvdG8aGU1pc3RUcmlhbEJlc3RBdmF0",
            "YXIucHJvdG8iwgEKEk1pc3RUcmlhbExldmVsRGF0YRIRCglvcGVuX3RpbWUY",
            "CiABKA0SLgoQYmVzdF9hdmF0YXJfbGlzdBgDIAMoCzIULk1pc3RUcmlhbEJl",
            "c3RBdmF0YXISEAoIbGV2ZWxfaWQYDiABKA0SFwoPZmlyc3RfcGFzc190aW1l",
            "GAEgASgNEi0KD2Jlc3RfaGl0X2F2YXRhchgLIAEoCzIULk1pc3RUcmlhbEJl",
            "c3RBdmF0YXISDwoHaXNfb3BlbhgJIAEoCEIiqgIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MistTrialLevelData), global::Weedwacker.Shared.Network.Proto.MistTrialLevelData.Parser, new[]{ "OpenTime", "BestAvatarList", "LevelId", "FirstPassTime", "BestHitAvatar", "IsOpen" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MistTrialLevelData : pb::IMessage<MistTrialLevelData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MistTrialLevelData> _parser = new pb::MessageParser<MistTrialLevelData>(() => new MistTrialLevelData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MistTrialLevelData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MistTrialLevelDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialLevelData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialLevelData(MistTrialLevelData other) : this() {
      openTime_ = other.openTime_;
      bestAvatarList_ = other.bestAvatarList_.Clone();
      levelId_ = other.levelId_;
      firstPassTime_ = other.firstPassTime_;
      bestHitAvatar_ = other.bestHitAvatar_ != null ? other.bestHitAvatar_.Clone() : null;
      isOpen_ = other.isOpen_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MistTrialLevelData Clone() {
      return new MistTrialLevelData(this);
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 10;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "best_avatar_list" field.</summary>
    public const int BestAvatarListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar> _repeated_bestAvatarList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar> bestAvatarList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar> BestAvatarList {
      get { return bestAvatarList_; }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 14;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "first_pass_time" field.</summary>
    public const int FirstPassTimeFieldNumber = 1;
    private uint firstPassTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FirstPassTime {
      get { return firstPassTime_; }
      set {
        firstPassTime_ = value;
      }
    }

    /// <summary>Field number for the "best_hit_avatar" field.</summary>
    public const int BestHitAvatarFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar bestHitAvatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar BestHitAvatar {
      get { return bestHitAvatar_; }
      set {
        bestHitAvatar_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 9;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MistTrialLevelData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MistTrialLevelData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpenTime != other.OpenTime) return false;
      if(!bestAvatarList_.Equals(other.bestAvatarList_)) return false;
      if (LevelId != other.LevelId) return false;
      if (FirstPassTime != other.FirstPassTime) return false;
      if (!object.Equals(BestHitAvatar, other.BestHitAvatar)) return false;
      if (IsOpen != other.IsOpen) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      hash ^= bestAvatarList_.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (FirstPassTime != 0) hash ^= FirstPassTime.GetHashCode();
      if (bestHitAvatar_ != null) hash ^= BestHitAvatar.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
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
      if (FirstPassTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FirstPassTime);
      }
      bestAvatarList_.WriteTo(output, _repeated_bestAvatarList_codec);
      if (IsOpen != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsOpen);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OpenTime);
      }
      if (bestHitAvatar_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BestHitAvatar);
      }
      if (LevelId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelId);
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
      if (FirstPassTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(FirstPassTime);
      }
      bestAvatarList_.WriteTo(ref output, _repeated_bestAvatarList_codec);
      if (IsOpen != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsOpen);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OpenTime);
      }
      if (bestHitAvatar_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(BestHitAvatar);
      }
      if (LevelId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelId);
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
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      size += bestAvatarList_.CalculateSize(_repeated_bestAvatarList_codec);
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (FirstPassTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FirstPassTime);
      }
      if (bestHitAvatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BestHitAvatar);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MistTrialLevelData other) {
      if (other == null) {
        return;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      bestAvatarList_.Add(other.bestAvatarList_);
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.FirstPassTime != 0) {
        FirstPassTime = other.FirstPassTime;
      }
      if (other.bestHitAvatar_ != null) {
        if (bestHitAvatar_ == null) {
          BestHitAvatar = new global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar();
        }
        BestHitAvatar.MergeFrom(other.BestHitAvatar);
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
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
            FirstPassTime = input.ReadUInt32();
            break;
          }
          case 26: {
            bestAvatarList_.AddEntriesFrom(input, _repeated_bestAvatarList_codec);
            break;
          }
          case 72: {
            IsOpen = input.ReadBool();
            break;
          }
          case 80: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 90: {
            if (bestHitAvatar_ == null) {
              BestHitAvatar = new global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar();
            }
            input.ReadMessage(BestHitAvatar);
            break;
          }
          case 112: {
            LevelId = input.ReadUInt32();
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
            FirstPassTime = input.ReadUInt32();
            break;
          }
          case 26: {
            bestAvatarList_.AddEntriesFrom(ref input, _repeated_bestAvatarList_codec);
            break;
          }
          case 72: {
            IsOpen = input.ReadBool();
            break;
          }
          case 80: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 90: {
            if (bestHitAvatar_ == null) {
              BestHitAvatar = new global::Weedwacker.Shared.Network.Proto.MistTrialBestAvatar();
            }
            input.ReadMessage(BestHitAvatar);
            break;
          }
          case 112: {
            LevelId = input.ReadUInt32();
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
