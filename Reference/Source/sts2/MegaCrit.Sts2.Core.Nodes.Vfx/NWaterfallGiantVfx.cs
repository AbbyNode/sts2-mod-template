using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/NWaterfallGiantVfx.cs")]
public class NWaterfallGiantVfx : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationEvent;

		public static readonly StringName StartSteam1;

		public static readonly StringName EndSteam1;

		public static readonly StringName StartSteam2;

		public static readonly StringName EndSteam2;

		public static readonly StringName StartSteam3;

		public static readonly StringName EndSteam3;

		public static readonly StringName StartSteam5;

		public static readonly StringName EndSteam5;

		public static readonly StringName StartWaterfall;

		public static readonly StringName EndWaterfall;

		public static readonly StringName Explode;

		public static readonly StringName Buildup1;

		public static readonly StringName Buildup2;

		public static readonly StringName Buildup3;

		public static readonly StringName EmitGracefully;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _steam1Particles;

		public static readonly StringName _steam2Particles;

		public static readonly StringName _steam3Particles;

		public static readonly StringName _steam4Particles;

		public static readonly StringName _steam5Particles;

		public static readonly StringName _steam6Particles;

		public static readonly StringName _steamLeakParticles1;

		public static readonly StringName _steamLeakParticles2;

		public static readonly StringName _steamLeakParticles3;

		public static readonly StringName _mistParticles;

		public static readonly StringName _mouthParticles;

		public static readonly StringName _dropletParticles;

		public static readonly StringName _isDead;

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

	public extern NWaterfallGiantVfx();
}
