using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.addons.mega_text;

[Tool]
[ScriptPath("res://addons/mega_text/MegaLabel.cs")]
public class MegaLabel : Label
{
	public new class MethodName : Label.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RefreshFont;

		public new static readonly StringName _Notification;

		public static readonly StringName SetTextAutoSize;

		public static readonly StringName SetFontSize;

		public static readonly StringName AdjustFontSize;

		public extern MethodName();
	}

	public new class PropertyName : Label.PropertyName
	{
		public static readonly StringName AutoSizeEnabled;

		public static readonly StringName MinFontSize;

		public static readonly StringName MaxFontSize;

		public static readonly StringName _autoSizeEnabled;

		public static readonly StringName _minFontSize;

		public static readonly StringName _maxFontSize;

		public static readonly StringName _lastSetSize;

		public static readonly StringName _lastAdjustedSize;

		public extern PropertyName();
	}

	public new class SignalName : Label.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	[Export(PropertyHint.None, "")]
	public extern bool AutoSizeEnabled { get; set; }

	[Export(PropertyHint.None, "")]
	public extern int MinFontSize { get; set; }

	[Export(PropertyHint.None, "")]
	public extern int MaxFontSize { get; set; }

	public override extern void _Ready();

	public extern void RefreshFont();

	public override extern void _Notification(int what);

	public extern void SetTextAutoSize(string text);

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

	public extern MegaLabel();
}
