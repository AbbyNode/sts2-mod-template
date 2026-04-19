using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Ectoplasm : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool ShouldGainGold(decimal amount, Player player);

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	public extern Ectoplasm();
}
