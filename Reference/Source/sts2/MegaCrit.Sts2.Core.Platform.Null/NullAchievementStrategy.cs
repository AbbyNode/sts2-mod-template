using MegaCrit.Sts2.Core.Achievements;

namespace MegaCrit.Sts2.Core.Platform.Null;

public class NullAchievementStrategy : IAchievementStrategy
{
	public extern void Unlock(Achievement achievement);

	public extern void Revoke(Achievement achievement);

	public extern bool IsUnlocked(Achievement achievement);

	public extern NullAchievementStrategy();
}
