using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Utilities;

[ScriptPath("res://src/Core/Nodes/Vfx/Utilities/NScreenShake.cs")]
public class NScreenShake : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName SetTarget;

		public new static readonly StringName _Process;

		public static readonly StringName Shake;

		public static readonly StringName Rumble;

		public static readonly StringName AddTrauma;

		public static readonly StringName ClearTarget;

		public static readonly StringName StopRumble;

		public static readonly StringName SetMultiplier;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _shakeTarget;

		public static readonly StringName _originalTargetPosition;

		public static readonly StringName _multiplier;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public extern void SetTarget(Control targetScreen);

	public override extern void _Process(double delta);

	public extern void Shake(ShakeStrength strength, ShakeDuration duration, float degAngle);

	public extern void Rumble(ShakeStrength strength, ShakeDuration duration, RumbleStyle style);

	public extern void AddTrauma(ShakeStrength strength);

	public extern void ClearTarget();

	public extern void SetMultiplier(float multiplier);

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

	public extern NScreenShake();
}
