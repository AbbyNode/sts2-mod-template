using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NControllerMapDrawingInput.cs")]
public class NControllerMapDrawingInput : NMapDrawingInput
{
	public new class MethodName : NMapDrawingInput.MethodName
	{
		public new static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public new static readonly StringName _Input;

		public extern MethodName();
	}

	public new class PropertyName : NMapDrawingInput.PropertyName
	{
		public static readonly StringName _eraserIconPos;

		public static readonly StringName _drawingIconPos;

		public static readonly StringName _isPressed;

		public static readonly StringName _cursorTex;

		public static readonly StringName _cursorTiltedTex;

		public static readonly StringName _cursor;

		public static readonly StringName _direction;

		public extern PropertyName();
	}

	public new class SignalName : NMapDrawingInput.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NMapDrawingInput Create();

	public override extern void _Ready();

	public override extern void _Process(double delta);

	public override extern void _Input(InputEvent input);

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

	public extern NControllerMapDrawingInput();
}
