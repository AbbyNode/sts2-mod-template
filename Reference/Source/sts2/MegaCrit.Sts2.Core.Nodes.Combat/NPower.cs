using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NPower.cs")]
public class NPower : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Reload;

		public static readonly StringName OnPulsingStarted;

		public static readonly StringName OnPulsingStopped;

		public static readonly StringName RefreshAmount;

		public static readonly StringName OnDisplayAmountChanged;

		public static readonly StringName FlashPower;

		public static readonly StringName OnHovered;

		public static readonly StringName OnUnhovered;

		public static readonly StringName SubscribeToModelEvents;

		public static readonly StringName UnsubscribeFromModelEvents;

		public static readonly StringName OnPowerRemoved;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName Container;

		public static readonly StringName _icon;

		public static readonly StringName _amountLabel;

		public static readonly StringName _powerFlash;

		public static readonly StringName _animInTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NPowerContainer Container
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern PowerModel Model { get; set; }

	public static extern NPower Create(PowerModel power);

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

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

	public extern NPower();
}
