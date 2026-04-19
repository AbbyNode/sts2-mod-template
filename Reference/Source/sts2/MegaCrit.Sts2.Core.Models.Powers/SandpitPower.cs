using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SandpitPower : PowerModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool IsInstanced { get; }

	public override extern Task AfterApplied(Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterSideTurnStart_003Ed__12))]
	public override extern Task AfterSideTurnStart(CombatSide side, CombatState combatState);

	[AsyncStateMachine(typeof(_003CAfterPowerAmountChanged_003Ed__13))]
	public override extern Task AfterPowerAmountChanged(PowerModel power, decimal _, Creature? __, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterRemoved_003Ed__14))]
	public override extern Task AfterRemoved(Creature oldOwner);

	[AsyncStateMachine(typeof(_003CAfterCreatureAddedToCombat_003Ed__15))]
	public override extern Task AfterCreatureAddedToCombat(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterOstyRevived_003Ed__16))]
	public override extern Task AfterOstyRevived(Creature osty);

	[AsyncStateMachine(typeof(_003CBeforeTurnEnd_003Ed__17))]
	public override extern Task BeforeTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern SandpitPower();
}
