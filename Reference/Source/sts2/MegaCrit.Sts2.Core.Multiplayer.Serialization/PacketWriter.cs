using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Godot;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public class PacketWriter
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int BitPosition
	{
		[CompilerGenerated]
		get;
	}

	public extern int BytePosition { get; }

	public extern byte[] Buffer
	{
		[CompilerGenerated]
		get;
	}

	public extern bool WarnOnGrow
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Reset();

	public extern void WriteBool(bool val);

	public extern void WriteByte(byte val, int bits = 8);

	public extern void WriteBytes(byte[] bytes, int byteCount);

	public extern void WriteShort(short val, int bits = 16);

	public extern void WriteUShort(ushort val, int bits = 16);

	public extern void WriteEnum<T>(T val) where T : struct, Enum;

	public extern void WriteInt(int val, int bits = 32);

	public extern void WriteUInt(uint val, int bits = 32);

	public extern void WriteFloat(float val, QuantizeParams? quantizeParams = null);

	public extern void WriteLong(long val, int bits = 64);

	public extern void WriteULong(ulong val, int bits = 64);

	public extern void WriteDouble(double val);

	public extern void WriteVector2(Vector2 val, QuantizeParams? quantizeParamsX = null, QuantizeParams? quantizeParamsY = null);

	public extern void WriteList<T>(IReadOnlyList<T> list, int lengthBits = 32) where T : IPacketSerializable, new();

	public extern void WriteString(string str);

	public extern void Write<T>(T val) where T : IPacketSerializable;

	public extern void ZeroByteRemainder();

	public static extern uint Quantize(float value, float min, float max, int bitLength);

	public extern PacketWriter();
}
