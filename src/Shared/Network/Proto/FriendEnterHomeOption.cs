// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FriendEnterHomeOption.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FriendEnterHomeOption.proto</summary>
  public static partial class FriendEnterHomeOptionReflection {

    #region Descriptor
    /// <summary>File descriptor for FriendEnterHomeOption.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendEnterHomeOptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGcmllbmRFbnRlckhvbWVPcHRpb24ucHJvdG8qjAEKFUZyaWVuZEVudGVy",
            "SG9tZU9wdGlvbhIpCiVGUklFTkRfRU5URVJfSE9NRV9PUFRJT05fTkVFRF9D",
            "T05GSVJNEAASIwofRlJJRU5EX0VOVEVSX0hPTUVfT1BUSU9OX1JFRlVTRRAB",
            "EiMKH0ZSSUVORF9FTlRFUl9IT01FX09QVElPTl9ESVJFQ1QQAkIiqgIfV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FriendEnterHomeOption {
    [pbr::OriginalName("FRIEND_ENTER_HOME_OPTION_NEED_CONFIRM")] NeedConfirm = 0,
    [pbr::OriginalName("FRIEND_ENTER_HOME_OPTION_REFUSE")] Refuse = 1,
    [pbr::OriginalName("FRIEND_ENTER_HOME_OPTION_DIRECT")] Direct = 2,
  }

  #endregion

}

#endregion Designer generated code
