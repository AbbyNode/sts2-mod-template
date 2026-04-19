using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

[ScriptPath("res://src/Core/Nodes/GodotExtensions/NMegaTextEdit.cs")]
public class NMegaTextEdit : TextEdit
{
	public new class MethodName : TextEdit.MethodName
	{
		public static readonly StringName IsEditing;

		public new static readonly StringName _Ready;

		public static readonly StringName RefreshFont;

		public static readonly StringName OnFocus;

		public static readonly StringName OnUnfocus;

		public new static readonly StringName _GuiInput;

		public static readonly StringName OpenKeyboard;

		public static readonly StringName StopEditing;

		public extern MethodName();
	}

	public new class PropertyName : TextEdit.PropertyName
	{
		public static readonly StringName _selectionReticle;

		public static readonly StringName _isEditing;

		public extern PropertyName();
	}

	public new class SignalName : TextEdit.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsEditing();

	public override extern void _Ready();

	public extern void RefreshFont();

	public override extern void _GuiInput(InputEvent inputEvent);

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

	public extern NMegaTextEdit();
}
