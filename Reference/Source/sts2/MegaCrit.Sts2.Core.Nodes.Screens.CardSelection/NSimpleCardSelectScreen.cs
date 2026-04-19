using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardSelection;

[ScriptPath("res://src/Core/Nodes/Screens/CardSelection/NSimpleCardSelectScreen.cs")]
public sealed class NSimpleCardSelectScreen : NCardGridSelectionScreen
{
	public new class MethodName : NCardGridSelectionScreen.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignalsAndInitGrid;

		public new static readonly StringName AfterOverlayOpened;

		public static readonly StringName CheckIfSelectionComplete;

		public static readonly StringName CompleteSelection;

		public extern MethodName();
	}

	public new class PropertyName : NCardGridSelectionScreen.PropertyName
	{
		public static readonly StringName _bottomTextContainer;

		public static readonly StringName _infoLabel;

		public static readonly StringName _confirmButton;

		public static readonly StringName _combatPiles;

		public extern PropertyName();
	}

	public new class SignalName : NCardGridSelectionScreen.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NSimpleCardSelectScreen Create(IReadOnlyList<CardModel> cards, CardSelectorPrefs prefs);

	public static extern NSimpleCardSelectScreen Create(IReadOnlyList<CardCreationResult> cards, CardSelectorPrefs prefs);

	public override extern void _Ready();

	public override extern void AfterOverlayOpened();

	public extern NSimpleCardSelectScreen();
}
