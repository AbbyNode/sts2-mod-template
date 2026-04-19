using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Achievements;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Saves.Validation;

namespace MegaCrit.Sts2.Core.Saves;

public class ProgressState
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyDictionary<ModelId, CharacterStats> CharacterStats { get; }

	public extern IReadOnlyDictionary<ModelId, CardStats> CardStats { get; }

	public extern IReadOnlyDictionary<ModelId, EncounterStats> EncounterStats { get; }

	public extern IReadOnlyDictionary<ModelId, EnemyStats> EnemyStats { get; }

	public extern IReadOnlyDictionary<ModelId, AncientStats> AncientStats { get; }

	public extern IReadOnlySet<ModelId> DiscoveredCards { get; }

	public extern IReadOnlySet<ModelId> DiscoveredRelics { get; }

	public extern IReadOnlySet<ModelId> DiscoveredPotions { get; }

	public extern IReadOnlySet<ModelId> DiscoveredEvents { get; }

	public extern IReadOnlySet<ModelId> DiscoveredActs { get; }

	public extern IReadOnlyList<SerializableEpoch> Epochs { get; }

	public extern IReadOnlyDictionary<Achievement, long> UnlockedAchievements { get; }

	public extern IReadOnlySet<string> FtueCompleted { get; }

	public extern string UniqueId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern bool EnableFtues
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern long TotalPlaytime
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int TotalUnlocks
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int CurrentScore
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern long FloorsClimbed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern long ArchitectDamage
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int WongoPoints
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int PreferredMultiplayerAscension
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int MaxMultiplayerAscension
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int TestSubjectKills
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern ModelId PendingCharacterUnlock
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int Wins { get; }

	public extern int Losses { get; }

	public extern long FastestVictory { get; }

	public extern long BestWinStreak { get; }

	public extern int NumberOfRuns { get; }

	public static extern ProgressState CreateDefault();

	public static extern ProgressState FromSerializable(SerializableProgress save, DeserializationContext ctx);

	public extern SerializableProgress ToSerializable();

	public extern CharacterStats GetOrCreateCharacterStats(ModelId characterId);

	public extern CardStats GetOrCreateCardStats(ModelId cardId);

	public extern bool MarkCardAsSeen(ModelId cardId);

	public extern bool MarkRelicAsSeen(ModelId relicId);

	public extern bool MarkPotionAsSeen(ModelId potionId);

	public extern bool MarkEventAsSeen(ModelId eventId);

	public extern bool MarkActAsSeen(ModelId actId);

	public extern bool MarkFtueAsComplete(string ftueId);

	public extern void AddUnlockedAchievement(Achievement achievement, long unlockTime);

	public extern bool RemoveUnlockedAchievement(Achievement achievement);

	public extern bool IsAchievementUnlocked(Achievement achievement);

	public extern void ObtainEpoch(string epochId);

	public extern void ObtainEpochOverride(string epochId, EpochState state);

	public extern void UnlockSlot(string epochId);

	public extern void RevealEpoch(string epochId);

	public extern void ResetEpochs();

	public extern CharacterStats? GetStatsForCharacter(ModelId characterId);

	public extern EncounterStats GetOrCreateEncounterStats(ModelId encounterId);

	public extern EnemyStats GetOrCreateEnemyStats(ModelId enemyId);

	public extern AncientStats GetOrCreateAncientStats(ModelId ancientId);

	public extern AncientStats? GetStatsForAncient(ModelId ancientId);

	public extern void ResetFtues();

	public extern bool HasEpoch(string epochId);

	public extern bool IsEpochObtained(string epochId);

	public extern bool IsEpochRevealed(string epochId);

	public extern ProgressState();
}
