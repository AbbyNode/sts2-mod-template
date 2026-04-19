using System;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Map;

[Serializable]
public struct MapCoord : IEquatable<MapCoord>, IComparable<MapCoord>, IPacketSerializable
{
	[JsonInclude]
	public int col;

	[JsonInclude]
	public int row;

	public extern MapCoord(int col, int row);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public static extern bool operator ==(MapCoord first, MapCoord second);

	public static extern bool operator !=(MapCoord first, MapCoord second);

	public extern bool Equals(MapCoord other);

	public override extern bool Equals(object? obj);

	public override extern int GetHashCode();

	public extern int CompareTo(MapCoord other);

	public override extern string ToString();
}
