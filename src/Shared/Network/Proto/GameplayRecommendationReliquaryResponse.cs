// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GameplayRecommendationReliquaryResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GameplayRecommendationReliquaryResponse.proto</summary>
  public static partial class GameplayRecommendationReliquaryResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for GameplayRecommendationReliquaryResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameplayRecommendationReliquaryResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1HYW1lcGxheVJlY29tbWVuZGF0aW9uUmVsaXF1YXJ5UmVzcG9uc2UucHJv",
            "dG8aMUdhbWVwbGF5UmVjb21tZW5kYXRpb25SZWxpcXVhcnlNYWluUHJvcERh",
            "dGEucHJvdG8iiAEKJ0dhbWVwbGF5UmVjb21tZW5kYXRpb25SZWxpcXVhcnlS",
            "ZXNwb25zZRISCgplcXVpcF90eXBlGAsgASgNEkkKE21haW5fcHJvcF9kYXRh",
            "X2xpc3QYAiADKAsyLC5HYW1lcGxheVJlY29tbWVuZGF0aW9uUmVsaXF1YXJ5",
            "TWFpblByb3BEYXRhQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryResponse), global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryResponse.Parser, new[]{ "EquipType", "MainPropDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GameplayRecommendationReliquaryResponse : pb::IMessage<GameplayRecommendationReliquaryResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameplayRecommendationReliquaryResponse> _parser = new pb::MessageParser<GameplayRecommendationReliquaryResponse>(() => new GameplayRecommendationReliquaryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameplayRecommendationReliquaryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryResponse(GameplayRecommendationReliquaryResponse other) : this() {
      equipType_ = other.equipType_;
      mainPropDataList_ = other.mainPropDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryResponse Clone() {
      return new GameplayRecommendationReliquaryResponse(this);
    }

    /// <summary>Field number for the "equip_type" field.</summary>
    public const int EquipTypeFieldNumber = 11;
    private uint equipType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EquipType {
      get { return equipType_; }
      set {
        equipType_ = value;
      }
    }

    /// <summary>Field number for the "main_prop_data_list" field.</summary>
    public const int MainPropDataListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData> _repeated_mainPropDataList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData> mainPropDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData> MainPropDataList {
      get { return mainPropDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameplayRecommendationReliquaryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameplayRecommendationReliquaryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EquipType != other.EquipType) return false;
      if(!mainPropDataList_.Equals(other.mainPropDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EquipType != 0) hash ^= EquipType.GetHashCode();
      hash ^= mainPropDataList_.GetHashCode();
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
      mainPropDataList_.WriteTo(output, _repeated_mainPropDataList_codec);
      if (EquipType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EquipType);
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
      mainPropDataList_.WriteTo(ref output, _repeated_mainPropDataList_codec);
      if (EquipType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EquipType);
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
      if (EquipType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EquipType);
      }
      size += mainPropDataList_.CalculateSize(_repeated_mainPropDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameplayRecommendationReliquaryResponse other) {
      if (other == null) {
        return;
      }
      if (other.EquipType != 0) {
        EquipType = other.EquipType;
      }
      mainPropDataList_.Add(other.mainPropDataList_);
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
            mainPropDataList_.AddEntriesFrom(input, _repeated_mainPropDataList_codec);
            break;
          }
          case 88: {
            EquipType = input.ReadUInt32();
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
            mainPropDataList_.AddEntriesFrom(ref input, _repeated_mainPropDataList_codec);
            break;
          }
          case 88: {
            EquipType = input.ReadUInt32();
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
