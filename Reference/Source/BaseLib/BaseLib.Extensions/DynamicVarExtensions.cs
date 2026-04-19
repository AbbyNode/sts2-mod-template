using System;
using System.Collections.Generic;
using BaseLib.Utils;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Hooks;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.ValueProps;

namespace BaseLib.Extensions;

public static class DynamicVarExtensions
{
	[HarmonyPatch(typeof(DynamicVar), "Clone")]
	private class CloneTooltips
	{
		[HarmonyPostfix]
		private static DynamicVar Copy(DynamicVar __result, DynamicVar __instance)
		{
			DynamicVarTips[__result] = DynamicVarTips[__instance];
			DynamicVarUpgrades[__result] = DynamicVarUpgrades[__instance];
			return __result;
		}
	}

	public static readonly SpireField<DynamicVar, Func<IHoverTip>> DynamicVarTips = new SpireField<DynamicVar, Func<IHoverTip>>(() => (Func<IHoverTip>?)null);

	public static readonly SpireField<DynamicVar, decimal?> DynamicVarUpgrades = new SpireField<DynamicVar, decimal?>(() => (decimal?)null);

	public static TDynamicVar WithUpgrade<TDynamicVar>(this TDynamicVar dynamicVar, decimal upgradeValue) where TDynamicVar : DynamicVar
	{
		if (upgradeValue != 0m)
		{
			DynamicVarUpgrades[(DynamicVar)(object)dynamicVar] = upgradeValue;
		}
		return dynamicVar;
	}

	public static decimal CalculateBlock(this DynamicVar var, Creature creature, ValueProp props, CardPlay? cardPlay = null, CardModel? cardSource = null)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		decimal baseValue = var.BaseValue;
		if (!CombatManager.Instance.IsInProgress)
		{
			return baseValue;
		}
		if (CombatManager.Instance.IsEnding)
		{
			return baseValue;
		}
		CombatState combatState = creature.CombatState;
		if (combatState == null)
		{
			return baseValue;
		}
		IEnumerable<AbstractModel> enumerable = default(IEnumerable<AbstractModel>);
		baseValue = Hook.ModifyBlock(combatState, creature, baseValue, props, cardSource, cardPlay, ref enumerable);
		return Math.Max(baseValue, 0m);
	}

	/// <summary>
	/// Adds a tooltip to a card this DynamicVar is attached to.
	/// By default will pull from the static_hover_tips table.
	/// The key will be the variable's name, with a mod prefix added, in the form of "PREFIX-NAME" (all capitalized).
	/// </summary>
	/// <returns></returns>
	public static TDynamicVar WithTooltip<TDynamicVar>(this TDynamicVar var, string? locKey = null, string locTable = "static_hover_tips") where TDynamicVar : DynamicVar
	{
		string key = locKey ?? (((object)var).GetType().GetPrefix() + StringHelper.Slugify(((DynamicVar)var).Name));
		DynamicVarTips[(DynamicVar)(object)var] = delegate
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			LocString val = new LocString(locTable, key + ".title");
			LocString val2 = new LocString(locTable, key + ".description");
			val.Add((DynamicVar)(object)var);
			val2.Add((DynamicVar)(object)var);
			return (IHoverTip)(object)new HoverTip(val, val2, (Texture2D)null);
		};
		return var;
	}
}
