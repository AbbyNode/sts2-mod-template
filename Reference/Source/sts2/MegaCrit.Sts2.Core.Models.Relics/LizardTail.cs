using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class LizardTail : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	public override extern bool IsUsedUp { get; }

	[SavedProperty]
	public extern bool WasUsed { get; set; }

	public override extern bool ShouldDieLate(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterPreventingDeath_003Ed__11))]
	public override extern Task AfterPreventingDeath(Creature creature);

	public extern LizardTail();
}
