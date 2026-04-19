using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class MiniatureTent : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool ShouldDisableRemainingRestSiteOptions(Player player);

	public extern MiniatureTent();
}
