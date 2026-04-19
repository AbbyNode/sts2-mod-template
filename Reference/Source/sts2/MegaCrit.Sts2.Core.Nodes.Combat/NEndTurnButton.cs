using System.Collections.Generic;
using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NEndTurnButton.cs")]
public class NEndTurnButton : NButton
{
	public new class MethodName : NButton.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName StartOrStopPulseVfx;

		public static readonly StringName GlowPulse;

		public new static readonly StringName OnRelease;

		public static readonly StringName CallReleaseLogic;

		public static readonly StringName SecretEndTurnLogicViaFtue;

		public static readonly StringName ShouldShowPlayableCardsFtue;

		public new static readonly StringName OnEnable;

		public new static readonly StringName OnDisable;

		public static readonly StringName AnimOut;

		public static readonly StringName AnimIn;

		public static readonly StringName OnCombatEnded;

		public new static readonly StringName OnFocus;

		public static readonly StringName HasPlayableCard;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public static readonly StringName UpdateShaderV;

		public static readonly StringName SetState;

		public static readonly StringName RefreshEnabled;

		public extern MethodName();
	}

	public new class PropertyName : NButton.PropertyName
	{
		public static readonly StringName CanTurnBeEnded;

		public static readonly StringName ShowPos;

		public static readonly StringName HidePos;

		public new static readonly StringName Hotkeys;

		public static readonly StringName _state;

		public static readonly StringName _isShiny;

		public static readonly StringName _visuals;

		public static readonly StringName _glowTexture;

		public static readonly StringName _normalTexture;

		public static readonly StringName _image;

		public static readonly StringName _hsv;

		public static readonly StringName _glow;

		public static readonly StringName _glowVfx;

		public static readonly StringName _label;

		public static readonly StringName _combatUi;

		public static readonly StringName _viewport;

		public static readonly StringName _playerIconContainer;

		public static readonly StringName _longPressBar;

		public static readonly StringName _pulseTimer;

		public static readonly StringName _positionTween;

		public static readonly StringName _hoverTween;

		public static readonly StringName _glowVfxTween;

		public static readonly StringName _glowEnableTween;

		public static readonly StringName _endTurnWithNoPlayableCardsCount;

		public extern PropertyName();
	}

	public new class SignalName : NButton.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern IEnumerable<string> AssetPaths { get; }

	protected override extern string[] Hotkeys { get; }

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void Initialize(CombatState state);

	protected override extern void OnRelease();

	public extern void CallReleaseLogic();

	public extern void SecretEndTurnLogicViaFtue();

	protected override extern void OnEnable();

	protected override extern void OnDisable();

	public extern void OnCombatEnded();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	public extern void RefreshEnabled();

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

	public extern NEndTurnButton();
}
