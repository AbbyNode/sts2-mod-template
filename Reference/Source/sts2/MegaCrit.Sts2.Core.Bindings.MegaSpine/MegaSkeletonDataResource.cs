using System.Collections.Generic;
using Godot;
using Godot.Collections;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaSkeletonDataResource : MegaSpineBinding
{
	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	public extern MegaSkeletonDataResource(Variant native);

	public extern MegaSkin? FindSkin(string skinName);

	public extern MegaAnimation? FindAnimation(string animName);

	public extern Array<GodotObject> GetAnimations();

	public extern Array<GodotObject> GetSkins();
}
