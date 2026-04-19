using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/NAmalgamVfx.cs")]
public class NAmalgamVfx : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationEvent;

		public static readonly StringName PoofToDeath;

		public static readonly StringName RestartTorches;

		public static readonly StringName KillTorches;

		public static readonly StringName PlayHit1;

		public static readonly StringName PlayHit2;

		public static readonly StringName PlayHit3;

		public static readonly StringName PlayLaserBase;

		public static readonly StringName PlayLaserHit;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _hitFxParticles;

		public static readonly StringName _hitBoneNode;

		public static readonly StringName _deathBodyParticles;

		public static readonly StringName _laserBaseParticles;

		public static readonly StringName _hitParticles1;

		public static readonly StringName _hitParticles2;

		public static readonly StringName _hitParticles3;

		public static readonly StringName _constantSparks1;

		public static readonly StringName _constantSparks2;

		public static readonly StringName _constantSparks3;

		public static readonly StringName _torch1Node;

		public static readonly StringName _torch2Node;

		public static readonly StringName _torch3Node;

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

	public extern NAmalgamVfx();
}
