// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GearActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GearActivityDetailInfo.proto</summary>
  public static partial class GearActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GearActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GearActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZWFyQWN0aXZpdHlEZXRhaWxJbmZvLnByb3RvGhlVbmsyODAwX0JQT0pJ",
            "SURFQURELnByb3RvGhlVbmsyODAwX0pJUE1KUEFLSUtFLnByb3RvIn4KFkdl",
            "YXJBY3Rpdml0eURldGFpbEluZm8SMQoTVW5rMjgwMF9HQkFQQ0JQTUhOShgO",
            "IAMoCzIULlVuazI4MDBfQlBPSklJREVBREQSMQoTVW5rMjgwMF9JSEVIR09C",
            "Q0lOQxgIIAEoCzIULlVuazI4MDBfSklQTUpQQUtJS0VCIqoCH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2800BPOJIIDEADDReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Unk2800JIPMJPAKIKEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GearActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.GearActivityDetailInfo.Parser, new[]{ "Unk2800GBAPCBPMHNJ", "Unk2800IHEHGOBCINC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GearActivityDetailInfo : pb::IMessage<GearActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GearActivityDetailInfo> _parser = new pb::MessageParser<GearActivityDetailInfo>(() => new GearActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GearActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GearActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearActivityDetailInfo(GearActivityDetailInfo other) : this() {
      unk2800GBAPCBPMHNJ_ = other.unk2800GBAPCBPMHNJ_.Clone();
      unk2800IHEHGOBCINC_ = other.unk2800IHEHGOBCINC_ != null ? other.unk2800IHEHGOBCINC_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearActivityDetailInfo Clone() {
      return new GearActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk2800_GBAPCBPMHNJ" field.</summary>
    public const int Unk2800GBAPCBPMHNJFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.Unk2800_BPOJIIDEADD> _repeated_unk2800GBAPCBPMHNJ_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Shared.Network.Proto.Unk2800_BPOJIIDEADD.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2800_BPOJIIDEADD> unk2800GBAPCBPMHNJ_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2800_BPOJIIDEADD>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.Unk2800_BPOJIIDEADD> Unk2800GBAPCBPMHNJ {
      get { return unk2800GBAPCBPMHNJ_; }
    }

    /// <summary>Field number for the "Unk2800_IHEHGOBCINC" field.</summary>
    public const int Unk2800IHEHGOBCINCFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.Unk2800_JIPMJPAKIKE unk2800IHEHGOBCINC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2800_JIPMJPAKIKE Unk2800IHEHGOBCINC {
      get { return unk2800IHEHGOBCINC_; }
      set {
        unk2800IHEHGOBCINC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GearActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GearActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2800GBAPCBPMHNJ_.Equals(other.unk2800GBAPCBPMHNJ_)) return false;
      if (!object.Equals(Unk2800IHEHGOBCINC, other.Unk2800IHEHGOBCINC)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2800GBAPCBPMHNJ_.GetHashCode();
      if (unk2800IHEHGOBCINC_ != null) hash ^= Unk2800IHEHGOBCINC.GetHashCode();
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
      if (unk2800IHEHGOBCINC_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Unk2800IHEHGOBCINC);
      }
      unk2800GBAPCBPMHNJ_.WriteTo(output, _repeated_unk2800GBAPCBPMHNJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (unk2800IHEHGOBCINC_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Unk2800IHEHGOBCINC);
      }
      unk2800GBAPCBPMHNJ_.WriteTo(ref output, _repeated_unk2800GBAPCBPMHNJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2800GBAPCBPMHNJ_.CalculateSize(_repeated_unk2800GBAPCBPMHNJ_codec);
      if (unk2800IHEHGOBCINC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2800IHEHGOBCINC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GearActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      unk2800GBAPCBPMHNJ_.Add(other.unk2800GBAPCBPMHNJ_);
      if (other.unk2800IHEHGOBCINC_ != null) {
        if (unk2800IHEHGOBCINC_ == null) {
          Unk2800IHEHGOBCINC = new global::Weedwacker.Shared.Network.Proto.Unk2800_JIPMJPAKIKE();
        }
        Unk2800IHEHGOBCINC.MergeFrom(other.Unk2800IHEHGOBCINC);
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
          case 66: {
            if (unk2800IHEHGOBCINC_ == null) {
              Unk2800IHEHGOBCINC = new global::Weedwacker.Shared.Network.Proto.Unk2800_JIPMJPAKIKE();
            }
            input.ReadMessage(Unk2800IHEHGOBCINC);
            break;
          }
          case 114: {
            unk2800GBAPCBPMHNJ_.AddEntriesFrom(input, _repeated_unk2800GBAPCBPMHNJ_codec);
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
          case 66: {
            if (unk2800IHEHGOBCINC_ == null) {
              Unk2800IHEHGOBCINC = new global::Weedwacker.Shared.Network.Proto.Unk2800_JIPMJPAKIKE();
            }
            input.ReadMessage(Unk2800IHEHGOBCINC);
            break;
          }
          case 114: {
            unk2800GBAPCBPMHNJ_.AddEntriesFrom(ref input, _repeated_unk2800GBAPCBPMHNJ_codec);
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