using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;
using MegaCrit.Sts2.Core.Timeline;

namespace MegaCrit.Sts2.Core.Nodes.Screens.Timeline;

[ScriptPath("res://src/Core/Nodes/Screens/Timeline/NEpochSlot.cs")]
public class NEpochSlot : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName OnRelease;

		public static readonly StringName RevealEpoch;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName _Process;

		public static readonly StringName DisableHighlight;

		public static readonly StringName EnableHighlight;

		public static readonly StringName SetState;

		public static readonly StringName UpdateShaderS;

		public static readonly StringName UpdateShaderV;

		public static readonly StringName UpdateBlurLod;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public new static readonly StringName ClickedSfx;

		public new static readonly StringName HoveredSfx;

		public static readonly StringName State;

		public static readonly StringName HasSpawned;

		public static readonly StringName _slotImage;

		public static readonly StringName _portrait;

		public static readonly StringName _chains;

		public static readonly StringName _hsv;

		public static readonly StringName _blurPortrait;

		public static readonly StringName _outline;

		public static readonly StringName _blur;

		public static readonly StringName _blurShader;

		public static readonly StringName _selectionReticle;

		public static readonly StringName _offscreenVfx;

		public static readonly StringName _highlightVfx;

		public static readonly StringName _subViewportContainer;

		public static readonly StringName _subViewport;

		public static readonly StringName _isGlowPulsing;

		public static readonly StringName _isComplete;

		public new static readonly StringName _isHovered;

		public static readonly StringName _era;

		public static readonly StringName eraPosition;

		public static readonly StringName _glowTween;

		public static readonly StringName _spawnTween;

		public static readonly StringName _hoverTween;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	public static readonly IEnumerable<string> assetPaths;

	public EpochModel model;

	public int eraPosition;

	protected override extern string ClickedSfx { get; }

	protected override extern string HoveredSfx { get; }

	public extern EpochSlotState State
	{
		[CompilerGenerated]
		get;
	}

	public extern bool HasSpawned
	{
		[CompilerGenerated]
		get;
	}

	public override extern void _Ready();

	public static extern NEpochSlot Create(EpochSlotData data);

	protected override extern void OnRelease();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	[AsyncStateMachine(typeof(_003CSpawnSlot_003Ed__50))]
	public extern Task SpawnSlot();

	public override extern void _Process(double delta);

	public extern void SetState(EpochSlotState setState);

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

	public extern NEpochSlot();
}
