using System;
using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardSelection;

[ScriptPath("res://src/Core/Nodes/Screens/CardSelection/NDeckTransformSelectScreen.cs")]
public sealed class NDeckTransformSelectScreen : NCardGridSelectionScreen
{
	public new class MethodName : NCardGridSelectionScreen.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RefreshConfirmButtonVisibility;

		public static readonly StringName CloseSelection;

		public static readonly StringName CancelSelection;

		public static readonly StringName ConfirmSelection;

		public static readonly StringName OpenPreviewScreen;

		public static readonly StringName CompleteSelection;

		public static readonly StringName ToggleShowUpgrades;

		public static readonly StringName OnControllerStateUpdated;

		public extern MethodName();
	}

	public new class PropertyName : NCardGridSelectionScreen.PropertyName
	{
		public new static readonly StringName DefaultFocusedControl;

		public new static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName _previewContainer;

		public static readonly StringName _transformPreview;

		public static readonly StringName _confirmButton;

		public static readonly StringName _previewCancelButton;

		public static readonly StringName _previewConfirmButton;

		public static readonly StringName _bottomTextContainer;

		public static readonly StringName _infoLabel;

		public static readonly StringName _viewUpgrades;

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

	public static extern NDeckTransformSelectScreen ShowScreen(IReadOnlyList<CardModel> cards, Func<CardModel, CardTransformation> cardToTransformation, CardSelectorPrefs prefs);

	public extern NDeckTransformSelectScreen();
}
