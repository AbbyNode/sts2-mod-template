using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.addons.mega_text;

namespace MegaCrit.Sts2.Core.Nodes.GodotExtensions;

[ScriptPath("res://src/Core/Nodes/GodotExtensions/NDropdown.cs")]
public class NDropdown : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignals;

		public static readonly StringName OnVisibilityChange;

		public static readonly StringName ClearDropdownItems;

		public new static readonly StringName _Input;

		public static readonly StringName OnDismisserClicked;

		public new static readonly StringName OnRelease;

		public static readonly StringName OpenDropdown;

		public static readonly StringName CloseDropdown;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName _dropdownContainer;

		public static readonly StringName _dropdownItems;

		public static readonly StringName _dismisser;

		public static readonly StringName _currentOptionLabel;

		public static readonly StringName _currentOptionHighlight;

		public new static readonly StringName _isHovered;

		public static readonly StringName _isOpen;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	protected Control _dropdownItems;

	protected MegaLabel _currentOptionLabel;

	protected Control _currentOptionHighlight;

	public override extern void _Ready();

	protected override extern void ConnectSignals();

	protected extern void ClearDropdownItems();

	public override extern void _Input(InputEvent inputEvent);

	protected override extern void OnRelease();

	protected extern void CloseDropdown();

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

	public extern NDropdown();
}
