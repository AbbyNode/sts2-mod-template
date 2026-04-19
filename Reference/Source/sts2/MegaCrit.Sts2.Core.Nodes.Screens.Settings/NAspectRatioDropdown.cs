using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NAspectRatioDropdown.cs")]
public class NAspectRatioDropdown : NSettingsDropdown, IResettableSettingNode
{
	public new class MethodName : NSettingsDropdown.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetFromSettings;

		public static readonly StringName AddDropdownItem;

		public static readonly StringName OnDropdownItemSelected;

		public static readonly StringName GetAspectRatioSettingString;

		public extern MethodName();
	}

	public new class PropertyName : NSettingsDropdown.PropertyName
	{
		public static readonly StringName _currentAspectRatioSetting;

		public extern PropertyName();
	}

	public new class SignalName : NSettingsDropdown.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern void _Ready();

	public extern void SetFromSettings();

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

	public extern NAspectRatioDropdown();
}
