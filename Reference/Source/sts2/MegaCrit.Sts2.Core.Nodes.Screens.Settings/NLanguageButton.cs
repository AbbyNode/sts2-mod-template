using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NLanguageButton.cs")]
public class NLanguageButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Init;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public static readonly StringName SetAsSelected;

		public static readonly StringName SetAsDeselected;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName IsSelected;

		public static readonly StringName _image;

		public static readonly StringName _outline;

		public static readonly StringName _flag;

		public static readonly StringName _label;

		public static readonly StringName _tween;

		public static readonly StringName isoCode;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	public string isoCode;

	public extern bool IsSelected
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public extern void Init(string languageIsoCode);

	protected override extern void OnRelease();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	public extern void SetAsSelected();

	public extern void SetAsDeselected();

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

	public extern NLanguageButton();
}
