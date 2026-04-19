using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardSelection;

[ScriptPath("res://src/Core/Nodes/Screens/CardSelection/NDeckEnchantSelectScreen.cs")]
public sealed class NDeckEnchantSelectScreen : NCardGridSelectionScreen
{
	public new class MethodName : NCardGridSelectionScreen.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName RefreshConfirmButtonVisibility;

		public static readonly StringName CloseSelection;

		public static readonly StringName CancelSelection;

		public static readonly StringName PreviewSelection;

		public static readonly StringName ConfirmSelection;

		public static readonly StringName CheckIfSelectionComplete;

		public extern MethodName();
	}

	public new class PropertyName : NCardGridSelectionScreen.PropertyName
	{
		public static readonly StringName UseSingleSelection;

		public new static readonly StringName DefaultFocusedControl;

		public new static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName _enchantmentAmount;

		public static readonly StringName _enchantSinglePreviewContainer;

		public static readonly StringName _singlePreview;

		public static readonly StringName _singlePreviewCancelButton;

		public static readonly StringName _singlePreviewConfirmButton;

		public static readonly StringName _confirmButton;

		public static readonly StringName _enchantMultiPreviewContainer;

		public static readonly StringName _multiPreview;

		public static readonly StringName _multiPreviewCancelButton;

		public static readonly StringName _multiPreviewConfirmButton;

		public static readonly StringName _enchantmentDescriptionContainer;

		public static readonly StringName _enchantmentTitle;

		public static readonly StringName _enchantmentDescription;

		public static readonly StringName _enchantmentIcon;

		public static readonly StringName _bottomTextContainer;

		public static readonly StringName _infoLabel;

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

	public static extern NDeckEnchantSelectScreen ShowScreen(IReadOnlyList<CardModel> cards, EnchantmentModel enchantment, int amount, CardSelectorPrefs prefs);

	public extern NDeckEnchantSelectScreen();
}
