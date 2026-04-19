using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Runs;

public static class ScoreUtility
{
	public const int clientScore = -99999;

	public static extern int CalculateScore(IRunState runState, bool won);

	public static extern int CalculateScore(SerializableRun run, bool won);
}
