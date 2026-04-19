using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class TenderPower : PowerModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int DisplayAmount { get; }

	[AsyncStateMachine(typeof(_003CAfterCardPlayed_003Ed__12))]
	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__13))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern TenderPower();
}
