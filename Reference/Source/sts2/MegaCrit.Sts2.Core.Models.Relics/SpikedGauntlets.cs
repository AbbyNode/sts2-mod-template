using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class SpikedGauntlets : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	public override extern bool TryModifyEnergyCostInCombat(CardModel card, decimal originalCost, out decimal modifiedCost);

	public extern SpikedGauntlets();
}
