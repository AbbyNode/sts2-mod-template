using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class BlurPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldClearBlock(Creature creature);

	public override extern Task AfterPreventingBlockClear(AbstractModel preventer, Creature creature);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__8))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	public extern BlurPower();
}
