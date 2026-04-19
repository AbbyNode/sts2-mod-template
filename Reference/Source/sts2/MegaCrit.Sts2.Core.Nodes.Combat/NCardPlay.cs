using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCardPlay.cs")]
public abstract class NCardPlay : Node
{
	[Signal]
	public delegate void FinishedEventHandler(bool success);

	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Start;

		public static readonly StringName CancelPlayCard;

		public static readonly StringName OnCancelPlayCard;

		public static readonly StringName Cleanup;

		public static readonly StringName OnCreatureHover;

		public static readonly StringName OnCreatureUnhover;

		public static readonly StringName CenterCard;

		public static readonly StringName HideTargetingVisuals;

		public static readonly StringName ShowMultiCreatureTargetingVisuals;

		public static readonly StringName AutoDisableCannotPlayCardFtueCheck;

		public static readonly StringName TryShowEvokingOrbs;

		public static readonly StringName HideEvokingOrbs;

		public static readonly StringName ClearTarget;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName Holder;

		public static readonly StringName CardNode;

		public static readonly StringName CardOwnerNode;

		public static readonly StringName _viewport;

		public static readonly StringName _isTryingToPlayCard;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public static readonly StringName Finished;

		public extern SignalName();
	}

	protected Viewport _viewport;

	public extern NHandCardHolder Holder
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	protected extern NCard? CardNode { get; }

	protected extern CardModel? Card { get; }

	protected extern NCreature? CardOwnerNode { get; }

	public extern Player Player
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	public extern event FinishedEventHandler Finished;

	public override extern void _Ready();

	public abstract void Start();

	protected extern void TryPlayCard(Creature? target);

	public extern void CancelPlayCard();

	protected virtual extern void OnCancelPlayCard();

	protected virtual extern void Cleanup();

	protected extern void OnCreatureHover(NCreature creature);

	protected extern void OnCreatureUnhover(NCreature _);

	protected extern void CenterCard();

	protected extern void CannotPlayThisCardFtueCheck(CardModel card);

	protected extern void HideTargetingVisuals();

	protected extern void ShowMultiCreatureTargetingVisuals();

	protected extern void TryShowEvokingOrbs();

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

	protected extern void EmitSignalFinished(bool success);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	protected extern NCardPlay();
}
