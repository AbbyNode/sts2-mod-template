using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Multiplayer;

[ScriptPath("res://src/Core/Nodes/Multiplayer/NMultiplayerWarningPopup.cs")]
public class NMultiplayerWarningPopup : NVerticalPopup, IScreenContext
{
	public new class MethodName : NVerticalPopup.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName OnBackButtonPressed;

		public static readonly StringName OnIgnoreButtonPressed;

		public extern MethodName();
	}

	public new class PropertyName : NVerticalPopup.PropertyName
	{
		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _verticalPopup;

		public extern PropertyName();
	}

	public new class SignalName : NVerticalPopup.SignalName
	{
		public extern SignalName();
	}

	public const string ftueId = "multiplayer_warning";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public new static extern IEnumerable<string> AssetPaths { get; }

	public extern Control? DefaultFocusedControl { get; }

	public static extern NMultiplayerWarningPopup? Create();

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

	public extern NMultiplayerWarningPopup();
}
