// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_BBMKJGPMIOE.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_BBMKJGPMIOE.proto</summary>
  public static partial class Unk2700BBMKJGPMIOEReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_BBMKJGPMIOE.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700BBMKJGPMIOEReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX0JCTUtKR1BNSU9FLnByb3RvGhlVbmsyNzAwX0tJR0dPS0FF",
            "RkhNLnByb3RvIkgKE1VuazI3MDBfQkJNS0pHUE1JT0USMQoTVW5rMjcwMF9D",
            "TkpQQ0NFQ0JQRBgOIAEoCzIULlVuazI3MDBfS0lHR09LQUVGSE1CIqoCH1dl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700KIGGOKAEFHMReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_BBMKJGPMIOE), global::Weedwacker.Shared.Network.Proto.Unk2700_BBMKJGPMIOE.Parser, new[]{ "Unk2700CNJPCCECBPD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8580
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_BBMKJGPMIOE : pb::IMessage<Unk2700_BBMKJGPMIOE>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_BBMKJGPMIOE> _parser = new pb::MessageParser<Unk2700_BBMKJGPMIOE>(() => new Unk2700_BBMKJGPMIOE());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_BBMKJGPMIOE> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700BBMKJGPMIOEReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BBMKJGPMIOE() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BBMKJGPMIOE(Unk2700_BBMKJGPMIOE other) : this() {
      unk2700CNJPCCECBPD_ = other.unk2700CNJPCCECBPD_ != null ? other.unk2700CNJPCCECBPD_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_BBMKJGPMIOE Clone() {
      return new Unk2700_BBMKJGPMIOE(this);
    }

    /// <summary>Field number for the "Unk2700_CNJPCCECBPD" field.</summary>
    public const int Unk2700CNJPCCECBPDFieldNumber = 14;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_KIGGOKAEFHM unk2700CNJPCCECBPD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_KIGGOKAEFHM Unk2700CNJPCCECBPD {
      get { return unk2700CNJPCCECBPD_; }
      set {
        unk2700CNJPCCECBPD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_BBMKJGPMIOE);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_BBMKJGPMIOE other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Unk2700CNJPCCECBPD, other.Unk2700CNJPCCECBPD)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (unk2700CNJPCCECBPD_ != null) hash ^= Unk2700CNJPCCECBPD.GetHashCode();
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
      if (unk2700CNJPCCECBPD_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Unk2700CNJPCCECBPD);
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
      if (unk2700CNJPCCECBPD_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Unk2700CNJPCCECBPD);
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
      if (unk2700CNJPCCECBPD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk2700CNJPCCECBPD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_BBMKJGPMIOE other) {
      if (other == null) {
        return;
      }
      if (other.unk2700CNJPCCECBPD_ != null) {
        if (unk2700CNJPCCECBPD_ == null) {
          Unk2700CNJPCCECBPD = new global::Weedwacker.Shared.Network.Proto.Unk2700_KIGGOKAEFHM();
        }
        Unk2700CNJPCCECBPD.MergeFrom(other.Unk2700CNJPCCECBPD);
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
          case 114: {
            if (unk2700CNJPCCECBPD_ == null) {
              Unk2700CNJPCCECBPD = new global::Weedwacker.Shared.Network.Proto.Unk2700_KIGGOKAEFHM();
            }
            input.ReadMessage(Unk2700CNJPCCECBPD);
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
          case 114: {
            if (unk2700CNJPCCECBPD_ == null) {
              Unk2700CNJPCCECBPD = new global::Weedwacker.Shared.Network.Proto.Unk2700_KIGGOKAEFHM();
            }
            input.ReadMessage(Unk2700CNJPCCECBPD);
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