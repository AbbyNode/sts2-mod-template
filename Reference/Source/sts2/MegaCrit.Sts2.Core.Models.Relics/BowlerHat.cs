using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BowlerHat : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool IsAllowed(IRunState runState);

	public override extern bool ShouldGainGold(decimal amount, Player player);

	[AsyncStateMachine(typeof(_003CAfterGoldGained_003Ed__7))]
	public override extern Task AfterGoldGained(Player player);

	public extern BowlerHat();
}
