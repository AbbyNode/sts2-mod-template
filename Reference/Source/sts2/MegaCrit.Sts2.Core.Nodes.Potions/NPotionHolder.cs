using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using Godot.Bridge;
using Godot.NativeInterop;
using MegaCrit.Sts2.Core.Nodes.GodotExtensions;

namespace MegaCrit.Sts2.Core.Nodes.Potions;

[ScriptPath("res://src/Core/Nodes/Potions/NPotionHolder.cs")]
public class NPotionHolder : NClickableControl
{
	public new class MethodName : NClickableControl.MethodName
	{
		public static readonly StringName Create;

		public new static readonly StringName _Ready;

		public new static readonly StringName OnFocus;

		public new static readonly StringName OnUnfocus;

		public new static readonly StringName OnPress;

		public new static readonly StringName OnRelease;

		public static readonly StringName OpenPotionPopup;

		public static readonly StringName AddPotion;

		public static readonly StringName DisableUntilPotionRemoved;

		public static readonly StringName CancelPotionUse;

		public static readonly StringName RemoveUsedPotion;

		public static readonly StringName DiscardPotion;

		public static readonly StringName ShouldCancelTargeting;

		public extern MethodName();
	}

	public new class PropertyName : NClickableControl.PropertyName
	{
		public static readonly StringName Potion;

		public static readonly StringName HasPotion;

		public static readonly StringName IsPotionUsable;

		public static readonly StringName _potionScale;

		public static readonly StringName _emptyIcon;

		public static readonly StringName _popup;

		public static readonly StringName _potionTargeting;

		public static readonly StringName _isUsable;

		public static readonly StringName _emptyPotionTween;

		public static readonly StringName _hoverTween;

		public static readonly StringName _disabledUntilPotionRemoved;

		public static readonly StringName _isFocused;

		public extern PropertyName();
	}

	public new class SignalName : NClickableControl.SignalName
	{
		public extern SignalName();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NPotion? Potion
	{
		[CompilerGenerated]
		get;
	}

	public extern bool HasPotion { get; }

	public extern bool IsPotionUsable { get; }

	public static extern IEnumerable<string> AssetPaths { get; }

	public static extern NPotionHolder Create(bool isUsable);

	public override extern void _Ready();

	protected override extern void OnFocus();

	protected override extern void OnUnfocus();

	protected override extern void OnPress();

	protected override extern void OnRelease();

	public extern void AddPotion(NPotion potion);

	public extern void DisableUntilPotionRemoved();

	public extern void CancelPotionUse();

	public extern void RemoveUsedPotion();

	public extern void DiscardPotion();

	[AsyncStateMachine(typeof(_003CUsePotion_003Ed__36))]
	public extern Task UsePotion();

	[AsyncStateMachine(typeof(_003CShineOnStartOfCombat_003Ed__39))]
	public extern Task ShineOnStartOfCombat();

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

	public extern NPotionHolder();
}
