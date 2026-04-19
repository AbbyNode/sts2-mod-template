using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Events;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class PunchOff : EventModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern EventLayoutType LayoutType { get; }

	public override extern EncounterModel CanonicalEncounter { get; }

	public override extern bool IsShared { get; }

	public override extern bool IsAllowed(RunState runState);

	public override extern Task AfterEventStarted();

	public override extern void CalculateVars();

	public extern PunchOff();
}
