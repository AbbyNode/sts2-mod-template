using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Platform;
using MegaCrit.Sts2.Core.Runs.History;
using MegaCrit.Sts2.Core.Saves.MapDrawing;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Saves;

public class SerializableRun : ISaveSchema, IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("schema_version")]
	public extern int SchemaVersion
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("acts")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<SerializableActModel> Acts
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("modifiers")]
	public extern List<SerializableModifier> Modifiers
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("dailyTime")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotTypeDefault)]
	public extern DateTimeOffset? DailyTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("current_act_index")]
	public extern int CurrentActIndex
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("events_seen")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<ModelId> EventsSeen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("pre_finished_room")]
	public extern SerializableRoom? PreFinishedRoom
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("odds")]
	public extern SerializableRunOddsSet SerializableOdds
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("shared_relic_grab_bag")]
	public extern SerializableRelicGrabBag SerializableSharedRelicGrabBag
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("players")]
	public extern List<SerializablePlayer> Players
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("rng")]
	public extern SerializableRunRngSet SerializableRng
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("visited_map_coords")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<MapCoord> VisitedMapCoords
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("map_point_history")]
	[JsonSerializeCondition(SerializationCondition.SaveIfNotCollectionEmptyOrNull)]
	public extern List<List<MapPointHistoryEntry>> MapPointHistory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("save_time")]
	public extern long SaveTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("start_time")]
	public extern long StartTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("run_time")]
	public extern long RunTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("win_time")]
	public extern long WinTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("ascension")]
	public extern int Ascension
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("platform_type")]
	public extern PlatformType PlatformType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonConverter(typeof(SerializableMapDrawingsJsonConverter))]
	[JsonPropertyName("map_drawings")]
	public extern SerializableMapDrawings? MapDrawings
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("extra_fields")]
	public extern SerializableExtraRunFields ExtraFields
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializableRun Anonymized();

	public extern SerializableRun();
}
