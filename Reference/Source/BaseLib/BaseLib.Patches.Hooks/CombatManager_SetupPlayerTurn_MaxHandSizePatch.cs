using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// Patches <c>void CombatManager.SetupPlayerTurn(Player player, HookPlayerChoiceContext choiceContext)</c>.
/// Changes the max hand size constant to a call to GetMaxHandSize(player).
/// </summary>
[HarmonyPatch(typeof(CombatManager), "SetupPlayerTurn")]
public static class CombatManager_SetupPlayerTurn_MaxHandSizePatch
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
