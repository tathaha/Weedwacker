// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ModifierAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ModifierAction.proto</summary>
  public static partial class ModifierActionReflection {

    #region Descriptor
    /// <summary>File descriptor for ModifierAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModifierActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRNb2RpZmllckFjdGlvbi5wcm90bypICg5Nb2RpZmllckFjdGlvbhIZChVN",
            "T0RJRklFUl9BQ1RJT05fQURERUQQABIbChdNT0RJRklFUl9BQ1RJT05fUkVN",
            "T1ZFRBABQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.ModifierAction), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ModifierAction {
    [pbr::OriginalName("MODIFIER_ACTION_ADDED")] Added = 0,
    [pbr::OriginalName("MODIFIER_ACTION_REMOVED")] Removed = 1,
  }

  #endregion

}

#endregion Designer generated code
