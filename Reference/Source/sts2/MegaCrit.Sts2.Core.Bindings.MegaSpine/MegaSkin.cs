using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaSkin : MegaSpineBinding
{
	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	public extern MegaSkin(Variant native);

	public extern void AddSkin(MegaSkin? skin);
}
