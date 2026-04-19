using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Map;

[ScriptPath("res://src/Core/Nodes/Screens/Map/NMouseHeldMapDrawingInput.cs")]
public class NMouseHeldMapDrawingInput : NMapDrawingInput
{
	public new class MethodName : NMapDrawingInput.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Input;

		public static readonly StringName ProcessMouseDrawingEvent;

		public extern MethodName();
	}

	public new class PropertyName : NMapDrawingInput.PropertyName
	{
		public static readonly StringName ListeningButton;

		public extern PropertyName();
	}

	public new class SignalName : NMapDrawingInput.SignalName
	{
		public extern SignalName();
	}

	public override extern void _Ready();

	public override extern void _Input(InputEvent inputEvent);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NMouseHeldMapDrawingInput();
}
