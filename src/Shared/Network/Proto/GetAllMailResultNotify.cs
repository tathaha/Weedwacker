// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAllMailResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetAllMailResultNotify.proto</summary>
  public static partial class GetAllMailResultNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAllMailResultNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAllMailResultNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRBbGxNYWlsUmVzdWx0Tm90aWZ5LnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvGg5NYWlsRGF0YS5wcm90byLMAQoWR2V0QWxs",
            "TWFpbFJlc3VsdE5vdGlmeRIbChNVbmszMzAwX0xNQ0FBRFBBSUNNGA0gASgN",
            "EhMKC3RyYW5zYWN0aW9uGA4gASgJEhQKDGlzX2NvbGxlY3RlZBgMIAEoCBIP",
            "CgdyZXRjb2RlGAcgASgFEjwKCW1haWxfbGlzdBgCIAMoCzIpLldlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uTWFpbERhdGESGwoTVW5rMzMwMF9Q",
            "R0pJSEVMS0NFQRgGIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MailDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetAllMailResultNotify), global::Weedwacker.Shared.Network.Proto.GetAllMailResultNotify.Parser, new[]{ "Unk3300LMCAADPAICM", "Transaction", "IsCollected", "Retcode", "MailList", "Unk3300PGJIHELKCEA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1425;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetAllMailResultNotify : pb::IMessage<GetAllMailResultNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllMailResultNotify> _parser = new pb::MessageParser<GetAllMailResultNotify>(() => new GetAllMailResultNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAllMailResultNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetAllMailResultNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllMailResultNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllMailResultNotify(GetAllMailResultNotify other) : this() {
      unk3300LMCAADPAICM_ = other.unk3300LMCAADPAICM_;
      transaction_ = other.transaction_;
      isCollected_ = other.isCollected_;
      retcode_ = other.retcode_;
      mailList_ = other.mailList_.Clone();
      unk3300PGJIHELKCEA_ = other.unk3300PGJIHELKCEA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllMailResultNotify Clone() {
      return new GetAllMailResultNotify(this);
    }

    /// <summary>Field number for the "Unk3300_LMCAADPAICM" field.</summary>
    public const int Unk3300LMCAADPAICMFieldNumber = 13;
    private uint unk3300LMCAADPAICM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LMCAADPAICM {
      get { return unk3300LMCAADPAICM_; }
      set {
        unk3300LMCAADPAICM_ = value;
      }
    }

    /// <summary>Field number for the "transaction" field.</summary>
    public const int TransactionFieldNumber = 14;
    private string transaction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Transaction {
      get { return transaction_; }
      set {
        transaction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_collected" field.</summary>
    public const int IsCollectedFieldNumber = 12;
    private bool isCollected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCollected {
      get { return isCollected_; }
      set {
        isCollected_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "mail_list" field.</summary>
    public const int MailListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.MailData> _repeated_mailList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.MailData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MailData> mailList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MailData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MailData> MailList {
      get { return mailList_; }
    }

    /// <summary>Field number for the "Unk3300_PGJIHELKCEA" field.</summary>
    public const int Unk3300PGJIHELKCEAFieldNumber = 6;
    private uint unk3300PGJIHELKCEA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PGJIHELKCEA {
      get { return unk3300PGJIHELKCEA_; }
      set {
        unk3300PGJIHELKCEA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAllMailResultNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAllMailResultNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300LMCAADPAICM != other.Unk3300LMCAADPAICM) return false;
      if (Transaction != other.Transaction) return false;
      if (IsCollected != other.IsCollected) return false;
      if (Retcode != other.Retcode) return false;
      if(!mailList_.Equals(other.mailList_)) return false;
      if (Unk3300PGJIHELKCEA != other.Unk3300PGJIHELKCEA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300LMCAADPAICM != 0) hash ^= Unk3300LMCAADPAICM.GetHashCode();
      if (Transaction.Length != 0) hash ^= Transaction.GetHashCode();
      if (IsCollected != false) hash ^= IsCollected.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= mailList_.GetHashCode();
      if (Unk3300PGJIHELKCEA != 0) hash ^= Unk3300PGJIHELKCEA.GetHashCode();
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
      mailList_.WriteTo(output, _repeated_mailList_codec);
      if (Unk3300PGJIHELKCEA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300PGJIHELKCEA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (IsCollected != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsCollected);
      }
      if (Unk3300LMCAADPAICM != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300LMCAADPAICM);
      }
      if (Transaction.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(Transaction);
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
      mailList_.WriteTo(ref output, _repeated_mailList_codec);
      if (Unk3300PGJIHELKCEA != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300PGJIHELKCEA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (IsCollected != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsCollected);
      }
      if (Unk3300LMCAADPAICM != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300LMCAADPAICM);
      }
      if (Transaction.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(Transaction);
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
      if (Unk3300LMCAADPAICM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LMCAADPAICM);
      }
      if (Transaction.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Transaction);
      }
      if (IsCollected != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += mailList_.CalculateSize(_repeated_mailList_codec);
      if (Unk3300PGJIHELKCEA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PGJIHELKCEA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAllMailResultNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300LMCAADPAICM != 0) {
        Unk3300LMCAADPAICM = other.Unk3300LMCAADPAICM;
      }
      if (other.Transaction.Length != 0) {
        Transaction = other.Transaction;
      }
      if (other.IsCollected != false) {
        IsCollected = other.IsCollected;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      mailList_.Add(other.mailList_);
      if (other.Unk3300PGJIHELKCEA != 0) {
        Unk3300PGJIHELKCEA = other.Unk3300PGJIHELKCEA;
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
          case 18: {
            mailList_.AddEntriesFrom(input, _repeated_mailList_codec);
            break;
          }
          case 48: {
            Unk3300PGJIHELKCEA = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            IsCollected = input.ReadBool();
            break;
          }
          case 104: {
            Unk3300LMCAADPAICM = input.ReadUInt32();
            break;
          }
          case 114: {
            Transaction = input.ReadString();
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
            mailList_.AddEntriesFrom(ref input, _repeated_mailList_codec);
            break;
          }
          case 48: {
            Unk3300PGJIHELKCEA = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            IsCollected = input.ReadBool();
            break;
          }
          case 104: {
            Unk3300LMCAADPAICM = input.ReadUInt32();
            break;
          }
          case 114: {
            Transaction = input.ReadString();
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
