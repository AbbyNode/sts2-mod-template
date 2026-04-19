using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Saves;

public class AncientStats
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("ancient_id")]
	public required extern ModelId Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("character_stats")]
	public extern List<AncientCharacterStats> CharStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonIgnore]
	public extern int TotalVisits { get; }

	[JsonIgnore]
	public extern int TotalWins { get; }

	[JsonIgnore]
	public extern int TotalLosses { get; }

	public extern void IncrementWin(ModelId characterId);

	public extern void IncrementLoss(ModelId characterId);

	public extern int GetVisitsAs(ModelId characterId);

	public extern AncientStats();
}
