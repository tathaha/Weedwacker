// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FeatureBlockType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FeatureBlockType.proto</summary>
  public static partial class FeatureBlockTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for FeatureBlockType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeatureBlockTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGZWF0dXJlQmxvY2tUeXBlLnByb3RvKqABChBGZWF0dXJlQmxvY2tUeXBl",
            "EhsKF0ZFQVRVUkVfQkxPQ0tfVFlQRV9OT05FEAASGwoXRkVBVFVSRV9CTE9D",
            "S19UWVBFX0NIQVQQARIZChVGRUFUVVJFX0JMT0NLX1RZUEVfTVAQAhIaChZG",
            "RUFUVVJFX0JMT0NLX1RZUEVfQ1JDEAMSGwoXRkVBVFVSRV9CTE9DS19UWVBF",
            "X0hPTUUQBEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.FeatureBlockType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FeatureBlockType {
    [pbr::OriginalName("FEATURE_BLOCK_TYPE_NONE")] None = 0,
    [pbr::OriginalName("FEATURE_BLOCK_TYPE_CHAT")] Chat = 1,
    [pbr::OriginalName("FEATURE_BLOCK_TYPE_MP")] Mp = 2,
    [pbr::OriginalName("FEATURE_BLOCK_TYPE_CRC")] Crc = 3,
    [pbr::OriginalName("FEATURE_BLOCK_TYPE_HOME")] Home = 4,
  }

  #endregion

}

#endregion Designer generated code
