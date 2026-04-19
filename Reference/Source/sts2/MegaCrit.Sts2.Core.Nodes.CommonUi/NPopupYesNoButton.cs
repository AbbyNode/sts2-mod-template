using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NPopupYesNoButton.cs")]
public class NPopupYesNoButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName DisconnectHotkeys;

		public static readonly StringName SetText;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnRelease;

		public static readonly StringName UpdateShaderS;

		public static readonly StringName UpdateShaderV;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName IsYes;

		public new static readonly StringName Hotkeys;

		public static readonly StringName _visuals;

		public static readonly StringName _outline;

		public static readonly StringName _image;

		public static readonly StringName _label;

		public static readonly StringName _tween;

		public static readonly StringName _baseS;

		public static readonly StringName _baseV;

		public static readonly StringName _hsv;

		public static readonly StringName _outlineMaterial;

		public static readonly StringName _isFocused;

		public static readonly StringName _isYes;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsYes { get; set; }

	protected override extern string[] Hotkeys { get; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void DisconnectHotkeys();

	public extern void SetText(string text);

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	protected override extern void OnRelease();

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

	public extern NPopupYesNoButton();
}
