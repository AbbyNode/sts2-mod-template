using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class NemesisPower : PowerModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__5))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern NemesisPower();
}
