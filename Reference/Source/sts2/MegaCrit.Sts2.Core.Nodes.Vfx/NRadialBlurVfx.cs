using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NRadialBlurVfx.cs")]
public class NRadialBlurVfx : BackBufferCopy
{
	public new class MethodName : BackBufferCopy.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Activate;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : BackBufferCopy.PropertyName
	{
		public static readonly StringName _blurShader;

		public static readonly StringName _vfxPosition;

		public static readonly StringName _rect;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : BackBufferCopy.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void Activate(VfxPosition vfxPosition = VfxPosition.Center);

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

	public extern NRadialBlurVfx();
}
