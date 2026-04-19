using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using BaseLib.Utils.Patching;
using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// Patches Scrawl, Dredge, CrashLanding, and Pillage OnPlay hand-size constants to use GetMaxHandSize(player).
/// </summary>
[HarmonyPatch]
public static class CardOnPlay_MaxHandSizePatch
{
	private static IEnumerable<MethodBase> TargetMethods()
	{
		yield return AccessTools.AsyncMoveNext((MethodBase)AccessTools.Method(typeof(Scrawl), "OnPlay", new Type[2]
		{
			typeof(PlayerChoiceContext),
			typeof(CardPlay)
		}, (Type[])null));
		yield return AccessTools.AsyncMoveNext((MethodBase)AccessTools.Method(typeof(Dredge), "OnPlay", new Type[2]
		{
			typeof(PlayerChoiceContext),
			typeof(CardPlay)
		}, (Type[])null));
		yield return AccessTools.AsyncMoveNext((MethodBase)AccessTools.Method(typeof(CrashLanding), "OnPlay", new Type[2]
		{
			typeof(PlayerChoiceContext),
			typeof(CardPlay)
		}, (Type[])null));
		yield return AccessTools.AsyncMoveNext((MethodBase)AccessTools.Method(typeof(Pillage), "OnPlay", new Type[2]
		{
			typeof(PlayerChoiceContext),
			typeof(CardPlay)
		}, (Type[])null));
	}

	[HarmonyTranspiler]
	private static List<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator il, MethodBase original)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		List<CodeInstruction> list = instructions.ToList();
		new InstructionPatcher(list).Match(new InstructionMatcher().ldarg_0().ldfld(null).PredicateMatch((object? op) => op is FieldInfo fieldInfo && typeof(CardModel).IsAssignableFrom(fieldInfo.FieldType))).CopyMatch(out List<CodeInstruction> match);
		for (int num = 0; num < list.Count; num++)
		{
			if (MaxHandSizePatch.IsDefaultMaxHandSizeConst(list[num]))
			{
				list[num] = new CodeInstruction(OpCodes.Call, (object)AccessTools.Method(typeof(MaxHandSizePatch), "GetMaxHandSizeFromCard", (Type[])null, (Type[])null));
				list.InsertRange(num, match.Select((CodeInstruction ci) => ci.Clone()));
				num += match.Count;
			}
		}
		return list;
	}
}
