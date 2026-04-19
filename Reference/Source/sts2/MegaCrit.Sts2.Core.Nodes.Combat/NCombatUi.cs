using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.CommonUi;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCombatUi.cs")]
public class NCombatUi : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName Deactivate;

		public static readonly StringName DisconnectSignals;

		public static readonly StringName AddToPlayContainer;

		public static readonly StringName AnimIn;

		public static readonly StringName OnHandSelectModeEntered;

		public static readonly StringName OnHandSelectModeExited;

		public static readonly StringName OnPeekButtonReady;

		public static readonly StringName OnPeekButtonToggled;

		public static readonly StringName Enable;

		public static readonly StringName Disable;

		public new static readonly StringName _Input;

		public static readonly StringName DebugHideCombatUi;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName EnergyCounterContainer;

		public static readonly StringName EndTurnButton;

		public static readonly StringName PingButton;

		public static readonly StringName DrawPile;

		public static readonly StringName DiscardPile;

		public static readonly StringName ExhaustPile;

		public static readonly StringName Hand;

		public static readonly StringName PlayContainer;

		public static readonly StringName PlayQueue;

		public static readonly StringName CardPreviewContainer;

		public static readonly StringName MessyCardPreviewContainer;

		public static readonly StringName _starCounter;

		public static readonly StringName _energyCounter;

		public static readonly StringName _combatPilesContainer;

		public static readonly StringName _playContainerPeekModeTween;

		public static readonly StringName _originalHandChildIndex;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control EnergyCounterContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NEndTurnButton EndTurnButton
	{
		[CompilerGenerated]
		get;
	}

	public extern NDrawPileButton DrawPile { get; }

	public extern NDiscardPileButton DiscardPile { get; }

	public extern NExhaustPileButton ExhaustPile { get; }

	public extern NPlayerHand Hand
	{
		[CompilerGenerated]
		get;
	}

	public extern Control PlayContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NCardPlayQueue PlayQueue
	{
		[CompilerGenerated]
		get;
	}

	public extern Control CardPreviewContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern NMessyCardPreviewContainer MessyCardPreviewContainer
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHidingIntent
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHidingPlayContainer
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHidingHpBar
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHideTextVfx
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHideTargetingUi
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHideMpTargetingUi
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IsDebugHideMpIntents
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action? DebugToggleIntent;

	public extern event Action? DebugToggleHpBar;

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void Activate(CombatState state);

	public extern void Deactivate();

	public extern void AddToPlayContainer(NCard card);

	public extern NCard? GetCardFromPlayContainer(CardModel model);

	public extern void AnimOut(CombatRoom _);

	public extern void OnHandSelectModeEntered();

	public extern void OnHandSelectModeExited();

	public extern void OnPeekButtonReady(NPeekButton peekButton);

	public extern void Enable();

	public extern void Disable();

	public override extern void _Input(InputEvent inputEvent);

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

	public extern NCombatUi();
}
