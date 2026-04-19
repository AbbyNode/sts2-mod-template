using System.Collections.Generic;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class TheFutureOfPotions : EventModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern IEnumerable<LocString> GameInfoOptions { get; }

	public override extern bool IsAllowed(RunState runState);

	public extern TheFutureOfPotions();
}
