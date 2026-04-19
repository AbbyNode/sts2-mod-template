using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class CorrosiveWavePower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterCardDrawn_003Ed__6))]
	public override extern Task AfterCardDrawn(PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__7))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern CorrosiveWavePower();
}
