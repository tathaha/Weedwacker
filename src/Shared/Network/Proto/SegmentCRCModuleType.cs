// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SegmentCRCModuleType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SegmentCRCModuleType.proto</summary>
  public static partial class SegmentCRCModuleTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for SegmentCRCModuleType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SegmentCRCModuleTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTZWdtZW50Q1JDTW9kdWxlVHlwZS5wcm90byrmAgoUU2VnbWVudENSQ01v",
            "ZHVsZVR5cGUSIAocU0VHTUVOVF9DUkNfTU9EVUxFX1RZUEVfTk9ORRAAEioK",
            "JlNFR01FTlRfQ1JDX01PRFVMRV9UWVBFX1BDX1VOSVRZUExBWUVSEAESKwon",
            "U0VHTUVOVF9DUkNfTU9EVUxFX1RZUEVfUENfVVNFUkFTU0VNQkxZEAISIwof",
            "U0VHTUVOVF9DUkNfTU9EVUxFX1RZUEVfUENfWExVQRADEi0KKVNFR01FTlRf",
            "Q1JDX01PRFVMRV9UWVBFX0FORFJPSURfTElCSUwyQ1BQEAsSLAooU0VHTUVO",
            "VF9DUkNfTU9EVUxFX1RZUEVfQU5EUk9JRF9MSUJVTklUWRAMEisKJ1NFR01F",
            "TlRfQ1JDX01PRFVMRV9UWVBFX0FORFJPSURfTElCWExVQRANEiQKIFNFR01F",
            "TlRfQ1JDX01PRFVMRV9UWVBFX0lPU19ISzRFEBVCIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.SegmentCRCModuleType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SegmentCRCModuleType {
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_NONE")] None = 0,
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_PC_UNITYPLAYER")] PcUnityplayer = 1,
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_PC_USERASSEMBLY")] PcUserassembly = 2,
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_PC_XLUA")] PcXlua = 3,
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_ANDROID_LIBIL2CPP")] AndroidLibil2Cpp = 11,
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_ANDROID_LIBUNITY")] AndroidLibunity = 12,
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_ANDROID_LIBXLUA")] AndroidLibxlua = 13,
    [pbr::OriginalName("SEGMENT_CRC_MODULE_TYPE_IOS_HK4E")] IosHk4E = 21,
  }

  #endregion

}

#endregion Designer generated code
