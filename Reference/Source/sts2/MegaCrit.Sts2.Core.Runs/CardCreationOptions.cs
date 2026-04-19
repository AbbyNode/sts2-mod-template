using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Runs;

public record CardCreationOptions
{
	[CompilerGenerated]
	protected virtual extern Type EqualityContract
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyCollection<CardPoolModel> CardPools { get; }

	public extern Func<CardModel, bool>? CardPoolFilter
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<CardModel>? CustomCardPool
	{
		[CompilerGenerated]
		get;
	}

	public extern CardCreationSource Source
	{
		[CompilerGenerated]
		get;
	}

	public extern CardRarityOddsType RarityOdds
	{
		[CompilerGenerated]
		get;
	}

	public extern CardCreationFlags Flags
	{
		[CompilerGenerated]
		get;
	}

	public extern Rng? RngOverride
	{
		[CompilerGenerated]
		get;
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardCreationOptions(IEnumerable<CardPoolModel> cardPools, CardCreationSource source, CardRarityOddsType rarityOdds, Func<CardModel, bool>? cardPoolFilter = null);

	public extern CardCreationOptions(IEnumerable<CardModel> customCardPool, CardCreationSource source, CardRarityOddsType rarityOdds);

	public static extern CardCreationOptions ForRoom(Player player, RoomType roomType);

	public static extern CardCreationOptions ForNonCombatWithDefaultOdds(IEnumerable<CardPoolModel> cardPools, Func<CardModel, bool>? cardPoolFilter = null);

	public static extern CardCreationOptions ForNonCombatWithDefaultOdds(IEnumerable<CardModel> customCardPool);

	public static extern CardCreationOptions ForNonCombatWithUniformOdds(IEnumerable<CardPoolModel> cardPools, Func<CardModel, bool>? cardPoolFilter = null);

	public extern IEnumerable<CardModel> GetPossibleCards(Player player);

	public extern CardCreationOptions WithCustomPool(IEnumerable<CardModel> customPool, CardRarityOddsType? rarityOdds = null);

	public extern CardCreationOptions WithCardPools(IEnumerable<CardPoolModel> pools, Func<CardModel, bool>? cardPoolFilter = null);

	public extern CardCreationOptions WithFlags(CardCreationFlags flag);

	public extern CardCreationOptions WithRngOverride(Rng rng);

	public extern CardRarity? TryGetSingleRarityInPool();

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	protected virtual extern bool PrintMembers(StringBuilder builder);

	[CompilerGenerated]
	public override extern int GetHashCode();

	[CompilerGenerated]
	public virtual extern bool Equals(CardCreationOptions? other);

	[CompilerGenerated]
	protected extern CardCreationOptions(CardCreationOptions original);
}
