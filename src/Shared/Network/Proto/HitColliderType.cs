// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HitColliderType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HitColliderType.proto</summary>
  public static partial class HitColliderTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for HitColliderType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HitColliderTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVIaXRDb2xsaWRlclR5cGUucHJvdG8qkgEKD0hpdENvbGxpZGVyVHlwZRId",
            "ChlISVRfQ09MTElERVJfVFlQRV9JTlZBTElEEAASHQoZSElUX0NPTExJREVS",
            "X1RZUEVfSElUX0JPWBABEiEKHUhJVF9DT0xMSURFUl9UWVBFX1dFVF9ISVRf",
            "Qk9YEAISHgoaSElUX0NPTExJREVSX1RZUEVfSEVBRF9CT1gQA0IiqgIfV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.HitColliderType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum HitColliderType {
    [pbr::OriginalName("HIT_COLLIDER_TYPE_INVALID")] Invalid = 0,
    [pbr::OriginalName("HIT_COLLIDER_TYPE_HIT_BOX")] HitBox = 1,
    [pbr::OriginalName("HIT_COLLIDER_TYPE_WET_HIT_BOX")] WetHitBox = 2,
    [pbr::OriginalName("HIT_COLLIDER_TYPE_HEAD_BOX")] HeadBox = 3,
  }

  #endregion

}

#endregion Designer generated code
