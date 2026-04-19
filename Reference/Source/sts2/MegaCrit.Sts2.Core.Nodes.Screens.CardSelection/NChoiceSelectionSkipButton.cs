using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardSelection;

[ScriptPath("res://src/Core/Nodes/Screens/CardSelection/NChoiceSelectionSkipButton.cs")]
public class NChoiceSelectionSkipButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName AnimateIn;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public static readonly StringName UpdateShaderParam;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public new static readonly StringName Hotkeys;

		public static readonly StringName _image;

		public static readonly StringName _label;

		public static readonly StringName _optionName;

		public static readonly StringName _animInTween;

		public static readonly StringName _showPosition;

		public static readonly StringName _currentTween;

		public static readonly StringName _hsv;

		public static readonly StringName _hsvDefault;

		public static readonly StringName _hsvHover;

		public static readonly StringName _hsvDown;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string[] Hotkeys { get; }

	public override extern void _Ready();

	public extern void AnimateIn();

	protected override extern void OnPress();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

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

	public extern NChoiceSelectionSkipButton();
}
