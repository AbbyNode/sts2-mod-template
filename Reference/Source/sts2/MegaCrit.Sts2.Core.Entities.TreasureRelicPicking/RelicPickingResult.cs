using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.TreasureRelicPicking;

public class RelicPickingResult
{
	public RelicPickingResultType type;

	public required RelicModel relic;

	public required Player player;

	public RelicPickingFight? fight;

	public static extern RelicPickingResult GenerateRelicFight(List<Player> players, RelicModel relic, Func<RelicPickingFightMove> generateMove);

	public extern RelicPickingResult();
}
