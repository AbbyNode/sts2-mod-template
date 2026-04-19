using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public class CardPile
{
	public const int maxCardsInHand = 10;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern PileType Type
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<CardModel> Cards { get; }

	public extern bool IsEmpty { get; }

	public extern bool IsCombatPile { get; }

	public extern int UpgradableCardCount { get; }

	public extern event Action? ContentsChanged;

	public extern event Action<CardModel>? CardAdded;

	public extern event Action<CardModel>? CardRemoved;

	public extern event Action? CardAddFinished;

	public extern event Action? CardRemoveFinished;

	public extern CardPile(PileType type);

	public static extern CardPile? Get(PileType type, Player player);

	public static extern IEnumerable<CardModel> GetCards(Player player, params PileType[] piles);

	public extern void RandomizeOrderInternal(Player player, Rng rng, CombatState state);

	public extern void AddInternal(CardModel card, int index = -1, bool silent = false);

	public extern void RemoveInternal(CardModel card, bool silent = false);

	public extern void MoveToBottomInternal(CardModel card);

	public extern void MoveToTopInternal(CardModel card);

	public extern void Clear(bool silent = false);

	public extern void InvokeCardAddFinished();

	public extern void InvokeCardRemoveFinished();

	public extern void InvokeContentsChanged();
}
