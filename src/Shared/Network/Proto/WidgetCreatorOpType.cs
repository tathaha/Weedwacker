// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetCreatorOpType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WidgetCreatorOpType.proto</summary>
  public static partial class WidgetCreatorOpTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetCreatorOpType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetCreatorOpTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlXaWRnZXRDcmVhdG9yT3BUeXBlLnByb3RvKokBChNXaWRnZXRDcmVhdG9y",
            "T3BUeXBlEh8KG1dJREdFVF9DUkVBVE9SX09QX1RZUEVfTk9ORRAAEiIKHldJ",
            "REdFVF9DUkVBVE9SX09QX1RZUEVfUkVUUkFDVBABEi0KKVdJREdFVF9DUkVB",
            "VE9SX09QX1RZUEVfUkVUUkFDVF9BTkRfQ1JFQVRFEAJCIqoCH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.WidgetCreatorOpType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum WidgetCreatorOpType {
    [pbr::OriginalName("WIDGET_CREATOR_OP_TYPE_NONE")] None = 0,
    [pbr::OriginalName("WIDGET_CREATOR_OP_TYPE_RETRACT")] Retract = 1,
    [pbr::OriginalName("WIDGET_CREATOR_OP_TYPE_RETRACT_AND_CREATE")] RetractAndCreate = 2,
  }

  #endregion

}

#endregion Designer generated code
