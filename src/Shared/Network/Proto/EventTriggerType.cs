// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EventTriggerType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EventTriggerType.proto</summary>
  public static partial class EventTriggerTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for EventTriggerType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventTriggerTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZFdmVudFRyaWdnZXJUeXBlLnByb3RvKlMKEEV2ZW50VHJpZ2dlclR5cGUS",
            "GwoXRVZFTlRfVFJJR0dFUl9UWVBFX05PTkUQABIiCh5FVkVOVF9UUklHR0VS",
            "X1RZUEVfRU5URVJfRk9SQ0UQAUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.EventTriggerType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum EventTriggerType {
    [pbr::OriginalName("EVENT_TRIGGER_TYPE_NONE")] None = 0,
    [pbr::OriginalName("EVENT_TRIGGER_TYPE_ENTER_FORCE")] EnterForce = 1,
  }

  #endregion

}

#endregion Designer generated code
