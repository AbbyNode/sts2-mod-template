using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NPeekButton.cs")]
public class NPeekButton : NButton
{
	[Signal]
	public delegate void ToggledEventHandler(NPeekButton peekButton);

	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public static readonly StringName OnOverlayStackChanged;

		public static readonly StringName Wiggle;

		public static readonly StringName AddTargets;

		public static readonly StringName SetPeeking;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName OnCombatRoomReady;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public new static readonly StringName Hotkeys;

		public static readonly StringName IsPeeking;

		public static readonly StringName CurrentCardMarker;

		public static readonly StringName _flash;

		public static readonly StringName _visuals;

		public static readonly StringName _hoverTween;

		public static readonly StringName _wiggleTween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public static readonly StringName Toggled;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string[] Hotkeys { get; }

	public extern bool IsPeeking
	{
		[CompilerGenerated]
		get;
	}

	public extern Marker2D CurrentCardMarker
	{
		[CompilerGenerated]
		get;
	}

	public extern event ToggledEventHandler Toggled;

	public override extern void _Ready();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	public extern void Wiggle();

	public extern void AddTargets(params Control[] targets);

	public extern void SetPeeking(bool isPeeking);

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

	protected extern void EmitSignalToggled(NPeekButton peekButton);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NPeekButton();
}
