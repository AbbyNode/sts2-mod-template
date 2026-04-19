using System;
using MegaCrit.Sts2.Core.Bindings.MegaSpine;

namespace MegaCrit.Sts2.Core.Animation;

public class CreatureAnimator
{
	public const string idleTrigger = "Idle";

	public const string attackTrigger = "Attack";

	public const string castTrigger = "Cast";

	public const string deathTrigger = "Dead";

	public const string hitTrigger = "Hit";

	public const string reviveTrigger = "Revive";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event Action<string>? BoundsUpdated;

	public extern CreatureAnimator(AnimState initialState, MegaSprite spineController);

	public extern void AddAnyState(string trigger, AnimState state, Func<bool>? condition = null);

	public extern void SetTrigger(string trigger);

	public extern bool HasTrigger(string trigger);
}
