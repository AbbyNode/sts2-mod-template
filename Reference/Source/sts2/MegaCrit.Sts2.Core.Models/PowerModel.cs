using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;

namespace MegaCrit.Sts2.Core.Models;

public abstract class PowerModel : AbstractModel
{
	public const string locTable = "powers";

	protected static readonly Color _normalAmountLabelColor;

	protected static readonly Color _debuffAmountLabelColor;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public virtual extern LocString Title { get; }

	public virtual extern LocString Description { get; }

	public extern LocString SmartDescription { get; }

	public extern bool HasSmartDescription { get; }

	public extern LocString RemoteDescription { get; }

	public extern bool HasRemoteDescription { get; }

	protected virtual extern string RemoteDescriptionLocKey { get; }

	protected virtual extern string SmartDescriptionLocKey { get; }

	protected extern LocString SelectionScreenPrompt { get; }

	public extern string PackedIconPath { get; }

	public extern string IconPath { get; }

	public extern Texture2D Icon { get; }

	public extern Texture2D BigIcon { get; }

	public extern string ResolvedBigIconPath { get; }

	public abstract PowerType Type { get; }

	public virtual extern bool IsInstanced { get; }

	public extern bool IsVisible { get; }

	protected virtual extern bool IsVisibleInternal { get; }

	public virtual extern bool ShouldPlayVfx { get; }

	public extern int Amount { get; set; }

	public extern int AmountOnTurnStart { get; set; }

	public virtual extern int DisplayAmount { get; }

	public virtual extern Color AmountLabelColor { get; }

	public abstract PowerStackType StackType { get; }

	public virtual extern bool AllowNegative { get; }

	public extern PowerType TypeForCurrentAmount { get; }

	public extern bool SkipNextDurationTick { get; set; }

	public extern Creature Owner { get; }

	public extern CombatState CombatState { get; }

	public extern Creature? Applier { get; set; }

	public extern Creature? Target { get; set; }

	public extern DynamicVarSet DynamicVars { get; }

	public virtual extern bool ShouldScaleInMultiplayer { get; }

	protected virtual extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public extern HoverTip DumbHoverTip { get; }

	protected virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public virtual extern bool OwnerIsSecondaryEnemy { get; }

	public extern event Action? PulsingStarted;

	public extern event Action? PulsingStopped;

	public extern event Action<PowerModel>? Flashed;

	public extern event Action? DisplayAmountChanged;

	public extern event Action? Removed;

	public extern void StartPulsing();

	public extern void StopPulsing();

	protected extern void Flash();

	protected extern void InvokeDisplayAmountChanged();

	public extern PowerType GetTypeForAmount(decimal customAmount);

	public extern bool ShouldRemoveDueToAmount();

	protected virtual extern object? InitInternalData();

	protected extern T GetInternalData<T>();

	public extern void SetAmount(int amount, bool silent = false);

	public extern PowerModel ToMutable(int initialAmount = 0);

	public extern void ApplyInternal(Creature owner, decimal amount, bool silent = false);

	public extern void RemoveInternal();

	protected override extern void DeepCloneFields();

	protected override extern void AfterCloned();

	public virtual extern Task BeforeApplied(Creature target, decimal amount, Creature? applier, CardModel? cardSource);

	public virtual extern Task AfterApplied(Creature? applier, CardModel? cardSource);

	public virtual extern Task AfterRemoved(Creature oldOwner);

	public virtual extern bool ShouldPowerBeRemovedAfterOwnerDeath();

	public virtual extern bool ShouldOwnerDeathTriggerFatal();

	protected extern PowerModel();
}
