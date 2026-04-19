using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

[ScriptPath("res://src/Core/Nodes/GodotExtensions/NMegaLineEdit.cs")]
public class NMegaLineEdit : LineEdit
{
	public new class MethodName : LineEdit.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _GuiInput;

		public static readonly StringName OpenKeyboard;

		public extern MethodName();
	}

	public new class PropertyName : LineEdit.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : LineEdit.SignalName
	{
		public extern SignalName();
	}

	public override extern void _Ready();

	public override extern void _GuiInput(InputEvent inputEvent);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NMegaLineEdit();
}
