using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/GodotExtensions/NSlider.cs")]
public class NSlider : Range
{
	[Signal]
	public delegate void MouseReleasedEventHandler(InputEvent inputEvent);

	[Signal]
	public delegate void MousePressedEventHandler(InputEvent inputEvent);

	public new class MethodName : Range.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _GuiInput;

		public static readonly StringName SetValueBasedOnMousePosition;

		public static readonly StringName SetValueWithoutAnimation;

		public new static readonly StringName _Process;

		public static readonly StringName UpdateHandlePosition;

		public extern MethodName();
	}

	public new class PropertyName : Range.PropertyName
	{
		public static readonly StringName _handle;

		public static readonly StringName _currentHandlePosition;

		public static readonly StringName _currentVelocity;

		public static readonly StringName _isDragging;

		public extern PropertyName();
	}

	public new class SignalName : Range.SignalName
	{
		public static readonly StringName MouseReleased;

		public static readonly StringName MousePressed;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event MouseReleasedEventHandler MouseReleased;

	public extern event MousePressedEventHandler MousePressed;

	public override extern void _Ready();

	public override extern void _GuiInput(InputEvent inputEvent);

	public extern void SetValueWithoutAnimation(double value);

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

	protected extern void EmitSignalMousePressed(InputEvent inputEvent);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NSlider();
}
