namespace MegaCrit.Sts2.Core.Models;

public abstract class AchievementModel : AbstractModel
{
	public override extern bool ShouldReceiveCombatHooks { get; }

	protected extern AchievementModel();
}
