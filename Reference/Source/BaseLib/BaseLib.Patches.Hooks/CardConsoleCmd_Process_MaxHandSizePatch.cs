using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using MegaCrit.Sts2.Core.DevConsole.ConsoleCommands;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// Patches <c>void CardConsoleCmd.Process(Player issuingPlayer, string[] args)</c>.
/// Changes the max hand size constant to a call to GetMaxHandSize(player).
/// </summary>
[HarmonyPatch(typeof(CardConsoleCmd), "Process")]
public static class CardConsoleCmd_Process_MaxHandSizePatch
{
	[HarmonyTranspiler]
	private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator il, MethodBase original)
	{
		foreach (CodeInstruction instruction in instructions)
		{
			if (MaxHandSizePatch.IsDefaultMaxHandSizeConst(instruction))
			{
				yield return new CodeInstruction(OpCodes.Ldarg_1, (object)null);
				yield return new CodeInstruction(OpCodes.Call, (object)MaxHandSizePatch.GetMaxHandSizeMethod);
			}
			else
			{
				yield return instruction;
			}
		}
	}
}
