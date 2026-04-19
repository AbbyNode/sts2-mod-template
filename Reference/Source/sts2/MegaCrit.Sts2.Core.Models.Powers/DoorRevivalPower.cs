using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class DoorRevivalPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public extern bool IsHalfDead { get; }

	public override extern Task BeforeDeath(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterDeath_003Ed__11))]
	public override extern Task AfterDeath(PlayerChoiceContext choiceContext, Creature creature, bool wasRemovalPrevented, float deathAnimLength);

	[AsyncStateMachine(typeof(_003CDoRevive_003Ed__12))]
	public extern Task DoRevive();

	public override extern bool ShouldAllowHitting(Creature creature);

	public override extern bool ShouldStopCombatFromEnding();

	public override extern bool ShouldCreatureBeRemovedFromCombatAfterDeath(Creature creature);

	public override extern bool ShouldPowerBeRemovedAfterOwnerDeath();

	public extern DoorRevivalPower();
}
