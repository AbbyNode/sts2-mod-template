using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class CrimsonMantlePower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterPlayerTurnStart_003Ed__9))]
	public override extern Task AfterPlayerTurnStart(PlayerChoiceContext choiceContext, Player player);

	public extern void IncrementSelfDamage();

	public extern CrimsonMantlePower();
}
