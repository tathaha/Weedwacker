// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MusicGameActivityDetailInfo.proto</summary>
  public static partial class MusicGameActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFNdXNpY0dhbWVBY3Rpdml0eURldGFpbEluZm8ucHJvdG8aFU11c2ljR2Ft",
            "ZVJlY29yZC5wcm90bxoXVWdjTXVzaWNCcmllZkluZm8ucHJvdG8ioQIKG011",
            "c2ljR2FtZUFjdGl2aXR5RGV0YWlsSW5mbxIvChNVbmszMzAwX0FBR0NEQ09J",
            "UEpNGAIgAygLMhIuVWdjTXVzaWNCcmllZkluZm8SLwoTVW5rMzMwMF9PS0hB",
            "QUNHSE1BUBgMIAMoCzISLlVnY011c2ljQnJpZWZJbmZvElMKFW11c2ljX2dh",
            "bWVfcmVjb3JkX21hcBgJIAMoCzI0Lk11c2ljR2FtZUFjdGl2aXR5RGV0YWls",
            "SW5mby5NdXNpY0dhbWVSZWNvcmRNYXBFbnRyeRpLChdNdXNpY0dhbWVSZWNv",
            "cmRNYXBFbnRyeRILCgNrZXkYASABKA0SHwoFdmFsdWUYAiABKAsyEC5NdXNp",
            "Y0dhbWVSZWNvcmQ6AjgBQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MusicGameRecordReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.MusicGameActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.MusicGameActivityDetailInfo.Parser, new[]{ "Unk3300AAGCDCOIPJM", "Unk3300OKHAACGHMAP", "MusicGameRecordMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MusicGameActivityDetailInfo : pb::IMessage<MusicGameActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameActivityDetailInfo> _parser = new pb::MessageParser<MusicGameActivityDetailInfo>(() => new MusicGameActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.MusicGameActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameActivityDetailInfo(MusicGameActivityDetailInfo other) : this() {
      unk3300AAGCDCOIPJM_ = other.unk3300AAGCDCOIPJM_.Clone();
      unk3300OKHAACGHMAP_ = other.unk3300OKHAACGHMAP_.Clone();
      musicGameRecordMap_ = other.musicGameRecordMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameActivityDetailInfo Clone() {
      return new MusicGameActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk3300_AAGCDCOIPJM" field.</summary>
    public const int Unk3300AAGCDCOIPJMFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> _repeated_unk3300AAGCDCOIPJM_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> unk3300AAGCDCOIPJM_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> Unk3300AAGCDCOIPJM {
      get { return unk3300AAGCDCOIPJM_; }
    }

    /// <summary>Field number for the "Unk3300_OKHAACGHMAP" field.</summary>
    public const int Unk3300OKHAACGHMAPFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> _repeated_unk3300OKHAACGHMAP_codec
        = pb::FieldCodec.ForMessage(98, global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> unk3300OKHAACGHMAP_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.UgcMusicBriefInfo> Unk3300OKHAACGHMAP {
      get { return unk3300OKHAACGHMAP_; }
    }

    /// <summary>Field number for the "music_game_record_map" field.</summary>
    public const int MusicGameRecordMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord>.Codec _map_musicGameRecordMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.MusicGameRecord.Parser), 74);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord> musicGameRecordMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.MusicGameRecord> MusicGameRecordMap {
      get { return musicGameRecordMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk3300AAGCDCOIPJM_.Equals(other.unk3300AAGCDCOIPJM_)) return false;
      if(!unk3300OKHAACGHMAP_.Equals(other.unk3300OKHAACGHMAP_)) return false;
      if (!MusicGameRecordMap.Equals(other.MusicGameRecordMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk3300AAGCDCOIPJM_.GetHashCode();
      hash ^= unk3300OKHAACGHMAP_.GetHashCode();
      hash ^= MusicGameRecordMap.GetHashCode();
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
      unk3300AAGCDCOIPJM_.WriteTo(output, _repeated_unk3300AAGCDCOIPJM_codec);
      musicGameRecordMap_.WriteTo(output, _map_musicGameRecordMap_codec);
      unk3300OKHAACGHMAP_.WriteTo(output, _repeated_unk3300OKHAACGHMAP_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk3300AAGCDCOIPJM_.WriteTo(ref output, _repeated_unk3300AAGCDCOIPJM_codec);
      musicGameRecordMap_.WriteTo(ref output, _map_musicGameRecordMap_codec);
      unk3300OKHAACGHMAP_.WriteTo(ref output, _repeated_unk3300OKHAACGHMAP_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk3300AAGCDCOIPJM_.CalculateSize(_repeated_unk3300AAGCDCOIPJM_codec);
      size += unk3300OKHAACGHMAP_.CalculateSize(_repeated_unk3300OKHAACGHMAP_codec);
      size += musicGameRecordMap_.CalculateSize(_map_musicGameRecordMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      unk3300AAGCDCOIPJM_.Add(other.unk3300AAGCDCOIPJM_);
      unk3300OKHAACGHMAP_.Add(other.unk3300OKHAACGHMAP_);
      musicGameRecordMap_.Add(other.musicGameRecordMap_);
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
          case 18: {
            unk3300AAGCDCOIPJM_.AddEntriesFrom(input, _repeated_unk3300AAGCDCOIPJM_codec);
            break;
          }
          case 74: {
            musicGameRecordMap_.AddEntriesFrom(input, _map_musicGameRecordMap_codec);
            break;
          }
          case 98: {
            unk3300OKHAACGHMAP_.AddEntriesFrom(input, _repeated_unk3300OKHAACGHMAP_codec);
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
          case 18: {
            unk3300AAGCDCOIPJM_.AddEntriesFrom(ref input, _repeated_unk3300AAGCDCOIPJM_codec);
            break;
          }
          case 74: {
            musicGameRecordMap_.AddEntriesFrom(ref input, _map_musicGameRecordMap_codec);
            break;
          }
          case 98: {
            unk3300OKHAACGHMAP_.AddEntriesFrom(ref input, _repeated_unk3300OKHAACGHMAP_codec);
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
