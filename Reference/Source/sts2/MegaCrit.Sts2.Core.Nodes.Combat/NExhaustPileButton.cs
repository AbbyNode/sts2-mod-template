using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NExhaustPileButton.cs")]
public class NExhaustPileButton : NCombatCardPile
{
	public new class MethodName : NCombatCardPile.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName AddCard;

		public new static readonly StringName SetAnimInOutPositions;

		public new static readonly StringName AnimIn;

		public extern MethodName();
	}

	public new class PropertyName : NCombatCardPile.PropertyName
	{
		public new static readonly StringName Hotkeys;

		public new static readonly StringName Pile;

		public static readonly StringName _viewport;

		public static readonly StringName _posOffset;

		public extern PropertyName();
	}

	public new class SignalName : NCombatCardPile.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	protected override extern string[] Hotkeys { get; }

	protected override extern PileType Pile { get; }

	public override extern void _Ready();

	public override extern void Initialize(Player player);

	protected override extern void AddCard();

	protected override extern void SetAnimInOutPositions();

	public override extern void AnimIn();

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

	public extern NExhaustPileButton();
}
