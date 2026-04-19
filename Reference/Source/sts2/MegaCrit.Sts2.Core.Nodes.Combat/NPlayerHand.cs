using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NPlayerHand.cs")]
public class NPlayerHand : Control
{
	[Signal]
	public delegate void ModeChangedEventHandler();

	public enum Mode
	{
		None,
		Play,
		SimpleSelect,
		UpgradeSelect
	}

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName IsAwaitingPlay;

		public static readonly StringName Add;

		public static readonly StringName AddCardHolder;

		public static readonly StringName RemoveCardHolder;

		public static readonly StringName OnHolderFocused;

		public static readonly StringName OnHolderUnfocused;

		public static readonly StringName CancelAllCardPlay;

		public static readonly StringName ReturnHolderToHand;

		public static readonly StringName ForceRefreshCardIndices;

		public static readonly StringName RefreshLayout;

		public static readonly StringName OnPeekButtonToggled;

		public static readonly StringName UpdateSelectModeCardVisibility;

		public static readonly StringName CancelHandSelectionIfNecessary;

		public static readonly StringName OnHolderPressed;

		public static readonly StringName CanPlayCards;

		public static readonly StringName AreCardActionsAllowed;

		public static readonly StringName StartCardPlay;

		public static readonly StringName SelectCardInSimpleMode;

		public static readonly StringName SelectCardInUpgradeMode;

		public static readonly StringName DeselectCard;

		public static readonly StringName OnSelectModeConfirmButtonPressed;

		public static readonly StringName CheckIfSelectionComplete;

		public static readonly StringName RefreshSelectModeConfirmButton;

		public static readonly StringName AnimIn;

		public static readonly StringName AnimOut;

		public static readonly StringName AnimDisable;

		public static readonly StringName AnimEnable;

		public static readonly StringName FlashPlayableHolders;

		public static readonly StringName OnCardSelected;

		public static readonly StringName OnCardDeselected;

		public static readonly StringName UpdateSelectedCardContainer;

		public static readonly StringName EnableControllerNavigation;

		public static readonly StringName DisableControllerNavigation;

		public new static readonly StringName _UnhandledInput;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName CardHolderContainer;

		public static readonly StringName PeekButton;

		public static readonly StringName InCardPlay;

		public static readonly StringName IsInCardSelection;

		public static readonly StringName CurrentMode;

		public static readonly StringName HasDraggedHolder;

		public static readonly StringName FocusedHolder;

		public static readonly StringName DefaultFocusedControl;

		public static readonly StringName _selectCardShortcuts;

		public static readonly StringName _selectModeBackstop;

		public static readonly StringName _upgradePreviewContainer;

		public static readonly StringName _selectedHandCardContainer;

		public static readonly StringName _upgradePreview;

		public static readonly StringName _selectModeConfirmButton;

		public static readonly StringName _selectionHeader;

		public static readonly StringName _currentCardPlay;

		public static readonly StringName _currentMode;

		public static readonly StringName _draggedHolderIndex;

		public static readonly StringName _lastFocusedHolderIdx;

		public static readonly StringName _animEnableTween;

		public static readonly StringName _isDisabled;

		public static readonly StringName _animInTween;

		public static readonly StringName _animOutTween;

		public static readonly StringName _selectedCardScaleTween;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName ModeChanged;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NPlayerHand? Instance { get; }

	public extern Control CardHolderContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NPeekButton PeekButton
	{
		[CompilerGenerated]
		get;
	}

	public extern bool InCardPlay { get; }

	public extern bool IsInCardSelection { get; }

	public extern Mode CurrentMode { get; }

	public extern Func<CardModel, bool>? SelectModeGoldGlowOverride { get; }

	public extern NHandCardHolder? FocusedHolder
	{
		[CompilerGenerated]
		get;
	}

	public extern IReadOnlyList<NHandCardHolder> ActiveHolders { get; }

	public extern Control DefaultFocusedControl { get; }

	public extern event ModeChangedEventHandler ModeChanged;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern NCard? GetCard(CardModel card);

	public extern bool IsAwaitingPlay(NHandCardHolder? holder);

	public extern NCardHolder? GetCardHolder(CardModel card);

	public extern NHandCardHolder Add(NCard card, int index = -1);

	public extern void Remove(CardModel card);

	public extern void RemoveCardHolder(NCardHolder holder);

	public extern void TryCancelCardPlay(CardModel card);

	public extern void CancelAllCardPlay();

	public extern void ForceRefreshCardIndices();

	[AsyncStateMachine(typeof(_003CSelectCards_003Ed__82))]
	public extern Task<IEnumerable<CardModel>> SelectCards(CardSelectorPrefs prefs, Func<CardModel, bool>? filter, AbstractModel? source, Mode mode = Mode.SimpleSelect);

	public extern void DeselectCard(NCard card);

	public extern void AnimIn();

	public extern void AnimOut();

	public extern void FlashPlayableHolders();

	public extern void EnableControllerNavigation();

	public extern void DisableControllerNavigation();

	public override extern void _UnhandledInput(InputEvent input);

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

	protected extern void EmitSignalModeChanged();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NPlayerHand();
}
