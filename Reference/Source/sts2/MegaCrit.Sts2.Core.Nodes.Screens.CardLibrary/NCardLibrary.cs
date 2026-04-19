using Godot;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary;

[ScriptPath("res://src/Core/Nodes/Screens/CardLibrary/NCardLibrary.cs")]
public sealed class NCardLibrary : NSubmenu
{
	public new class MethodName : NSubmenu.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName OnCardTypeSort;

		public static readonly StringName OnRaritySort;

		public static readonly StringName OnCostSort;

		public static readonly StringName OnAlphabetSort;

		public new static readonly StringName OnSubmenuOpened;

		public new static readonly StringName OnSubmenuClosed;

		public static readonly StringName ToggleShowStats;

		public static readonly StringName ToggleShowUpgrades;

		public static readonly StringName ToggleFilterMultiplayerCards;

		public static readonly StringName UpdateCardPoolFilter;

		public static readonly StringName UpdateTypeFilter;

		public static readonly StringName UpdateRarityFilter;

		public static readonly StringName UpdateCostFilter;

		public static readonly StringName SearchBarQueryChanged;

		public static readonly StringName SearchBarQuerySubmitted;

		public static readonly StringName UpdateFilter;

		public static readonly StringName ShowCardDetail;

		public extern MethodName();
	}

	public new class PropertyName : NSubmenu.PropertyName
	{
		public new static readonly StringName InitialFocusedControl;

		public static readonly StringName _grid;

		public static readonly StringName _searchBar;

		public static readonly StringName _ironcladFilter;

		public static readonly StringName _silentFilter;

		public static readonly StringName _defectFilter;

		public static readonly StringName _regentFilter;

		public static readonly StringName _necrobinderFilter;

		public static readonly StringName _colorlessFilter;

		public static readonly StringName _ancientsFilter;

		public static readonly StringName _miscPoolFilter;

		public static readonly StringName _typeSorter;

		public static readonly StringName _attackFilter;

		public static readonly StringName _skillFilter;

		public static readonly StringName _powerFilter;

		public static readonly StringName _otherTypeFilter;

		public static readonly StringName _raritySorter;

		public static readonly StringName _commonFilter;

		public static readonly StringName _uncommonFilter;

		public static readonly StringName _rareFilter;

		public static readonly StringName _otherFilter;

		public static readonly StringName _costSorter;

		public static readonly StringName _zeroFilter;

		public static readonly StringName _oneFilter;

		public static readonly StringName _twoFilter;

		public static readonly StringName _threePlusFilter;

		public static readonly StringName _xFilter;

		public static readonly StringName _alphabetSorter;

		public static readonly StringName _viewMultiplayerCards;

		public static readonly StringName _viewStats;

		public static readonly StringName _viewUpgrades;

		public static readonly StringName _cardCountLabel;

		public static readonly StringName _noResultsLabel;

		public static readonly StringName _lastHoveredControl;

		public extern PropertyName();
	}

	public new class SignalName : NSubmenu.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern string[] AssetPaths { get; }

	public static extern NCardLibrary? Create();

	public override extern void _Ready();

	public extern void Initialize(IRunState runState);

	public override extern void OnSubmenuOpened();

	public override extern void OnSubmenuClosed();

	public extern NCardLibrary();
}
