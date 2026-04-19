using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class BurstPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int ModifyCardPlayCount(CardModel card, Creature? target, int playCount);

	[AsyncStateMachine(typeof(_003CAfterModifyingCardPlayCount_003Ed__5))]
	public override extern Task AfterModifyingCardPlayCount(CardModel card);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__6))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern BurstPower();
}
