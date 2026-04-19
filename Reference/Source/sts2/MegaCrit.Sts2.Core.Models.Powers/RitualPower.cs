using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class RitualPower : PowerModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern Task AfterApplied(Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__11))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern RitualPower();
}
