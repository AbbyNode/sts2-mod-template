using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Runs.Metrics;

public class RunMetrics
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public required extern string BuildId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern string PlayerId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern ModelId Character
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern bool Win
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern int NumPlayers
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<ModelId> Team
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern string BuildType
	{
		[CompilerGenerated]
		get;
	}

	public extern int Ascension
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern float TotalPlaytime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern float TotalWinRate
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern float RunPlaytime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern int FloorReached
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern ModelId KilledByEncounter
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<CardChoiceMetric> CardChoices
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<string> CampfireUpgrades
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<EventChoiceMetric> EventChoices
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<AncientMetric> AncientChoices
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<string> RelicBuys
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<string> PotionBuys
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<string> ColorlessBuys
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<string> PotionDiscards
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<EncounterMetric> Encounters
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern List<ActWinMetric> ActWins
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern IEnumerable<ModelId> Deck
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public required extern IEnumerable<ModelId> Relics
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern RunMetrics();
}
