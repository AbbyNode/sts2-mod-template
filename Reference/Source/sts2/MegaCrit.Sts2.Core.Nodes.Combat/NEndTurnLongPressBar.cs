using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NEndTurnLongPressBar.cs")]
public class NEndTurnLongPressBar : ColorRect
{
	public new class MethodName : ColorRect.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Init;

		public static readonly StringName StartPress;

		public static readonly StringName CancelPress;

		public new static readonly StringName _Process;

		public static readonly StringName RecalculateBar;

		public extern MethodName();
	}

	public new class PropertyName : ColorRect.PropertyName
	{
		public static readonly StringName _outline;

		public static readonly StringName _pressTimer;

		public static readonly StringName _isPressed;

		public static readonly StringName _endTurnButton;

		public static readonly StringName _tween;

		public static readonly StringName _enabled;

		public extern PropertyName();
	}

	public new class SignalName : ColorRect.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void Init(NEndTurnButton endTurnButton);

	public extern void StartPress();

	public extern void CancelPress();

	public override extern void _Process(double delta);

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

	public extern NEndTurnLongPressBar();
}
