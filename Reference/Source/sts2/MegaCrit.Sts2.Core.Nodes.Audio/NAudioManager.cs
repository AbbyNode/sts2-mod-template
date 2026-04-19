using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;

namespace MegaCrit.Sts2.Core.Nodes.Audio;

[ScriptPath("res://src/Core/Nodes/Audio/NAudioManager.cs")]
public class NAudioManager : Node
{
	public new class MethodName : Node.MethodName
	{
		public new static readonly StringName _EnterTree;

		public static readonly StringName PlayLoop;

		public static readonly StringName StopLoop;

		public static readonly StringName SetParam;

		public static readonly StringName StopAllLoops;

		public static readonly StringName PlayOneShot;

		public static readonly StringName PlayMusic;

		public static readonly StringName UpdateMusicParameter;

		public static readonly StringName StopMusic;

		public static readonly StringName SetMasterVol;

		public static readonly StringName SetSfxVol;

		public static readonly StringName SetAmbienceVol;

		public static readonly StringName SetBgmVol;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _audioNode;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NAudioManager? Instance { get; }

	public override extern void _EnterTree();

	public extern void PlayLoop(string path, bool usesLoopParam);

	public extern void StopLoop(string path);

	public extern void SetParam(string path, string param, float value);

	public extern void StopAllLoops();

	public extern void PlayOneShot(string path, Dictionary<string, float> parameters, float volume = 1f);

	public extern void PlayOneShot(string path, float volume = 1f);

	public extern void PlayMusic(string music);

	public extern void UpdateMusicParameter(string parameter, string value);

	public extern void StopMusic();

	public extern void SetMasterVol(float volume);

	public extern void SetSfxVol(float volume);

	public extern void SetAmbienceVol(float volume);

	public extern void SetBgmVol(float volume);

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

	public extern NAudioManager();
}
