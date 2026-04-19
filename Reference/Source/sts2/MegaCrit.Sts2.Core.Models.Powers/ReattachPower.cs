using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class ReattachPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldScaleInMultiplayer { get; }

	[AsyncStateMachine(typeof(_003CDoReattach_003Ed__10))]
	public extern Task DoReattach();

	[AsyncStateMachine(typeof(_003CAfterDeath_003Ed__11))]
	public override extern Task AfterDeath(PlayerChoiceContext choiceContext, Creature creature, bool wasRemovalPrevented, float deathAnimLength);

	public override extern bool ShouldAllowHitting(Creature creature);

	public override extern bool ShouldCreatureBeRemovedFromCombatAfterDeath(Creature creature);

	public override extern bool ShouldPowerBeRemovedAfterOwnerDeath();

	public override extern bool ShouldOwnerDeathTriggerFatal();

	public extern ReattachPower();
}
