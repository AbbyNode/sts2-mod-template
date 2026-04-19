using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.UI;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Cards.Holders;

[ScriptPath("res://src/Core/Nodes/Cards/Holders/NCardHolder.cs")]
public abstract class NCardHolder : Control
{
	[Signal]
	public delegate void PressedEventHandler(NCardHolder cardHolder);

	[Signal]
	public delegate void AltPressedEventHandler(NCardHolder cardHolder);

	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetClickable;

		public static readonly StringName ConnectSignals;

		public new static readonly StringName _GuiInput;

		public static readonly StringName SetCard;

		public static readonly StringName OnCardReassigned;

		public static readonly StringName OnMousePressed;

		public static readonly StringName OnMouseReleased;

		public static readonly StringName OnFocus;

		public static readonly StringName CreateHoverTips;

		public static readonly StringName ClearHoverTips;

		public static readonly StringName OnUnfocus;

		public static readonly StringName RefreshFocusState;

		public static readonly StringName DoCardHoverEffects;

		public static readonly StringName OnChildExitingTree;

		public static readonly StringName Clear;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName HoverScale;

		public static readonly StringName SmallScale;

		public static readonly StringName Hitbox;

		public static readonly StringName CardNode;

		public static readonly StringName IsShowingUpgradedCard;

		public static readonly StringName CanBeFocused;

		public static readonly StringName _hitbox;

		public static readonly StringName _isHovered;

		public static readonly StringName _isFocused;

		public static readonly StringName _hoverTween;

		public static readonly StringName _currentPressedAction;

		public static readonly StringName _isClickable;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public static readonly StringName Pressed;

		public static readonly StringName AltPressed;

		public extern SignalName();
	}

	public static readonly Vector2 smallScale;

	protected NClickableControl _hitbox;

	protected bool _isHovered;

	protected bool _isFocused;

	protected Tween? _hoverTween;

	protected bool _isClickable;

	protected virtual extern Vector2 HoverScale { get; }

	public virtual extern Vector2 SmallScale { get; }

	public extern NClickableControl Hitbox { get; }

	public extern NCard? CardNode
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	public virtual extern CardModel? CardModel { get; }

	public virtual extern bool IsShowingUpgradedCard { get; }

	protected extern bool CanBeFocused { get; }

	public extern event PressedEventHandler Pressed;

	public extern event AltPressedEventHandler AltPressed;

	public override extern void _Ready();

	public extern void SetClickable(bool isClickable);

	protected extern void ConnectSignals();

	public override extern void _GuiInput(InputEvent inputEvent);

	protected virtual extern void SetCard(NCard node);

	public extern void ReassignToCard(CardModel cardModel, PileType pileType, Creature? target, ModelVisibility visibility);

	protected virtual extern void OnCardReassigned();

	protected virtual extern void OnMousePressed(InputEvent inputEvent);

	protected virtual extern void OnMouseReleased(InputEvent inputEvent);

	protected virtual extern void OnFocus();

	protected virtual extern void CreateHoverTips();

	protected extern void ClearHoverTips();

	protected virtual extern void OnUnfocus();

	protected extern void RefreshFocusState();

	protected virtual extern void DoCardHoverEffects(bool isHovered);

	public virtual extern void Clear();

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

	protected extern void EmitSignalPressed(NCardHolder cardHolder);

	protected extern void EmitSignalAltPressed(NCardHolder cardHolder);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	protected extern NCardHolder();
}
