using System.ComponentModel;
using System.Runtime.CompilerServices;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NHealthBar.cs")]
public class NHealthBar : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public static readonly StringName DebugToggleVisibility;

		public static readonly StringName UpdateLayoutForCreatureBounds;

		public static readonly StringName UpdateWidthRelativeToReferenceValue;

		public static readonly StringName SetHpBarContainerSizeWithOffsets;

		public static readonly StringName SetHpBarContainerSizeWithOffsetsImmediately;

		public static readonly StringName RefreshValues;

		public static readonly StringName RefreshMiddleground;

		public static readonly StringName RefreshForeground;

		public static readonly StringName RefreshBlockUi;

		public static readonly StringName RefreshText;

		public static readonly StringName IsPoisonLethal;

		public static readonly StringName IsDoomLethal;

		public static readonly StringName GetFgWidth;

		public static readonly StringName FadeOutHpLabel;

		public static readonly StringName FadeInHpLabel;

		public static readonly StringName AnimateInBlock;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName MaxFgWidth;

		public static readonly StringName HpBarContainer;

		public static readonly StringName _hpForegroundContainer;

		public static readonly StringName _hpForeground;

		public static readonly StringName _poisonForeground;

		public static readonly StringName _doomForeground;

		public static readonly StringName _hpMiddleground;

		public static readonly StringName _hpLabel;

		public static readonly StringName _blockContainer;

		public static readonly StringName _blockLabel;

		public static readonly StringName _blockOutline;

		public static readonly StringName _infinityTex;

		public static readonly StringName _blockTween;

		public static readonly StringName _hpLabelFadeTween;

		public static readonly StringName _middlegroundTween;

		public static readonly StringName _originalBlockPosition;

		public static readonly StringName _currentHpOnLastRefresh;

		public static readonly StringName _maxHpOnLastRefresh;

		public static readonly StringName _expectedMaxFgWidth;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Control HpBarContainer
	{
		[CompilerGenerated]
		get;
	}

	public extern void SetCreature(Creature creature);

	public override extern void _Ready();

	public extern void UpdateLayoutForCreatureBounds(Control bounds);

	public extern void UpdateWidthRelativeToReferenceValue(float refMaxHp, float refWidth);

	public extern void RefreshValues();

	public extern void FadeOutHpLabel(float duration, float finalAlpha);

	public extern void FadeInHpLabel(float duration);

	public extern void AnimateInBlock(int oldBlock, int blockGain);

	public extern void TrackBlockStatus(Creature creature);

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

	public extern NHealthBar();
}
