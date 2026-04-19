using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardSelection;

[ScriptPath("res://src/Core/Nodes/Screens/CardSelection/NDeckUpgradeSelectScreen.cs")]
public sealed class NDeckUpgradeSelectScreen : NCardGridSelectionScreen
{
	public new class MethodName : NCardGridSelectionScreen.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName CloseSelection;

		public static readonly StringName CancelSelection;

		public static readonly StringName ConfirmSelection;

		public static readonly StringName CheckIfSelectionComplete;

		public static readonly StringName ToggleShowUpgrades;

		public static readonly StringName OnControllerStateUpdated;

		public extern MethodName();
	}

	public new class PropertyName : NCardGridSelectionScreen.PropertyName
	{
		public static readonly StringName UseSingleSelection;

		public new static readonly StringName DefaultFocusedControl;

		public new static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName _upgradeSinglePreviewContainer;

		public static readonly StringName _singlePreview;

		public static readonly StringName _singlePreviewCancelButton;

		public static readonly StringName _singlePreviewConfirmButton;

		public static readonly StringName _viewUpgrades;

		public static readonly StringName _bottomTextContainer;

		public static readonly StringName _infoLabel;

		public static readonly StringName _upgradeMultiPreviewContainer;

		public static readonly StringName _multiPreview;

		public static readonly StringName _multiPreviewCancelButton;

		public static readonly StringName _multiPreviewConfirmButton;

		public static readonly StringName _closeButton;

		public extern PropertyName();
	}

	public new class SignalName : NCardGridSelectionScreen.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern Control? DefaultFocusedControl { get; }

	public override extern Control? FocusedControlFromTopBar { get; }

	public override extern void _Ready();

	public static extern NDeckUpgradeSelectScreen ShowScreen(IReadOnlyList<CardModel> cards, CardSelectorPrefs prefs, IRunState runState);

	public extern NDeckUpgradeSelectScreen();
}
