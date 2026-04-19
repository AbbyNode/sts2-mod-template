using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Nodes.Screens.Overlays;
using MegaCrit.Sts2.Core.Nodes.Screens.ScreenContext;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens;

[ScriptPath("res://src/Core/Nodes/Screens/NRewardsScreen.cs")]
public class NRewardsScreen : Control, IOverlayScreen, IScreenContext
{
	[Signal]
	public delegate void CompletedEventHandler();

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RewardCollectedFrom;

		public static readonly StringName RewardSkippedFrom;

		public static readonly StringName UpdateScreenState;

		public static readonly StringName RemoveButton;

		public static readonly StringName OnProceedButtonPressed;

		public static readonly StringName AfterOverlayOpened;

		public static readonly StringName AfterOverlayClosed;

		public static readonly StringName TryEnableProceedButton;

		public static readonly StringName AfterOverlayShown;

		public static readonly StringName AfterOverlayHidden;

		public new static readonly StringName _GuiInput;

		public static readonly StringName ProcessScrollEvent;

		public static readonly StringName ProcessGuiFocus;

		public new static readonly StringName _Process;

		public static readonly StringName UpdateScrollPosition;

		public static readonly StringName HideWaitingForPlayersScreen;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName CanScroll;

		public static readonly StringName ScrollLimitBottom;

		public static readonly StringName IsComplete;

		public static readonly StringName ScreenType;

		public static readonly StringName UseSharedBackstop;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName _proceedButton;

		public static readonly StringName _rewardsContainer;

		public static readonly StringName _scrollbar;

		public static readonly StringName _headerLabel;

		public static readonly StringName _rewardContainerMask;

		public static readonly StringName _waitingForOtherPlayersOverlay;

		public static readonly StringName _rewardsWindow;

		public static readonly StringName _targetDragPos;

		public static readonly StringName _scrollbarPressed;

		public static readonly StringName _fadeTween;

		public static readonly StringName _lastRewardFocused;

		public static readonly StringName _isTerminal;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Completed;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern Task ClosedTask { get; }

	public extern bool IsComplete
	{
		[CompilerGenerated]
		get;
	}

	public extern NetScreenType ScreenType { get; }

	public extern bool UseSharedBackstop { get; }

	public extern Control DefaultFocusedControl { get; }

	public extern Control FocusedControlFromTopBar { get; }

	public extern event CompletedEventHandler Completed;

	public static extern NRewardsScreen ShowScreen(bool isTerminal, IRunState runState);

	public override extern void _Ready();

	public extern void SetRewards(IEnumerable<Reward> rewards);

	public extern void RewardCollectedFrom(Control button);

	public extern void RewardSkippedFrom(Control button);

	public extern void AfterOverlayOpened();

	public extern void AfterOverlayClosed();

	public extern void AfterOverlayShown();

	public extern void AfterOverlayHidden();

	public override extern void _GuiInput(InputEvent inputEvent);

	public override extern void _Process(double delta);

	public extern void HideWaitingForPlayersScreen();

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

	protected extern void EmitSignalCompleted();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NRewardsScreen();
}
