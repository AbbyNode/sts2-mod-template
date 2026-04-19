using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.ControllerInput;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NControllerManager.cs")]
public class NControllerManager : Node
{
	[Signal]
	public delegate void ControllerDetectedEventHandler();

	[Signal]
	public delegate void MouseDetectedEventHandler();

	[Signal]
	public delegate void ControllerTypeChangedEventHandler();

	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Process;

		public new static readonly StringName _Input;

		public static readonly StringName OnControllerTypeChanged;

		public static readonly StringName CheckForMouseInput;

		public static readonly StringName CheckForControllerInput;

		public static readonly StringName ControlModeChanged;

		public static readonly StringName OnScreenContextChanged;

		public static readonly StringName GetHotkeyIcon;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName ShouldAllowControllerRebinding;

		public static readonly StringName IsUsingController;

		public static readonly StringName ControllerMappingType;

		public static readonly StringName _lastMousePosition;

		public static readonly StringName _label;

		public static readonly StringName _notifyTween;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public static readonly StringName ControllerDetected;

		public static readonly StringName MouseDetected;

		public static readonly StringName ControllerTypeChanged;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NControllerManager? Instance { get; }

	public extern bool ShouldAllowControllerRebinding { get; }

	public extern bool IsUsingController
	{
		[CompilerGenerated]
		get;
	}

	public extern Dictionary<StringName, StringName> GetDefaultControllerInputMap { get; }

	public extern ControllerMappingType ControllerMappingType { get; }

	public extern event ControllerDetectedEventHandler ControllerDetected;

	public extern event MouseDetectedEventHandler MouseDetected;

	public extern event ControllerTypeChangedEventHandler ControllerTypeChanged;

	[AsyncStateMachine(typeof(_003CInit_003Ed__16))]
	public extern Task Init();

	public override extern void _ExitTree();

	public override extern void _Process(double delta);

	public override extern void _Input(InputEvent inputEvent);

	public extern void OnControllerTypeChanged();

	public extern Texture2D? GetHotkeyIcon(string hotkey);

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

	protected extern void EmitSignalControllerDetected();

	protected extern void EmitSignalMouseDetected();

	protected extern void EmitSignalControllerTypeChanged();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NControllerManager();
}
