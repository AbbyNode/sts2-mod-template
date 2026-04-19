using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class DieForYouPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldPlayVfx { get; }

	public override extern Creature ModifyUnblockedDamageTarget(Creature target, decimal _, ValueProp props, Creature? __);

	public override extern bool ShouldAllowHitting(Creature creature);

	public override extern bool ShouldCreatureBeRemovedFromCombatAfterDeath(Creature creature);

	public override extern bool ShouldPowerBeRemovedAfterOwnerDeath();

	public extern DieForYouPower();
}
