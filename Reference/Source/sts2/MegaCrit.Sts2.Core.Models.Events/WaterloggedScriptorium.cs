using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class WaterloggedScriptorium : EventModel
{
	public override extern bool IsAllowed(RunState runState);

	public extern WaterloggedScriptorium();
}
