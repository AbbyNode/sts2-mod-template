using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.CommonUi;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NLanguageDropdownItem.cs")]
public class NLanguageDropdownItem : NDropdownItem
{
	public new class MethodName : NDropdownItem.MethodName
	{
		public static readonly StringName Init;

		public extern MethodName();
	}

	public new class PropertyName : NDropdownItem.PropertyName
	{
		public static readonly StringName LanguageCode;

		public extern PropertyName();
	}

	public new class SignalName : NDropdownItem.SignalName
	{
		public extern SignalName();
	}

	public const string languageWarningIconPath = "res://images/ui/language_warning.png";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string LanguageCode
	{
		[CompilerGenerated]
		get;
	}

	public extern void Init(string languageCode);

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

	public extern NLanguageDropdownItem();
}
