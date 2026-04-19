using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Saves;

public class EncounterStats
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("encounter_id")]
	public required extern ModelId Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("fight_stats")]
	public extern List<FightStats> FightStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonIgnore]
	public extern int TotalWins { get; }

	[JsonIgnore]
	public extern int TotalLosses { get; }

	public extern void IncrementWin(ModelId characterId);

	public extern void IncrementLoss(ModelId characterId);

	public extern EncounterStats();
}
