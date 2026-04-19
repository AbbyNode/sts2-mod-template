using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using MegaCrit.Sts2.Core.Commands;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// Patches <c>static bool CardPileCmd.CheckIfDrawIsPossibleAndShowThoughtBubbleIfNot(Player player)</c>.
/// Changes the max hand size constant to a call to GetMaxHandSize(player).
/// </summary>
[HarmonyPatch(typeof(CardPileCmd), "CheckIfDrawIsPossibleAndShowThoughtBubbleIfNot")]
public static class CardPileCmd_CheckIfDrawIsPossibleAndShowThoughtBubbleIfNot_MaxHandSizePatch
{
	[HarmonyTranspiler]
	private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator il, MethodBase original)
	{
		foreach (CodeInstruction instruction in instructions)
		{
			if (MaxHandSizePatch.IsDefaultMaxHandSizeConst(instruction))
			{
				yield return new CodeInstruction(OpCodes.Ldarg_0, (object)null);
				yield return new CodeInstruction(OpCodes.Call, (object)MaxHandSizePatch.GetMaxHandSizeMethod);
			}
			else
			{
				yield return instruction;
			}
		}
	}
}
