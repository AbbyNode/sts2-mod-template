using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NInputSettingsPanel.cs")]
public class NInputSettingsPanel : NSettingsPanel
{
	public new class MethodName : NSettingsPanel.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnViewportSizeChange;

		public new static readonly StringName OnVisibilityChange;

		public static readonly StringName SetAsListeningEntry;

		public new static readonly StringName _UnhandledKeyInput;

		public new static readonly StringName _Input;

		public extern MethodName();
	}

	public new class PropertyName : NSettingsPanel.PropertyName
	{
		public new static readonly StringName _minPadding;

		public static readonly StringName _listeningEntry;

		public static readonly StringName _resetToDefaultButton;

		public static readonly StringName _commandHeader;

		public static readonly StringName _keyboardHeader;

		public static readonly StringName _controllerHeader;

		public static readonly StringName _steamInputPrompt;

		public extern PropertyName();
	}

	public new class SignalName : NSettingsPanel.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	protected override extern void OnVisibilityChange();

	public override extern void _UnhandledKeyInput(InputEvent inputEvent);

	public override extern void _Input(InputEvent inputEvent);

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

	public extern NInputSettingsPanel();
}
