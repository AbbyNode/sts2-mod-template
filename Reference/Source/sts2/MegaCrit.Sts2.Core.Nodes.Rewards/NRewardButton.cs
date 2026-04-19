using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Screens;
using MegaCrit.Sts2.Core.Rewards;

namespace MegaCrit.Sts2.Core.Nodes.Rewards;

[ScriptPath("res://src/Core/Nodes/Rewards/NRewardButton.cs")]
public class NRewardButton : NButton
{
	[Signal]
	public delegate void RewardClaimedEventHandler(NRewardButton button);

	[Signal]
	public delegate void RewardSkippedEventHandler(NRewardButton button);

	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Reload;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName UpdateShaderParam;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName _background;

		public static readonly StringName _iconContainer;

		public static readonly StringName _label;

		public static readonly StringName _reticle;

		public static readonly StringName _hsv;

		public static readonly StringName _currentTween;

		public static readonly StringName _hsvDefault;

		public static readonly StringName _hsvHover;

		public static readonly StringName _hsvDown;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public static readonly StringName RewardClaimed;

		public static readonly StringName RewardSkipped;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Reward? Reward
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern event RewardClaimedEventHandler RewardClaimed;

	public extern event RewardSkippedEventHandler RewardSkipped;

	public static extern NRewardButton Create(Reward reward, NRewardsScreen screen);

	public override extern void _Ready();

	protected override extern void OnRelease();

	protected override extern void OnPress();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool SetGodotClassPropertyValue(in godot_string_name name, in godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	protected extern void EmitSignalRewardClaimed(NRewardButton button);

	protected extern void EmitSignalRewardSkipped(NRewardButton button);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NRewardButton();
}
