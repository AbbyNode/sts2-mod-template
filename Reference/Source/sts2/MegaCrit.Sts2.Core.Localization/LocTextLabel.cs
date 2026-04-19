using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Localization;

[ScriptPath("res://src/Core/Localization/LocTextLabel.cs")]
public class LocTextLabel : RichTextLabel
{
	public new class MethodName : RichTextLabel.MethodName
	{
		public static readonly StringName UpdateLocalization;

		public new static readonly StringName _Ready;

		public extern MethodName();
	}

	public new class PropertyName : RichTextLabel.PropertyName
	{
		public static readonly StringName LocalizationTable;

		public static readonly StringName LocalizationKey;

		public static readonly StringName _localizationTable;

		public static readonly StringName _localizationKey;

		public extern PropertyName();
	}

	public new class SignalName : RichTextLabel.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string? LocalizationTable { get; set; }

	public extern string? LocalizationKey { get; set; }

	public override extern void _Ready();

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

	public extern LocTextLabel();
}
