// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WinterCampTriathlonSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WinterCampTriathlonSettleNotify.proto</summary>
  public static partial class WinterCampTriathlonSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WinterCampTriathlonSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WinterCampTriathlonSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVXaW50ZXJDYW1wVHJpYXRobG9uU2V0dGxlTm90aWZ5LnByb3RvItsBCh9X",
            "aW50ZXJDYW1wVHJpYXRobG9uU2V0dGxlTm90aWZ5EhsKE1VuazMzMDBfQUNE",
            "T01CSE1OSkcYCyABKA0SEgoKaXNfc3VjY2VzcxgKIAEoCBINCgVzY29yZRgP",
            "IAEoDRIVCg1pc19uZXdfcmVjb3JkGAcgASgIEhIKCmdhbGxlcnlfaWQYDiAB",
            "KA0SGwoTVW5rMzMwMF9PRUZPR09ORU5GThgMIAEoDRITCgtyZW1haW5fdGlt",
            "ZRgGIAEoDRIbChNVbmszMzAwX0VNTktKR0tOQ01QGAUgASgNQiKqAh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WinterCampTriathlonSettleNotify), global::Weedwacker.Shared.Network.Proto.WinterCampTriathlonSettleNotify.Parser, new[]{ "Unk3300ACDOMBHMNJG", "IsSuccess", "Score", "IsNewRecord", "GalleryId", "Unk3300OEFOGONENFN", "RemainTime", "Unk3300EMNKJGKNCMP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8194;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class WinterCampTriathlonSettleNotify : pb::IMessage<WinterCampTriathlonSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WinterCampTriathlonSettleNotify> _parser = new pb::MessageParser<WinterCampTriathlonSettleNotify>(() => new WinterCampTriathlonSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WinterCampTriathlonSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WinterCampTriathlonSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampTriathlonSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampTriathlonSettleNotify(WinterCampTriathlonSettleNotify other) : this() {
      unk3300ACDOMBHMNJG_ = other.unk3300ACDOMBHMNJG_;
      isSuccess_ = other.isSuccess_;
      score_ = other.score_;
      isNewRecord_ = other.isNewRecord_;
      galleryId_ = other.galleryId_;
      unk3300OEFOGONENFN_ = other.unk3300OEFOGONENFN_;
      remainTime_ = other.remainTime_;
      unk3300EMNKJGKNCMP_ = other.unk3300EMNKJGKNCMP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampTriathlonSettleNotify Clone() {
      return new WinterCampTriathlonSettleNotify(this);
    }

    /// <summary>Field number for the "Unk3300_ACDOMBHMNJG" field.</summary>
    public const int Unk3300ACDOMBHMNJGFieldNumber = 11;
    private uint unk3300ACDOMBHMNJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300ACDOMBHMNJG {
      get { return unk3300ACDOMBHMNJG_; }
      set {
        unk3300ACDOMBHMNJG_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 10;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 15;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 7;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 14;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OEFOGONENFN" field.</summary>
    public const int Unk3300OEFOGONENFNFieldNumber = 12;
    private uint unk3300OEFOGONENFN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300OEFOGONENFN {
      get { return unk3300OEFOGONENFN_; }
      set {
        unk3300OEFOGONENFN_ = value;
      }
    }

    /// <summary>Field number for the "remain_time" field.</summary>
    public const int RemainTimeFieldNumber = 6;
    private uint remainTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainTime {
      get { return remainTime_; }
      set {
        remainTime_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EMNKJGKNCMP" field.</summary>
    public const int Unk3300EMNKJGKNCMPFieldNumber = 5;
    private uint unk3300EMNKJGKNCMP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EMNKJGKNCMP {
      get { return unk3300EMNKJGKNCMP_; }
      set {
        unk3300EMNKJGKNCMP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WinterCampTriathlonSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WinterCampTriathlonSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300ACDOMBHMNJG != other.Unk3300ACDOMBHMNJG) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (Score != other.Score) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (GalleryId != other.GalleryId) return false;
      if (Unk3300OEFOGONENFN != other.Unk3300OEFOGONENFN) return false;
      if (RemainTime != other.RemainTime) return false;
      if (Unk3300EMNKJGKNCMP != other.Unk3300EMNKJGKNCMP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300ACDOMBHMNJG != 0) hash ^= Unk3300ACDOMBHMNJG.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (Unk3300OEFOGONENFN != 0) hash ^= Unk3300OEFOGONENFN.GetHashCode();
      if (RemainTime != 0) hash ^= RemainTime.GetHashCode();
      if (Unk3300EMNKJGKNCMP != 0) hash ^= Unk3300EMNKJGKNCMP.GetHashCode();
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
      if (Unk3300EMNKJGKNCMP != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300EMNKJGKNCMP);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RemainTime);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsNewRecord);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSuccess);
      }
      if (Unk3300ACDOMBHMNJG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300ACDOMBHMNJG);
      }
      if (Unk3300OEFOGONENFN != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300OEFOGONENFN);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GalleryId);
      }
      if (Score != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Score);
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
      if (Unk3300EMNKJGKNCMP != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300EMNKJGKNCMP);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RemainTime);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsNewRecord);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSuccess);
      }
      if (Unk3300ACDOMBHMNJG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300ACDOMBHMNJG);
      }
      if (Unk3300OEFOGONENFN != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300OEFOGONENFN);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GalleryId);
      }
      if (Score != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Score);
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
      if (Unk3300ACDOMBHMNJG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300ACDOMBHMNJG);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (Unk3300OEFOGONENFN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OEFOGONENFN);
      }
      if (RemainTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainTime);
      }
      if (Unk3300EMNKJGKNCMP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EMNKJGKNCMP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WinterCampTriathlonSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300ACDOMBHMNJG != 0) {
        Unk3300ACDOMBHMNJG = other.Unk3300ACDOMBHMNJG;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.Unk3300OEFOGONENFN != 0) {
        Unk3300OEFOGONENFN = other.Unk3300OEFOGONENFN;
      }
      if (other.RemainTime != 0) {
        RemainTime = other.RemainTime;
      }
      if (other.Unk3300EMNKJGKNCMP != 0) {
        Unk3300EMNKJGKNCMP = other.Unk3300EMNKJGKNCMP;
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
            Unk3300EMNKJGKNCMP = input.ReadUInt32();
            break;
          }
          case 48: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 56: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 80: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300ACDOMBHMNJG = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300OEFOGONENFN = input.ReadUInt32();
            break;
          }
          case 112: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 120: {
            Score = input.ReadUInt32();
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
            Unk3300EMNKJGKNCMP = input.ReadUInt32();
            break;
          }
          case 48: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 56: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 80: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300ACDOMBHMNJG = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300OEFOGONENFN = input.ReadUInt32();
            break;
          }
          case 112: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 120: {
            Score = input.ReadUInt32();
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
