using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.GameActions;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.Cards;
using MegaCrit.Sts2.Core.Nodes.Cards.Holders;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCardPlayQueue.cs")]
public class NCardPlayQueue : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName RemoveCardFromQueueForCancellation;

		public static readonly StringName RemoveCardFromQueue;

		public static readonly StringName TweenAllToQueuePosition;

		public static readonly StringName AnimOut;

		public static readonly StringName GetScaleForQueueIndex;

		public static readonly StringName GetPositionForQueueIndex;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NCardPlayQueue? Instance { get; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void OnLocalCardPlayed(PlayCardAction action, NCardHolder? holder, CardModel card);

	public extern void ReAddCardAfterPlayerChoice(NCard card, GameAction action);

	public extern void RemoveCardFromQueueForCancellation(PlayCardAction action);

	public extern void RemoveCardFromQueueForCancellation(NCard card, bool forceReturnToHand = false);

	public extern void UpdateCardBeforeExecution(PlayCardAction playCardAction);

	public extern void RemoveCardFromQueueForExecution(CardModel card);

	public extern NCard? GetCardNode(CardModel card);

	public extern void AnimOut();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NCardPlayQueue();
}
