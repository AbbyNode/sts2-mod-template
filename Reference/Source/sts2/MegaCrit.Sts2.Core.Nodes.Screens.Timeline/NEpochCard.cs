using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/NEpochCard.cs")]
public class NEpochCard : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _Process;

		public static readonly StringName SetToWigglyUnlockPreviewMode;

		public static readonly StringName GlowFlash;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _glow;

		public static readonly StringName _mask;

		public static readonly StringName _portrait;

		public static readonly StringName _isHovered;

		public static readonly StringName _isHoverable;

		public static readonly StringName _isHeld;

		public static readonly StringName _isWigglyUnlockPreviewMode;

		public static readonly StringName _glowTween;

		public static readonly StringName _targetScale;

		public static readonly StringName _time;

		public static readonly StringName _noiseSpeed;

		public static readonly StringName _noise;

		public static readonly StringName _denyTween;

		public static readonly StringName _transparencyTween;

		public static readonly StringName _scaleTween;

		public static readonly StringName _blueGlowColor;

		public static readonly StringName _goldGlowColor;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern void Init(EpochModel epochModel);

	public override extern void _Ready();

	public override extern void _Process(double delta);

	public extern void SetToWigglyUnlockPreviewMode();

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

	public extern NEpochCard();
}
