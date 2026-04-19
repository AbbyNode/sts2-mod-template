using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Nodes.Cards.Holders;

[ScriptPath("res://src/Core/Nodes/Cards/Holders/NHandCardHolder.cs")]
public class NHandCardHolder : NCardHolder
{
	[Signal]
	public delegate void HolderFocusedEventHandler(NHandCardHolder cardHolder);

	[Signal]
	public delegate void HolderUnfocusedEventHandler(NHandCardHolder cardHolder);

	[Signal]
	public delegate void HolderMouseClickedEventHandler(NCardHolder cardHolder);

	public new class MethodName : NCardHolder.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName Clear;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnMousePressed;

		public new static readonly StringName OnMouseReleased;

		public new static readonly StringName DoCardHoverEffects;

		public static readonly StringName SetIndexLabel;

		public static readonly StringName SetTargetAngle;

		public static readonly StringName SetTargetPosition;

		public static readonly StringName SetTargetScale;

		public static readonly StringName SetAngleInstantly;

		public static readonly StringName SetScaleInstantly;

		public static readonly StringName StopAnimations;

		public new static readonly StringName SetCard;

		public static readonly StringName UpdateCard;

		public static readonly StringName BeginDrag;

		public static readonly StringName CancelDrag;

		public static readonly StringName SetDefaultTargets;

		public static readonly StringName Flash;

		public extern MethodName();
	}

	public new class PropertyName : NCardHolder.PropertyName
	{
		public static readonly StringName InSelectMode;

		public static readonly StringName TargetPosition;

		public static readonly StringName TargetAngle;

		public static readonly StringName ShouldGlowGold;

		public static readonly StringName ShouldGlowRed;

		public static readonly StringName _flash;

		public static readonly StringName _flashTween;

		public static readonly StringName _handIndexLabel;

		public static readonly StringName _targetPosition;

		public static readonly StringName _targetAngle;

		public static readonly StringName _targetScale;

		public static readonly StringName _hand;

		public extern PropertyName();
	}

	public new class SignalName : NCardHolder.SignalName
	{
		public static readonly StringName HolderFocused;

		public static readonly StringName HolderUnfocused;

		public static readonly StringName HolderMouseClicked;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool InSelectMode
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern Vector2 TargetPosition { get; }

	public extern float TargetAngle { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern event HolderFocusedEventHandler HolderFocused;

	public extern event HolderUnfocusedEventHandler HolderUnfocused;

	public extern event HolderMouseClickedEventHandler HolderMouseClicked;

	public static extern NHandCardHolder Create(NCard card, NPlayerHand hand);

	public override extern void _Ready();

	public override extern void _ExitTree();

	public override extern void Clear();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnMousePressed(InputEvent inputEvent);

	protected override extern void OnMouseReleased(InputEvent inputEvent);

	protected override extern void DoCardHoverEffects(bool isHovered);

	public extern void SetIndexLabel(int i);

	public extern void SetTargetAngle(float angle);

	public extern void SetTargetPosition(Vector2 position);

	public extern void SetTargetScale(Vector2 scale);

	public extern void SetAngleInstantly(float setAngle);

	public extern void SetScaleInstantly(Vector2 setScale);

	protected override extern void SetCard(NCard node);

	public extern void UpdateCard();

	public extern void BeginDrag();

	public extern void CancelDrag();

	public extern void SetDefaultTargets();

	public extern void Flash();

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

	protected extern void EmitSignalHolderFocused(NHandCardHolder cardHolder);

	protected extern void EmitSignalHolderUnfocused(NHandCardHolder cardHolder);

	protected extern void EmitSignalHolderMouseClicked(NCardHolder cardHolder);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NHandCardHolder();
}
