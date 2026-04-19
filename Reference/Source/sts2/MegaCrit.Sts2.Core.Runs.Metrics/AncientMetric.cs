using System.Collections.Generic;
using MegaCrit.Sts2.Core.Runs.History;

namespace MegaCrit.Sts2.Core.Runs.Metrics;

public struct AncientMetric
{
	public readonly string picked;

	public readonly List<string> skipped;

	public extern AncientMetric(MapPointHistoryEntry entry, PlayerMapPointHistoryEntry playerEntry);
}
