using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Multiplayer.Connection;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;

namespace MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

[ScriptPath("res://src/Core/Nodes/Screens/MainMenu/NMainMenu.cs")]
public class NMainMenu : Control, IScreenContext
{
	public new class MethodName : Control.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName ConnectMainMenuTextButtonFocusLogic;

		public static readonly StringName MainMenuButtonFocused;

		public static readonly StringName MainMenuButtonUnfocused;

		public static readonly StringName EnableBackstop;

		public static readonly StringName DisableBackstop;

		public static readonly StringName DisableBackstopInstantly;

		public static readonly StringName EnableBackstopInstantly;

		public static readonly StringName UpdateShaderMix;

		public static readonly StringName UpdateShaderLod;

		public static readonly StringName RefreshButtons;

		public static readonly StringName UpdateTimelineButtonBehavior;

		public static readonly StringName OnSubmenuStackChanged;

		public static readonly StringName OnContinueButtonPressed;

		public static readonly StringName DisplayLoadSaveError;

		public static readonly StringName OnAbandonRunButtonPressed;

		public static readonly StringName AbandonRun;

		public static readonly StringName SingleplayerButtonPressed;

		public static readonly StringName OpenSingleplayerSubmenu;

		public static readonly StringName OpenMultiplayerSubmenu;

		public static readonly StringName OpenCompendiumSubmenu;

		public static readonly StringName OpenTimelineScreen;

		public static readonly StringName OpenSettingsMenu;

		public static readonly StringName OpenProfileScreen;

		public static readonly StringName OpenPatchNotes;

		public static readonly StringName Quit;

		public static readonly StringName OnWindowChange;

		public static readonly StringName CheckCommandLineArgs;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName PatchNotesScreen;

		public static readonly StringName BlurBackstop;

		public static readonly StringName MainMenuButtons;

		public static readonly StringName SubmenuStack;

		public static readonly StringName ContinueRunInfo;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _window;

		public static readonly StringName _continueButton;

		public static readonly StringName _abandonRunButton;

		public static readonly StringName _singleplayerButton;

		public static readonly StringName _compendiumButton;

		public static readonly StringName _timelineButton;

		public static readonly StringName _settingsButton;

		public static readonly StringName _quitButton;

		public static readonly StringName _multiplayerButton;

		public static readonly StringName _buttonReticleLeft;

		public static readonly StringName _buttonReticleRight;

		public static readonly StringName _reticleTween;

		public static readonly StringName _patchNotesButtonNode;

		public static readonly StringName _openProfileScreenButton;

		public static readonly StringName _lastHitButton;

		public static readonly StringName _runInfo;

		public static readonly StringName _timelineNotificationDot;

		public static readonly StringName _backstopTween;

		public static readonly StringName _bg;

		public static readonly StringName _blur;

		public static readonly StringName _openTimeline;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern NPatchNotesScreen PatchNotesScreen
	{
		[CompilerGenerated]
		get;
	}

	public extern Control BlurBackstop
	{
		[CompilerGenerated]
		get;
	}

	public extern NMainMenuSubmenuStack SubmenuStack
	{
		[CompilerGenerated]
		get;
	}

	public extern NContinueRunInfo ContinueRunInfo { get; }

	public extern Control DefaultFocusedControl { get; }

	public static extern NMainMenu Create(bool openTimeline);

	public override extern void _Ready();

	public extern void EnableBackstop();

	public extern void DisableBackstop();

	public extern void DisableBackstopInstantly();

	public extern void EnableBackstopInstantly();

	public extern void RefreshButtons();

	public extern void AbandonRun();

	public extern NSingleplayerSubmenu OpenSingleplayerSubmenu();

	public extern void OpenMultiplayerSubmenu(NButton _);

	public extern NMultiplayerSubmenu OpenMultiplayerSubmenu();

	public extern void OpenProfileScreen();

	public extern void OpenSettingsMenu();

	[AsyncStateMachine(typeof(_003CJoinGame_003Ed__78))]
	public extern Task JoinGame(IClientConnectionInitializer connInitializer);

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

	public extern NMainMenu();
}
