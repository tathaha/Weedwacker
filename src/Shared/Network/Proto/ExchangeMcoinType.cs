// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExchangeMcoinType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ExchangeMcoinType.proto</summary>
  public static partial class ExchangeMcoinTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for ExchangeMcoinType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExchangeMcoinTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdFeGNoYW5nZU1jb2luVHlwZS5wcm90byp5ChFFeGNoYW5nZU1jb2luVHlw",
            "ZRIcChhFWENIQU5HRV9NQ09JTl9UWVBFX05PTkUQABIiCh5FWENIQU5HRV9N",
            "Q09JTl9UWVBFX1BDTV9UT19QU04QARIiCh5FWENIQU5HRV9NQ09JTl9UWVBF",
            "X1BTTl9UT19QQ00QAkIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.ExchangeMcoinType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ExchangeMcoinType {
    [pbr::OriginalName("EXCHANGE_MCOIN_TYPE_NONE")] None = 0,
    [pbr::OriginalName("EXCHANGE_MCOIN_TYPE_PCM_TO_PSN")] PcmToPsn = 1,
    [pbr::OriginalName("EXCHANGE_MCOIN_TYPE_PSN_TO_PCM")] PsnToPcm = 2,
  }

  #endregion

}

#endregion Designer generated code
