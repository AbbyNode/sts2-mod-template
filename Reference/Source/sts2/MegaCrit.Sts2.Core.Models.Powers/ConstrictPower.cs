using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class ConstrictPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterTurnEnd_003Ed__4))]
	public override extern Task AfterTurnEnd(PlayerChoiceContext choiceContext, CombatSide side);

	[AsyncStateMachine(typeof(_003CAfterDeath_003Ed__5))]
	public override extern Task AfterDeath(PlayerChoiceContext choiceContext, Creature creature, bool wasRemovalPrevented, float deathAnimLength);

	public extern ConstrictPower();
}
