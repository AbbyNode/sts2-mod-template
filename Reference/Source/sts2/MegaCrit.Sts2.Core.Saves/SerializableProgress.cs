using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Saves;

public class SerializableProgress : ISaveSchema
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

	[JsonPropertyName("unique_id")]
	public extern string UniqueId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	[JsonPropertyName("character_stats")]
	public extern List<CharacterStats> CharStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("card_stats")]
	public extern List<CardStats> CardStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("encounter_stats")]
	public extern List<EncounterStats> EncounterStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("enemy_stats")]
	public extern List<EnemyStats> EnemyStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("ancient_stats")]
	public extern List<AncientStats> AncientStats
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("enable_ftues")]
	public extern bool EnableFtues
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("epochs")]
	public extern List<SerializableEpoch> Epochs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("ftue_completed")]
	public extern List<string> FtueCompleted
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("unlocked_achievements")]
	public extern List<SerializableUnlockedAchievement> UnlockedAchievements
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_cards")]
	public extern List<ModelId> DiscoveredCards
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_relics")]
	public extern List<ModelId> DiscoveredRelics
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_events")]
	public extern List<ModelId> DiscoveredEvents
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_potions")]
	public extern List<ModelId> DiscoveredPotions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("discovered_acts")]
	public extern List<ModelId> DiscoveredActs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("total_playtime")]
	public extern long TotalPlaytime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("total_unlocks")]
	public extern int TotalUnlocks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("current_score")]
	public extern int CurrentScore
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("floors_climbed")]
	public extern long FloorsClimbed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("architect_damage")]
	public extern long ArchitectDamage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("wongo_points")]
	public extern int WongoPoints
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("preferred_multiplayer_ascension")]
	public extern int PreferredMultiplayerAscension
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("max_multiplayer_ascension")]
	public extern int MaxMultiplayerAscension
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("test_subject_kills")]
	public extern int TestSubjectKills
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("pending_character_unlock")]
	public extern ModelId PendingCharacterUnlock
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public extern int Wins { get; }

	[JsonIgnore]
	public extern int Losses { get; }

	[JsonIgnore]
	public extern long FastestVictory { get; }

	[JsonIgnore]
	public extern long BestWinStreak { get; }

	[JsonIgnore]
	public extern int NumberOfRuns { get; }

	public extern SerializableProgress();

	public extern CharacterStats? GetStatsForCharacter(ModelId characterId);

	public extern AncientStats? GetStatsForAncient(ModelId ancientId);
}
