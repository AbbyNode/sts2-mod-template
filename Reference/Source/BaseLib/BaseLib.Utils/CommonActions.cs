using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseLib.Extensions;
using MegaCrit.Sts2.Core.CardSelection;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Commands.Builders;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace BaseLib.Utils;

/// <summary>
/// Contains commonly used actions in cards as shortcuts that handle the most common ways these commands are used.
/// </summary>
public static class CommonActions
{
	/// <summary>
	/// Performs an attack using a card's DamageVar or CalculatedDamageVar on the card play's target.
	/// </summary>
	/// <param name="card"></param>
	/// <param name="play"></param>
	/// <param name="hitCount"></param>
	/// <param name="vfx"></param>
	/// <param name="sfx"></param>
	/// <param name="tmpSfx"></param>
	/// <returns></returns>
	public static AttackCommand CardAttack(CardModel card, CardPlay play, int hitCount = 1, string? vfx = null, string? sfx = null, string? tmpSfx = null)
	{
		return CardAttack(card, play.Target, hitCount, vfx, sfx, tmpSfx);
	}

	/// <summary>
	/// Performs an attack using a card's DamageVar or CalculatedDamageVar on a specified target.
	/// </summary>
	/// <param name="card"></param>
	/// <param name="target"></param>
	/// <param name="hitCount"></param>
	/// <param name="vfx"></param>
	/// <param name="sfx"></param>
	/// <param name="tmpSfx"></param>
	/// <returns></returns>
	/// <exception cref="T:System.Exception"></exception>
	public static AttackCommand CardAttack(CardModel card, Creature? target, int hitCount = 1, string? vfx = null, string? sfx = null, string? tmpSfx = null)
	{
		if (card.DynamicVars.ContainsKey("CalculatedDamage"))
		{
			return CardAttack(card, target, card.DynamicVars.CalculatedDamage, hitCount, vfx, sfx, tmpSfx);
		}
		if (card.DynamicVars.ContainsKey("Damage"))
		{
			return CardAttack(card, target, ((DynamicVar)card.DynamicVars.Damage).BaseValue, hitCount, vfx, sfx, tmpSfx);
		}
		throw new Exception("Card " + card.Title + " does not have a damage variable supported by CommonActions.CardAttack");
	}

