using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class WongosMysteryTicket : RelicModel
{
	public const int combatsToActivate = 5;

	public const int relicCount = 3;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool IsUsedUp { get; }

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int CombatsFinished { get; set; }

	[SavedProperty]
	public extern bool GaveRelic { get; set; }

	public override extern Task AfterCombatEnd(CombatRoom _);

	public override extern bool TryModifyRewards(Player player, List<Reward> rewards, AbstractRoom? room);

	public override extern Task AfterModifyingRewards();

	public extern WongosMysteryTicket();
}
