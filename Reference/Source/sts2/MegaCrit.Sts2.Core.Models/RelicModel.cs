using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Models;

public abstract class RelicModel : AbstractModel
{
	protected const string _locTable = "relics";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public virtual extern LocString Title { get; }

	public extern LocString Flavor { get; }

	protected extern LocString EventDescription { get; }

	public extern LocString Description { get; }

	protected extern LocString SelectionScreenPrompt { get; }

	public extern LocString DynamicEventDescription { get; }

	public extern LocString DynamicDescription { get; }

	protected extern LocString? AdditionalRestSiteHealText { get; }

	protected virtual extern string IconBaseName { get; }

	public virtual extern string PackedIconPath { get; }

	protected virtual extern string PackedIconOutlinePath { get; }

	protected virtual extern string BigIconPath { get; }

	public extern string IconPath { get; }

	public extern Texture2D Icon { get; }

	public extern Texture2D IconOutline { get; }

	public extern Texture2D BigIcon { get; }

	public abstract RelicRarity Rarity { get; }

	public extern RelicPoolModel Pool { get; }

	public extern bool IsTradable { get; }

	public extern Player Owner { get; set; }

	public virtual extern bool IsUsedUp { get; }

	public virtual extern bool HasUponPickupEffect { get; }

	public virtual extern bool SpawnsPets { get; }

	public virtual extern bool IsStackable { get; }

	[SavedProperty(SerializationCondition.SaveIfNotTypeDefault)]
	public extern bool IsWax { get; set; }

	[SavedProperty(SerializationCondition.SaveIfNotTypeDefault)]
	public extern bool IsMelted { get; set; }

	public virtual extern bool AddsPet { get; }

	public extern int StackCount
	{
		[CompilerGenerated]
		get;
	}

	public extern DynamicVarSet DynamicVars { get; }

	protected virtual extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public virtual extern int MerchantCost { get; }

	public extern int FloorAddedToDeck { get; set; }

	public extern RelicStatus Status { get; set; }

	public virtual extern bool ShowCounter { get; }

	public virtual extern int DisplayAmount { get; }

	public virtual extern string FlashSfx { get; }

	public virtual extern bool ShouldFlashOnPlayer { get; }

	public extern HoverTip HoverTip { get; }

	protected virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern IEnumerable<IHoverTip> HoverTipsExcludingRelic { get; }

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public extern RelicModel CanonicalInstance { get; }

	public extern bool HasBeenRemovedFromState
	{
		[CompilerGenerated]
		get;
	}

	public override extern bool ShouldReceiveCombatHooks { get; }

	public extern event Action<RelicModel, IEnumerable<Creature>>? Flashed;

	public extern event Action? DisplayAmountChanged;

	public extern event Action? StatusChanged;

	public virtual extern bool IsAllowed(IRunState runState);

	protected static extern bool IsBeforeAct3TreasureChest(IRunState runState);

	public extern void Flash();

	public extern void Flash(IEnumerable<Creature> targets);

	protected extern void InvokeDisplayAmountChanged();

	public extern void UpdateTexture(TextureRect texture);

	public extern RelicModel ToMutable();

	protected override extern void DeepCloneFields();

	protected override extern void AfterCloned();

	public extern void RemoveInternal();

	public extern void IncrementStackCount();

	public virtual extern Task AfterObtained();

	public virtual extern Task AfterRemoved();

	public extern SerializableRelic ToSerializable();

	public static extern RelicModel FromSerializable(SerializableRelic save);

	protected extern void RelicIconChanged();

	protected static extern LocString L10NLookup(string entryName);

	protected extern RelicModel();
}
