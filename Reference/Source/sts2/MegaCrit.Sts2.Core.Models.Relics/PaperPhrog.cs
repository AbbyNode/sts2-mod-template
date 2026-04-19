using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PaperPhrog : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public extern decimal ModifyVulnerableMultiplier(Creature target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public extern PaperPhrog();
}
