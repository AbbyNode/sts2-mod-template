using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class Sozu : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool ShouldProcurePotion(PotionModel potion, Player player);

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	public extern Sozu();
}
