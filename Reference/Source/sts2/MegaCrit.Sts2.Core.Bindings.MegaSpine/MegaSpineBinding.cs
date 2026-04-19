using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public abstract class MegaSpineBinding
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern GodotObject BoundObject
	{
		[CompilerGenerated]
		get;
	}

	protected abstract string SpineClassName { get; }

	protected virtual extern IEnumerable<string> SpineMethods { get; }

	protected virtual extern IEnumerable<string> SpineSignals { get; }

	protected extern MegaSpineBinding(Variant native);

	protected extern Error Connect(string signalName, Callable callable);

	protected extern void Disconnect(string signalName, Callable callable);

	protected extern Variant Call(string methodName, params Variant[] args);

	protected extern Variant? CallNullable(string methodName, params Variant[] args);
}
