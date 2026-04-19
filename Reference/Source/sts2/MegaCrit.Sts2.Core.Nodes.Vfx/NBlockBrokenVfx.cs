using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NBlockBrokenVfx.cs")]
public class NBlockBrokenVfx : Sprite2D
{
	public new class MethodName : Sprite2D.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName OnAnimationFinished;

		public static readonly StringName Create;

		public extern MethodName();
	}

	public new class PropertyName : Sprite2D.PropertyName
	{
		public extern PropertyName();
	}

	public new class SignalName : Sprite2D.SignalName
	{
		public extern SignalName();
	}

	public static extern IEnumerable<string> AssetPaths { get; }

	public override extern void _Ready();

	public static extern NBlockBrokenVfx? Create();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool InvokeGodotClassMethod(in godot_string_name method, NativeVariantPtrArgs args, out godot_variant ret);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassMethod(in godot_string_name method);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void SaveGodotObjectData(GodotSerializationInfo info);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RestoreGodotObjectData(GodotSerializationInfo info);

	public extern NBlockBrokenVfx();
}
