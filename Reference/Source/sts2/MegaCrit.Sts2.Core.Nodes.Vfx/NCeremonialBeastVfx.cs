using System.ComponentModel;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/NCeremonialBeastVfx.cs")]
public class NCeremonialBeastVfx : Node, IDeathDelayer
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationEvent;

		public static readonly StringName TurnOnDeathParticles;

		public static readonly StringName TurnOnEnergyParticles;

		public static readonly StringName TurnOffEnergyParticles;

		public static readonly StringName OnPlowStart;

		public static readonly StringName OnPlowEnd;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _deathParticles;

		public static readonly StringName _energyParticlesFront;

		public static readonly StringName _energyParticlesBack;

		public static readonly StringName _plowStartTarget;

		public static readonly StringName _plowEndTarget;

		public static readonly StringName _parent;

		public static readonly StringName _globalPlowTarget;

		public static readonly StringName _globalPlowEndTarget;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern Task GetDelayTask();

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

	public extern NCeremonialBeastVfx();
}
