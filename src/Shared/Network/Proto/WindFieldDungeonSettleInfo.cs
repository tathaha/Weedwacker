// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WindFieldDungeonSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WindFieldDungeonSettleInfo.proto</summary>
  public static partial class WindFieldDungeonSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WindFieldDungeonSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WindFieldDungeonSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBXaW5kRmllbGREdW5nZW9uU2V0dGxlSW5mby5wcm90bxogV2luZEZpZWxk",
            "RHVuZ2VvbkZhaWxSZWFzb24ucHJvdG8iiAEKGldpbmRGaWVsZER1bmdlb25T",
            "ZXR0bGVJbmZvEhsKE1VuazMzMDBfRkpHRk9KQkdCS00YByADKA0SMAoLZmFp",
            "bF9yZWFzb24YAyABKA4yGy5XaW5kRmllbGREdW5nZW9uRmFpbFJlYXNvbhIb",
            "ChNVbmszMzAwX0VNQ09JTEdBQ09DGAEgAygNQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WindFieldDungeonSettleInfo), global::Weedwacker.Shared.Network.Proto.WindFieldDungeonSettleInfo.Parser, new[]{ "Unk3300FJGFOJBGBKM", "FailReason", "Unk3300EMCOILGACOC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WindFieldDungeonSettleInfo : pb::IMessage<WindFieldDungeonSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WindFieldDungeonSettleInfo> _parser = new pb::MessageParser<WindFieldDungeonSettleInfo>(() => new WindFieldDungeonSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WindFieldDungeonSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WindFieldDungeonSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldDungeonSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldDungeonSettleInfo(WindFieldDungeonSettleInfo other) : this() {
      unk3300FJGFOJBGBKM_ = other.unk3300FJGFOJBGBKM_.Clone();
      failReason_ = other.failReason_;
      unk3300EMCOILGACOC_ = other.unk3300EMCOILGACOC_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldDungeonSettleInfo Clone() {
      return new WindFieldDungeonSettleInfo(this);
    }

    /// <summary>Field number for the "Unk3300_FJGFOJBGBKM" field.</summary>
    public const int Unk3300FJGFOJBGBKMFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300FJGFOJBGBKM_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> unk3300FJGFOJBGBKM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300FJGFOJBGBKM {
      get { return unk3300FJGFOJBGBKM_; }
    }

    /// <summary>Field number for the "fail_reason" field.</summary>
    public const int FailReasonFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason failReason_ = global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason FailReason {
      get { return failReason_; }
      set {
        failReason_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EMCOILGACOC" field.</summary>
    public const int Unk3300EMCOILGACOCFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300EMCOILGACOC_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> unk3300EMCOILGACOC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300EMCOILGACOC {
      get { return unk3300EMCOILGACOC_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WindFieldDungeonSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WindFieldDungeonSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk3300FJGFOJBGBKM_.Equals(other.unk3300FJGFOJBGBKM_)) return false;
      if (FailReason != other.FailReason) return false;
      if(!unk3300EMCOILGACOC_.Equals(other.unk3300EMCOILGACOC_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk3300FJGFOJBGBKM_.GetHashCode();
      if (FailReason != global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason.None) hash ^= FailReason.GetHashCode();
      hash ^= unk3300EMCOILGACOC_.GetHashCode();
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
      unk3300EMCOILGACOC_.WriteTo(output, _repeated_unk3300EMCOILGACOC_codec);
      if (FailReason != global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FailReason);
      }
      unk3300FJGFOJBGBKM_.WriteTo(output, _repeated_unk3300FJGFOJBGBKM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk3300EMCOILGACOC_.WriteTo(ref output, _repeated_unk3300EMCOILGACOC_codec);
      if (FailReason != global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason.None) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FailReason);
      }
      unk3300FJGFOJBGBKM_.WriteTo(ref output, _repeated_unk3300FJGFOJBGBKM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk3300FJGFOJBGBKM_.CalculateSize(_repeated_unk3300FJGFOJBGBKM_codec);
      if (FailReason != global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FailReason);
      }
      size += unk3300EMCOILGACOC_.CalculateSize(_repeated_unk3300EMCOILGACOC_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WindFieldDungeonSettleInfo other) {
      if (other == null) {
        return;
      }
      unk3300FJGFOJBGBKM_.Add(other.unk3300FJGFOJBGBKM_);
      if (other.FailReason != global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason.None) {
        FailReason = other.FailReason;
      }
      unk3300EMCOILGACOC_.Add(other.unk3300EMCOILGACOC_);
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
          case 10:
          case 8: {
            unk3300EMCOILGACOC_.AddEntriesFrom(input, _repeated_unk3300EMCOILGACOC_codec);
            break;
          }
          case 24: {
            FailReason = (global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason) input.ReadEnum();
            break;
          }
          case 58:
          case 56: {
            unk3300FJGFOJBGBKM_.AddEntriesFrom(input, _repeated_unk3300FJGFOJBGBKM_codec);
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
          case 10:
          case 8: {
            unk3300EMCOILGACOC_.AddEntriesFrom(ref input, _repeated_unk3300EMCOILGACOC_codec);
            break;
          }
          case 24: {
            FailReason = (global::Weedwacker.Shared.Network.Proto.WindFieldDungeonFailReason) input.ReadEnum();
            break;
          }
          case 58:
          case 56: {
            unk3300FJGFOJBGBKM_.AddEntriesFrom(ref input, _repeated_unk3300FJGFOJBGBKM_codec);
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
