// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FetterState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FetterState.proto</summary>
  public static partial class FetterStateReflection {

    #region Descriptor
    /// <summary>File descriptor for FetterState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FetterStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGZXR0ZXJTdGF0ZS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90byqJAQoLRmV0dGVyU3RhdGUSFQoRRkVUVEVSX1NUQVRFX05PTkUQ",
            "ABIZChVGRVRURVJfU1RBVEVfTk9UX09QRU4QARIVChFGRVRURVJfU1RBVEVf",
            "T1BFThACEhcKE0ZFVFRFUl9TVEFURV9GSU5JU0gQAxIYChRGRVRURVJfU1RB",
            "VEVfQ09OQ0VBTBAEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.FetterState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FetterState {
    [pbr::OriginalName("FETTER_STATE_NONE")] None = 0,
    [pbr::OriginalName("FETTER_STATE_NOT_OPEN")] NotOpen = 1,
    [pbr::OriginalName("FETTER_STATE_OPEN")] Open = 2,
    [pbr::OriginalName("FETTER_STATE_FINISH")] Finish = 3,
    [pbr::OriginalName("FETTER_STATE_CONCEAL")] Conceal = 4,
  }

  #endregion

}

#endregion Designer generated code
