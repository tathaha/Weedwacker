// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FoundationStatus.proto</summary>
  public static partial class FoundationStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for FoundationStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoundationStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGb3VuZGF0aW9uU3RhdHVzLnByb3RvKocBChBGb3VuZGF0aW9uU3RhdHVz",
            "EhoKFkZPVU5EQVRJT05fU1RBVFVTX05PTkUQABIaChZGT1VOREFUSU9OX1NU",
            "QVRVU19JTklUEAESHgoaRk9VTkRBVElPTl9TVEFUVVNfQlVJTERJTkcQAhIb",
            "ChdGT1VOREFUSU9OX1NUQVRVU19CVUlMVBADQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.FoundationStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FoundationStatus {
    [pbr::OriginalName("FOUNDATION_STATUS_NONE")] None = 0,
    [pbr::OriginalName("FOUNDATION_STATUS_INIT")] Init = 1,
    [pbr::OriginalName("FOUNDATION_STATUS_BUILDING")] Building = 2,
    [pbr::OriginalName("FOUNDATION_STATUS_BUILT")] Built = 3,
  }

  #endregion

}

#endregion Designer generated code
