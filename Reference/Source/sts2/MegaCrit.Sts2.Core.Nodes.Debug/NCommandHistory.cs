using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Debug;

[ScriptPath("res://src/Core/Nodes/Debug/NCommandHistory.cs")]
public class NCommandHistory : Panel
{
	public new class MethodName : Panel.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Input;

		public static readonly StringName SetBackgroundColor;

		public static readonly StringName ShowConsole;

		public static readonly StringName HideConsole;

		public static readonly StringName GetHistory;

		public static readonly StringName Refresh;

		public static readonly StringName GetText;

		public extern MethodName();
	}

	public new class PropertyName : Panel.PropertyName
	{
		public static readonly StringName _outputBuffer;

		public extern PropertyName();
	}

	public new class SignalName : Panel.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public override extern void _Input(InputEvent inputEvent);

	public extern void SetBackgroundColor(Color color);

	public extern void ShowConsole();

	public extern void HideConsole();

	public static extern string GetHistory();

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

	public extern NCommandHistory();
}
