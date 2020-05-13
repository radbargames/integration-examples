// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SyncServer
{

using global::System;
using global::FlatBuffers;

public struct Packet : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static Packet GetRootAsPacket(ByteBuffer _bb) { return GetRootAsPacket(_bb, new Packet()); }
  public static Packet GetRootAsPacket(ByteBuffer _bb, Packet obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public Packet __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public short Opcode { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }

  public static Offset<Packet> CreatePacket(FlatBufferBuilder builder,
      short opcode = 0) {
    builder.StartObject(1);
    Packet.AddOpcode(builder, opcode);
    return Packet.EndPacket(builder);
  }

  public static void StartPacket(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddOpcode(FlatBufferBuilder builder, short opcode) { builder.AddShort(0, opcode, 0); }
  public static Offset<Packet> EndPacket(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<Packet>(o);
  }
  public static void FinishPacketBuffer(FlatBufferBuilder builder, Offset<Packet> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedPacketBuffer(FlatBufferBuilder builder, Offset<Packet> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}
