using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NSfxVolumeSlider.cs")]
public class NSfxVolumeSlider : NSettingsSlider
{
	public new class MethodName : NSettingsSlider.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnValueChanged;

		public static readonly StringName OnDragEnded;

		public extern MethodName();
	}

	public new class PropertyName : NSettingsSlider.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NSettingsSlider.SignalName
	{
		public extern SignalName();
	}

	public override extern void _Ready();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NSfxVolumeSlider();
}
