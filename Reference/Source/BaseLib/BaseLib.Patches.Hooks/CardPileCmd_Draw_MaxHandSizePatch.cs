using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using BaseLib.Utils.Patching;
using HarmonyLib;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// Patches <c>static Task&lt;IEnumerable&lt;CardModel&gt;&gt; CardPileCmd.Draw(PlayerChoiceContext choiceContext, decimal count, Player player, bool fromHandDraw = false)</c>.
/// Changes the max hand size constant to a call to GetMaxHandSize(player).
/// </summary>
[HarmonyPatch]
public static class CardPileCmd_Draw_MaxHandSizePatch
{
	private static MethodInfo TargetMethod()
	{
		return AccessTools.AsyncMoveNext((MethodBase)AccessTools.Method(typeof(CardPileCmd), "Draw", new Type[4]
		{
			typeof(PlayerChoiceContext),
			typeof(decimal),
			typeof(Player),
			typeof(bool)
		}, (Type[])null));
	}

	[HarmonyTranspiler]
	private static List<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator il, MethodBase original)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		List<CodeInstruction> list = instructions.ToList();
		new InstructionPatcher(list).Match(new InstructionMatcher().ldarg_0().ldfld(null).PredicateMatch((object? op) => op is FieldInfo fieldInfo && fieldInfo.FieldType == typeof(Player))).CopyMatch(out List<CodeInstruction> match);
		for (int num = 0; num < list.Count; num++)
		{
			if (MaxHandSizePatch.IsDefaultMaxHandSizeConst(list[num]))
			{
				list[num] = new CodeInstruction(OpCodes.Call, (object)MaxHandSizePatch.GetMaxHandSizeMethod);
				list.InsertRange(num, match.Select((CodeInstruction ci) => ci.Clone()));
				num += match.Count;
			}
		}
		return list;
	}
}
