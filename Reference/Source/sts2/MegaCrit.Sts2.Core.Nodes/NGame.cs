using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Audio.Debug;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Game.Lobby;
using MegaCrit.Sts2.Core.Nodes.Audio;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Nodes.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Reaction;
using MegaCrit.Sts2.Core.Nodes.Screens;
using MegaCrit.Sts2.Core.Nodes.Screens.FeedbackScreen;
using MegaCrit.Sts2.Core.Nodes.Screens.InspectScreens;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Nodes;

[ScriptPath("res://src/Core/Nodes/NGame.cs")]
public class NGame : Control
{
	[Signal]
	public delegate void WindowChangeEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _EnterTree;

		public new static readonly StringName _Ready;

		public static readonly StringName OnWindowChange;

		public static readonly StringName IsMainThread;

		public new static readonly StringName _ExitTree;

		public static readonly StringName IsReleaseGame;

		public static readonly StringName InitializeGraphicsPreferences;

		public static readonly StringName ApplyDisplaySettings;

		public static readonly StringName GetInspectRelicScreen;

		public static readonly StringName GetInspectCardScreen;

		public static readonly StringName ApplySyncSetting;

		public static readonly StringName Reset;

		public new static readonly StringName _Notification;

		public static readonly StringName Quit;

		public static readonly StringName Relocalize;

		public static readonly StringName ReloadMainMenu;

		public new static readonly StringName _Input;

		public static readonly StringName ToggleFullscreen;

		public static readonly StringName DebugModifyTimescale;

		public static readonly StringName ActivateWorldEnvironment;

		public static readonly StringName DeactivateWorldEnvironment;

		public static readonly StringName SetScreenShakeTarget;

		public static readonly StringName ClearScreenShakeTarget;

		public static readonly StringName ScreenShake;

		public static readonly StringName ScreenRumble;

		public static readonly StringName ScreenShakeTrauma;

		public static readonly StringName DoHitStop;

		public static readonly StringName ToggleTrailerMode;

		public static readonly StringName SetScreenshakeMultiplier;

		public static readonly StringName InitPools;

		public static readonly StringName CheckShowLocalizationOverrideErrors;

		public static readonly StringName LogResourceStats;

		public static readonly StringName FormatBytes;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName RootSceneContainer;

		public static readonly StringName HoverTipsContainer;

		public static readonly StringName MainMenu;

		public static readonly StringName CurrentRunNode;

		public static readonly StringName LogoAnimation;

		public static readonly StringName Transition;

		public static readonly StringName TimeoutOverlay;

		public static readonly StringName AudioManager;

		public static readonly StringName RemoteCursorContainer;

		public static readonly StringName InputManager;

		public static readonly StringName HotkeyManager;

		public static readonly StringName ReactionWheel;

		public static readonly StringName ReactionContainer;

		public static readonly StringName CursorManager;

		public static readonly StringName DebugAudio;

		public static readonly StringName DebugSeedOverride;

		public static readonly StringName StartOnMainMenu;

		public static readonly StringName InspectRelicScreen;

		public static readonly StringName InspectCardScreen;

		public static readonly StringName FeedbackScreen;

		public static readonly StringName WorldEnvironment;

		public static readonly StringName HitStop;

		public static readonly StringName _inspectionContainer;

		public static readonly StringName _screenShake;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName WindowChange;

