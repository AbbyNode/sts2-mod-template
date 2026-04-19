using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.addons.mega_text;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NDropdownItem.cs")]
public class NDropdownItem : NButton
{
	[Signal]
	public delegate void SelectedEventHandler(NDropdownItem cardHolder);

	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnRelease;

		public static readonly StringName UnhoverSelection;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName Text;

		public static readonly StringName _highlight;

		public static readonly StringName _label;

		public static readonly StringName _richLabel;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public static readonly StringName Selected;

		public extern SignalName();
	}

	protected MegaLabel _label;

	protected MegaRichTextLabel? _richLabel;

	public extern string Text { get; set; }

	public extern event SelectedEventHandler Selected;

	public override extern void _Ready();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	protected sealed override extern void OnRelease();

	public extern void UnhoverSelection();

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

	protected extern void EmitSignalSelected(NDropdownItem cardHolder);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NDropdownItem();
}
