using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.CommonUi;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NResolutionDropdownItem.cs")]
public class NResolutionDropdownItem : NDropdownItem
{
	public new class MethodName : NDropdownItem.MethodName
	{
		public static readonly StringName Init;

		public extern MethodName();
	}

	public new class PropertyName : NDropdownItem.PropertyName
	{
		public static readonly StringName resolution;

		public extern PropertyName();
	}

	public new class SignalName : NDropdownItem.SignalName
	{
		public extern SignalName();
	}

	public Vector2I resolution;

	public extern void Init(Vector2I setResolution);

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

	public extern NResolutionDropdownItem();
}
