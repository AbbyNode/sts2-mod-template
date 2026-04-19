using MegaCrit.Sts2.Core.Localization;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public static class CardRarityExtensions
{
	public static extern CardRarity GetNextHighestRarity(this CardRarity cardRarity);

	public static extern LocString ToLocString(this CardRarity cardRarity);
}
