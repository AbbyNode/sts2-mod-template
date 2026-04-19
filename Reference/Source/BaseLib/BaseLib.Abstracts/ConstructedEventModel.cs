using System;
using System.Collections.Generic;
using MegaCrit.Sts2.Core.Events;

namespace BaseLib.Abstracts;

public abstract class ConstructedEventModel : CustomEventModel
{
	protected override IReadOnlyList<EventOption> GenerateInitialOptions()
	{
		throw new NotImplementedException();
	}
}
