using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Platform;
using MegaCrit.Sts2.Core.Runs.History;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs;

public class RunHistory : ISaveSchema
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

	[JsonPropertyName("platform_type")]
	public extern PlatformType PlatformType
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("game_mode")]
	public extern GameMode GameMode
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("win")]
	public extern bool Win
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("seed")]
	public extern string Seed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("start_time")]
	public extern long StartTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("run_time")]
	public extern float RunTime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("ascension")]
	public extern int Ascension
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("build_id")]
	public extern string BuildId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("was_abandoned")]
	public extern bool WasAbandoned
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("killed_by_encounter")]
	public extern ModelId KilledByEncounter
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("killed_by_event")]
	public extern ModelId KilledByEvent
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("players")]
	public extern List<RunHistoryPlayer> Players
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("acts")]
	public extern List<ModelId> Acts
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("modifiers")]
	public extern List<SerializableModifier> Modifiers
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("map_point_history")]
	public extern List<List<MapPointHistoryEntry>> MapPointHistory
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern RunHistory();
}
