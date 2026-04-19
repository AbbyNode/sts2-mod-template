using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Nodes.Screens.Overlays;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Nodes.Screens.GameOverScreen;

[ScriptPath("res://src/Core/Nodes/Screens/GameOverScreen/NGameOverScreen.cs")]
public class NGameOverScreen : NClickableControl, IOverlayScreen, IScreenContext
{
	public new class MethodName : NClickableControl.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName DiscoveredAnyEpochs;

		public static readonly StringName InitializeBannerAndQuote;

		public static readonly StringName OpenSummaryScreen;

		public static readonly StringName AddBadge;

		public static readonly StringName PlayUnlockSfx;

		public static readonly StringName TweenScore;

		public static readonly StringName GetScoreThreshold;

		public static readonly StringName ShowLeaderboard;

		public static readonly StringName HideSummary;

		public static readonly StringName OpenRunHistoryScreen;

		public static readonly StringName OnMainMenuButtonPressed;

		public static readonly StringName OpenTimeline;

		public static readonly StringName ReturnToMainMenu;

		public static readonly StringName AfterOverlayOpened;

		public static readonly StringName MoveCreaturesToDifferentLayerAndDisableUi;

		public static readonly StringName UpdateBackstopMaterial;

		public static readonly StringName AfterOverlayClosed;

		public static readonly StringName AfterOverlayShown;

		public static readonly StringName AfterOverlayHidden;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName ScreenType;

		public static readonly StringName UseSharedBackstop;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _continueButton;

		public static readonly StringName _viewRunButton;

		public static readonly StringName _mainMenuButton;

		public static readonly StringName _leaderboardButton;

		public static readonly StringName _badgeContainer;

		public static readonly StringName _scoreBar;

		public static readonly StringName _scoreFg;

		public static readonly StringName _scoreProgress;

		public static readonly StringName _unlocksRemaining;

		public static readonly StringName _score;

		public static readonly StringName _scoreThreshold;

		public static readonly StringName _scoreUnlockedEpochId;

		public static readonly StringName _leaderboard;

		public static readonly StringName _creatureContainer;

		public static readonly StringName _summaryContainer;

		public static readonly StringName _fullBlackBackstop;

		public static readonly StringName _summaryBackstop;

		public static readonly StringName _backstop;

		public static readonly StringName _banner;

		public static readonly StringName _deathQuote;

		public static readonly StringName _victoryDamageLabel;

		public static readonly StringName _uiNode;

		public static readonly StringName _screenshakeContainer;

		public static readonly StringName _discoveryLabel;

		public static readonly StringName _encounterQuote;

		public static readonly StringName _isAnimatingSummary;

		public static readonly StringName _backstopMaterial;

		public static readonly StringName _quoteTween;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern NetScreenType ScreenType { get; }

	public extern bool UseSharedBackstop { get; }

	public extern Control DefaultFocusedControl { get; }

	public override extern void _Ready();

	public static extern NGameOverScreen? Create(RunState runState, SerializableRun serializableRun);

	public extern void AfterOverlayOpened();

	public extern void AfterOverlayClosed();

	public extern void AfterOverlayShown();

	public extern void AfterOverlayHidden();

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

	public extern NGameOverScreen();
}
