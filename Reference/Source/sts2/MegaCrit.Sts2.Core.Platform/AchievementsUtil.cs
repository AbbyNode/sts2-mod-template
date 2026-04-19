using System;
using MegaCrit.Sts2.Core.Achievements;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Platform;

public static class AchievementsUtil
{
	public static extern event Action? AchievementsChanged;

	public static extern void Unlock(Achievement achievement, Player? localPlayer);

	public static extern void Revoke(Achievement achievement);

	public static extern bool IsUnlocked(Achievement achievement);

	public static extern int TotalAchievementCount();

	public static extern int UnlockedAchievementCount();
}
