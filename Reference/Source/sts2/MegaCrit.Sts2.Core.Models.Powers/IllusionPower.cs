using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class IllusionPower : PowerModel
{
	public const string stunTrigger = "StunTrigger";

	public const string wakeUpTrigger = "WakeUpTrigger";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldPlayVfx { get; }

	public extern string? FollowUpStateId { get; set; }

	public extern bool IsReviving { get; }

	public override extern bool ShouldPowerBeRemovedOnDeath(PowerModel power);

	public override extern Task AfterApplied(Creature? applier, CardModel? cardSource);

	[AsyncStateMachine(typeof(_003CAfterDeath_003Ed__18))]
	public override extern Task AfterDeath(PlayerChoiceContext choiceContext, Creature creature, bool wasRemovalPrevented, float deathAnimLength);

	public override extern bool ShouldAllowHitting(Creature creature);

	public override extern bool ShouldCreatureBeRemovedFromCombatAfterDeath(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterCombatEnd_003Ed__21))]
	public override extern Task AfterCombatEnd(CombatRoom room);

	public extern IllusionPower();
}
