using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/NRegentVfx.cs")]
public class NRegentVfx : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationEvent;

		public static readonly StringName TurnOnDying;

		public static readonly StringName TurnOnDying2;

		public static readonly StringName TurnOffDying;

		public static readonly StringName Explode;

		public static readonly StringName DisableExplode;

		public static readonly StringName Attack;

		public static readonly StringName OnAnimationStart;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _deathParticlesArm;

		public static readonly StringName _deathParticlesChest;

		public static readonly StringName _deathParticlesBack;

		public static readonly StringName _deathParticlesLeg;

		public static readonly StringName _deathParticlesLegL;

		public static readonly StringName _explosionParticles;

		public static readonly StringName _attackParticlesSmall;

		public static readonly StringName _attackParticlesSmall2;

		public static readonly StringName _attackParticlesLarge;

		public static readonly StringName _curWeapon;

		public static readonly StringName _parent;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

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

	public extern NRegentVfx();
}
