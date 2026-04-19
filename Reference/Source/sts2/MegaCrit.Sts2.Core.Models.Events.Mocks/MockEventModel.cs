using System.Collections.Generic;
using MegaCrit.Sts2.Core.Events;

namespace MegaCrit.Sts2.Core.Models.Events.Mocks;

public class MockEventModel : EventModel
{
	public bool isShared;

	public int? optionChosen;

	public List<EventOption>? initialOptions;

	public override extern bool IsShared { get; }

	public extern string OptionKey { get; }

	protected override extern IReadOnlyList<EventOption> GenerateInitialOptions();

	public extern void SetEventState(IEnumerable<EventOption> options);

	public extern void SetEventFinished();

	public extern MockEventModel();
}
