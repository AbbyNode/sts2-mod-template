using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Screens;
using MegaCrit.Sts2.Core.Rewards;

namespace MegaCrit.Sts2.Core.Nodes.Rewards;

[ScriptPath("res://src/Core/Nodes/Rewards/NLinkedRewardSet.cs")]
public class NLinkedRewardSet : Control
{
	[Signal]
	public delegate void RewardClaimedEventHandler(NLinkedRewardSet linkedRewardSet);

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Reload;

		public static readonly StringName GetReward;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _rewardsScreen;

		public static readonly StringName _rewardContainer;

		public static readonly StringName _chainsContainer;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName RewardClaimed;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LinkedRewardSet LinkedRewardSet
	{
		[CompilerGenerated]
		get;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern event RewardClaimedEventHandler RewardClaimed;

	public override extern void _Ready();

	public static extern NLinkedRewardSet Create(LinkedRewardSet linkedReward, NRewardsScreen screen);

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

	protected extern void EmitSignalRewardClaimed(NLinkedRewardSet linkedRewardSet);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NLinkedRewardSet();
}
