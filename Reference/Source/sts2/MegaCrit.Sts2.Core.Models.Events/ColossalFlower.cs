using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class ColossalFlower : EventModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool IsAllowed(RunState runState);

	public extern ColossalFlower();
}
