using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.PauseMenu;

[ScriptPath("res://src/Core/Nodes/Screens/PauseMenu/NPauseMenu.cs")]
public class NPauseMenu : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RefreshLabels;

		public static readonly StringName OnBackOrResumeButtonPressed;

		public static readonly StringName OnSettingsButtonPressed;

		public static readonly StringName OnCompendiumButtonPressed;

		public static readonly StringName OnGiveUpButtonPressed;

		public static readonly StringName OnDisconnectButtonPressed;

		public static readonly StringName OnSaveAndQuitButtonPressed;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName Buttons;

		public static readonly StringName UseSharedBackstop;

		public static readonly StringName ScreenType;

		public new static readonly StringName _backButton;

		public static readonly StringName _buttonContainer;

		public static readonly StringName _resumeButton;

		public static readonly StringName _settingsButton;

		public static readonly StringName _compendiumButton;

		public static readonly StringName _giveUpButton;

		public static readonly StringName _disconnectButton;

		public static readonly StringName _saveAndQuitButton;

		public static readonly StringName _pausedLabel;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern Control InitialFocusedControl { get; }

	public extern bool UseSharedBackstop { get; }

	public extern NetScreenType ScreenType { get; }

	public override extern void _Ready();

	public extern void Initialize(IRunState runState);

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

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

	public extern NPauseMenu();
}
