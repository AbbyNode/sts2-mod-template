using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NBackButton.cs")]
public class NBackButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnWindowChange;

		public static readonly StringName MoveToHidePosition;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public new static readonly StringName ClickedSfx;

		public new static readonly StringName Hotkeys;

		public new static readonly StringName ControllerIconHotkey;

		public static readonly StringName _outline;

		public static readonly StringName _buttonImage;

		public static readonly StringName _defaultOutlineColor;

		public static readonly StringName _hoveredOutlineColor;

		public static readonly StringName _downColor;

		public static readonly StringName _outlineColor;

		public static readonly StringName _outlineTransparentColor;

		public static readonly StringName _posOffset;

		public static readonly StringName _showPos;

		public static readonly StringName _hidePos;

		public static readonly StringName _hoverTween;

		public static readonly StringName _moveTween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string ClickedSfx { get; }

	protected override extern string[] Hotkeys { get; }

	protected override extern string ControllerIconHotkey { get; }

	public override extern void _Ready();

	public extern void MoveToHidePosition();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

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

	public extern NBackButton();
}
