using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Entities.TreasureRelicPicking;

public class RelicPickingFight
{
	public List<Player> playersInvolved;

	public List<RelicPickingFightRound> rounds;

	public extern RelicPickingFight();
}
