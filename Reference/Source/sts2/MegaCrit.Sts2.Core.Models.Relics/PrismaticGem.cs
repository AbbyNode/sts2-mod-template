using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class PrismaticGem : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyMaxEnergy(Player player, decimal amount);

	public override extern CardCreationOptions ModifyCardRewardCreationOptions(Player player, CardCreationOptions options);

	public extern PrismaticGem();
}
