// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2800_KHLHFFHGEHA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2800_KHLHFFHGEHA.proto</summary>
  public static partial class Unk2800KHLHFFHGEHAReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2800_KHLHFFHGEHA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2800KHLHFFHGEHAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyODAwX0tITEhGRkhHRUhBLnByb3RvGhlVbmsyODAwX0ZHRk1NRkFL",
            "REVMLnByb3RvIosBChNVbmsyODAwX0tITEhGRkhHRUhBEhIKCmlzX3N1Y2Nl",
            "c3MYBCABKAgSGwoTVW5rMjgwMF9JQ05DRUtJSk5KQRgMIAEoCBIxChNVbmsy",
            "ODAwX0VHSkRCQkdOTUZJGAkgAygLMhQuVW5rMjgwMF9GR0ZNTUZBS0RFTBIQ",
            "CghsZXZlbF9pZBgFIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2800FGFMMFAKDELReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2800_KHLHFFHGEHA), global::Weedwacker.Shared.Network.Proto.Unk2800_KHLHFFHGEHA.Parser, new[]{ "IsSuccess", "Unk2800ICNCEKIJNJA", "Unk2800EGJDBBGNMFI", "LevelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 21834
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class Unk2800_KHLHFFHGEHA : pb::IMessage<Unk2800_KHLHFFHGEHA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2800_KHLHFFHGEHA> _parser = new pb::MessageParser<Unk2800_KHLHFFHGEHA>(() => new Unk2800_KHLHFFHGEHA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2800_KHLHFFHGEHA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2800KHLHFFHGEHAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_KHLHFFHGEHA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_KHLHFFHGEHA(Unk2800_KHLHFFHGEHA other) : this() {
      isSuccess_ = other.isSuccess_;
      unk2800ICNCEKIJNJA_ = other.unk2800ICNCEKIJNJA_;
      unk2800EGJDBBGNMFI_ = other.unk2800EGJDBBGNMFI_.Clone();
      levelId_ = other.levelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2800_KHLHFFHGEHA Clone() {
      return new Unk2800_KHLHFFHGEHA(this);
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 4;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_ICNCEKIJNJA" field.</summary>
    public const int Unk2800ICNCEKIJNJAFieldNumber = 12;
    private bool unk2800ICNCEKIJNJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk2800ICNCEKIJNJA {
      get { return unk2800ICNCEKIJNJA_; }
      set {
        unk2800ICNCEKIJNJA_ = value;
      }
    }

    /// <summary>Field number for the "Unk2800_EGJDBBGNMFI" field.</summary>
    public const int Unk2800EGJDBBGNMFIFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2800_FGFMMFAKDEL> _repeated_unk2800EGJDBBGNMFI_codec
        = pb::FieldCodec.ForMessage(74, global::Weedwacker.Shared.Network.Proto.Unk2800_FGFMMFAKDEL.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2800_FGFMMFAKDEL> unk2800EGJDBBGNMFI_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2800_FGFMMFAKDEL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2800_FGFMMFAKDEL> Unk2800EGJDBBGNMFI {
      get { return unk2800EGJDBBGNMFI_; }
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2800_KHLHFFHGEHA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2800_KHLHFFHGEHA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      if (Unk2800ICNCEKIJNJA != other.Unk2800ICNCEKIJNJA) return false;
      if(!unk2800EGJDBBGNMFI_.Equals(other.unk2800EGJDBBGNMFI_)) return false;
      if (LevelId != other.LevelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (Unk2800ICNCEKIJNJA != false) hash ^= Unk2800ICNCEKIJNJA.GetHashCode();
      hash ^= unk2800EGJDBBGNMFI_.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
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
      if (IsSuccess != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsSuccess);
      }
      if (LevelId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LevelId);
      }
      unk2800EGJDBBGNMFI_.WriteTo(output, _repeated_unk2800EGJDBBGNMFI_codec);
      if (Unk2800ICNCEKIJNJA != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk2800ICNCEKIJNJA);
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
      if (IsSuccess != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsSuccess);
      }
      if (LevelId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LevelId);
      }
      unk2800EGJDBBGNMFI_.WriteTo(ref output, _repeated_unk2800EGJDBBGNMFI_codec);
      if (Unk2800ICNCEKIJNJA != false) {
        output.WriteRawTag(96);
        output.WriteBool(Unk2800ICNCEKIJNJA);
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
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (Unk2800ICNCEKIJNJA != false) {
        size += 1 + 1;
      }
      size += unk2800EGJDBBGNMFI_.CalculateSize(_repeated_unk2800EGJDBBGNMFI_codec);
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2800_KHLHFFHGEHA other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.Unk2800ICNCEKIJNJA != false) {
        Unk2800ICNCEKIJNJA = other.Unk2800ICNCEKIJNJA;
      }
      unk2800EGJDBBGNMFI_.Add(other.unk2800EGJDBBGNMFI_);
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 40: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 74: {
            unk2800EGJDBBGNMFI_.AddEntriesFrom(input, _repeated_unk2800EGJDBBGNMFI_codec);
            break;
          }
          case 96: {
            Unk2800ICNCEKIJNJA = input.ReadBool();
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
            IsSuccess = input.ReadBool();
            break;
          }
          case 40: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 74: {
            unk2800EGJDBBGNMFI_.AddEntriesFrom(ref input, _repeated_unk2800EGJDBBGNMFI_codec);
            break;
          }
          case 96: {
            Unk2800ICNCEKIJNJA = input.ReadBool();
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