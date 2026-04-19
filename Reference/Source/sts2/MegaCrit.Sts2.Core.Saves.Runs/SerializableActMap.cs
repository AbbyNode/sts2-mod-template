using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializableActMap : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("points")]
	public extern List<SerializableMapPoint> Points
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("boss")]
	public extern SerializableMapPoint BossPoint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("second_boss")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public extern SerializableMapPoint? SecondBossPoint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("start")]
	public extern SerializableMapPoint StartingPoint
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("start_coords")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public extern List<MapCoord>? StartMapPointCoords
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("width")]
	public extern int GridWidth
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("height")]
	public extern int GridHeight
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public static extern SerializableActMap FromActMap(ActMap map);

	public extern SerializableActMap();
}
