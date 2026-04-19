using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Cards.Mocks;

public sealed class MockQuestCard : MockCardModel
{
	public override extern CardType Type { get; }

	public override extern CardRarity Rarity { get; }

	public override extern TargetType TargetType { get; }

	public override extern int MaxUpgradeLevel { get; }

	public override extern IEnumerable<CardKeyword> CanonicalKeywords { get; }

	public override extern MockCardModel MockBlock(int block);

	public extern MockQuestCard();
}
