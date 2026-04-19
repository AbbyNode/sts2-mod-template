using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Unlocks;

public class UnlockState
{
	public static readonly UnlockState none;

	public static readonly UnlockState all;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int NumberOfRuns
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<CharacterModel> Characters { get; }

	public extern IEnumerable<AncientEventModel> SharedAncients { get; }

	public extern IEnumerable<RelicModel> Relics { get; }

	public extern IEnumerable<PotionModel> Potions { get; }

	public extern IEnumerable<CardPoolModel> CharacterCardPools { get; }

	public extern IEnumerable<CardModel> Cards { get; }

	public extern IEnumerable<CardPoolModel> CardPools { get; }

	public extern bool HasSeenEncounter(EncounterModel encounter);

	public extern UnlockState(IEnumerable<string> unlockedEpochIds, IEnumerable<ModelId> encountersSeen, int numberOfRuns);

	public extern UnlockState(ProgressState progress);

	public extern UnlockState(IEnumerable<UnlockState> unlockStatesEnumerable);

	public extern bool IsEpochRevealed<T>() where T : EpochModel;

	public extern int EpochUnlockCount();

	public extern SerializableUnlockState ToSerializable();

	public static extern UnlockState FromSerializable(SerializableUnlockState unlockState);
}
