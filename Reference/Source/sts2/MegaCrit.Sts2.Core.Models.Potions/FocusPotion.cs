using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Potions;
using MegaCrit.Sts2.Core.HoverTips;

namespace MegaCrit.Sts2.Core.Models.Potions;

public sealed class FocusPotion : PotionModel
{
	public override extern PotionRarity Rarity { get; }

	public override extern PotionUsage Usage { get; }

	public override extern TargetType TargetType { get; }

	public override extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern FocusPotion();
}
