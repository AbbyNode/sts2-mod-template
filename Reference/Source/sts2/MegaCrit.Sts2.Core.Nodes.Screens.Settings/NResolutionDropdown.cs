using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NResolutionDropdown.cs")]
public class NResolutionDropdown : NSettingsDropdown
{
	public new class MethodName : NSettingsDropdown.MethodName
	{
		public new static readonly StringName _EnterTree;

		public new static readonly StringName _Ready;

		public static readonly StringName RefreshCurrentlySelectedResolution;

		public static readonly StringName PopulateDropdownItems;

		public static readonly StringName OnWindowChange;

		public static readonly StringName RefreshEnabled;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public static readonly StringName OnDropdownItemSelected;

		public static readonly StringName DoesResolutionFit;

		public extern MethodName();
	}

	public new class PropertyName : NSettingsDropdown.PropertyName
	{
		public static readonly StringName _dropdownItemScene;

		public static readonly StringName _arrow;

		public extern PropertyName();
	}

	public new class SignalName : NSettingsDropdown.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NResolutionDropdown? Instance
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _EnterTree();

	public override extern void _Ready();

	public extern void RefreshCurrentlySelectedResolution();

	public extern void PopulateDropdownItems();

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

	public extern NResolutionDropdown();
}
