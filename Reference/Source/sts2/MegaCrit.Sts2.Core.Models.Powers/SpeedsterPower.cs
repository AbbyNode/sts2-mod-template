using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SpeedsterPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterCardDrawn_003Ed__4))]
	public override extern Task AfterCardDrawn(PlayerChoiceContext choiceContext, CardModel card, bool fromHandDraw);

	public extern SpeedsterPower();
}
