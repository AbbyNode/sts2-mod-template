using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Relics;

public class Driftwood : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool TryModifyRewardsLate(Player player, List<Reward> rewards, AbstractRoom? room);

	public extern Driftwood();
}
