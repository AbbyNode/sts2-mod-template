using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Achievements;

public static class AchievementsHelper
{
	public static extern void AfterRunEnded(RunState state, Player player, bool isVictory);

	public static extern void CheckTimelineComplete();

	public static extern void CheckForDefeatedAllEnemiesAchievement(ActModel act, Player localPlayer);

	public static extern void AfterBossDefeated(Player localPlayer);
}
