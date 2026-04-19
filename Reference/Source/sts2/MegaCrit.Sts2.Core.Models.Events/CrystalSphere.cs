using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class CrystalSphere : EventModel
{
	public override extern bool IsDeterministic { get; }

	public override extern void CalculateVars();

	public override extern bool IsAllowed(RunState runState);

	public extern CrystalSphere();
}
