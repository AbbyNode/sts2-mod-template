using System.Collections.Generic;
using MegaCrit.Sts2.Core.Runs.History;

namespace MegaCrit.Sts2.Core.Runs.Metrics;

public struct CardChoiceMetric
{
	public readonly List<string> picked;

	public readonly List<string> skipped;

	public extern CardChoiceMetric(List<CardChoiceHistoryEntry> choices);
}
