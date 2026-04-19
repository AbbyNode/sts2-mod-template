using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.Combat;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NDoomVfx.cs")]
public class NDoomVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Ready;

		public static readonly StringName ShowOrHideParticles;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName _tween;

		public static readonly StringName _back;

		public static readonly StringName _front;

		public static readonly StringName _creatureVisuals;

		public static readonly StringName _position;

		public static readonly StringName _size;

		public static readonly StringName _shouldDie;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public extern Task? VfxTask
	{
		[CompilerGenerated]
		get;
	}

	public static extern NDoomVfx? Create(NCreatureVisuals creatureVisuals, Vector2 position, Vector2 size, bool shouldDie);

	public override extern void _ExitTree();

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

	public extern NDoomVfx();
}
