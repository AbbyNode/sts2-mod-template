using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NSettingsTab.cs")]
public class NSettingsTab : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ForceTabPressed;

		public static readonly StringName Select;

		public static readonly StringName Deselect;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public static readonly StringName UpdateShaderParam;

		public static readonly StringName SetLabel;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName _isSelected;

		public static readonly StringName _outline;

		public static readonly StringName _image;

		public static readonly StringName _label;

		public static readonly StringName _hsv;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void ForceTabPressed();

	public extern void Select();

	public extern void Deselect();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	public extern void SetLabel(string text);

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

	public extern NSettingsTab();
}
