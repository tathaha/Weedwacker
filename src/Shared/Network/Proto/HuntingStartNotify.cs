// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HuntingStartNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HuntingStartNotify.proto</summary>
  public static partial class HuntingStartNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HuntingStartNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HuntingStartNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhIdW50aW5nU3RhcnROb3RpZnkucHJvdG8aEUh1bnRpbmdQYWlyLnByb3Rv",
            "GgxWZWN0b3IucHJvdG8ifQoSSHVudGluZ1N0YXJ0Tm90aWZ5EiIKDGh1bnRp",
            "bmdfcGFpchgDIAEoCzIMLkh1bnRpbmdQYWlyEhEKCWZhaWxfdGltZRgFIAEo",
            "DRIeCg1jbHVlX3Bvc2l0aW9uGAYgASgLMgcuVmVjdG9yEhAKCGlzX2ZpbmFs",
            "GAggASgIQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HuntingPairReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HuntingStartNotify), global::Weedwacker.Shared.Network.Proto.HuntingStartNotify.Parser, new[]{ "HuntingPair", "FailTime", "CluePosition", "IsFinal" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4344;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class HuntingStartNotify : pb::IMessage<HuntingStartNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HuntingStartNotify> _parser = new pb::MessageParser<HuntingStartNotify>(() => new HuntingStartNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HuntingStartNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HuntingStartNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HuntingStartNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HuntingStartNotify(HuntingStartNotify other) : this() {
      huntingPair_ = other.huntingPair_ != null ? other.huntingPair_.Clone() : null;
      failTime_ = other.failTime_;
      cluePosition_ = other.cluePosition_ != null ? other.cluePosition_.Clone() : null;
      isFinal_ = other.isFinal_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HuntingStartNotify Clone() {
      return new HuntingStartNotify(this);
    }

    /// <summary>Field number for the "hunting_pair" field.</summary>
    public const int HuntingPairFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.HuntingPair huntingPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HuntingPair HuntingPair {
      get { return huntingPair_; }
      set {
        huntingPair_ = value;
      }
    }

    /// <summary>Field number for the "fail_time" field.</summary>
    public const int FailTimeFieldNumber = 5;
    private uint failTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FailTime {
      get { return failTime_; }
      set {
        failTime_ = value;
      }
    }

    /// <summary>Field number for the "clue_position" field.</summary>
    public const int CluePositionFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.Vector cluePosition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector CluePosition {
      get { return cluePosition_; }
      set {
        cluePosition_ = value;
      }
    }

    /// <summary>Field number for the "is_final" field.</summary>
    public const int IsFinalFieldNumber = 8;
    private bool isFinal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinal {
      get { return isFinal_; }
      set {
        isFinal_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HuntingStartNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HuntingStartNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(HuntingPair, other.HuntingPair)) return false;
      if (FailTime != other.FailTime) return false;
      if (!object.Equals(CluePosition, other.CluePosition)) return false;
      if (IsFinal != other.IsFinal) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (huntingPair_ != null) hash ^= HuntingPair.GetHashCode();
      if (FailTime != 0) hash ^= FailTime.GetHashCode();
      if (cluePosition_ != null) hash ^= CluePosition.GetHashCode();
      if (IsFinal != false) hash ^= IsFinal.GetHashCode();
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
      if (huntingPair_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HuntingPair);
      }
      if (FailTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FailTime);
      }
      if (cluePosition_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CluePosition);
      }
      if (IsFinal != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsFinal);
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
      if (huntingPair_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HuntingPair);
      }
      if (FailTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FailTime);
      }
      if (cluePosition_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CluePosition);
      }
      if (IsFinal != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsFinal);
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
      if (huntingPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HuntingPair);
      }
      if (FailTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FailTime);
      }
      if (cluePosition_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CluePosition);
      }
      if (IsFinal != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HuntingStartNotify other) {
      if (other == null) {
        return;
      }
      if (other.huntingPair_ != null) {
        if (huntingPair_ == null) {
          HuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
        }
        HuntingPair.MergeFrom(other.HuntingPair);
      }
      if (other.FailTime != 0) {
        FailTime = other.FailTime;
      }
      if (other.cluePosition_ != null) {
        if (cluePosition_ == null) {
          CluePosition = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        CluePosition.MergeFrom(other.CluePosition);
      }
      if (other.IsFinal != false) {
        IsFinal = other.IsFinal;
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
            if (huntingPair_ == null) {
              HuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
            }
            input.ReadMessage(HuntingPair);
            break;
          }
          case 40: {
            FailTime = input.ReadUInt32();
            break;
          }
          case 50: {
            if (cluePosition_ == null) {
              CluePosition = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(CluePosition);
            break;
          }
          case 64: {
            IsFinal = input.ReadBool();
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
            if (huntingPair_ == null) {
              HuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
            }
            input.ReadMessage(HuntingPair);
            break;
          }
          case 40: {
            FailTime = input.ReadUInt32();
            break;
          }
          case 50: {
            if (cluePosition_ == null) {
              CluePosition = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(CluePosition);
            break;
          }
          case 64: {
            IsFinal = input.ReadBool();
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
