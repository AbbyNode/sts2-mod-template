using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Potions;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Odds;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Entities.Players;

public class Player
{
	public const int initialMaxPotionSlotCount = 3;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int MaxPotionCount { get; }

	public extern CharacterModel Character
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature Creature
	{
		[CompilerGenerated]
		get;
	}

	public extern ulong NetId
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerRngSet PlayerRng
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerOddsSet PlayerOdds
	{
		[CompilerGenerated]
		get;
	}

	public extern RelicGrabBag RelicGrabBag
	{
		[CompilerGenerated]
		get;
	}

	public extern UnlockState UnlockState
	{
		[CompilerGenerated]
		get;
	}

	public extern IRunState RunState { get; set; }

	public extern bool IsActiveForHooks
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerCombatState? PlayerCombatState
	{
		[CompilerGenerated]
		get;
	}

	public extern ExtraPlayerFields ExtraFields
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<RelicModel> Relics { get; }

	public extern IReadOnlyList<PotionModel?> PotionSlots { get; }

	public extern IEnumerable<PotionModel> Potions { get; }

	public extern Creature? Osty { get; }

	public extern bool IsOstyAlive { get; }

	public extern bool IsOstyMissing { get; }

	public extern int Gold { get; set; }

	public extern int MaxAscensionWhenRunStarted
	{
		[CompilerGenerated]
		get;
	}

	public extern bool HasOpenPotionSlots { get; }

	public extern bool CanRemovePotions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern CardPile Deck
	{
		[CompilerGenerated]
		get;
	}

	public extern int MaxEnergy
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<ModelId> DiscoveredCards
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<ModelId> DiscoveredRelics
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<ModelId> DiscoveredPotions
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<ModelId> DiscoveredEnemies
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern List<string> DiscoveredEpochs
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern int BaseOrbSlotCount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern IEnumerable<CardPile> Piles { get; }

	public extern event Action<RelicModel>? RelicObtained;

	public extern event Action<RelicModel>? RelicRemoved;

	public extern event Action<int>? MaxPotionCountChanged;

	public extern event Action<PotionModel>? PotionProcured;

	public extern event Action<PotionModel>? PotionDiscarded;

	public extern event Action<PotionModel>? UsedPotionRemoved;

	public extern event Action? AddPotionFailed;

	public extern event Action? GoldChanged;

	public extern bool HasEventPet();

	public static extern Player CreateForNewRun<T>(UnlockState unlockState, ulong netId) where T : CharacterModel;

	public static extern Player CreateForNewRun(CharacterModel character, UnlockState unlockState, ulong netId);

	public static extern Player FromSerializable(SerializablePlayer save);

	public extern void InitializeSeed(string seed);

	public extern void PopulateRelicGrabBagIfNecessary(Rng rng);

	public extern SerializablePlayer ToSerializable();

	public extern void SyncWithSerializedPlayer(SerializablePlayer player);

	public extern void AddRelicInternal(RelicModel relic, int index = -1, bool silent = false);

	public extern void RemoveRelicInternal(RelicModel relic, bool silent = false);

	public extern void MeltRelicInternal(RelicModel relic);

	public extern T? GetRelic<T>() where T : RelicModel;

	public extern RelicModel? GetRelicById(ModelId id);

	public extern int GetPotionSlotIndex(PotionModel model);

	public extern PotionModel? GetPotionAtSlotIndex(int index);

	public extern void AddToMaxPotionCount(int maxPotionCountIncrease);

	public extern void SubtractFromMaxPotionCount(int maxPotionCountDecrease);

	public extern PotionProcureResult AddPotionInternal(PotionModel potion, int slotIndex = -1, bool silent = false);

	public extern void DiscardPotionInternal(PotionModel potion, bool silent = false);

	public extern void RemoveUsedPotionInternal(PotionModel potion);

	public extern void ResetCombatState();

	public extern void PopulateCombatState(Rng rng, CombatState state);

	[AsyncStateMachine(typeof(_003CReviveBeforeCombatEnd_003Ed__161))]
	public extern Task ReviveBeforeCombatEnd();

	public extern void AfterCombatEnd();

	public extern void OnSideSwitch();

	public extern void DeactivateHooks();

	public extern void ActivateHooks();
}
