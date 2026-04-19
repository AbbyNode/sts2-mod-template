using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCombatPilesContainer.cs")]
public class NCombatPilesContainer : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName AnimIn;

		public static readonly StringName AnimOut;

		public static readonly StringName Enable;

		public static readonly StringName Disable;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName DrawPile;

		public static readonly StringName DiscardPile;

		public static readonly StringName ExhaustPile;

		public static readonly StringName _drawPile;

		public static readonly StringName _discardPile;

		public static readonly StringName _exhaustPile;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	public static readonly string scenePath;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NDrawPileButton DrawPile { get; }

	public extern NDiscardPileButton DiscardPile { get; }

	public extern NExhaustPileButton ExhaustPile { get; }

	public override extern void _Ready();

	public extern void Initialize(Player player);

	public extern void AnimIn();

	public extern void AnimOut();

	public extern void Enable();

	public extern void Disable();

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

	public extern NCombatPilesContainer();
}
