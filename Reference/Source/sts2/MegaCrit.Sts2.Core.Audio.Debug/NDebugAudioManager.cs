using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Audio.Debug;

[ScriptPath("res://src/Core/Audio/Debug/NDebugAudioManager.cs")]
public class NDebugAudioManager : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName Play;

		public static readonly StringName Stop;

		public static readonly StringName StopInternalById;

		public static readonly StringName StopInternal;

		public static readonly StringName SetMasterAudioVolume;

		public static readonly StringName SetSfxAudioVolume;

		public static readonly StringName PlayerFinished;

		public static readonly StringName GetRandomPitchScale;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _nextId;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NDebugAudioManager? Instance { get; }

	public override extern void _Ready();

	public extern int Play(string streamName, float volume = 1f, PitchVariance variance = PitchVariance.None);

	public extern void Stop(int id, float fadeTime = 0.5f);

	public extern void SetMasterAudioVolume(float linearVolume);

	public extern void SetSfxAudioVolume(float linearVolume);

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

	public extern NDebugAudioManager();
}
