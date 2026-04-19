using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx;

[ScriptPath("res://src/Core/Nodes/Vfx/NDoomSubEmitterVfx.cs")]
public class NDoomSubEmitterVfx : Node2D
{
	public new class MethodName : Node2D.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName FireSpear;

		public static readonly StringName FireAllSpears;

		public static readonly StringName ShowOrHide;

		public static readonly StringName UpdateWidth;

		public static readonly StringName SetVisibility;

		public new static readonly StringName _ExitTree;

		public extern MethodName();
	}

	public new class PropertyName : Node2D.PropertyName
	{
		public static readonly StringName CurScaleX;

		public static readonly StringName _scalableLayers;

		public static readonly StringName _spears;

		public static readonly StringName _verticalShrinkingLayer;

		public static readonly StringName _particlesToKeepDense;

		public static readonly StringName _baseScales;

		public static readonly StringName _indeces;

		public static readonly StringName _baseSpearRegionWidth;

		public static readonly StringName _dumbHackBecauseOfHowTexturerectsWork;

		public static readonly StringName _rotationHackForSameDumbReason;

		public static readonly StringName _baseParticleDensity;

		public static readonly StringName _spearFixedHScale;

		public static readonly StringName _spearAngleIntensity;

		public static readonly StringName _minSpearSize;

		public static readonly StringName _maxSpearSize;

		public static readonly StringName _minSpearTime;

		public static readonly StringName _maxSpearTime;

		public static readonly StringName _outerMargin;

		public static readonly StringName _innerMargin;

		public static readonly StringName _time;

		public static readonly StringName _isOn;

		public static readonly StringName _curScaleX;

		public static readonly StringName _tween;

		public extern PropertyName();
	}

	public new class SignalName : Node2D.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern float CurScaleX { get; set; }

	public override extern void _Ready();

	public extern void ShowOrHide(float widthScale, float tweenTime);

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

	public extern NDoomSubEmitterVfx();
}
