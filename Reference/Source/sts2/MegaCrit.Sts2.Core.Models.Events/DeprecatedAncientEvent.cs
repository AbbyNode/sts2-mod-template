using System.Collections.Generic;
using MegaCrit.Sts2.Core.Events;

namespace MegaCrit.Sts2.Core.Models.Events;

public sealed class DeprecatedAncientEvent : AncientEventModel
{
	public override extern IEnumerable<EventOption> AllPossibleOptions { get; }

	public extern DeprecatedAncientEvent();
}
