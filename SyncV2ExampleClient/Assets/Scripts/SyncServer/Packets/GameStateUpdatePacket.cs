// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SyncServer
{

using global::System;
using global::FlatBuffers;

public struct GameStateUpdatePacket : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static GameStateUpdatePacket GetRootAsGameStateUpdatePacket(ByteBuffer _bb) { return GetRootAsGameStateUpdatePacket(_bb, new GameStateUpdatePacket()); }
  public static GameStateUpdatePacket GetRootAsGameStateUpdatePacket(ByteBuffer _bb, GameStateUpdatePacket obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public GameStateUpdatePacket __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public short Opcode { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public PlayerData? Players(int j) { int o = __p.__offset(6); return o != 0 ? (PlayerData?)(new PlayerData()).__assign(__p.__vector(o) + j * 24, __p.bb) : null; }
  public int PlayersLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long GameTime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<GameStateUpdatePacket> CreateGameStateUpdatePacket(FlatBufferBuilder builder,
      short opcode = 0,
      VectorOffset playersOffset = default(VectorOffset),
      long game_time = 0) {
    builder.StartObject(3);
    GameStateUpdatePacket.AddGameTime(builder, game_time);
    GameStateUpdatePacket.AddPlayers(builder, playersOffset);
    GameStateUpdatePacket.AddOpcode(builder, opcode);
    return GameStateUpdatePacket.EndGameStateUpdatePacket(builder);
  }

  public static void StartGameStateUpdatePacket(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddOpcode(FlatBufferBuilder builder, short opcode) { builder.AddShort(0, opcode, 0); }
  public static void AddPlayers(FlatBufferBuilder builder, VectorOffset playersOffset) { builder.AddOffset(1, playersOffset.Value, 0); }
  public static void StartPlayersVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(24, numElems, 8); }
  public static void AddGameTime(FlatBufferBuilder builder, long gameTime) { builder.AddLong(2, gameTime, 0); }
  public static Offset<GameStateUpdatePacket> EndGameStateUpdatePacket(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GameStateUpdatePacket>(o);
  }
};


}