	/// <summary>
	/// Performs an attacking using a specified amount of damage on a target.
	/// </summary>
	/// <param name="card"></param>
	/// <param name="target"></param>
	/// <param name="damage"></param>
	/// <param name="hitCount"></param>
	/// <param name="vfx"></param>
	/// <param name="sfx"></param>
	/// <param name="tmpSfx"></param>
	/// <returns></returns>
	/// <exception cref="T:System.Exception"></exception>
	public static AttackCommand CardAttack(CardModel card, Creature? target, decimal damage, int hitCount = 1, string? vfx = null, string? sfx = null, string? tmpSfx = null)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected I4, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		AttackCommand val = DamageCmd.Attack(damage).WithHitCount(hitCount).FromCard(card);
		CombatState combatState = card.CombatState;
		TargetType targetType = card.TargetType;
		switch (targetType - 2)
		{
		case 0:
			if (target == null)
			{
				return val;
			}
			val.Targeting(target);
			break;
		case 1:
			if (combatState == null)
			{
				return val;
			}
			val.TargetingAllOpponents(combatState);
			break;
		case 2:
			if (combatState == null)
			{
				return val;
			}
			val.TargetingRandomOpponents(combatState, true);
			break;
		default:
			throw new Exception($"Unsupported AttackCommand target type {card.TargetType} for card {card.Title}");
		}
		if (vfx != null || sfx != null || tmpSfx != null)
		{
			val.WithHitFx(vfx, sfx, tmpSfx);
		}
		return val;
	}

	/// <summary>
	/// Performs an attacking using aCalculatedDamageVar on a target.
	/// </summary>
	/// <param name="card"></param>
	/// <param name="target"></param>
	/// <param name="calculatedDamage"></param>
	/// <param name="hitCount"></param>
	/// <param name="vfx"></param>
	/// <param name="sfx"></param>
	/// <param name="tmpSfx"></param>
	/// <returns></returns>
	/// <exception cref="T:System.Exception"></exception>
	public static AttackCommand CardAttack(CardModel card, Creature? target, CalculatedDamageVar calculatedDamage, int hitCount = 1, string? vfx = null, string? sfx = null, string? tmpSfx = null)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected I4, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		AttackCommand val = DamageCmd.Attack(calculatedDamage).WithHitCount(hitCount).FromCard(card);
		CombatState combatState = card.CombatState;
		TargetType targetType = card.TargetType;
		switch (targetType - 2)
		{
		case 0:
			if (target == null)
			{
				return val;
			}
			val.Targeting(target);
			break;
		case 1:
			if (combatState == null)
			{
				return val;
			}
			val.TargetingAllOpponents(combatState);
			break;
		case 2:
			if (combatState == null)
			{
				return val;
			}
			val.TargetingRandomOpponents(combatState, true);
			break;
		default:
			throw new Exception($"Unsupported AttackCommand target type {card.TargetType} for card {card.Title}");
		}
		if (vfx != null || sfx != null || tmpSfx != null)
		{
			val.WithHitFx(vfx, sfx, tmpSfx);
		}
		return val;
	}

	/// <summary>
	/// Gains Block based on the card's BlockVar<seealso cref="T:MegaCrit.Sts2.Core.Localization.DynamicVars.BlockVar" />.
	/// </summary>
	/// <returns></returns>
	public static async Task<decimal> CardBlock(CardModel card, CardPlay play)
	{
		return await CardBlock(card, card.DynamicVars.Block, play);
	}

	/// <summary>
	/// Gains Block based on the given BlockVar<seealso cref="T:MegaCrit.Sts2.Core.Localization.DynamicVars.BlockVar" />.
	/// </summary>
	/// <returns></returns>
	public static async Task<decimal> CardBlock(CardModel card, BlockVar blockVar, CardPlay play)
	{
		return await CreatureCmd.GainBlock(card.Owner.Creature, blockVar, play, false);
	}

	/// <summary>
	/// Gains Block based on the given DynamicVar (supports CalculatedBlockVar)
	/// </summary>
	/// <param name="card"></param>
	/// <param name="var"></param>
	/// <param name="play"></param>
	/// <param name="fast"></param>
	/// <returns></returns>
	public static async Task<decimal> CardBlock(CardModel card, DynamicVar var, CardPlay play, bool fast = false)
	{
		CalculatedBlockVar val = (CalculatedBlockVar)(object)((var is CalculatedBlockVar) ? var : null);
		if (val != null)
		{
			return await CreatureCmd.GainBlock(card.Owner.Creature, ((CalculatedVar)val).Calculate(play.Target), val.Props, play, fast);
		}
		Creature creature = card.Owner.Creature;
		decimal baseValue = var.BaseValue;
		DynamicVar obj = ((var is BlockVar) ? var : null);
		return await CreatureCmd.GainBlock(creature, baseValue, (ValueProp)((obj == null) ? 8 : ((int)((BlockVar)obj).Props)), play, fast);
	}

	/// <summary>
	/// Draws cards based on the card's CardsVar<seealso cref="T:MegaCrit.Sts2.Core.Localization.DynamicVars.CardsVar" />.
	/// </summary>
	/// <returns></returns>
	public static async Task<IEnumerable<CardModel>> Draw(CardModel card, PlayerChoiceContext context)
	{
		return await CardPileCmd.Draw(context, ((DynamicVar)card.DynamicVars.Cards).BaseValue, card.Owner, false);
	}

	/// <summary>
	/// Applies the power specified as the generic parameter to the target using a PowerVar defined for that power.
	/// </summary>
	/// <returns></returns>
	public static async Task<T?> Apply<T>(Creature target, DynamicVarSource dynVarSource, bool silent = false) where T : PowerModel
	{
		return await PowerCmd.Apply<T>(target, dynVarSource.DynamicVars.Power<T>().BaseValue, dynVarSource.Owner, dynVarSource.Card, silent);
	}

	/// <summary>
	/// Applies the power specified as the generic parameter to multiple targets using a PowerVar defined for that power.
	/// </summary>
	/// <returns></returns>
	public static async Task<IReadOnlyList<T>> Apply<T>(IEnumerable<Creature> targets, DynamicVarSource dynVarSource, bool silent = false) where T : PowerModel
	{
		return await PowerCmd.Apply<T>(targets, dynVarSource.DynamicVars.Power<T>().BaseValue, dynVarSource.Owner, dynVarSource.Card, silent);
	}

	/// <summary>
	/// Applies the power specified as the generic parameter to the target using a PowerVar defined for that power.
	/// </summary>
	/// <returns></returns>
	public static async Task<T?> Apply<T>(Creature target, CardModel card, bool silent = false) where T : PowerModel
	{
		return await PowerCmd.Apply<T>(target, card.DynamicVars.Power<T>().BaseValue, card.Owner.Creature, card, silent);
	}

	/// <summary>
	/// Applies the power specified as the generic parameter to the target.
	/// </summary>
	/// <returns></returns>
	public static async Task<T?> Apply<T>(Creature target, CardModel? card, decimal amount, bool silent = false) where T : PowerModel
	{
		return await PowerCmd.Apply<T>(target, amount, (card != null) ? card.Owner.Creature : null, card, silent);
	}

	/// <summary>
	/// Applies the power specified as the generic parameter to the card's owner using a PowerVar defined for that power.
	/// </summary>
	public static async Task<T?> ApplySelf<T>(CardModel card, bool silent = false) where T : PowerModel
	{
		return await ApplySelf<T>(card, card.DynamicVars.Power<T>().BaseValue, silent);
	}

	/// <summary>
	/// Applies the power specified as the generic parameter to the card's owner.
	/// </summary>
	public static async Task<T?> ApplySelf<T>(CardModel card, decimal amount, bool silent = false) where T : PowerModel
	{
		return await PowerCmd.Apply<T>(card.Owner.Creature, amount, card.Owner.Creature, card, silent);
	}

	/// <summary>
	/// Opens a card selection screen where a specific number of cards must be selected and returns the selection result.
	/// </summary>
	/// <returns></returns>
	public static async Task<IEnumerable<CardModel>> SelectCards(CardModel card, LocString selectionPrompt, PlayerChoiceContext context, PileType pileType, int count = 1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		CardSelectorPrefs val = default(CardSelectorPrefs);
		((CardSelectorPrefs)(ref val))._002Ector(selectionPrompt, count);
		CardPile pile = PileTypeExtensions.GetPile(pileType, card.Owner);
		IReadOnlyList<CardModel> readOnlyList = pile.Cards;
		if ((int)pile.Type == 1)
		{
			readOnlyList = (from c in readOnlyList
				orderby c.Rarity, ((AbstractModel)c).Id
				select c).ToList();
		}
		return await CardSelectCmd.FromSimpleGrid(context, readOnlyList, card.Owner, val);
	}

	/// <summary>
	/// Opens a card selection screen where a range of cards must be selected and returns the selection result.
	/// </summary>
	/// <returns></returns>
	public static async Task<IEnumerable<CardModel>> SelectCards(CardModel card, LocString selectionPrompt, PlayerChoiceContext context, PileType pileType, int minCount, int maxCount)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		CardSelectorPrefs val = default(CardSelectorPrefs);
		((CardSelectorPrefs)(ref val))._002Ector(selectionPrompt, minCount, maxCount);
		CardPile pile = PileTypeExtensions.GetPile(pileType, card.Owner);
		IReadOnlyList<CardModel> readOnlyList = pile.Cards;
		if ((int)pile.Type == 1)
		{
			readOnlyList = (from c in readOnlyList
				orderby c.Rarity, ((AbstractModel)c).Id
				select c).ToList();
		}
		return await CardSelectCmd.FromSimpleGrid(context, readOnlyList, card.Owner, val);
	}

	/// <summary>
	/// Opens a card selection screen selecting a single card and returns that single card (or null if no card could be selected).
	/// </summary>
	/// <returns></returns>
	public static async Task<CardModel?> SelectSingleCard(CardModel card, LocString selectionPrompt, PlayerChoiceContext context, PileType pileType)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		CardSelectorPrefs val = default(CardSelectorPrefs);
		((CardSelectorPrefs)(ref val))._002Ector(selectionPrompt, 1);
		CardPile pile = PileTypeExtensions.GetPile(pileType, card.Owner);
		IReadOnlyList<CardModel> readOnlyList = pile.Cards;
		if ((int)pile.Type == 1)
		{
			readOnlyList = (from c in readOnlyList
				orderby c.Rarity, ((AbstractModel)c).Id
				select c).ToList();
		}
		return (await CardSelectCmd.FromSimpleGrid(context, readOnlyList, card.Owner, val)).FirstOrDefault();
	}
}
