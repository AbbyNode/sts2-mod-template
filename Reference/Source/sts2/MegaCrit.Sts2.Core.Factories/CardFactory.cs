using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Factories;

public static class CardFactory
{
	public static extern CardCreationResult CreateForMerchant(Player player, IEnumerable<CardModel> options, CardType type);

	public static extern CardCreationResult CreateForMerchant(Player player, IEnumerable<CardModel> options, CardRarity rarity);

	public static extern IEnumerable<CardCreationResult> CreateForReward(Player player, int cardCount, CardCreationOptions options);

	public static extern IEnumerable<CardModel> GetDistinctForCombat(Player player, IEnumerable<CardModel> cards, int count, Rng rng);

	public static extern IEnumerable<CardModel> GetForCombat(Player player, IEnumerable<CardModel> cards, int count, Rng rng);

	public static extern IEnumerable<CardModel> FilterForCombat(IEnumerable<CardModel> cards);

	public static extern IEnumerable<CardModel> GetDefaultTransformationOptions(CardModel original, bool isInCombat);

	public static extern CardModel CreateRandomCardForTransform(CardModel original, bool isInCombat, Rng rng);

	public static extern CardModel CreateRandomCardForTransform(CardModel original, IEnumerable<CardModel> options, bool isInCombat, Rng rng);
}
