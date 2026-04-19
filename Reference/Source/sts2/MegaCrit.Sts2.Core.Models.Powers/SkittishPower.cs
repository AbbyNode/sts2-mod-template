using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands.Builders;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SkittishPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldScaleInMultiplayer { get; }

	public extern bool HasGainedBlockThisTurn { get; }

	[AsyncStateMachine(typeof(_003CAfterAttack_003Ed__15))]
	public override extern Task AfterAttack(AttackCommand command);

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__16))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	public extern SkittishPower();
}
