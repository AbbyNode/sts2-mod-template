using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Godot;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Enchantments;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Saves.Runs;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models;

public abstract class EnchantmentModel : AbstractModel
{
	public const string locTable = "enchantments";

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern LocString Title { get; }

	public extern LocString Description { get; }

	public extern LocString ExtraCardText { get; }

	public virtual extern bool HasExtraCardText { get; }

	public extern LocString DynamicDescription { get; }

	public extern LocString? DynamicExtraCardText { get; }

	public static extern string MissingIconPath { get; }

	public extern string IntendedIconPath { get; }

	public extern string IconPath { get; }

	public extern CompressedTexture2D Icon { get; }

	public virtual extern bool ShowAmount { get; }

	public virtual extern int DisplayAmount { get; }

	public override extern bool PreviewOutsideOfCombat { get; }

	public override extern bool ShouldReceiveCombatHooks { get; }

	public virtual extern bool ShouldStartAtBottomOfDrawPile { get; }

	public extern CardModel Card { get; set; }

	public extern bool HasCard { get; }

	public extern int Amount { get; set; }

	[JsonPropertyName("props")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public extern SavedProperties? Props
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public virtual extern bool IsStackable { get; }

	public extern DynamicVarSet DynamicVars { get; }

	protected virtual extern IEnumerable<DynamicVar> CanonicalVars { get; }

	public extern EnchantmentStatus Status { get; set; }

	public virtual extern bool ShouldGlowGold { get; }

	public virtual extern bool ShouldGlowRed { get; }

	public extern EnchantmentModel CanonicalInstance { get; }

	public extern HoverTip HoverTip { get; }

	protected virtual extern IEnumerable<IHoverTip> ExtraHoverTips { get; }

	public extern IEnumerable<IHoverTip> HoverTips { get; }

	public extern event Action? StatusChanged;

	public virtual extern bool CanEnchantCardType(CardType cardType);

	public virtual extern bool CanEnchant(CardModel card);

	public virtual extern Task OnPlay(PlayerChoiceContext choiceContext, CardPlay? cardPlay);

	public extern EnchantmentModel ToMutable();

	protected override extern void DeepCloneFields();

	public extern void ApplyInternal(CardModel card, decimal amount);

	public extern void ClearInternal();

	public extern void ModifyCard();

	public virtual extern void RecalculateValues();

	public extern SerializableEnchantment ToSerializable();

	public static extern EnchantmentModel FromSerializable(SerializableEnchantment save);

	protected virtual extern void OnEnchant();

	public virtual extern decimal EnchantBlockAdditive(decimal originalBlock, ValueProp props);

	public virtual extern decimal EnchantBlockMultiplicative(decimal originalBlock, ValueProp props);

	public virtual extern decimal EnchantDamageAdditive(decimal originalDamage, ValueProp props);

	public virtual extern decimal EnchantDamageMultiplicative(decimal originalDamage, ValueProp props);

	public virtual extern int EnchantPlayCount(int originalPlayCount);

	protected extern EnchantmentModel();
}
