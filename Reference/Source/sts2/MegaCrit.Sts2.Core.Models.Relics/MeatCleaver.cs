using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Entities.RestSite;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class MeatCleaver : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool TryModifyRestSiteOptions(Player player, ICollection<RestSiteOption> options);

	public extern MeatCleaver();
}
