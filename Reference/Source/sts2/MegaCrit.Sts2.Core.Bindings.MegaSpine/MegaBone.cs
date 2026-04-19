using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaBone : MegaSpineBinding
{
	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	public extern MegaBone(Variant native);

	public extern MegaBoneData GetData();

	public extern void SetRotation(float rotation);

	public extern void SetScaleX(float scaleX);

	public extern void SetScaleY(float scaleY);

	public extern void Hide();
}
