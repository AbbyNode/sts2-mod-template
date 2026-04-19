using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class Midas : ModifierModel
{
	public override extern bool TryModifyRewardsLate(Player player, List<Reward> rewards, AbstractRoom? room);

	public override extern bool TryModifyRestSiteOptions(Player player, ICollection<RestSiteOption> options);

	public extern Midas();
}
