using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NHyperbeamVfx.cs")]
public class NHyperbeamVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public static readonly StringName Create;

		public static readonly StringName ApplyRotation;

		public new static readonly StringName _Ready;

		public static readonly StringName ShowLaser;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName _anticipationParticles;

		public static readonly StringName _laserParticles;

		public static readonly StringName _laserEndParticles;

		public static readonly StringName _laserLine;

		public static readonly StringName _laserContainer;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	public static readonly string scenePath;

	public static readonly float hyperbeamAnticipationDuration;

	public static readonly float hyperbeamLaserDuration;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NHyperbeamVfx? Create(Creature owner, Creature target);

	public static extern NHyperbeamVfx? Create(Vector2 defectEyePosition, Vector2 mainTargetCenterPosition);

	public extern void ApplyRotation(Vector2 sourcePosition, Vector2 targetPosition);

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

	public extern NHyperbeamVfx();
}
