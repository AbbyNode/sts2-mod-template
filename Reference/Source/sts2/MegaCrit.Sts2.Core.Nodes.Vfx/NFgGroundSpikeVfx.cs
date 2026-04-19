using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NFgGroundSpikeVfx.cs")]
public class NFgGroundSpikeVfx : NBgGroundSpikeVfx
{
	public new class MethodName : NBgGroundSpikeVfx.MethodName
	{
		public new static readonly StringName Create;

		public new static readonly StringName AdjustStartPosition;

		public extern MethodName();
	}

	public new class PropertyName : NBgGroundSpikeVfx.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : NBgGroundSpikeVfx.SignalName
	{
		public extern SignalName();
	}

	public new static extern NFgGroundSpikeVfx? Create(Vector2 position, bool movingRight = true, VfxColor vfxColor = VfxColor.Red);

	protected override extern void AdjustStartPosition();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NFgGroundSpikeVfx();
}
