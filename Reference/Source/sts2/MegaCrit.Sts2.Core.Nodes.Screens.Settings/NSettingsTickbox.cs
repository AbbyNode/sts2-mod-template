using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.CommonUi;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NSettingsTickbox.cs")]
public class NSettingsTickbox : NTickbox
{
	public new class MethodName : NTickbox.MethodName
	{
		public new static readonly StringName ConnectSignals;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public extern MethodName();
	}

	public new class PropertyName : NTickbox.PropertyName
	{
		public static readonly StringName _settingsScreen;

		public static readonly StringName _selectionReticle;

		public extern PropertyName();
	}

	public new class SignalName : NTickbox.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern void ConnectSignals();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

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

	public extern NSettingsTickbox();
}
