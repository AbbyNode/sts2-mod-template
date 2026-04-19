using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class RollingBoulderPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool IsInstanced { get; }

	[AsyncStateMachine(typeof(_003CAfterPlayerTurnStart_003Ed__8))]
	public override extern Task AfterPlayerTurnStart(PlayerChoiceContext choiceContext, Player player);

	public extern RollingBoulderPower();
}
