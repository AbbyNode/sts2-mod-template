using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class MinionPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldPlayVfx { get; }

	public override extern bool OwnerIsSecondaryEnemy { get; }

	public override extern bool ShouldPowerBeRemovedAfterOwnerDeath();

	public override extern bool ShouldOwnerDeathTriggerFatal();

	public extern MinionPower();
}
