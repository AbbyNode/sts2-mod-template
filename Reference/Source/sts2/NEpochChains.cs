using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

[ScriptPath("res://src/Core/Nodes/Vfx/Ui/NEpochChains.cs")]
public class NEpochChains : TextureRect
{
	[Signal]
	public delegate void OnAnimationFinishedEventHandler();

	public new class MethodName : TextureRect.MethodName
	{
		public static readonly StringName UpdateParticles;

		public static readonly StringName SetProperties;

		public static readonly StringName Unlock;

		public extern MethodName();
	}

	public new class PropertyName : TextureRect.PropertyName
	{
		public static readonly StringName _duration;

		public static readonly StringName _particles;

		public static readonly StringName _endParticles;

		public static readonly StringName _particlesCurve;

		public static readonly StringName _brightEnabledCurve;

		public static readonly StringName _erosionEnabledCurve;

		public static readonly StringName _erosionBaseCurve;

		public static readonly StringName _previousParticleIndex;

		public static readonly StringName _asShaderMaterial;

		public extern PropertyName();
	}

	public new class SignalName : TextureRect.SignalName
	{
		public static readonly StringName OnAnimationFinished;

		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event OnAnimationFinishedEventHandler OnAnimationFinished;

	public extern void Unlock();

	[AsyncStateMachine(typeof(_003CUnlocking_003Ed__16))]
	public extern Task Unlocking();

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

	protected extern void EmitSignalOnAnimationFinished();

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern void RaiseGodotClassSignalCallbacks(in godot_string_name signal, NativeVariantPtrArgs args);

	[EditorBrowsable(EditorBrowsableState.Never)]
	protected override extern bool HasGodotClassSignal(in godot_string_name signal);

	public extern NEpochChains();
}
