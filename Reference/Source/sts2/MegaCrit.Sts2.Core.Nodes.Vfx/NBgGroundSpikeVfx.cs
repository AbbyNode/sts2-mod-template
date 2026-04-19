using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NBgGroundSpikeVfx.cs")]
public class NBgGroundSpikeVfx : Sprite2D
{
	public new class MethodName : Sprite2D.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName SetColor;

		public static readonly StringName AdjustStartPosition;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName _Process;

		public extern MethodName();
	}

	public new class PropertyName : Sprite2D.PropertyName
	{
		public static readonly StringName _startPosition;

		public static readonly StringName _movingRight;

		public static readonly StringName _vfxColor;

		public static readonly StringName _velocity;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : Sprite2D.SignalName
	{
		public extern SignalName();
	}

	protected Vector2 _startPosition;

	protected bool _movingRight;

	protected VfxColor _vfxColor;

	public static extern NBgGroundSpikeVfx? Create(Vector2 position, bool movingRight = true, VfxColor vfxColor = VfxColor.Red);

	public override extern void _Ready();

	protected virtual extern void AdjustStartPosition();

	public override extern void _ExitTree();

	public override extern void _Process(double delta);

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

	public extern NBgGroundSpikeVfx();
}
