using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class RingingPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterApplied_003Ed__4))]
	public override extern Task AfterApplied(Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterCardEnteredCombat_003Ed__5))]
	public override extern Task AfterCardEnteredCombat(CardModel card);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__6))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public override extern Task AfterRemoved(Creature oldOwner);

	public override extern bool ShouldPlay(CardModel card, AutoPlayType _);

	public extern RingingPower();
}
