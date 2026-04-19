using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaEventData : MegaSpineBinding
{
	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	public extern MegaEventData(Variant native);

	public extern string GetEventName();
}
