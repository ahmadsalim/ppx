// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ppx
{

using global::System;
using global::FlatBuffers;

public struct Observe : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Observe GetRootAsObserve(ByteBuffer _bb) { return GetRootAsObserve(_bb, new Observe()); }
  public static Observe GetRootAsObserve(ByteBuffer _bb, Observe obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Observe __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Address { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetAddressBytes() { return __p.__vector_as_arraysegment(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
  public Distribution DistributionType { get { int o = __p.__offset(8); return o != 0 ? (Distribution)__p.bb.Get(o + __p.bb_pos) : Distribution.NONE; } }
  public TTable? Distribution<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(10); return o != 0 ? (TTable?)__p.__union<TTable>(o) : null; }
  public Tensor? Value { get { int o = __p.__offset(12); return o != 0 ? (Tensor?)(new Tensor()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<Observe> CreateObserve(FlatBufferBuilder builder,
      StringOffset addressOffset = default(StringOffset),
      StringOffset nameOffset = default(StringOffset),
      Distribution distribution_type = Distribution.NONE,
      int distributionOffset = 0,
      Offset<Tensor> valueOffset = default(Offset<Tensor>)) {
    builder.StartObject(5);
    Observe.AddValue(builder, valueOffset);
    Observe.AddDistribution(builder, distributionOffset);
    Observe.AddName(builder, nameOffset);
    Observe.AddAddress(builder, addressOffset);
    Observe.AddDistributionType(builder, distribution_type);
    return Observe.EndObserve(builder);
  }

  public static void StartObserve(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddAddress(FlatBufferBuilder builder, StringOffset addressOffset) { builder.AddOffset(0, addressOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddDistributionType(FlatBufferBuilder builder, Distribution distributionType) { builder.AddByte(2, (byte)distributionType, 0); }
  public static void AddDistribution(FlatBufferBuilder builder, int distributionOffset) { builder.AddOffset(3, distributionOffset, 0); }
  public static void AddValue(FlatBufferBuilder builder, Offset<Tensor> valueOffset) { builder.AddOffset(4, valueOffset.Value, 0); }
  public static Offset<Observe> EndObserve(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Observe>(o);
  }
};


}
