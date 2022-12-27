// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RoguelikeDungeonActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RoguelikeDungeonActivityDetailInfo.proto</summary>
  public static partial class RoguelikeDungeonActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RoguelikeDungeonActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoguelikeDungeonActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihSb2d1ZWxpa2VEdW5nZW9uQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGhRS",
            "b2d1ZVN0YWdlSW5mby5wcm90bxoeUm9ndWVsaWtlU2hpa2lnYW1pUmVjb3Jk",
            "LnByb3RvIuIBCiJSb2d1ZWxpa2VEdW5nZW9uQWN0aXZpdHlEZXRhaWxJbmZv",
            "EiMKCnN0YWdlX2xpc3QYDiADKAsyDy5Sb2d1ZVN0YWdlSW5mbxIaChJlcXVp",
            "cHBlZF9ydW5lX2xpc3QYCSADKA0SGgoSY29udGVudF9jbG9zZV90aW1lGAsg",
            "ASgNEhEKCXJ1bmVfbGlzdBgDIAMoDRIxCg5zaGlraWdhbWlfbGlzdBgEIAMo",
            "CzIZLlJvZ3VlbGlrZVNoaWtpZ2FtaVJlY29yZBIZChFpc19jb250ZW50X2Ns",
            "b3NlZBgFIAEoCEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.RogueStageInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.RoguelikeShikigamiRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonActivityDetailInfo.Parser, new[]{ "StageList", "EquippedRuneList", "ContentCloseTime", "RuneList", "ShikigamiList", "IsContentClosed" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RoguelikeDungeonActivityDetailInfo : pb::IMessage<RoguelikeDungeonActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RoguelikeDungeonActivityDetailInfo> _parser = new pb::MessageParser<RoguelikeDungeonActivityDetailInfo>(() => new RoguelikeDungeonActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RoguelikeDungeonActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RoguelikeDungeonActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeDungeonActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeDungeonActivityDetailInfo(RoguelikeDungeonActivityDetailInfo other) : this() {
      stageList_ = other.stageList_.Clone();
      equippedRuneList_ = other.equippedRuneList_.Clone();
      contentCloseTime_ = other.contentCloseTime_;
      runeList_ = other.runeList_.Clone();
      shikigamiList_ = other.shikigamiList_.Clone();
      isContentClosed_ = other.isContentClosed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RoguelikeDungeonActivityDetailInfo Clone() {
      return new RoguelikeDungeonActivityDetailInfo(this);
    }

    /// <summary>Field number for the "stage_list" field.</summary>
    public const int StageListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RogueStageInfo> _repeated_stageList_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Shared.Network.Proto.RogueStageInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueStageInfo> stageList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueStageInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RogueStageInfo> StageList {
      get { return stageList_; }
    }

    /// <summary>Field number for the "equipped_rune_list" field.</summary>
    public const int EquippedRuneListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_equippedRuneList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> equippedRuneList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EquippedRuneList {
      get { return equippedRuneList_; }
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 11;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "rune_list" field.</summary>
    public const int RuneListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_runeList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> runeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RuneList {
      get { return runeList_; }
    }

    /// <summary>Field number for the "shikigami_list" field.</summary>
    public const int ShikigamiListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.RoguelikeShikigamiRecord> _repeated_shikigamiList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.RoguelikeShikigamiRecord.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RoguelikeShikigamiRecord> shikigamiList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RoguelikeShikigamiRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.RoguelikeShikigamiRecord> ShikigamiList {
      get { return shikigamiList_; }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 5;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RoguelikeDungeonActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RoguelikeDungeonActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!stageList_.Equals(other.stageList_)) return false;
      if(!equippedRuneList_.Equals(other.equippedRuneList_)) return false;
      if (ContentCloseTime != other.ContentCloseTime) return false;
      if(!runeList_.Equals(other.runeList_)) return false;
      if(!shikigamiList_.Equals(other.shikigamiList_)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= stageList_.GetHashCode();
      hash ^= equippedRuneList_.GetHashCode();
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
      hash ^= runeList_.GetHashCode();
      hash ^= shikigamiList_.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
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
      runeList_.WriteTo(output, _repeated_runeList_codec);
      shikigamiList_.WriteTo(output, _repeated_shikigamiList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsContentClosed);
      }
      equippedRuneList_.WriteTo(output, _repeated_equippedRuneList_codec);
      if (ContentCloseTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ContentCloseTime);
      }
      stageList_.WriteTo(output, _repeated_stageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      runeList_.WriteTo(ref output, _repeated_runeList_codec);
      shikigamiList_.WriteTo(ref output, _repeated_shikigamiList_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsContentClosed);
      }
      equippedRuneList_.WriteTo(ref output, _repeated_equippedRuneList_codec);
      if (ContentCloseTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ContentCloseTime);
      }
      stageList_.WriteTo(ref output, _repeated_stageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += stageList_.CalculateSize(_repeated_stageList_codec);
      size += equippedRuneList_.CalculateSize(_repeated_equippedRuneList_codec);
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      size += runeList_.CalculateSize(_repeated_runeList_codec);
      size += shikigamiList_.CalculateSize(_repeated_shikigamiList_codec);
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RoguelikeDungeonActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      stageList_.Add(other.stageList_);
      equippedRuneList_.Add(other.equippedRuneList_);
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
      }
      runeList_.Add(other.runeList_);
      shikigamiList_.Add(other.shikigamiList_);
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
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
          case 26:
          case 24: {
            runeList_.AddEntriesFrom(input, _repeated_runeList_codec);
            break;
          }
          case 34: {
            shikigamiList_.AddEntriesFrom(input, _repeated_shikigamiList_codec);
            break;
          }
          case 40: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            equippedRuneList_.AddEntriesFrom(input, _repeated_equippedRuneList_codec);
            break;
          }
          case 88: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 114: {
            stageList_.AddEntriesFrom(input, _repeated_stageList_codec);
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
          case 26:
          case 24: {
            runeList_.AddEntriesFrom(ref input, _repeated_runeList_codec);
            break;
          }
          case 34: {
            shikigamiList_.AddEntriesFrom(ref input, _repeated_shikigamiList_codec);
            break;
          }
          case 40: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            equippedRuneList_.AddEntriesFrom(ref input, _repeated_equippedRuneList_codec);
            break;
          }
          case 88: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 114: {
            stageList_.AddEntriesFrom(ref input, _repeated_stageList_codec);
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
