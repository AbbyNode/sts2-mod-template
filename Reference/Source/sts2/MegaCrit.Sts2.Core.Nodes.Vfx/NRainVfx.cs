using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NRainVfx.cs")]
public class NRainVfx : GpuParticles2D
{
	public new class MethodName : GpuParticles2D.MethodName
	{
		public static readonly StringName Create;

		public extern MethodName();
	}

	public new class PropertyName : GpuParticles2D.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : GpuParticles2D.SignalName
	{
		public extern SignalName();
	}

	public static extern NRainVfx Create();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NRainVfx();
}
