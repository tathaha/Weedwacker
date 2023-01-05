// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Item.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Item.proto</summary>
  public static partial class ItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Item.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpJdGVtLnByb3RvGgtFcXVpcC5wcm90bxoPRnVybml0dXJlLnByb3RvGg5N",
            "YXRlcmlhbC5wcm90byKIAQoESXRlbRIPCgdpdGVtX2lkGAEgASgNEgwKBGd1",
            "aWQYAiABKAQSHQoIbWF0ZXJpYWwYBSABKAsyCS5NYXRlcmlhbEgAEhcKBWVx",
            "dWlwGAYgASgLMgYuRXF1aXBIABIfCglmdXJuaXR1cmUYByABKAsyCi5GdXJu",
            "aXR1cmVIAEIICgZkZXRhaWxCIqoCH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.EquipReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.FurnitureReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.MaterialReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Item), global::Weedwacker.Shared.Network.Proto.Item.Parser, new[]{ "ItemId", "Guid", "Material", "Equip", "Furniture" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Item : pb::IMessage<Item>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Item> _parser = new pb::MessageParser<Item>(() => new Item());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Item> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Item() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Item(Item other) : this() {
      itemId_ = other.itemId_;
      guid_ = other.guid_;
      switch (other.DetailCase) {
        case DetailOneofCase.Material:
          Material = other.Material.Clone();
          break;
        case DetailOneofCase.Equip:
          Equip = other.Equip.Clone();
          break;
        case DetailOneofCase.Furniture:
          Furniture = other.Furniture.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Item Clone() {
      return new Item(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 2;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "material" field.</summary>
    public const int MaterialFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Material Material {
      get { return detailCase_ == DetailOneofCase.Material ? (global::Weedwacker.Shared.Network.Proto.Material) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Material;
      }
    }

    /// <summary>Field number for the "equip" field.</summary>
    public const int EquipFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Equip Equip {
      get { return detailCase_ == DetailOneofCase.Equip ? (global::Weedwacker.Shared.Network.Proto.Equip) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Equip;
      }
    }

    /// <summary>Field number for the "furniture" field.</summary>
    public const int FurnitureFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Furniture Furniture {
      get { return detailCase_ == DetailOneofCase.Furniture ? (global::Weedwacker.Shared.Network.Proto.Furniture) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Furniture;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      Material = 5,
      Equip = 6,
      Furniture = 7,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Item);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Item other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (Guid != other.Guid) return false;
      if (!object.Equals(Material, other.Material)) return false;
      if (!object.Equals(Equip, other.Equip)) return false;
      if (!object.Equals(Furniture, other.Furniture)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (detailCase_ == DetailOneofCase.Material) hash ^= Material.GetHashCode();
      if (detailCase_ == DetailOneofCase.Equip) hash ^= Equip.GetHashCode();
      if (detailCase_ == DetailOneofCase.Furniture) hash ^= Furniture.GetHashCode();
      hash ^= (int) detailCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Guid);
      }
      if (detailCase_ == DetailOneofCase.Material) {
        output.WriteRawTag(42);
        output.WriteMessage(Material);
      }
      if (detailCase_ == DetailOneofCase.Equip) {
        output.WriteRawTag(50);
        output.WriteMessage(Equip);
      }
      if (detailCase_ == DetailOneofCase.Furniture) {
        output.WriteRawTag(58);
        output.WriteMessage(Furniture);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ItemId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ItemId);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Guid);
      }
      if (detailCase_ == DetailOneofCase.Material) {
        output.WriteRawTag(42);
        output.WriteMessage(Material);
      }
      if (detailCase_ == DetailOneofCase.Equip) {
        output.WriteRawTag(50);
        output.WriteMessage(Equip);
      }
      if (detailCase_ == DetailOneofCase.Furniture) {
        output.WriteRawTag(58);
        output.WriteMessage(Furniture);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (detailCase_ == DetailOneofCase.Material) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Material);
      }
      if (detailCase_ == DetailOneofCase.Equip) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Equip);
      }
      if (detailCase_ == DetailOneofCase.Furniture) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Furniture);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Item other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.Material:
          if (Material == null) {
            Material = new global::Weedwacker.Shared.Network.Proto.Material();
          }
          Material.MergeFrom(other.Material);
          break;
        case DetailOneofCase.Equip:
          if (Equip == null) {
            Equip = new global::Weedwacker.Shared.Network.Proto.Equip();
          }
          Equip.MergeFrom(other.Equip);
          break;
        case DetailOneofCase.Furniture:
          if (Furniture == null) {
            Furniture = new global::Weedwacker.Shared.Network.Proto.Furniture();
          }
          Furniture.MergeFrom(other.Furniture);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 16: {
            Guid = input.ReadUInt64();
            break;
          }
          case 42: {
            global::Weedwacker.Shared.Network.Proto.Material subBuilder = new global::Weedwacker.Shared.Network.Proto.Material();
            if (detailCase_ == DetailOneofCase.Material) {
              subBuilder.MergeFrom(Material);
            }
            input.ReadMessage(subBuilder);
            Material = subBuilder;
            break;
          }
          case 50: {
            global::Weedwacker.Shared.Network.Proto.Equip subBuilder = new global::Weedwacker.Shared.Network.Proto.Equip();
            if (detailCase_ == DetailOneofCase.Equip) {
              subBuilder.MergeFrom(Equip);
            }
            input.ReadMessage(subBuilder);
            Equip = subBuilder;
            break;
          }
          case 58: {
            global::Weedwacker.Shared.Network.Proto.Furniture subBuilder = new global::Weedwacker.Shared.Network.Proto.Furniture();
            if (detailCase_ == DetailOneofCase.Furniture) {
              subBuilder.MergeFrom(Furniture);
            }
            input.ReadMessage(subBuilder);
            Furniture = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 16: {
            Guid = input.ReadUInt64();
            break;
          }
          case 42: {
            global::Weedwacker.Shared.Network.Proto.Material subBuilder = new global::Weedwacker.Shared.Network.Proto.Material();
            if (detailCase_ == DetailOneofCase.Material) {
              subBuilder.MergeFrom(Material);
            }
            input.ReadMessage(subBuilder);
            Material = subBuilder;
            break;
          }
          case 50: {
            global::Weedwacker.Shared.Network.Proto.Equip subBuilder = new global::Weedwacker.Shared.Network.Proto.Equip();
            if (detailCase_ == DetailOneofCase.Equip) {
              subBuilder.MergeFrom(Equip);
            }
            input.ReadMessage(subBuilder);
            Equip = subBuilder;
            break;
          }
          case 58: {
            global::Weedwacker.Shared.Network.Proto.Furniture subBuilder = new global::Weedwacker.Shared.Network.Proto.Furniture();
            if (detailCase_ == DetailOneofCase.Furniture) {
              subBuilder.MergeFrom(Furniture);
            }
            input.ReadMessage(subBuilder);
            Furniture = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
