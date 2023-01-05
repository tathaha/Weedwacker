// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessNormalCardInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ChessNormalCardInfo.proto</summary>
  public static partial class ChessNormalCardInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessNormalCardInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessNormalCardInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGVzc05vcm1hbENhcmRJbmZvLnByb3RvIlQKE0NoZXNzTm9ybWFsQ2Fy",
            "ZEluZm8SEwoLY29zdF9wb2ludHMYAyABKA0SDwoHY2FyZF9pZBgCIAEoDRIX",
            "Cg9pc19hdHRhY2hfY3Vyc2UYBCABKAhCIqoCH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ChessNormalCardInfo), global::Weedwacker.Shared.Network.Proto.ChessNormalCardInfo.Parser, new[]{ "CostPoints", "CardId", "IsAttachCurse" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChessNormalCardInfo : pb::IMessage<ChessNormalCardInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessNormalCardInfo> _parser = new pb::MessageParser<ChessNormalCardInfo>(() => new ChessNormalCardInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessNormalCardInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ChessNormalCardInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessNormalCardInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessNormalCardInfo(ChessNormalCardInfo other) : this() {
      costPoints_ = other.costPoints_;
      cardId_ = other.cardId_;
      isAttachCurse_ = other.isAttachCurse_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessNormalCardInfo Clone() {
      return new ChessNormalCardInfo(this);
    }

    /// <summary>Field number for the "cost_points" field.</summary>
    public const int CostPointsFieldNumber = 3;
    private uint costPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostPoints {
      get { return costPoints_; }
      set {
        costPoints_ = value;
      }
    }

    /// <summary>Field number for the "card_id" field.</summary>
    public const int CardIdFieldNumber = 2;
    private uint cardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardId {
      get { return cardId_; }
      set {
        cardId_ = value;
      }
    }

    /// <summary>Field number for the "is_attach_curse" field.</summary>
    public const int IsAttachCurseFieldNumber = 4;
    private bool isAttachCurse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAttachCurse {
      get { return isAttachCurse_; }
      set {
        isAttachCurse_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessNormalCardInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessNormalCardInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CostPoints != other.CostPoints) return false;
      if (CardId != other.CardId) return false;
      if (IsAttachCurse != other.IsAttachCurse) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CostPoints != 0) hash ^= CostPoints.GetHashCode();
      if (CardId != 0) hash ^= CardId.GetHashCode();
      if (IsAttachCurse != false) hash ^= IsAttachCurse.GetHashCode();
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
      if (CardId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CardId);
      }
      if (CostPoints != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CostPoints);
      }
      if (IsAttachCurse != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsAttachCurse);
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
      if (CardId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CardId);
      }
      if (CostPoints != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CostPoints);
      }
      if (IsAttachCurse != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsAttachCurse);
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
      if (CostPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostPoints);
      }
      if (CardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardId);
      }
      if (IsAttachCurse != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessNormalCardInfo other) {
      if (other == null) {
        return;
      }
      if (other.CostPoints != 0) {
        CostPoints = other.CostPoints;
      }
      if (other.CardId != 0) {
        CardId = other.CardId;
      }
      if (other.IsAttachCurse != false) {
        IsAttachCurse = other.IsAttachCurse;
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
            CardId = input.ReadUInt32();
            break;
          }
          case 24: {
            CostPoints = input.ReadUInt32();
            break;
          }
          case 32: {
            IsAttachCurse = input.ReadBool();
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
            CardId = input.ReadUInt32();
            break;
          }
          case 24: {
            CostPoints = input.ReadUInt32();
            break;
          }
          case 32: {
            IsAttachCurse = input.ReadBool();
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
