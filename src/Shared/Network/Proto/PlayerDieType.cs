// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerDieType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerDieType.proto</summary>
  public static partial class PlayerDieTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerDieType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerDieTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQbGF5ZXJEaWVUeXBlLnByb3RvKp4CCg1QbGF5ZXJEaWVUeXBlEhgKFFBM",
            "QVlFUl9ESUVfVFlQRV9OT05FEAASIwofUExBWUVSX0RJRV9UWVBFX0tJTExf",
            "QllfTU9OU1RFUhABEiAKHFBMQVlFUl9ESUVfVFlQRV9LSUxMX0JZX0dFQVIQ",
            "AhIYChRQTEFZRVJfRElFX1RZUEVfRkFMTBADEhkKFVBMQVlFUl9ESUVfVFlQ",
            "RV9EUkFXThAEEhkKFVBMQVlFUl9ESUVfVFlQRV9BQllTUxAFEhYKElBMQVlF",
            "Ul9ESUVfVFlQRV9HTRAGEiAKHFBMQVlFUl9ESUVfVFlQRV9DTElNQVRFX0NP",
            "TEQQBxIiCh5QTEFZRVJfRElFX1RZUEVfU1RPUk1fTElHSFRJTkcQCEIiqgIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.PlayerDieType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum PlayerDieType {
    [pbr::OriginalName("PLAYER_DIE_TYPE_NONE")] None = 0,
    [pbr::OriginalName("PLAYER_DIE_TYPE_KILL_BY_MONSTER")] KillByMonster = 1,
    [pbr::OriginalName("PLAYER_DIE_TYPE_KILL_BY_GEAR")] KillByGear = 2,
    [pbr::OriginalName("PLAYER_DIE_TYPE_FALL")] Fall = 3,
    [pbr::OriginalName("PLAYER_DIE_TYPE_DRAWN")] Drawn = 4,
    [pbr::OriginalName("PLAYER_DIE_TYPE_ABYSS")] Abyss = 5,
    [pbr::OriginalName("PLAYER_DIE_TYPE_GM")] Gm = 6,
    [pbr::OriginalName("PLAYER_DIE_TYPE_CLIMATE_COLD")] ClimateCold = 7,
    [pbr::OriginalName("PLAYER_DIE_TYPE_STORM_LIGHTING")] StormLighting = 8,
  }

  #endregion

}

#endregion Designer generated code
