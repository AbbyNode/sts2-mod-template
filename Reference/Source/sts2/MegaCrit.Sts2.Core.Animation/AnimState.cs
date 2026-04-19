using System;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Animation;

public class AnimState
{
	public const string attackAnim = "attack";

	public const string castAnim = "cast";

	public const string dieAnim = "die";

	public const string hurtAnim = "hurt";

	public const string idleAnim = "idle_loop";

	public const string reviveAnim = "revive";

	public const string stunAnim = "stun";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string Id
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsLooping
	{
		[CompilerGenerated]
		get;
	}

	public extern bool HasLooped
	{
		[CompilerGenerated]
		get;
	}

	public extern AnimState? NextState
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string? BoundsContainer
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern AnimState(string id, bool isLooping = false);

	public extern void AddBranch(string trigger, AnimState state, Func<bool>? condition = null);

	public extern AnimState? CallTrigger(string trigger);

	public extern bool HasTrigger(string trigger);

	public extern void MarkHasLooped();
}
