using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NDrawPileButton.cs")]
public class NDrawPileButton : NCombatCardPile
{
	public new class MethodName : NCombatCardPile.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName SetAnimInOutPositions;

		public extern MethodName();
	}

	public new class PropertyName : NCombatCardPile.PropertyName
	{
		public new static readonly StringName Hotkeys;

		public new static readonly StringName Pile;

		public extern PropertyName();
	}

	public new class SignalName : NCombatCardPile.SignalName
	{
		public extern SignalName();
	}

	protected override extern string[] Hotkeys { get; }

	protected override extern PileType Pile { get; }

	public override extern void _Ready();

	protected override extern void SetAnimInOutPositions();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool GetGodotClassPropertyValue(in godot_string_name name, out godot_variant value);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NDrawPileButton();
}
