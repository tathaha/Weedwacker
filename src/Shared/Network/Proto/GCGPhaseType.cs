// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGPhaseType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGPhaseType.proto</summary>
  public static partial class GCGPhaseTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGPhaseType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGPhaseTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHQ0dQaGFzZVR5cGUucHJvdG8qrAIKDEdDR1BoYXNlVHlwZRIaChZHQ0df",
            "UEhBU0VfVFlQRV9JTlZBTElEEAASGAoUR0NHX1BIQVNFX1RZUEVfU1RBUlQQ",
            "ARIXChNHQ0dfUEhBU0VfVFlQRV9EUkFXEAISGwoXR0NHX1BIQVNFX1RZUEVf",
            "T05fU1RBR0UQAxIXChNHQ0dfUEhBU0VfVFlQRV9ESUNFEAQSFwoTR0NHX1BI",
            "QVNFX1RZUEVfTUFJThAFEhYKEkdDR19QSEFTRV9UWVBFX0VORBAGEhYKEkdD",
            "R19QSEFTRV9UWVBFX0RJRRAHEhYKEkdDR19QSEFTRV9UWVBFX0ZJThAIEhsK",
            "F0dDR19QSEFTRV9UWVBFX1BSRV9NQUlOEAkSGQoVR0NHX1BIQVNFX1RZUEVf",
            "UkVST0xMEApCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.GCGPhaseType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGPhaseType {
    [pbr::OriginalName("GCG_PHASE_TYPE_INVALID")] Invalid = 0,
    [pbr::OriginalName("GCG_PHASE_TYPE_START")] Start = 1,
    [pbr::OriginalName("GCG_PHASE_TYPE_DRAW")] Draw = 2,
    [pbr::OriginalName("GCG_PHASE_TYPE_ON_STAGE")] OnStage = 3,
    [pbr::OriginalName("GCG_PHASE_TYPE_DICE")] Dice = 4,
    [pbr::OriginalName("GCG_PHASE_TYPE_MAIN")] Main = 5,
    [pbr::OriginalName("GCG_PHASE_TYPE_END")] End = 6,
    [pbr::OriginalName("GCG_PHASE_TYPE_DIE")] Die = 7,
    [pbr::OriginalName("GCG_PHASE_TYPE_FIN")] Fin = 8,
    [pbr::OriginalName("GCG_PHASE_TYPE_PRE_MAIN")] PreMain = 9,
    [pbr::OriginalName("GCG_PHASE_TYPE_REROLL")] Reroll = 10,
  }

  #endregion

}

#endregion Designer generated code
