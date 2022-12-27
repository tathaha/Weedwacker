// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReportTrackingIOInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ReportTrackingIOInfoNotify.proto</summary>
  public static partial class ReportTrackingIOInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ReportTrackingIOInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportTrackingIOInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBSZXBvcnRUcmFja2luZ0lPSW5mb05vdGlmeS5wcm90byKcAQoaUmVwb3J0",
            "VHJhY2tpbmdJT0luZm9Ob3RpZnkSEQoJY2xpZW50X3R6GA0gASgJEhsKE1Vu",
            "azMzMDBfREpIS0hFRlBDREsYCiABKAkSGwoTVW5rMzMwMF9QSUJGUERBTUpM",
            "RRgGIAEoCRIbChNVbmszMzAwX0NOUElHRE9FSlBCGAggASgJEhQKDHJ5ZGV2",
            "aWNldHlwZRgDIAEoCUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ReportTrackingIOInfoNotify), global::Weedwacker.Shared.Network.Proto.ReportTrackingIOInfoNotify.Parser, new[]{ "ClientTz", "Unk3300DJHKHEFPCDK", "Unk3300PIBFPDAMJLE", "Unk3300CNPIGDOEJPB", "Rydevicetype" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4144;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class ReportTrackingIOInfoNotify : pb::IMessage<ReportTrackingIOInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReportTrackingIOInfoNotify> _parser = new pb::MessageParser<ReportTrackingIOInfoNotify>(() => new ReportTrackingIOInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReportTrackingIOInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ReportTrackingIOInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportTrackingIOInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportTrackingIOInfoNotify(ReportTrackingIOInfoNotify other) : this() {
      clientTz_ = other.clientTz_;
      unk3300DJHKHEFPCDK_ = other.unk3300DJHKHEFPCDK_;
      unk3300PIBFPDAMJLE_ = other.unk3300PIBFPDAMJLE_;
      unk3300CNPIGDOEJPB_ = other.unk3300CNPIGDOEJPB_;
      rydevicetype_ = other.rydevicetype_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportTrackingIOInfoNotify Clone() {
      return new ReportTrackingIOInfoNotify(this);
    }

    /// <summary>Field number for the "client_tz" field.</summary>
    public const int ClientTzFieldNumber = 13;
    private string clientTz_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientTz {
      get { return clientTz_; }
      set {
        clientTz_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_DJHKHEFPCDK" field.</summary>
    public const int Unk3300DJHKHEFPCDKFieldNumber = 10;
    private string unk3300DJHKHEFPCDK_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300DJHKHEFPCDK {
      get { return unk3300DJHKHEFPCDK_; }
      set {
        unk3300DJHKHEFPCDK_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_PIBFPDAMJLE" field.</summary>
    public const int Unk3300PIBFPDAMJLEFieldNumber = 6;
    private string unk3300PIBFPDAMJLE_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300PIBFPDAMJLE {
      get { return unk3300PIBFPDAMJLE_; }
      set {
        unk3300PIBFPDAMJLE_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_CNPIGDOEJPB" field.</summary>
    public const int Unk3300CNPIGDOEJPBFieldNumber = 8;
    private string unk3300CNPIGDOEJPB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300CNPIGDOEJPB {
      get { return unk3300CNPIGDOEJPB_; }
      set {
        unk3300CNPIGDOEJPB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rydevicetype" field.</summary>
    public const int RydevicetypeFieldNumber = 3;
    private string rydevicetype_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Rydevicetype {
      get { return rydevicetype_; }
      set {
        rydevicetype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReportTrackingIOInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReportTrackingIOInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientTz != other.ClientTz) return false;
      if (Unk3300DJHKHEFPCDK != other.Unk3300DJHKHEFPCDK) return false;
      if (Unk3300PIBFPDAMJLE != other.Unk3300PIBFPDAMJLE) return false;
      if (Unk3300CNPIGDOEJPB != other.Unk3300CNPIGDOEJPB) return false;
      if (Rydevicetype != other.Rydevicetype) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientTz.Length != 0) hash ^= ClientTz.GetHashCode();
      if (Unk3300DJHKHEFPCDK.Length != 0) hash ^= Unk3300DJHKHEFPCDK.GetHashCode();
      if (Unk3300PIBFPDAMJLE.Length != 0) hash ^= Unk3300PIBFPDAMJLE.GetHashCode();
      if (Unk3300CNPIGDOEJPB.Length != 0) hash ^= Unk3300CNPIGDOEJPB.GetHashCode();
      if (Rydevicetype.Length != 0) hash ^= Rydevicetype.GetHashCode();
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
      if (Rydevicetype.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Rydevicetype);
      }
      if (Unk3300PIBFPDAMJLE.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Unk3300PIBFPDAMJLE);
      }
      if (Unk3300CNPIGDOEJPB.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Unk3300CNPIGDOEJPB);
      }
      if (Unk3300DJHKHEFPCDK.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Unk3300DJHKHEFPCDK);
      }
      if (ClientTz.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ClientTz);
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
      if (Rydevicetype.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Rydevicetype);
      }
      if (Unk3300PIBFPDAMJLE.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Unk3300PIBFPDAMJLE);
      }
      if (Unk3300CNPIGDOEJPB.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Unk3300CNPIGDOEJPB);
      }
      if (Unk3300DJHKHEFPCDK.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Unk3300DJHKHEFPCDK);
      }
      if (ClientTz.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(ClientTz);
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
      if (ClientTz.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientTz);
      }
      if (Unk3300DJHKHEFPCDK.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300DJHKHEFPCDK);
      }
      if (Unk3300PIBFPDAMJLE.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300PIBFPDAMJLE);
      }
      if (Unk3300CNPIGDOEJPB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300CNPIGDOEJPB);
      }
      if (Rydevicetype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Rydevicetype);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReportTrackingIOInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.ClientTz.Length != 0) {
        ClientTz = other.ClientTz;
      }
      if (other.Unk3300DJHKHEFPCDK.Length != 0) {
        Unk3300DJHKHEFPCDK = other.Unk3300DJHKHEFPCDK;
      }
      if (other.Unk3300PIBFPDAMJLE.Length != 0) {
        Unk3300PIBFPDAMJLE = other.Unk3300PIBFPDAMJLE;
      }
      if (other.Unk3300CNPIGDOEJPB.Length != 0) {
        Unk3300CNPIGDOEJPB = other.Unk3300CNPIGDOEJPB;
      }
      if (other.Rydevicetype.Length != 0) {
        Rydevicetype = other.Rydevicetype;
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
          case 26: {
            Rydevicetype = input.ReadString();
            break;
          }
          case 50: {
            Unk3300PIBFPDAMJLE = input.ReadString();
            break;
          }
          case 66: {
            Unk3300CNPIGDOEJPB = input.ReadString();
            break;
          }
          case 82: {
            Unk3300DJHKHEFPCDK = input.ReadString();
            break;
          }
          case 106: {
            ClientTz = input.ReadString();
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
          case 26: {
            Rydevicetype = input.ReadString();
            break;
          }
          case 50: {
            Unk3300PIBFPDAMJLE = input.ReadString();
            break;
          }
          case 66: {
            Unk3300CNPIGDOEJPB = input.ReadString();
            break;
          }
          case 82: {
            Unk3300DJHKHEFPCDK = input.ReadString();
            break;
          }
          case 106: {
            ClientTz = input.ReadString();
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
