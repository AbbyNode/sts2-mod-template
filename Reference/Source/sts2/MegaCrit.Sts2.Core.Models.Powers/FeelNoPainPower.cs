using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class FeelNoPainPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterCardExhausted_003Ed__6))]
	public override extern Task AfterCardExhausted(PlayerChoiceContext choiceContext, CardModel card, bool _);

	public extern FeelNoPainPower();
}
