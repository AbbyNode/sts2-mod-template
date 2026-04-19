using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.MonsterMoves.Intents;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NIntent.cs")]
public class NIntent : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public static readonly StringName DebugToggleVisibility;

		public new static readonly StringName _ExitTree;

		public static readonly StringName UpdateVisuals;

		public new static readonly StringName _Process;

		public static readonly StringName Create;

		public static readonly StringName PlayPerform;

		public static readonly StringName SetFrozen;

		public static readonly StringName OnHovered;

		public static readonly StringName OnUnhovered;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _intentHolder;

		public static readonly StringName _intentSprite;

		public static readonly StringName _valueLabel;

		public static readonly StringName _intentParticle;

		public static readonly StringName _timeOffset;

		public static readonly StringName _timeAccumulator;

		public static readonly StringName _isFrozen;

		public static readonly StringName _animationName;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void UpdateIntent(AbstractIntent intent, IEnumerable<Creature> targets, Creature owner);

	public override extern void _Process(double delta);

	public static extern NIntent Create(float startTime);

	public extern void PlayPerform();

	public extern void SetFrozen(bool isFrozen);

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

	public extern NIntent();
}
