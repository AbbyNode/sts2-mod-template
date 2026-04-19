using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Potions;

namespace MegaCrit.Sts2.Core.Models.Potions;

public sealed class SneckoOil : PotionModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PotionRarity Rarity { get; }

	public override extern PotionUsage Usage { get; }

	public override extern TargetType TargetType { get; }

	public extern int TestEnergyCostOverride { get; set; }

	public extern SneckoOil();
}
