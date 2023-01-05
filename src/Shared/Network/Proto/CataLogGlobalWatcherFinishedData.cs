// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CataLogGlobalWatcherFinishedData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CataLogGlobalWatcherFinishedData.proto</summary>
  public static partial class CataLogGlobalWatcherFinishedDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CataLogGlobalWatcherFinishedData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CataLogGlobalWatcherFinishedDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZDYXRhTG9nR2xvYmFsV2F0Y2hlckZpbmlzaGVkRGF0YS5wcm90byJeCiBD",
            "YXRhTG9nR2xvYmFsV2F0Y2hlckZpbmlzaGVkRGF0YRIkChxmaW5pc2hlZF9n",
            "bG9iYWxfd2F0Y2hlcl9saXN0GA8gAygNEhQKDGNhdGFsb2dfdHlwZRgCIAEo",
            "DUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedData), global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedData.Parser, new[]{ "FinishedGlobalWatcherList", "CatalogType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CataLogGlobalWatcherFinishedData : pb::IMessage<CataLogGlobalWatcherFinishedData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CataLogGlobalWatcherFinishedData> _parser = new pb::MessageParser<CataLogGlobalWatcherFinishedData>(() => new CataLogGlobalWatcherFinishedData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CataLogGlobalWatcherFinishedData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CataLogGlobalWatcherFinishedDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CataLogGlobalWatcherFinishedData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CataLogGlobalWatcherFinishedData(CataLogGlobalWatcherFinishedData other) : this() {
      finishedGlobalWatcherList_ = other.finishedGlobalWatcherList_.Clone();
      catalogType_ = other.catalogType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CataLogGlobalWatcherFinishedData Clone() {
      return new CataLogGlobalWatcherFinishedData(this);
    }

    /// <summary>Field number for the "finished_global_watcher_list" field.</summary>
    public const int FinishedGlobalWatcherListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_finishedGlobalWatcherList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> finishedGlobalWatcherList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedGlobalWatcherList {
      get { return finishedGlobalWatcherList_; }
    }

    /// <summary>Field number for the "catalog_type" field.</summary>
    public const int CatalogTypeFieldNumber = 2;
    private uint catalogType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CatalogType {
      get { return catalogType_; }
      set {
        catalogType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CataLogGlobalWatcherFinishedData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CataLogGlobalWatcherFinishedData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!finishedGlobalWatcherList_.Equals(other.finishedGlobalWatcherList_)) return false;
      if (CatalogType != other.CatalogType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= finishedGlobalWatcherList_.GetHashCode();
      if (CatalogType != 0) hash ^= CatalogType.GetHashCode();
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
      if (CatalogType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CatalogType);
      }
      finishedGlobalWatcherList_.WriteTo(output, _repeated_finishedGlobalWatcherList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CatalogType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CatalogType);
      }
      finishedGlobalWatcherList_.WriteTo(ref output, _repeated_finishedGlobalWatcherList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += finishedGlobalWatcherList_.CalculateSize(_repeated_finishedGlobalWatcherList_codec);
      if (CatalogType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CatalogType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CataLogGlobalWatcherFinishedData other) {
      if (other == null) {
        return;
      }
      finishedGlobalWatcherList_.Add(other.finishedGlobalWatcherList_);
      if (other.CatalogType != 0) {
        CatalogType = other.CatalogType;
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
          case 16: {
            CatalogType = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            finishedGlobalWatcherList_.AddEntriesFrom(input, _repeated_finishedGlobalWatcherList_codec);
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
          case 16: {
            CatalogType = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            finishedGlobalWatcherList_.AddEntriesFrom(ref input, _repeated_finishedGlobalWatcherList_codec);
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
