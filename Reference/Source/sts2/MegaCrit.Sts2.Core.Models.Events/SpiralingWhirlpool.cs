using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class SpiralingWhirlpool : EventModel
{
	public override extern void CalculateVars();

	public override extern bool IsAllowed(RunState runState);

	public extern SpiralingWhirlpool();
}
