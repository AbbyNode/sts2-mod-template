using System.ComponentModel;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.UI;

namespace MegaCrit.Sts2.Core.Nodes.Combat;

[ScriptPath("res://src/Core/Nodes/Combat/NCreatureStateDisplay.cs")]
public class NCreatureStateDisplay : Control
{
	public new class MethodName : Control.MethodName
	{
		public new static readonly StringName _Ready;

		public new static readonly StringName _EnterTree;

		public new static readonly StringName _ExitTree;

		public static readonly StringName SubscribeToCreatureEvents;

		public static readonly StringName DebugToggleVisibility;

		public static readonly StringName SetCreatureBounds;

		public static readonly StringName RefreshValues;

		public static readonly StringName OnHovered;

		public static readonly StringName OnUnhovered;

		public static readonly StringName ShowNameplate;

		public static readonly StringName HideNameplate;

		public static readonly StringName HideImmediately;

		public static readonly StringName AnimateIn;

		public static readonly StringName AnimateInBlock;

		public static readonly StringName AnimateOut;

		public static readonly StringName OnBlockTrackingCreatureBlockChanged;

		public extern MethodName();
	}

	public new class PropertyName : Control.PropertyName
	{
		public static readonly StringName _powerContainer;

		public static readonly StringName _nameplateContainer;

		public static readonly StringName _nameplateLabel;

		public static readonly StringName _healthBar;

		public static readonly StringName _hpBarHitbox;

		public static readonly StringName _creatureSize;

		public static readonly StringName _showHideTween;

		public static readonly StringName _hoverTween;

		public static readonly StringName _originalPosition;

		public extern PropertyName();
	}

	public new class SignalName : Control.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern void _Ready();

	public override extern void _EnterTree();

	public override extern void _ExitTree();

	public extern void SetCreature(Creature creature);

	public extern void SetCreatureBounds(Control bounds);

	public extern void ShowNameplate();

	public extern void HideNameplate();

	public extern void HideImmediately();

	public extern void AnimateIn(HealthBarAnimMode mode);

	public extern void AnimateOut();

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

	public extern NCreatureStateDisplay();
}
