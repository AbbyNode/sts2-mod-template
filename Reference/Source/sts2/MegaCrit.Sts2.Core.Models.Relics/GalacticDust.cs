using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class GalacticDust : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool ShowCounter { get; }

	public override extern int DisplayAmount { get; }

	[SavedProperty]
	public extern int StarsSpent { get; set; }

	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterStarsSpent_003Ed__19))]
	public override extern Task AfterStarsSpent(int amount, Player spender);

	public extern GalacticDust();
}
