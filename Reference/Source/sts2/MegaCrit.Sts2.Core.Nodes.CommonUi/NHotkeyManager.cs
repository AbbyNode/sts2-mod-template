using System;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NHotkeyManager.cs")]
public class NHotkeyManager : Node
{
	public new class MethodName : Node.MethodName
	{
		public static readonly StringName AddBlockingScreen;

		public static readonly StringName RemoveBlockingScreen;

		public new static readonly StringName _UnhandledInput;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NHotkeyManager? Instance { get; }

	public extern void PushHotkeyPressedBinding(string hotkey, Action action);

	public extern void RemoveHotkeyPressedBinding(string hotkey, Action action);

	public extern void PushHotkeyReleasedBinding(string hotkey, Action action);

	public extern void RemoveHotkeyReleasedBinding(string hotkey, Action action);

	public extern void AddBlockingScreen(Node screen);

	public extern void RemoveBlockingScreen(Node screen);

	public override extern void _UnhandledInput(InputEvent inputEvent);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NHotkeyManager();
}
