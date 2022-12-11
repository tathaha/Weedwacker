// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlessingActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BlessingActivityDetailInfo.proto</summary>
  public static partial class BlessingActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BlessingActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlessingActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBCbGVzc2luZ0FjdGl2aXR5RGV0YWlsSW5mby5wcm90bxIfV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90byLrAgoaQmxlc3NpbmdBY3Rpdml0eURl",
            "dGFpbEluZm8SGAoQY3VyX2RheV9zY2FuX251bRgKIAEoDRIaChJjb250ZW50",
            "X2Nsb3NlX3RpbWUYCCABKA0SGwoTVW5rMzMwMF9KTEFESEVLSlBCUBgBIAEo",
            "DRIZChFuZXh0X3JlZnJlc2hfdGltZRgGIAEoDRIUCgxpc19hY3RpdmF0ZWQY",
            "BSABKAgSGwoTVW5rMzMwMF9JTk9ITEVMQk9BTRgHIAEoDRIZChFpc19jb250",
            "ZW50X2Nsb3NlZBgCIAEoCBJfCgtwaWNfbnVtX21hcBgLIAMoCzJKLldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uQmxlc3NpbmdBY3Rpdml0eURl",
            "dGFpbEluZm8uUGljTnVtTWFwRW50cnkaMAoOUGljTnVtTWFwRW50cnkSCwoD",
            "a2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BlessingActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.BlessingActivityDetailInfo.Parser, new[]{ "CurDayScanNum", "ContentCloseTime", "Unk3300JLADHEKJPBP", "NextRefreshTime", "IsActivated", "Unk3300INOHLELBOAM", "IsContentClosed", "PicNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BlessingActivityDetailInfo : pb::IMessage<BlessingActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlessingActivityDetailInfo> _parser = new pb::MessageParser<BlessingActivityDetailInfo>(() => new BlessingActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlessingActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BlessingActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingActivityDetailInfo(BlessingActivityDetailInfo other) : this() {
      curDayScanNum_ = other.curDayScanNum_;
      contentCloseTime_ = other.contentCloseTime_;
      unk3300JLADHEKJPBP_ = other.unk3300JLADHEKJPBP_;
      nextRefreshTime_ = other.nextRefreshTime_;
      isActivated_ = other.isActivated_;
      unk3300INOHLELBOAM_ = other.unk3300INOHLELBOAM_;
      isContentClosed_ = other.isContentClosed_;
      picNumMap_ = other.picNumMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingActivityDetailInfo Clone() {
      return new BlessingActivityDetailInfo(this);
    }

    /// <summary>Field number for the "cur_day_scan_num" field.</summary>
    public const int CurDayScanNumFieldNumber = 10;
    private uint curDayScanNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurDayScanNum {
      get { return curDayScanNum_; }
      set {
        curDayScanNum_ = value;
      }
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 8;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JLADHEKJPBP" field.</summary>
    public const int Unk3300JLADHEKJPBPFieldNumber = 1;
    private uint unk3300JLADHEKJPBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300JLADHEKJPBP {
      get { return unk3300JLADHEKJPBP_; }
      set {
        unk3300JLADHEKJPBP_ = value;
      }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 6;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "is_activated" field.</summary>
    public const int IsActivatedFieldNumber = 5;
    private bool isActivated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsActivated {
      get { return isActivated_; }
      set {
        isActivated_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_INOHLELBOAM" field.</summary>
    public const int Unk3300INOHLELBOAMFieldNumber = 7;
    private uint unk3300INOHLELBOAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300INOHLELBOAM {
      get { return unk3300INOHLELBOAM_; }
      set {
        unk3300INOHLELBOAM_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 2;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "pic_num_map" field.</summary>
    public const int PicNumMapFieldNumber = 11;
    private static readonly pbc::MapField<uint, uint>.Codec _map_picNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 90);
    private readonly pbc::MapField<uint, uint> picNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> PicNumMap {
      get { return picNumMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlessingActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlessingActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurDayScanNum != other.CurDayScanNum) return false;
      if (ContentCloseTime != other.ContentCloseTime) return false;
      if (Unk3300JLADHEKJPBP != other.Unk3300JLADHEKJPBP) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if (IsActivated != other.IsActivated) return false;
      if (Unk3300INOHLELBOAM != other.Unk3300INOHLELBOAM) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (!PicNumMap.Equals(other.PicNumMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurDayScanNum != 0) hash ^= CurDayScanNum.GetHashCode();
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
      if (Unk3300JLADHEKJPBP != 0) hash ^= Unk3300JLADHEKJPBP.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      if (IsActivated != false) hash ^= IsActivated.GetHashCode();
      if (Unk3300INOHLELBOAM != 0) hash ^= Unk3300INOHLELBOAM.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      hash ^= PicNumMap.GetHashCode();
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
      if (Unk3300JLADHEKJPBP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300JLADHEKJPBP);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsContentClosed);
      }
      if (IsActivated != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsActivated);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextRefreshTime);
      }
      if (Unk3300INOHLELBOAM != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300INOHLELBOAM);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ContentCloseTime);
      }
      if (CurDayScanNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurDayScanNum);
      }
      picNumMap_.WriteTo(output, _map_picNumMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk3300JLADHEKJPBP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300JLADHEKJPBP);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsContentClosed);
      }
      if (IsActivated != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsActivated);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(NextRefreshTime);
      }
      if (Unk3300INOHLELBOAM != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300INOHLELBOAM);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ContentCloseTime);
      }
      if (CurDayScanNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CurDayScanNum);
      }
      picNumMap_.WriteTo(ref output, _map_picNumMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CurDayScanNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurDayScanNum);
      }
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      if (Unk3300JLADHEKJPBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JLADHEKJPBP);
      }
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      if (IsActivated != false) {
        size += 1 + 1;
      }
      if (Unk3300INOHLELBOAM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300INOHLELBOAM);
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      size += picNumMap_.CalculateSize(_map_picNumMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlessingActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.CurDayScanNum != 0) {
        CurDayScanNum = other.CurDayScanNum;
      }
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
      }
      if (other.Unk3300JLADHEKJPBP != 0) {
        Unk3300JLADHEKJPBP = other.Unk3300JLADHEKJPBP;
      }
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      if (other.IsActivated != false) {
        IsActivated = other.IsActivated;
      }
      if (other.Unk3300INOHLELBOAM != 0) {
        Unk3300INOHLELBOAM = other.Unk3300INOHLELBOAM;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      picNumMap_.Add(other.picNumMap_);
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
            Unk3300JLADHEKJPBP = input.ReadUInt32();
            break;
          }
          case 16: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 40: {
            IsActivated = input.ReadBool();
            break;
          }
          case 48: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300INOHLELBOAM = input.ReadUInt32();
            break;
          }
          case 64: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 80: {
            CurDayScanNum = input.ReadUInt32();
            break;
          }
          case 90: {
            picNumMap_.AddEntriesFrom(input, _map_picNumMap_codec);
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
            Unk3300JLADHEKJPBP = input.ReadUInt32();
            break;
          }
          case 16: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 40: {
            IsActivated = input.ReadBool();
            break;
          }
          case 48: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300INOHLELBOAM = input.ReadUInt32();
            break;
          }
          case 64: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 80: {
            CurDayScanNum = input.ReadUInt32();
            break;
          }
          case 90: {
            picNumMap_.AddEntriesFrom(ref input, _map_picNumMap_codec);
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
