using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NMinionDiveBombVfx.cs")]
public class NMinionDiveBombVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public static readonly StringName Create;

		public static readonly StringName Initialize;

		public new static readonly StringName _Ready;

		public static readonly StringName SetMinionVisible;

		public static readonly StringName UpdateMinionSprite;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName SourceFinalPosition;

		public static readonly StringName DestinationFinalPosition;

		public static readonly StringName _minionSprite;

		public static readonly StringName _minionTextures;

		public static readonly StringName _minionAnimator;

		public static readonly StringName _minionAnimations;

		public static readonly StringName _minionVfx;

		public static readonly StringName _fallingTrail;

		public static readonly StringName _fallingVfx;

		public static readonly StringName _impactVfx;

		public static readonly StringName _flightTime;

		public static readonly StringName _fallingVfxEntryTime;

		public static readonly StringName _horizontalCurve;

		public static readonly StringName _verticalCurve;

		public static readonly StringName _textureCurve;

		public static readonly StringName _maxHeight;

		public static readonly StringName _sourceOffset;

		public static readonly StringName _destinationOffset;

		public static readonly StringName _previousIndex;

		public static readonly StringName _sourcePosition;

		public static readonly StringName _destinationPosition;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	public static readonly string scenePath;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NMinionDiveBombVfx? Create(Creature owner, Creature target);

	public static extern NMinionDiveBombVfx? Create(Vector2 playerCenterPosition, Vector2 targetFloorPosition);

	public override extern void _Ready();

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

	public extern NMinionDiveBombVfx();
}
