using System;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Runs;

public struct RunLocation : IEquatable<RunLocation>, IComparable<RunLocation>, IPacketSerializable
{
	public int actIndex;

	public MapCoord? coord;

	public extern RunLocation(MapCoord? coord, int actIndex);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public static extern bool operator ==(RunLocation first, RunLocation second);

	public static extern bool operator !=(RunLocation first, RunLocation second);

	public extern bool Equals(RunLocation other);

	public override extern bool Equals(object? obj);

	public override extern int GetHashCode();

	public extern int CompareTo(RunLocation other);

	public override extern string ToString();
}
