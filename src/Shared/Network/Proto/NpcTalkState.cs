// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NpcTalkState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from NpcTalkState.proto</summary>
  public static partial class NpcTalkStateReflection {

    #region Descriptor
    /// <summary>File descriptor for NpcTalkState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NpcTalkStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJOcGNUYWxrU3RhdGUucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8qWwoMTnBjVGFsa1N0YXRlEhcKE05QQ19UQUxLX1NUQVRFX05P",
            "TkUQABIXChNOUENfVEFMS19TVEFURV9BVVRPEAESGQoVTlBDX1RBTEtfU1RB",
            "VEVfTUFOVUFMEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.NpcTalkState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum NpcTalkState {
    [pbr::OriginalName("NPC_TALK_STATE_NONE")] None = 0,
    [pbr::OriginalName("NPC_TALK_STATE_AUTO")] Auto = 1,
    [pbr::OriginalName("NPC_TALK_STATE_MANUAL")] Manual = 2,
  }

  #endregion

}

#endregion Designer generated code