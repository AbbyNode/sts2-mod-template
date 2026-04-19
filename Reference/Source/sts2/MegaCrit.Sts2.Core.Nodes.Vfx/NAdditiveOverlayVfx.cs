using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NAdditiveOverlayVfx.cs")]
public class NAdditiveOverlayVfx : ColorRect
{
	public new class MethodName : ColorRect.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName SetVfxColor;

		public static readonly StringName OnTweenFinished;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : ColorRect.PropertyName
	{
		public static readonly StringName _vfxColor;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : ColorRect.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NAdditiveOverlayVfx? Create(VfxColor vfxColor = VfxColor.Red);

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

	public extern NAdditiveOverlayVfx();
}
