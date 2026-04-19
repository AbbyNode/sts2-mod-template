using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/NTheInsatiableVfx.cs")]
public class NTheInsatiableVfx : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationEvent;

		public static readonly StringName TurnOnSaliva;

		public static readonly StringName TurnOffSaliva;

		public static readonly StringName TurnOnDrool;

		public static readonly StringName TurnOffDrool;

		public static readonly StringName TurnOnBaseBlast;

		public static readonly StringName TurnOffBaseBlast;

		public static readonly StringName TurnOffContinuousParticles;

		public static readonly StringName OnAnimationStart;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _continuousParticles;

		public static readonly StringName _salivaFountainParticles;

		public static readonly StringName _salivaDroolParticles;

		public static readonly StringName _salivaCloudParticles;

		public static readonly StringName _baseBlastParticles;

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

	public extern NTheInsatiableVfx();
}
