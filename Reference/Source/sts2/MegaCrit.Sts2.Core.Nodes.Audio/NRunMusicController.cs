using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Audio;

[ScriptPath("res://src/Core/Nodes/Audio/NRunMusicController.cs")]
public class NRunMusicController : Node
{
	public new class MethodName : Node.MethodName
	{
		public static readonly StringName GetTrack;

		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public static readonly StringName UpdateMusic;

		public static readonly StringName PlayCustomMusic;

		public static readonly StringName UpdateCustomTrack;

		public static readonly StringName StopCustomMusic;

		public static readonly StringName UpdateAmbience;

		public static readonly StringName UpdateTrack;

		public static readonly StringName UpdateMusicParameter;

		public static readonly StringName ToggleMerchantTrack;

		public static readonly StringName TriggerEliteSecondPhase;

		public static readonly StringName TriggerCampfireGoingOut;

		public static readonly StringName StopMusic;

		public static readonly StringName LoadActBank;

		public static readonly StringName UnloadActBanks;

		public extern MethodName();
	}

	public new class PropertyName : Node.PropertyName
	{
		public static readonly StringName _proxy;

		public static readonly StringName _currentTrack;

		public static readonly StringName _currentAmbience;

		public extern PropertyName();
	}

	public new class SignalName : Node.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NRunMusicController? Instance { get; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	public extern void SetRunState(IRunState runState);

	public extern void UpdateMusic();

	public extern void PlayCustomMusic(string customMusic);

	public extern void UpdateCustomTrack(string customTrack, float label);

	public extern void StopCustomMusic();

	public extern void UpdateAmbience();

	public extern void UpdateTrack();

	public extern void UpdateMusicParameter(string label, float trackIndex);

	public extern void ToggleMerchantTrack();

	public extern void TriggerEliteSecondPhase();

	public extern void TriggerCampfireGoingOut();

	public extern void StopMusic();

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

	public extern NRunMusicController();
}
