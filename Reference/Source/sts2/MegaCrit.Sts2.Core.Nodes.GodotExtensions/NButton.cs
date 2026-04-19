using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

[ScriptPath("res://src/Core/Nodes/GodotExtensions/NButton.cs")]
public class NButton : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignals;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _Input;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public static readonly StringName UpdateControllerButton;

		public static readonly StringName RegisterHotkeys;

		public static readonly StringName UnregisterHotkeys;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName ClickedSfx;

		public static readonly StringName HoveredSfx;

		public static readonly StringName Hotkeys;

		public static readonly StringName ControllerIconHotkey;

		public static readonly StringName HasControllerHotkey;

		public static readonly StringName _controllerHotkeyIcon;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	protected TextureRect? _controllerHotkeyIcon;

	protected virtual extern string? ClickedSfx { get; }

	protected virtual extern string HoveredSfx { get; }

	protected virtual extern string[] Hotkeys { get; }

	protected virtual extern string? ControllerIconHotkey { get; }

	public override extern void _Ready();

	protected override extern void ConnectSignals();

	public override extern void _EnterTree();

	public override extern void _Input(InputEvent inputEvent);

	protected override extern void OnPress();

	protected override extern void OnFocus();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	protected extern void UpdateControllerButton();

	protected extern void RegisterHotkeys();

	protected extern void UnregisterHotkeys();

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

	public extern NButton();
}
