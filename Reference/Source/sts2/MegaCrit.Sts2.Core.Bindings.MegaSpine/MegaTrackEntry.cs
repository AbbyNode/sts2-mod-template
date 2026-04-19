using System.Collections.Generic;
using Godot;

namespace MegaCrit.Sts2.Core.Bindings.MegaSpine;

public class MegaTrackEntry : MegaSpineBinding
{
	protected override extern string SpineClassName { get; }

	protected override extern IEnumerable<string> SpineMethods { get; }

	public extern MegaTrackEntry(Variant native);

	public extern MegaAnimation GetAnimation();

	public extern float GetAnimationEnd();

	public extern float GetTrackComplete();

	public extern float GetTrackTime();

	public extern bool IsComplete();

	public extern void SetLoop(bool loop);

	public extern void SetTimeScale(float scale);

	public extern void SetTrackTime(float time);

	public extern void SetMixDuration(float time);
}
