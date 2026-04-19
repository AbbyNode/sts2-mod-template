namespace MegaCrit.Sts2.Core.Runs.Metrics;

public struct ActWinMetric
{
	public readonly string act;

	public readonly bool win;

	public extern ActWinMetric(string actId, bool win);
}
