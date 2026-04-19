using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class RunicPyramid : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool ShouldFlush(Player player);

	public extern RunicPyramid();
}
