using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NOpenModdingScreenButton.cs")]
public class NOpenModdingScreenButton : NSettingsButton
{
	public new class MethodName : NSettingsButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public extern MethodName();
	}

	public new class PropertyName : NSettingsButton.PropertyName
	{
		public new static readonly StringName _image;

		public new static readonly StringName _label;

		public extern PropertyName();
	}

	public new class SignalName : NSettingsButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

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

	public extern NOpenModdingScreenButton();
}
