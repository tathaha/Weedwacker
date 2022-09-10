// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassRewardTakeOption.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BattlePassRewardTakeOption.proto</summary>
  public static partial class BattlePassRewardTakeOptionReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassRewardTakeOption.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassRewardTakeOptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBCYXR0bGVQYXNzUmV3YXJkVGFrZU9wdGlvbi5wcm90bxoZQmF0dGxlUGFz",
            "c1Jld2FyZFRhZy5wcm90byJTChpCYXR0bGVQYXNzUmV3YXJkVGFrZU9wdGlv",
            "bhIhCgN0YWcYCiABKAsyFC5CYXR0bGVQYXNzUmV3YXJkVGFnEhIKCm9wdGlv",
            "bl9pZHgYDiABKA1CIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BattlePassRewardTagReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BattlePassRewardTakeOption), global::Weedwacker.Shared.Network.Proto.BattlePassRewardTakeOption.Parser, new[]{ "Tag", "OptionIdx" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattlePassRewardTakeOption : pb::IMessage<BattlePassRewardTakeOption>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassRewardTakeOption> _parser = new pb::MessageParser<BattlePassRewardTakeOption>(() => new BattlePassRewardTakeOption());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassRewardTakeOption> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BattlePassRewardTakeOptionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassRewardTakeOption() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassRewardTakeOption(BattlePassRewardTakeOption other) : this() {
      tag_ = other.tag_ != null ? other.tag_.Clone() : null;
      optionIdx_ = other.optionIdx_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassRewardTakeOption Clone() {
      return new BattlePassRewardTakeOption(this);
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.BattlePassRewardTag tag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BattlePassRewardTag Tag {
      get { return tag_; }
      set {
        tag_ = value;
      }
    }

    /// <summary>Field number for the "option_idx" field.</summary>
    public const int OptionIdxFieldNumber = 14;
    private uint optionIdx_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionIdx {
      get { return optionIdx_; }
      set {
        optionIdx_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassRewardTakeOption);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassRewardTakeOption other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Tag, other.Tag)) return false;
      if (OptionIdx != other.OptionIdx) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (tag_ != null) hash ^= Tag.GetHashCode();
      if (OptionIdx != 0) hash ^= OptionIdx.GetHashCode();
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
      if (tag_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Tag);
      }
      if (OptionIdx != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(OptionIdx);
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
      if (tag_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Tag);
      }
      if (OptionIdx != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(OptionIdx);
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
      if (tag_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Tag);
      }
      if (OptionIdx != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionIdx);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassRewardTakeOption other) {
      if (other == null) {
        return;
      }
      if (other.tag_ != null) {
        if (tag_ == null) {
          Tag = new global::Weedwacker.Shared.Network.Proto.BattlePassRewardTag();
        }
        Tag.MergeFrom(other.Tag);
      }
      if (other.OptionIdx != 0) {
        OptionIdx = other.OptionIdx;
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
          case 82: {
            if (tag_ == null) {
              Tag = new global::Weedwacker.Shared.Network.Proto.BattlePassRewardTag();
            }
            input.ReadMessage(Tag);
            break;
          }
          case 112: {
            OptionIdx = input.ReadUInt32();
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
          case 82: {
            if (tag_ == null) {
              Tag = new global::Weedwacker.Shared.Network.Proto.BattlePassRewardTag();
            }
            input.ReadMessage(Tag);
            break;
          }
          case 112: {
            OptionIdx = input.ReadUInt32();
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