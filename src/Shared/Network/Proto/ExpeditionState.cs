// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExpeditionState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ExpeditionState.proto</summary>
  public static partial class ExpeditionStateReflection {

    #region Descriptor
    /// <summary>File descriptor for ExpeditionState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpeditionStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVFeHBlZGl0aW9uU3RhdGUucHJvdG8qpQEKD0V4cGVkaXRpb25TdGF0ZRIZ",
            "ChVFWFBFRElUSU9OX1NUQVRFX05PTkUQABIcChhFWFBFRElUSU9OX1NUQVRF",
            "X1NUQVJURUQQARIdChlFWFBFRElUSU9OX1NUQVRFX0ZJTklTSEVEEAISHQoZ",
            "RVhQRURJVElPTl9TVEFURV9SRVdBUkRFRBADEhsKF0VYUEVESVRJT05fU1RB",
            "VEVfTE9DS0VEEARCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.ExpeditionState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ExpeditionState {
    [pbr::OriginalName("EXPEDITION_STATE_NONE")] None = 0,
    [pbr::OriginalName("EXPEDITION_STATE_STARTED")] Started = 1,
    [pbr::OriginalName("EXPEDITION_STATE_FINISHED")] Finished = 2,
    [pbr::OriginalName("EXPEDITION_STATE_REWARDED")] Rewarded = 3,
    [pbr::OriginalName("EXPEDITION_STATE_LOCKED")] Locked = 4,
  }

  #endregion

}

#endregion Designer generated code
