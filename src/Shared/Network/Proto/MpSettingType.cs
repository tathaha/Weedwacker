// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MpSettingType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from MpSettingType.proto</summary>
  public static partial class MpSettingTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MpSettingType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MpSettingTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNNcFNldHRpbmdUeXBlLnByb3RvKnYKDU1wU2V0dGluZ1R5cGUSHAoYTVBf",
            "U0VUVElOR19UWVBFX05PX0VOVEVSEAASIAocTVBfU0VUVElOR19UWVBFX0VO",
            "VEVSX0ZSRUVMWRABEiUKIU1QX1NFVFRJTkdfVFlQRV9FTlRFUl9BRlRFUl9B",
            "UFBMWRACQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.MpSettingType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MpSettingType {
    [pbr::OriginalName("MP_SETTING_TYPE_NO_ENTER")] NoEnter = 0,
    [pbr::OriginalName("MP_SETTING_TYPE_ENTER_FREELY")] EnterFreely = 1,
    [pbr::OriginalName("MP_SETTING_TYPE_ENTER_AFTER_APPLY")] EnterAfterApply = 2,
  }

  #endregion

}

#endregion Designer generated code
