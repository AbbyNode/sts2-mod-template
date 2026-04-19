using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Vfx.Ui;

[ScriptPath("res://src/Core/Nodes/Vfx/Ui/NGaseousScreenVfx.cs")]
public class NGaseousScreenVfx : AspectRatioContainer
{
	public new class MethodName : AspectRatioContainer.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public static readonly StringName SetProperties;

		public static readonly StringName Play;

		public extern MethodName();
	}

	public new class PropertyName : AspectRatioContainer.PropertyName
	{
		public static readonly StringName _gfx;

		public static readonly StringName _duration;

		public static readonly StringName _alphaMultiplierCurve;

		public static readonly StringName _minBaseAlphaCurve;

		public static readonly StringName _erosionCurve;

		public static readonly StringName _noiseAOffsetCurve;

		public static readonly StringName _noiseBOffsetCurve;

		public static readonly StringName _originalMaterial;

		public static readonly StringName _materialCopy;

		public static readonly StringName _noiseAOffsetY;

		public static readonly StringName _noiseBOffsetY;

		public extern PropertyName();
	}

	public new class SignalName : AspectRatioContainer.SignalName
	{
		public extern SignalName();
	}

	public static readonly string scenePath;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NGaseousScreenVfx? Create();

	public override extern void _Ready();

	public extern void Play();

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

	public extern NGaseousScreenVfx();
}
