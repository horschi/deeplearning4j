// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace nd4j.graph
{

using global::System;
using global::FlatBuffers;

public struct FlatNode : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static FlatNode GetRootAsFlatNode(ByteBuffer _bb) { return GetRootAsFlatNode(_bb, new FlatNode()); }
  public static FlatNode GetRootAsFlatNode(ByteBuffer _bb, FlatNode obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public FlatNode __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
  public OpType OpType { get { int o = __p.__offset(8); return o != 0 ? (OpType)__p.bb.GetSbyte(o + __p.bb_pos) : OpType.TRANSFORM; } }
  public long OpNum { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Input(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int InputLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetInputBytes() { return __p.__vector_as_arraysegment(12); }
  public IntPair? InputPaired(int j) { int o = __p.__offset(14); return o != 0 ? (IntPair?)(new IntPair()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int InputPairedLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public DataType DataType { get { int o = __p.__offset(16); return o != 0 ? (DataType)__p.bb.GetSbyte(o + __p.bb_pos) : DataType.INHERIT; } }
  public int Output(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int OutputLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetOutputBytes() { return __p.__vector_as_arraysegment(18); }
  public float ExtraParams(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int ExtraParamsLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetExtraParamsBytes() { return __p.__vector_as_arraysegment(20); }
  public int ExtraInteger(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ExtraIntegerLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetExtraIntegerBytes() { return __p.__vector_as_arraysegment(22); }
  public int Dimensions(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int DimensionsLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetDimensionsBytes() { return __p.__vector_as_arraysegment(24); }
  public int Device { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Scalar { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int ScopeId { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string ScopeName { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetScopeNameBytes() { return __p.__vector_as_arraysegment(32); }

  public static Offset<FlatNode> CreateFlatNode(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset),
      OpType opType = OpType.TRANSFORM,
      long opNum = 0,
      VectorOffset inputOffset = default(VectorOffset),
      VectorOffset inputPairedOffset = default(VectorOffset),
      DataType dataType = DataType.INHERIT,
      VectorOffset outputOffset = default(VectorOffset),
      VectorOffset extraParamsOffset = default(VectorOffset),
      VectorOffset extraIntegerOffset = default(VectorOffset),
      VectorOffset dimensionsOffset = default(VectorOffset),
      int device = 0,
      float scalar = 0.0f,
      int scope_id = 0,
      StringOffset scope_nameOffset = default(StringOffset)) {
    builder.StartObject(15);
    FlatNode.AddOpNum(builder, opNum);
    FlatNode.AddScopeName(builder, scope_nameOffset);
    FlatNode.AddScopeId(builder, scope_id);
    FlatNode.AddScalar(builder, scalar);
    FlatNode.AddDevice(builder, device);
    FlatNode.AddDimensions(builder, dimensionsOffset);
    FlatNode.AddExtraInteger(builder, extraIntegerOffset);
    FlatNode.AddExtraParams(builder, extraParamsOffset);
    FlatNode.AddOutput(builder, outputOffset);
    FlatNode.AddInputPaired(builder, inputPairedOffset);
    FlatNode.AddInput(builder, inputOffset);
    FlatNode.AddName(builder, nameOffset);
    FlatNode.AddId(builder, id);
    FlatNode.AddDataType(builder, dataType);
    FlatNode.AddOpType(builder, opType);
    return FlatNode.EndFlatNode(builder);
  }

  public static void StartFlatNode(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddOpType(FlatBufferBuilder builder, OpType opType) { builder.AddSbyte(2, (sbyte)opType, 0); }
  public static void AddOpNum(FlatBufferBuilder builder, long opNum) { builder.AddLong(3, opNum, 0); }
  public static void AddInput(FlatBufferBuilder builder, VectorOffset inputOffset) { builder.AddOffset(4, inputOffset.Value, 0); }
  public static VectorOffset CreateInputVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartInputVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInputPaired(FlatBufferBuilder builder, VectorOffset inputPairedOffset) { builder.AddOffset(5, inputPairedOffset.Value, 0); }
  public static VectorOffset CreateInputPairedVector(FlatBufferBuilder builder, Offset<IntPair>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartInputPairedVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDataType(FlatBufferBuilder builder, DataType dataType) { builder.AddSbyte(6, (sbyte)dataType, 0); }
  public static void AddOutput(FlatBufferBuilder builder, VectorOffset outputOffset) { builder.AddOffset(7, outputOffset.Value, 0); }
  public static VectorOffset CreateOutputVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartOutputVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtraParams(FlatBufferBuilder builder, VectorOffset extraParamsOffset) { builder.AddOffset(8, extraParamsOffset.Value, 0); }
  public static VectorOffset CreateExtraParamsVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static void StartExtraParamsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExtraInteger(FlatBufferBuilder builder, VectorOffset extraIntegerOffset) { builder.AddOffset(9, extraIntegerOffset.Value, 0); }
  public static VectorOffset CreateExtraIntegerVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartExtraIntegerVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDimensions(FlatBufferBuilder builder, VectorOffset dimensionsOffset) { builder.AddOffset(10, dimensionsOffset.Value, 0); }
  public static VectorOffset CreateDimensionsVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDimensionsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDevice(FlatBufferBuilder builder, int device) { builder.AddInt(11, device, 0); }
  public static void AddScalar(FlatBufferBuilder builder, float scalar) { builder.AddFloat(12, scalar, 0.0f); }
  public static void AddScopeId(FlatBufferBuilder builder, int scopeId) { builder.AddInt(13, scopeId, 0); }
  public static void AddScopeName(FlatBufferBuilder builder, StringOffset scopeNameOffset) { builder.AddOffset(14, scopeNameOffset.Value, 0); }
  public static Offset<FlatNode> EndFlatNode(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FlatNode>(o);
  }
  public static void FinishFlatNodeBuffer(FlatBufferBuilder builder, Offset<FlatNode> offset) { builder.Finish(offset.Value); }
};


}
