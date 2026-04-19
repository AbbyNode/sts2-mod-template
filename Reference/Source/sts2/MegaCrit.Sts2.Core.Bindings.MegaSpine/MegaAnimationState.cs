using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaAnimationState : MegaSpineBinding
{
	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	public extern MegaAnimationState(Variant native);

	public extern MegaTrackEntry AddAnimation(string animationName, float delay = 0f, bool loop = true, int trackId = 0);

	public extern void Apply(MegaSkeleton skeleton);

	public extern MegaTrackEntry GetCurrent(int trackIndex);

	public extern MegaTrackEntry? SetAnimation(string animationName, bool loop = true, int trackId = 0);

	public extern MegaTrackEntry? AddEmptyAnimation(int trackId = 0);

	public extern void SetTimeScale(float scale);

	public extern void Update(float delta);
}
