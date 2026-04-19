using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NInputManager.cs")]
public class NInputManager : Node
{
	[Signal]
	public delegate void InputReboundEventHandler();

	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _EnterTree;

		public new static readonly StringName _Ready;

		public new static readonly StringName _UnhandledKeyInput;

		public static readonly StringName ProcessDebugKeyInput;

		public static readonly StringName ProcessShortcutKeyInput;

		public new static readonly StringName _UnhandledInput;

		public static readonly StringName GetShortcutKey;

		public static readonly StringName GetHotkeyIcon;

		public static readonly StringName ModifyShortcutKey;

		public static readonly StringName ModifyControllerButton;

		public static readonly StringName ResetToDefaults;

		public static readonly StringName ResetToDefaultControllerMapping;

		public static readonly StringName OnControllerTypeChanged;

		public static readonly StringName SaveControllerInputMapping;

		public static readonly StringName SaveKeyboardInputMapping;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName ControllerManager;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public static readonly StringName InputRebound;

		public extern SignalName();
	}

	public static readonly IReadOnlyList<StringName> remappableKeyboardInputs;

	public static readonly IReadOnlyList<StringName> remappableControllerInputs;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NInputManager? Instance { get; }

	public extern NControllerManager ControllerManager
	{
		[CompilerGenerated]
		get;
	}

	public extern event InputReboundEventHandler InputRebound;

	public override extern void _EnterTree();

	public override extern void _Ready();

	public override extern void _UnhandledKeyInput(InputEvent inputEvent);

	public override extern void _UnhandledInput(InputEvent inputEvent);

	public extern Key GetShortcutKey(StringName input);

	public extern Texture2D? GetHotkeyIcon(string hotkey);

	public extern void ModifyShortcutKey(StringName input, Key shortcutKey);

	public extern void ModifyControllerButton(StringName input, StringName controllerInput);

	public extern void ResetToDefaults();

	public extern void ResetToDefaultControllerMapping();

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

	protected extern void EmitSignalInputRebound();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NInputManager();
}
