using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class UnrestSite : EventModel
{
	public override extern bool IsAllowed(RunState runState);

	public override extern void CalculateVars();

	public extern UnrestSite();
}
