// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ppx
{

using global::System;
using global::FlatBuffers;

public struct Tag : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Tag GetRootAsTag(ByteBuffer _bb) { return GetRootAsTag(_bb, new Tag()); }
  public static Tag GetRootAsTag(ByteBuffer _bb, Tag obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Tag __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Address { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAddressBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetAddressBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetAddressArray() { return __p.__vector_as_array<byte>(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public Tensor? Value { get { int o = __p.__offset(8); return o != 0 ? (Tensor?)(new Tensor()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Tag> CreateTag(FlatBufferBuilder builder,
      StringOffset addressOffset = default(StringOffset),
      StringOffset nameOffset = default(StringOffset),
      Offset<Tensor> valueOffset = default(Offset<Tensor>)) {
    builder.StartObject(3);
    Tag.AddValue(builder, valueOffset);
    Tag.AddName(builder, nameOffset);
    Tag.AddAddress(builder, addressOffset);
    return Tag.EndTag(builder);
  }

  public static void StartTag(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddAddress(FlatBufferBuilder builder, StringOffset addressOffset) { builder.AddOffset(0, addressOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddValue(FlatBufferBuilder builder, Offset<Tensor> valueOffset) { builder.AddOffset(2, valueOffset.Value, 0); }
  public static Offset<Tag> EndTag(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Tag>(o);
  }
};


}