		public extern SignalName();
	}

	public static readonly Vector2 devResolution;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NGame? Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern NSceneContainer RootSceneContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern Node? HoverTipsContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NMainMenu? MainMenu { get; }

	public extern NRun? CurrentRunNode { get; }

	public extern NLogoAnimation? LogoAnimation { get; }

	public extern NTransition Transition
	{
		[CompilerGenerated]
		get;
	}

	public extern NMultiplayerTimeoutOverlay TimeoutOverlay
	{
		[CompilerGenerated]
		get;
	}

	public extern NAudioManager AudioManager
	{
		[CompilerGenerated]
		get;
	}

	public extern NRemoteMouseCursorContainer RemoteCursorContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NInputManager InputManager
	{
		[CompilerGenerated]
		get;
	}

	public extern NHotkeyManager HotkeyManager
	{
		[CompilerGenerated]
		get;
	}

	public extern NReactionWheel ReactionWheel
	{
		[CompilerGenerated]
		get;
	}

	public extern NReactionContainer ReactionContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NCursorManager CursorManager
	{
		[CompilerGenerated]
		get;
	}

	public extern NDebugAudioManager DebugAudio
	{
		[CompilerGenerated]
		get;
	}

	public extern string? DebugSeedOverride
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern bool StartOnMainMenu
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern bool IsTrailerMode
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHidingHoverTips
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHidingProceedButton
	{
		[CompilerGenerated]
		get;
	}

	public extern NInspectRelicScreen? InspectRelicScreen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern NInspectCardScreen? InspectCardScreen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern NSendFeedbackScreen FeedbackScreen
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern event Action? DebugToggleProceedButton;

	public extern event WindowChangeEventHandler WindowChange;

	public override extern void _EnterTree();

	public override extern void _Ready();

	public static extern bool IsMainThread();

	public override extern void _ExitTree();

	public static extern bool IsReleaseGame();

	public extern void ApplyDisplaySettings();

	public extern NInspectRelicScreen GetInspectRelicScreen();

	public extern NInspectCardScreen GetInspectCardScreen();

	public static extern void ApplySyncSetting();

	public static extern void Reset();

	public override extern void _Notification(int what);

	public extern void Quit();

	[AsyncStateMachine(typeof(_003CGoToTimelineAfterRun_003Ed__129))]
	public extern Task GoToTimelineAfterRun();

	[AsyncStateMachine(typeof(_003CReturnToMainMenuAfterRun_003Ed__130))]
	public extern Task ReturnToMainMenuAfterRun();

	[AsyncStateMachine(typeof(_003CGoToTimeline_003Ed__131))]
	public extern Task GoToTimeline();

	[AsyncStateMachine(typeof(_003CReturnToMainMenu_003Ed__132))]
	public extern Task ReturnToMainMenu();

	public extern void Relocalize();

	public extern void ReloadMainMenu();

	[AsyncStateMachine(typeof(_003CStartNewSingleplayerRun_003Ed__136))]
	public extern Task<RunState> StartNewSingleplayerRun(CharacterModel character, bool shouldSave, IReadOnlyList<ActModel> acts, IReadOnlyList<ModifierModel> modifiers, string seed, int ascensionLevel = 0, DateTimeOffset? dailyTime = null);

	[AsyncStateMachine(typeof(_003CStartNewMultiplayerRun_003Ed__137))]
	public extern Task<RunState> StartNewMultiplayerRun(StartRunLobby lobby, bool shouldSave, IReadOnlyList<ActModel> acts, IReadOnlyList<ModifierModel> modifiers, string seed, int ascensionLevel, DateTimeOffset? dailyTime = null);

	[AsyncStateMachine(typeof(_003CLoadRun_003Ed__138))]
	public extern Task LoadRun(RunState runState, SerializableRoom? preFinishedRoom);

	public override extern void _Input(InputEvent inputEvent);

	public extern WorldEnvironment ActivateWorldEnvironment();

	public extern void DeactivateWorldEnvironment();

	public extern void SetScreenShakeTarget(Control target);

	public extern void ClearScreenShakeTarget();

	public extern void ScreenShake(ShakeStrength strength, ShakeDuration duration, float degAngle = -1f);

	public extern void ScreenRumble(ShakeStrength strength, ShakeDuration duration, RumbleStyle style);

	public extern void ScreenShakeTrauma(ShakeStrength strength);

	public extern void DoHitStop(ShakeStrength strength, ShakeDuration duration);

	public static extern void ToggleTrailerMode();

	public extern void SetScreenshakeMultiplier(float multiplier);

	public extern void CheckShowSaveFileError(ReadSaveResult<SerializableProgress> progressReadResult, ReadSaveResult<PrefsSave> prefsReadResult, ReadSaveResult<SettingsSave>? settingsReadResult);

	public static extern void LogResourceStats(string context);

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

	protected extern void EmitSignalWindowChange();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NGame();
}
