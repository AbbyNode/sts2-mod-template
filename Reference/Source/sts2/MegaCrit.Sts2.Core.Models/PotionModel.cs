using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Potions;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class PotionModel : AbstractModel
{
	public const string locTable = "potions";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LocString Title { get; }

	public extern LocString Description { get; }

	public extern LocString SelectionScreenPrompt { get; }

	public extern LocString StaticDescription { get; }

	public extern LocString DynamicDescription { get; }

	public extern string ImagePath { get; }

	public extern Texture2D Image { get; }

	public extern string? OutlinePath { get; }

	public extern Texture2D? Outline { get; }

	public abstract PotionRarity Rarity { get; }

	public abstract PotionUsage Usage { get; }

	public abstract TargetType TargetType { get; }

	public extern PotionPoolModel Pool { get; }

	public extern Player Owner { get; set; }

	public extern DynamicVarSet DynamicVars { get; }

	protected virtual extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public extern bool IsQueued
	{
		[CompilerGenerated]
		get;
	}

	public virtual extern bool CanBeGeneratedInCombat { get; }

	public virtual extern bool PassesCustomUsabilityCheck { get; }

	public extern HoverTip HoverTip { get; }

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern PotionModel CanonicalInstance { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public extern bool HasBeenRemovedFromState
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action? BeforeUse;

	public extern PotionModel ToMutable();

	protected override extern void AfterCloned();

	public extern void Discard();

	public extern void RemoveBeforeUse();

	public extern void EnqueueManualUse(Creature? target);

	[AsyncStateMachine(typeof(_003COnUseWrapper_003Ed__72))]
	public extern Task OnUseWrapper(PlayerChoiceContext choiceContext, Creature? target);

	public extern void AfterUsageCanceled();

	protected virtual extern Task OnUse(PlayerChoiceContext choiceContext, Creature? target);

	public extern SerializablePotion ToSerializable(int slotIndex);

	public static extern PotionModel FromSerializable(SerializablePotion save);

	protected static extern void AssertValidForTargetedPotion([NotNull] Creature? target);

	public extern bool CanThrowAtAlly();

	protected extern PotionModel();
}
