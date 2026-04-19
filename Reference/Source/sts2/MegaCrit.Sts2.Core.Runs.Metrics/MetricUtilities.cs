using MegaCrit.Sts2.Core.Achievements;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Runs.Metrics;

public static class MetricUtilities
{
	public static extern void UploadRunMetrics(SerializableRun run, bool isVictory, ulong localPlayerId);

	public static extern void UploadAchievementMetric(Achievement achievement);

	public static extern void UploadEpochMetric(string epochId);

	public static extern void UploadSettingsMetric();
}
