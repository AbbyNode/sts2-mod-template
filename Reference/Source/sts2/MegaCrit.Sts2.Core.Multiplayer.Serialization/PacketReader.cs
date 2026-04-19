using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Godot;

namespace MegaCrit.Sts2.Core.Multiplayer.Serialization;

public class PacketReader
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int BitPosition
	{
		[CompilerGenerated]
		get;
	}

	public extern byte[] Buffer
	{
		[CompilerGenerated]
		get;
	}

	public extern void Reset(byte[] buffer);

	public extern bool ReadBool();

	public extern byte ReadByte(int bits = 8);

	public extern void ReadBytes(byte[] destinationBuffer, int byteCount);

	public extern short ReadShort(int bits = 16);

	public extern ushort ReadUShort(int bits = 16);

	public extern T ReadEnum<T>() where T : struct, Enum;

	public extern int ReadInt(int bits = 32);

	public extern uint ReadUInt(int bits = 32);

	public extern float ReadFloat(QuantizeParams? quantizeParams = null);

	public extern long ReadLong(int bits = 64);

	public extern ulong ReadULong(int bits = 64);

	public extern double ReadDouble();

	public extern Vector2 ReadVector2(QuantizeParams? quantizeParamsX = null, QuantizeParams? quantizeParamsY = null);

	public extern List<T> ReadList<T>(int lengthBits = 32) where T : IPacketSerializable, new();

	public extern string ReadString();

	public extern T Read<T>() where T : IPacketSerializable, new();

	public static extern float Unquantize(uint value, float min, float max, int bitLength);

	public extern PacketReader();
}
