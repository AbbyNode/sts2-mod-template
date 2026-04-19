using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NSettingsTabManager.cs")]
public class NSettingsTabManager : Control
{
	[Signal]
	public delegate void TabChangedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ResetTabs;

		public static readonly StringName Enable;

		public static readonly StringName Disable;

		public static readonly StringName TabLeft;

		public static readonly StringName TabRight;

		public static readonly StringName SwitchTabTo;

		public static readonly StringName UpdateControllerButton;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName CurrentlyDisplayedPanel;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _currentTab;

		public static readonly StringName _scrollContainer;

		public static readonly StringName _leftTriggerIcon;

		public static readonly StringName _rightTriggerIcon;

		public static readonly StringName _scrollbarTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName TabChanged;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control? DefaultFocusedControl { get; }

	public extern event TabChangedEventHandler TabChanged;

	public override extern void _Ready();

	public extern void ResetTabs();

	public extern void Enable();

	public extern void Disable();

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

	protected extern void EmitSignalTabChanged();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NSettingsTabManager();
}
