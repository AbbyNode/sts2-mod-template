using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class Vintage : ModifierModel
{
	public override extern bool TryModifyRewardsLate(Player player, List<Reward> rewards, AbstractRoom? room);

	public extern Vintage();
}
