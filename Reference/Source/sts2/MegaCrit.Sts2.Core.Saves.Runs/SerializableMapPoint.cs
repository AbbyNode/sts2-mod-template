using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializableMapPoint : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("coord")]
	public extern MapCoord Coord
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("type")]
	public extern MapPointType PointType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("can_modify")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern bool CanBeModified
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("children")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public extern List<MapCoord>? ChildCoords
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public static extern SerializableMapPoint FromMapPoint(MapPoint point);

	public extern SerializableMapPoint();
}
