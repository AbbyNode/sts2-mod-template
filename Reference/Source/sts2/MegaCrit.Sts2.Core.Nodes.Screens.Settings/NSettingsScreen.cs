using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Settings;

[ScriptPath("res://src/Core/Nodes/Screens/Settings/NSettingsScreen.cs")]
public class NSettingsScreen : NSubmenu
{
	[Signal]
	public delegate void SettingsClosedEventHandler();

	[Signal]
	public delegate void SettingsOpenedEventHandler();

	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName SetIsInRun;

		public new static readonly StringName _Ready;

		public static readonly StringName OnSettingsTabChanged;

		public static readonly StringName LocalizeLabels;

		public static readonly StringName OpenModdingScreen;

		public static readonly StringName OpenFeedbackScreen;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public new static readonly StringName OnSubmenuHidden;

		public new static readonly StringName OnSubmenuShown;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _settingsTabManager;

		public static readonly StringName _feedbackScreenButton;

		public static readonly StringName _moddingScreenButton;

		public static readonly StringName _toast;

		public static readonly StringName _isInRun;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public static readonly StringName SettingsClosed;

		public static readonly StringName SettingsOpened;

		public extern SignalName();
	}

	public static readonly Vector2 settingTipsOffset;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	protected override extern Control? InitialFocusedControl { get; }

	public extern event SettingsClosedEventHandler SettingsClosed;

	public extern event SettingsOpenedEventHandler SettingsOpened;

	public extern void SetIsInRun(bool isInRun);

	public override extern void _Ready();

	public extern void ShowToast(LocString locString);

	[AsyncStateMachine(typeof(_003COpenFeedbackScreen_003Ed__21))]
	public extern Task OpenFeedbackScreen();

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

	protected override extern void OnSubmenuHidden();

	protected override extern void OnSubmenuShown();

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

	protected extern void EmitSignalSettingsClosed();

	protected extern void EmitSignalSettingsOpened();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NSettingsScreen();
}
