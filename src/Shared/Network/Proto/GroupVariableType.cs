// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GroupVariableType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GroupVariableType.proto</summary>
  public static partial class GroupVariableTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GroupVariableType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupVariableTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHcm91cFZhcmlhYmxlVHlwZS5wcm90bypYChFHcm91cFZhcmlhYmxlVHlw",
            "ZRIeChpHUk9VUF9WQVJJQUJMRV9UWVBFX05PUk1BTBAAEiMKH0dST1VQX1ZB",
            "UklBQkxFX1RZUEVfTE9HSUNfU1RBVEUQAUIiqgIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.GroupVariableType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GroupVariableType {
    [pbr::OriginalName("GROUP_VARIABLE_TYPE_NORMAL")] Normal = 0,
    [pbr::OriginalName("GROUP_VARIABLE_TYPE_LOGIC_STATE")] LogicState = 1,
  }

  #endregion

}

#endregion Designer generated code
