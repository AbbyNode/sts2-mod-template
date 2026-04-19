using Godot;

namespace MegaCrit.Sts2.Core.ControllerInput;

public static class MegaInput
{
	public static readonly StringName up;

	public static readonly StringName down;

	public static readonly StringName left;

	public static readonly StringName right;

	public static readonly StringName accept;

	public static readonly StringName select;

	public static readonly StringName cancel;

	public static readonly StringName selectCard1;

	public static readonly StringName selectCard2;

	public static readonly StringName selectCard3;

	public static readonly StringName selectCard4;

	public static readonly StringName selectCard5;

	public static readonly StringName selectCard6;

	public static readonly StringName selectCard7;

	public static readonly StringName selectCard8;

	public static readonly StringName selectCard9;

	public static readonly StringName selectCard10;

	public static readonly StringName releaseCard;

	public static readonly StringName topPanel;

	public static readonly StringName viewDrawPile;

	public static readonly StringName viewDiscardPile;

	public static readonly StringName viewDeckAndTabLeft;

	public static readonly StringName viewExhaustPileAndTabRight;

	public static readonly StringName viewMap;

	public static readonly StringName pauseAndBack;

	public static readonly StringName back;

	public static readonly StringName peek;

	public static extern string[] AllInputs { get; }
}
