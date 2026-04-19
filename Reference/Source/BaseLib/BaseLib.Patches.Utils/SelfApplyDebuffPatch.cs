using System;
using System.Threading.Tasks;
using BaseLib.Abstracts;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Utils;

/// <summary>
/// If player applies a debuff to self or ally before turn ends (not from curse cards like doubt),
/// the debuff should tick it's duration at enemy's turn ends
/// </summary>
[HarmonyPatch(typeof(PowerCmd), "Apply", new Type[]
{
	typeof(PowerModel),
	typeof(Creature),
	typeof(decimal),
	typeof(Creature),
	typeof(CardModel),
	typeof(bool)
})]
public static class SelfApplyDebuffPatch
{
	[HarmonyPostfix]
	private static void Postfix(ref Task __result, PowerModel power, Creature target, Creature? applier, CardModel? cardSource)
	{
		__result = WrappedApplyTask(__result, power, target, applier, cardSource);
	}

	private static async Task WrappedApplyTask(Task originalTask, PowerModel power, Creature target, Creature? applier, CardModel? cardSource)
	{
		await originalTask;
		CombatState combatState = target.CombatState;
		if (combatState == null || (int)combatState.CurrentSide != 1 || (int)target.Side != 1 || power == null || (int)power.Type != 2)
		{
			return;
		}
		Creature applier2 = power.Applier;
		if (applier2 == null || (int)applier2.Side != 1)
		{
			return;
		}
		if (!(power is ICustomModel))
		{
			Creature applier3 = power.Applier;
			if (!(((applier3 != null) ? applier3.Monster : null) is ICustomModel))
			{
				Creature applier4 = power.Applier;
				object obj;
				if (applier4 == null)
				{
					obj = null;
				}
				else
				{
					Player player = applier4.Player;
					obj = ((player != null) ? player.Character : null);
				}
				if (!(obj is ICustomModel) && !(cardSource is ICustomModel))
				{
					return;
				}
			}
		}
		power.SkipNextDurationTick = false;
	}
}
