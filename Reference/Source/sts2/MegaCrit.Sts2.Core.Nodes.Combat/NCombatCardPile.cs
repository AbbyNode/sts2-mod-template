using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCombatCardPile.cs")]
public abstract class NCombatCardPile : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName ConnectSignals;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName SetAnimInOutPositions;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public static readonly StringName AddCard;

		public static readonly StringName RemoveCard;

		public static readonly StringName AnimIn;

		public static readonly StringName AnimOut;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName Pile;

		public static readonly StringName _countLabel;

		public static readonly StringName _icon;

		public static readonly StringName _bumpTween;

		public static readonly StringName _currentCount;

		public static readonly StringName _positionTween;

		public static readonly StringName _showPosition;

		public static readonly StringName _hidePosition;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	protected LocString _emptyPileMessage;

	protected Vector2 _showPosition;

	protected Vector2 _hidePosition;

	protected abstract PileType Pile { get; }

	public override extern void _Ready();

	protected override extern void ConnectSignals();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public virtual extern void Initialize(Player player);

	protected virtual extern void SetAnimInOutPositions();

	protected override extern void OnRelease();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	protected virtual extern void AddCard();

	public virtual extern void AnimIn();

	public extern void AnimOut();

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

	protected extern NCombatCardPile();
}
