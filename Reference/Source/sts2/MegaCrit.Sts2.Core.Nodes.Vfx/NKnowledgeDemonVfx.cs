using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[GlobalClass]
[ScriptPath("res://src/Core/Nodes/Vfx/NKnowledgeDemonVfx.cs")]
public class NKnowledgeDemonVfx : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationEvent;

		public static readonly StringName OnExplode;

		public static readonly StringName OnTakeDamage;

		public static readonly StringName OnBurningStart;

		public static readonly StringName OnEmbersStart;

		public static readonly StringName OnThinEmbersStart;

		public static readonly StringName OnBurningEnd;

		public static readonly StringName OnEmbersEnd;

		public static readonly StringName OnThinEmbersEnd;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _fireNode1;

		public static readonly StringName _fireNode2;

		public static readonly StringName _fireNode3;

		public static readonly StringName _fireNode4;

		public static readonly StringName _explosionParticles;

		public static readonly StringName _damageParticles;

		public static readonly StringName _emberParticles;

		public static readonly StringName _thinEmberParticles;

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

	public extern NKnowledgeDemonVfx();
}
