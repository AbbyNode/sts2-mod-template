using BaseLib.Cards.Variables;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Features;

[HarmonyPatch(typeof(CardModel), "GetResultPileType")]
public static class ExhaustivePatch
{
	private static void Postfix(CardModel __instance, ref PileType __result)
	{
		if (ExhaustForExhaustive(__instance))
		{
			__result = (PileType)4;
		}
	}

	private static bool ExhaustForExhaustive(CardModel card)
	{
		DynamicVar val = default(DynamicVar);
		if (card.DynamicVars.TryGetValue("Exhaustive", ref val))
		{
			return val.IntValue <= 1;
		}
		return false;
	}

	public static int GetExhaustive(CardModel card)
	{
		DynamicVar val = default(DynamicVar);
		int baseExhaustive = (card.DynamicVars.TryGetValue("Exhaustive", ref val) ? val.IntValue : 0);
		return ExhaustiveVar.ExhaustiveCount(card, baseExhaustive);
	}
}
