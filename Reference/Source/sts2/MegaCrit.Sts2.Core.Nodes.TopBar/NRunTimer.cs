using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.TopBar;

[ScriptPath("res://src/Core/Nodes/TopBar/NRunTimer.cs")]
public class NRunTimer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName DeferredInit;

		public new static readonly StringName _ExitTree;

		public static readonly StringName RefreshVisibility;

		public static readonly StringName ToggleTimer;

		public static readonly StringName OnTimerTimeout;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _timerLabel;

		public static readonly StringName _timer;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void RefreshVisibility();

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

	public extern NRunTimer();
}
