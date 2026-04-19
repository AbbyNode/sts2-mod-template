using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class GalvanicPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CBeforeCombatStart_003Ed__8))]
	public override extern Task BeforeCombatStart();

	[AsyncStateMachine(typeof(_003CAfterCardEnteredCombat_003Ed__9))]
	public override extern Task AfterCardEnteredCombat(CardModel card);

	[AsyncStateMachine(typeof(_003CAfterCardPlayed_003Ed__10))]
	public override extern Task AfterCardPlayed(PlayerChoiceContext context, CardPlay cardPlay);

	public extern GalvanicPower();
}
