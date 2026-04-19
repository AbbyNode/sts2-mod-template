using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.CommonUi;

[ScriptPath("res://src/Core/Nodes/CommonUi/NProceedButton.cs")]
public class NProceedButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _ExitTree;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public new static readonly StringName OnRelease;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public static readonly StringName DebugToggleVisibility;

		public static readonly StringName SetPulseState;

		public static readonly StringName StartGlowTween;

		public static readonly StringName StopGlowTween;

		public static readonly StringName UpdateShaderS;

		public static readonly StringName UpdateShaderV;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName IsSkip;

		public new static readonly StringName Hotkeys;

		public static readonly StringName ShowPos;

		public static readonly StringName HidePos;

		public static readonly StringName _outline;

		public static readonly StringName _buttonImage;

		public static readonly StringName _label;

		public static readonly StringName _hsv;

		public static readonly StringName _viewport;

		public static readonly StringName _defaultOutlineColor;

		public static readonly StringName _hoveredOutlineColor;

		public static readonly StringName _downColor;

		public static readonly StringName _outlineColor;

		public static readonly StringName _outlineTransparentColor;

		public static readonly StringName _animTween;

		public static readonly StringName _glowTween;

		public static readonly StringName _hoverTween;

		public static readonly StringName _elapsedTime;

		public static readonly StringName _shouldPulse;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern LocString ProceedLoc { get; }

	public static extern LocString SkipLoc { get; }

	public extern bool IsSkip
	{
		[CompilerGenerated]
		get;
	}

	protected override extern string[] Hotkeys { get; }

	public override extern void _Ready();

	public override extern void _ExitTree();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	protected override extern void OnRelease();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	public extern void UpdateText(LocString loc);

	public extern void SetPulseState(bool isPulsing);

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

	public extern NProceedButton();
}
