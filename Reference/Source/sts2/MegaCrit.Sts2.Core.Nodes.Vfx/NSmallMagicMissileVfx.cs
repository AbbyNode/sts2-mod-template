using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NSmallMagicMissileVfx.cs")]
public class NSmallMagicMissileVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public static readonly StringName Create;

		public static readonly StringName GetProjectileDirection;

		public static readonly StringName GetTopPosition;

		public static readonly StringName Initialize;

		public static readonly StringName ModulateParticles;

		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName WaitTime;

		public static readonly StringName _anticipationParticles;

		public static readonly StringName _projectileStartParticles;

		public static readonly StringName _projectileParticles;

		public static readonly StringName _impactParticles;

		public static readonly StringName _modulateParticles;

		public static readonly StringName _anticipationContainer;

		public static readonly StringName _anticipationDuration;

		public static readonly StringName _projectileContainer;

		public static readonly StringName _projectileStartPoint;

		public static readonly StringName _projectileEndPoint;

		public static readonly StringName _projectileOffset;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	public static readonly string scenePath;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern float WaitTime
	{
		[CompilerGenerated]
		get;
	}

	public static extern NSmallMagicMissileVfx? Create(Vector2 targetCenterPosition, Color tint);

	public override extern void _Ready();

	public override extern void _ExitTree();

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

	public extern NSmallMagicMissileVfx();
}
