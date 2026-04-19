using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaSkeleton : MegaSpineBinding
{
	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	public extern MegaSkeleton(Variant native);

	public extern MegaBone? FindBone(string boneName);

	public extern Rect2 GetBounds();

	public extern MegaSkeletonDataResource GetData();

	public extern void SetSkin(MegaSkin? skin);

	public extern void SetSkinByName(string skinName);

	public extern void SetSlotsToSetupPose();
}
