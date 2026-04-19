using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NRestSiteFireVfx.cs")]
public class NRestSiteFireVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Flicker;

		public static readonly StringName Sway;

		public static readonly StringName Extinguish;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName _minFlickerScale;

		public static readonly StringName _maxFlickerScale;

		public static readonly StringName _minFlickerTime;

		public static readonly StringName _maxFlickerTime;

		public static readonly StringName _minSkew;

		public static readonly StringName _maxSkew;

		public static readonly StringName _minSkewTime;

		public static readonly StringName _maxSkewTime;

		public static readonly StringName _extinguishTime;

		public static readonly StringName _enabled;

		public static readonly StringName _cpuGlowParticles;

		public static readonly StringName _gpuSparkParticles;

		public static readonly StringName _baseScale;

		public static readonly StringName _baseSkew;

		public static readonly StringName _scaleTweenRef;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void Extinguish();

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

	public extern NRestSiteFireVfx();
}
