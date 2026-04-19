using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Cards;

[ScriptPath("res://src/Core/Nodes/Vfx/Cards/NCardRareGlow.cs")]
public class NCardRareGlow : GpuParticles2D
{
	public new class MethodName : GpuParticles2D.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName Kill;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : GpuParticles2D.PropertyName
	{
		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : GpuParticles2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NCardRareGlow? Create();

	public override extern void _Ready();

	public extern void Kill();

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

	public extern NCardRareGlow();
}
