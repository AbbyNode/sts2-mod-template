using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NShortSubmenuButton.cs")]
public class NShortSubmenuButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public static readonly StringName GetImagePath;

		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignals;

		public static readonly StringName SetIconAndLocalization;

		public new static readonly StringName _Notification;

		public static readonly StringName RefreshLabels;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnRelease;

		public static readonly StringName UpdateShaderParam;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName _bgPanel;

		public static readonly StringName _icon;

		public static readonly StringName _title;

		public static readonly StringName _description;

		public static readonly StringName _locKeyPrefix;

		public static readonly StringName _hsv;

		public static readonly StringName _defaultV;

		public static readonly StringName _focusV;

		public static readonly StringName _pressV;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string? GetImagePath(string key);

	public override extern void _Ready();

	protected override extern void ConnectSignals();

	public extern void SetIconAndLocalization(string locKeyPrefix);

	public override extern void _Notification(int what);

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	protected override extern void OnRelease();

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

	public extern NShortSubmenuButton();
}
