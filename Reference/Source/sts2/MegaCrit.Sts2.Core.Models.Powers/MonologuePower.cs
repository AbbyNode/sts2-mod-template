using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class MonologuePower : PowerModel
{
	public const string strengthAppliedKey = "StrengthApplied";

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int DisplayAmount { get; }

	public override extern bool IsInstanced { get; }

	public override extern Task BeforeCardPlayed(CardPlay cardPlay);

	[AsyncStateMachine(typeof(_003CAfterCardPlayed_003Ed__16))]
	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__17))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern MonologuePower();
}
