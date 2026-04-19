using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NKaiserCrabBossVfx.cs")]
public class NKaiserCrabBossVfx : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationEvent;

		public static readonly StringName OnAnimationStart;

		public static readonly StringName OnChargeSteamStart;

		public static readonly StringName OnChargeSteamEnd;

		public static readonly StringName OnDeathSpitStart;

		public static readonly StringName OnDeathSpitEnd;

		public static readonly StringName OnLeftEmbersStart;

		public static readonly StringName OnPlowChunksStart;

		public static readonly StringName OnPlowChunksEnd;

		public static readonly StringName OnRegenSplatsStart;

		public static readonly StringName OnRegenSplatsEnd;

		public static readonly StringName OnRocketThrustStart;

		public static readonly StringName OnRocketThrustEnd;

		public static readonly StringName OnClawLExplode;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _regenSplatParticles;

		public static readonly StringName _plowChunkParticles;

		public static readonly StringName _steamParticles1;

		public static readonly StringName _steamParticles2;

		public static readonly StringName _steamParticles3;

		public static readonly StringName _smokeParticles;

		public static readonly StringName _sparkParticles;

		public static readonly StringName _spittleParticles;

		public static readonly StringName _leftArmExplosionPosition;

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

	public extern NKaiserCrabBossVfx();
}
