using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class StratagemPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterShuffle_003Ed__4))]
	public override extern Task AfterShuffle(PlayerChoiceContext choiceContext, Player player);

	public extern StratagemPower();
}
