using MegaCrit.Sts2.Core.Runs.History;

namespace MegaCrit.Sts2.Core.Runs.Metrics;

public struct EventChoiceMetric
{
	public readonly string id;

	public readonly string picked;

	public extern EventChoiceMetric(MapPointHistoryEntry entry, ulong playerId);
}
