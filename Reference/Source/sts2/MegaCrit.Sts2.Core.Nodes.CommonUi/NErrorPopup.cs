using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NErrorPopup.cs")]
public class NErrorPopup : NVerticalPopup, IScreenContext
{
	public new class MethodName : NVerticalPopup.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Create;

		public static readonly StringName OnOkButtonPressed;

		public static readonly StringName OnCancelButtonPressed;

		public static readonly StringName OnReportBugButtonPressed;

		public extern MethodName();
	}

	public new class PropertyName : NVerticalPopup.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _verticalPopup;

		public static readonly StringName _title;

		public static readonly StringName _body;

		public static readonly StringName _showReportBugButton;

		public extern PropertyName();
	}

	public new class SignalName : NVerticalPopup.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control? DefaultFocusedControl { get; }

	public new static extern IEnumerable<string> AssetPaths { get; }

	public override extern void _Ready();

	public static extern NErrorPopup? Create(NetErrorInfo info);

	public static extern NErrorPopup? Create(LocString title, LocString body, LocString? cancel, bool showReportBugButton);

	public static extern NErrorPopup? Create(string title, string body, bool showReportBugButton);

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

	public extern NErrorPopup();
}
