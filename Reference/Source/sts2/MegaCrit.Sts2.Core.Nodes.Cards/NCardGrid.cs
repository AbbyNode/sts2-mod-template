using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.UI;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;
using MegaCrit.Sts2.Core.Nodes.Screens.CardLibrary;

namespace MegaCrit.Sts2.Core.Nodes.Cards;

[ScriptPath("res://src/Core/Nodes/Cards/NCardGrid.cs")]
public class NCardGrid : Control
{
	[Signal]
	public delegate void HolderPressedEventHandler(NCardHolder card);

	[Signal]
	public delegate void HolderAltPressedEventHandler(NCardHolder card);

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName ConnectSignals;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName UpdateScrollLimitBottom;

		public new static readonly StringName _GuiInput;

		public new static readonly StringName _Process;

		public new static readonly StringName _Notification;

		public static readonly StringName SetScrollPosition;

		public static readonly StringName SetCanScroll;

		public static readonly StringName InsetForTopBar;

		public static readonly StringName ProcessMouseEvent;

		public static readonly StringName ProcessScrollEvent;

		public static readonly StringName ProcessGuiFocus;

		public static readonly StringName UpdateScrollPosition;

		public static readonly StringName ClearGrid;

		public static readonly StringName CalculateRowsNeeded;

		public static readonly StringName InitGrid;

		public static readonly StringName GetContainedCardsSize;

		public static readonly StringName ReflowColumns;

		public static readonly StringName UpdateGridPositions;

		public static readonly StringName OnHolderPressed;

		public static readonly StringName OnHolderAltPressed;

		public static readonly StringName GetTotalRowCount;

		public static readonly StringName AllocateCardHolders;

		public static readonly StringName ReallocateAll;

		public static readonly StringName UpdateGridNavigation;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName CanScroll;

		public static readonly StringName DisplayedRows;

		public static readonly StringName Columns;

		public static readonly StringName CardPadding;

		public static readonly StringName IsCardLibrary;

		public static readonly StringName ScrollLimitBottom;

		public static readonly StringName ScrollLimitTop;

		public static readonly StringName IsAnimatingOut;

		public static readonly StringName IsShowingUpgrades;

		public static readonly StringName YOffset;

		public static readonly StringName CenterGrid;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName FocusedControlFromTopBar;

		public static readonly StringName _startDrag;

		public static readonly StringName _targetDrag;

		public static readonly StringName _isDragging;

		public static readonly StringName _scrollingEnabled;

		public static readonly StringName _scrollContainer;

		public static readonly StringName _scrollbarPressed;

		public static readonly StringName _scrollbar;

		public static readonly StringName _slidingWindowCardIndex;

		public static readonly StringName _pileType;

		public static readonly StringName _cardSize;

		public static readonly StringName _cardsAnimatingOutForSetCards;

		public static readonly StringName _isShowingUpgrades;

		public static readonly StringName _lastFocusedHolder;

		public static readonly StringName _needsReinit;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName HolderPressed;

		public static readonly StringName HolderAltPressed;

		public extern SignalName();
	}

	protected Control _scrollContainer;

	protected Vector2 _cardSize;

	protected readonly List<CardModel> _cards;

	protected readonly List<List<NGridCardHolder>> _cardRows;

	protected extern int Columns { get; }

	protected extern float CardPadding { get; }

	protected virtual extern bool IsCardLibrary { get; }

	protected extern float ScrollLimitTop { get; }

	public extern IEnumerable<NGridCardHolder> CurrentlyDisplayedCardHolders { get; }

	public extern IEnumerable<CardModel> CurrentlyDisplayedCards { get; }

	public extern bool IsAnimatingOut { get; }

	public extern bool IsShowingUpgrades { get; set; }

	public extern int YOffset
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	protected virtual extern bool CenterGrid { get; }

	public extern Control? DefaultFocusedControl { get; }

	public extern Control? FocusedControlFromTopBar { get; }

	public extern event HolderPressedEventHandler HolderPressed;

	public extern event HolderAltPressedEventHandler HolderAltPressed;

	public override extern void _Ready();

	protected virtual extern void ConnectSignals();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public override extern void _GuiInput(InputEvent inputEvent);

	public override extern void _Process(double delta);

	public override extern void _Notification(int what);

	public extern void SetScrollPosition(float scrollY);

	public extern void SetCanScroll(bool canScroll);

	public extern void InsetForTopBar();

	public extern void ClearGrid();

	public extern void SetCards(IReadOnlyList<CardModel> cardsToDisplay, PileType pileType, List<SortingOrders> sortingPriority, Task? taskToWaitOn = null);

	public extern Task AnimateOut();

	protected virtual extern void InitGrid();

	public extern NGridCardHolder? GetCardHolder(CardModel model);

	public extern NCard? GetCardNode(CardModel model);

	public extern IEnumerable<NGridCardHolder>? GetTopRowOfCardNodes();

	public extern void HighlightCard(CardModel card);

	public extern void UnhighlightCard(CardModel card);

	protected virtual extern void AssignCardsToRow(List<NGridCardHolder> row, int startIndex);

	protected virtual extern ModelVisibility GetCardVisibility(CardModel card);

	protected virtual extern void UpdateGridNavigation();

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

	protected extern void EmitSignalHolderPressed(NCardHolder card);

	protected extern void EmitSignalHolderAltPressed(NCardHolder card);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NCardGrid();
}
