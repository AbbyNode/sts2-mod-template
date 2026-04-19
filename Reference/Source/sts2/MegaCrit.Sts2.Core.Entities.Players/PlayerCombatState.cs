using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Orbs;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Players;

public class PlayerCombatState
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<Creature> Pets { get; }

	public extern CardPile Hand
	{
		[CompilerGenerated]
		get;
	}

	public extern CardPile DrawPile
	{
		[CompilerGenerated]
		get;
	}

	public extern CardPile DiscardPile
	{
		[CompilerGenerated]
		get;
	}

	public extern CardPile ExhaustPile
	{
		[CompilerGenerated]
		get;
	}

	public extern CardPile PlayPile
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<CardPile> AllPiles { get; }

	public extern IEnumerable<CardModel> AllCards { get; }

	public extern int Energy { get; set; }

	public extern int MaxEnergy { get; }

	public extern int Stars { get; set; }

	public extern OrbQueue OrbQueue
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action<int, int>? EnergyChanged;

	public extern event Action<int, int>? StarsChanged;

	public extern PlayerCombatState(Player player);

	public extern void AfterCombatEnd();

	public extern void ResetEnergy();

	public extern void AddMaxEnergyToCurrent();

	public extern void LoseEnergy(decimal amount);

	public extern void GainEnergy(decimal amount);

	public extern bool HasEnoughResourcesFor(CardModel card, out UnplayableReason reason);

	public extern void LoseStars(decimal amount);

	public extern void GainStars(decimal amount);

	public extern void AddPetInternal(Creature pet);

	public extern Creature? GetPet<T>() where T : MonsterModel;

	public extern void RecalculateCardValues();

	public extern void EndOfTurnCleanup();

	public extern bool HasCardsToPlay();
}
