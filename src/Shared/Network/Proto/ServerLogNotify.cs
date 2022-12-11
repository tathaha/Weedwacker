// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerLogNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ServerLogNotify.proto</summary>
  public static partial class ServerLogNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ServerLogNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerLogNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTZXJ2ZXJMb2dOb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8aFFNlcnZlckxvZ0xldmVsLnByb3RvGhNTZXJ2ZXJMb2dU",
            "eXBlLnByb3RvIqsBCg9TZXJ2ZXJMb2dOb3RpZnkSEgoKc2VydmVyX2xvZxgL",
            "IAEoCRJCCglsb2dfbGV2ZWwYBSABKA4yLy5XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvLlNlcnZlckxvZ0xldmVsEkAKCGxvZ190eXBlGAkgASgO",
            "Mi4uV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5TZXJ2ZXJMb2dU",
            "eXBlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ServerLogLevelReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ServerLogTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ServerLogNotify), global::Weedwacker.Shared.Network.Proto.ServerLogNotify.Parser, new[]{ "ServerLog", "LogLevel", "LogType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 27;
  ///   ENET_CHANNEL_ID = 1;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ServerLogNotify : pb::IMessage<ServerLogNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ServerLogNotify> _parser = new pb::MessageParser<ServerLogNotify>(() => new ServerLogNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ServerLogNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ServerLogNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerLogNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerLogNotify(ServerLogNotify other) : this() {
      serverLog_ = other.serverLog_;
      logLevel_ = other.logLevel_;
      logType_ = other.logType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerLogNotify Clone() {
      return new ServerLogNotify(this);
    }

    /// <summary>Field number for the "server_log" field.</summary>
    public const int ServerLogFieldNumber = 11;
    private string serverLog_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ServerLog {
      get { return serverLog_; }
      set {
        serverLog_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "log_level" field.</summary>
    public const int LogLevelFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.ServerLogLevel logLevel_ = global::Weedwacker.Shared.Network.Proto.ServerLogLevel.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ServerLogLevel LogLevel {
      get { return logLevel_; }
      set {
        logLevel_ = value;
      }
    }

    /// <summary>Field number for the "log_type" field.</summary>
    public const int LogTypeFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.ServerLogType logType_ = global::Weedwacker.Shared.Network.Proto.ServerLogType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ServerLogType LogType {
      get { return logType_; }
      set {
        logType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ServerLogNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ServerLogNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerLog != other.ServerLog) return false;
      if (LogLevel != other.LogLevel) return false;
      if (LogType != other.LogType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerLog.Length != 0) hash ^= ServerLog.GetHashCode();
      if (LogLevel != global::Weedwacker.Shared.Network.Proto.ServerLogLevel.None) hash ^= LogLevel.GetHashCode();
      if (LogType != global::Weedwacker.Shared.Network.Proto.ServerLogType.None) hash ^= LogType.GetHashCode();
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
      if (LogLevel != global::Weedwacker.Shared.Network.Proto.ServerLogLevel.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) LogLevel);
      }
      if (LogType != global::Weedwacker.Shared.Network.Proto.ServerLogType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) LogType);
      }
      if (ServerLog.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ServerLog);
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
      if (LogLevel != global::Weedwacker.Shared.Network.Proto.ServerLogLevel.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) LogLevel);
      }
      if (LogType != global::Weedwacker.Shared.Network.Proto.ServerLogType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) LogType);
      }
      if (ServerLog.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ServerLog);
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
      if (ServerLog.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerLog);
      }
      if (LogLevel != global::Weedwacker.Shared.Network.Proto.ServerLogLevel.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LogLevel);
      }
      if (LogType != global::Weedwacker.Shared.Network.Proto.ServerLogType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LogType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ServerLogNotify other) {
      if (other == null) {
        return;
      }
      if (other.ServerLog.Length != 0) {
        ServerLog = other.ServerLog;
      }
      if (other.LogLevel != global::Weedwacker.Shared.Network.Proto.ServerLogLevel.None) {
        LogLevel = other.LogLevel;
      }
      if (other.LogType != global::Weedwacker.Shared.Network.Proto.ServerLogType.None) {
        LogType = other.LogType;
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
          case 40: {
            LogLevel = (global::Weedwacker.Shared.Network.Proto.ServerLogLevel) input.ReadEnum();
            break;
          }
          case 72: {
            LogType = (global::Weedwacker.Shared.Network.Proto.ServerLogType) input.ReadEnum();
            break;
          }
          case 90: {
            ServerLog = input.ReadString();
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
          case 40: {
            LogLevel = (global::Weedwacker.Shared.Network.Proto.ServerLogLevel) input.ReadEnum();
            break;
          }
          case 72: {
            LogType = (global::Weedwacker.Shared.Network.Proto.ServerLogType) input.ReadEnum();
            break;
          }
          case 90: {
            ServerLog = input.ReadString();
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
