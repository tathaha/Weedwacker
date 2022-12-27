// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InteractType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InteractType.proto</summary>
  public static partial class InteractTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for InteractType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InteractTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJJbnRlcmFjdFR5cGUucHJvdG8qjAQKDEludGVyYWN0VHlwZRIWChJJTlRF",
            "UkFDVF9UWVBFX05PTkUQABIbChdJTlRFUkFDVF9UWVBFX1BJQ0tfSVRFTRAB",
            "EhgKFElOVEVSQUNUX1RZUEVfR0FUSEVSEAISHAoYSU5URVJBQ1RfVFlQRV9P",
            "UEVOX0NIRVNUEAMSHQoZSU5URVJBQ1RfVFlQRV9PUEVOX1NUQVRVRRAEEhkK",
            "FUlOVEVSQUNUX1RZUEVfQ09OU1VNRRAFEiAKHElOVEVSQUNUX1RZUEVfTVBf",
            "UExBWV9SRVdBUkQQBhIWChJJTlRFUkFDVF9UWVBFX1ZJRVcQBxIgChxJTlRF",
            "UkFDVF9UWVBFX0dFTkVSQUxfUkVXQVJEEAgSHgoaSU5URVJBQ1RfVFlQRV9N",
            "SVJBQ0xFX1JJTkcQCRIcChhJTlRFUkFDVF9UWVBFX0ZPVU5EQVRJT04QChIc",
            "ChhJTlRFUkFDVF9UWVBFX0VDSE9fU0hFTEwQCxIdChlJTlRFUkFDVF9UWVBF",
            "X0hPTUVfR0FUSEVSEAwSHAoYSU5URVJBQ1RfVFlQRV9FTlZfQU5JTUFMEA0S",
            "HgoaSU5URVJBQ1RfVFlQRV9RVUVTVF9HQURHRVQQDhIdChlJTlRFUkFDVF9U",
            "WVBFX1VJX0lOVEVSQUNUEA8SIQodSU5URVJBQ1RfVFlQRV9ERVNIUkVUX09C",
            "RUxJU0sQEEIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.InteractType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum InteractType {
    [pbr::OriginalName("INTERACT_TYPE_NONE")] None = 0,
    [pbr::OriginalName("INTERACT_TYPE_PICK_ITEM")] PickItem = 1,
    [pbr::OriginalName("INTERACT_TYPE_GATHER")] Gather = 2,
    [pbr::OriginalName("INTERACT_TYPE_OPEN_CHEST")] OpenChest = 3,
    [pbr::OriginalName("INTERACT_TYPE_OPEN_STATUE")] OpenStatue = 4,
    [pbr::OriginalName("INTERACT_TYPE_CONSUME")] Consume = 5,
    [pbr::OriginalName("INTERACT_TYPE_MP_PLAY_REWARD")] MpPlayReward = 6,
    [pbr::OriginalName("INTERACT_TYPE_VIEW")] View = 7,
    [pbr::OriginalName("INTERACT_TYPE_GENERAL_REWARD")] GeneralReward = 8,
    [pbr::OriginalName("INTERACT_TYPE_MIRACLE_RING")] MiracleRing = 9,
    [pbr::OriginalName("INTERACT_TYPE_FOUNDATION")] Foundation = 10,
    [pbr::OriginalName("INTERACT_TYPE_ECHO_SHELL")] EchoShell = 11,
    [pbr::OriginalName("INTERACT_TYPE_HOME_GATHER")] HomeGather = 12,
    [pbr::OriginalName("INTERACT_TYPE_ENV_ANIMAL")] EnvAnimal = 13,
    [pbr::OriginalName("INTERACT_TYPE_QUEST_GADGET")] QuestGadget = 14,
    [pbr::OriginalName("INTERACT_TYPE_UI_INTERACT")] UiInteract = 15,
    [pbr::OriginalName("INTERACT_TYPE_DESHRET_OBELISK")] DeshretObelisk = 16,
  }

  #endregion

}

#endregion Designer generated code
