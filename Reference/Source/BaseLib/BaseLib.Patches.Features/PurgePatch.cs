using BaseLib.Cards;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Features;

[HarmonyPatch(typeof(CardModel), "GetResultPileType")]
public class PurgePatch
{
	[HarmonyPrefix]
	private static bool GoAwayForever(CardModel __instance, ref PileType __result)
	{
		if (ShouldPurge(__instance))
		{
			__result = (PileType)0;
			return false;
		}
		return true;
	}

	public static bool ShouldPurge(CardModel c)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return c.Keywords.Contains(BaseLibKeywords.Purge);
	}
}
