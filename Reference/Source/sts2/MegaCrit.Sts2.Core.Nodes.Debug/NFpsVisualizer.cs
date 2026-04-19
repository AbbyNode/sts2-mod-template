using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Debug;

[ScriptPath("res://src/Core/Nodes/Debug/NFpsVisualizer.cs")]
public class NFpsVisualizer : TextureRect
{
	[Signal]
	public delegate void MouseReleasedEventHandler(InputEvent inputEvent);

	public new class MethodName : TextureRect.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName HandleMouseRelease;

		public new static readonly StringName _GuiInput;

		public new static readonly StringName _Process;

		public extern MethodName();
	}

	public new class PropertyName : TextureRect.PropertyName
	{
		public static readonly StringName _label;

		public static readonly StringName _happy;

		public static readonly StringName _content;

		public static readonly StringName _neutral;

		public static readonly StringName _sad;

		public extern PropertyName();
	}

	public new class SignalName : TextureRect.SignalName
	{
		public static readonly StringName MouseReleased;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event MouseReleasedEventHandler MouseReleased;

	public override extern void _Ready();

	public override extern void _GuiInput(InputEvent inputEvent);

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

	protected extern void EmitSignalMouseReleased(InputEvent inputEvent);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NFpsVisualizer();
}
