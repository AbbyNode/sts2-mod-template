using MegaCrit.Sts2.Core.Events;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class TheLanternKey : EventModel
{
	public override extern EventLayoutType LayoutType { get; }

	public override extern EncounterModel CanonicalEncounter { get; }

	public override extern bool IsShared { get; }

	public extern TheLanternKey();
}
