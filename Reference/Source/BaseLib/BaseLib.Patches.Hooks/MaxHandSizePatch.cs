using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using BaseLib.Hooks;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// Patches all references to the max hand size constant of 10 to instead call GetMaxHandSize(player) which can be modified by IMaxHandSizeModifier implementations.
/// </summary>
public static class MaxHandSizePatch
{
	/// <summary>
	/// The default max hand size constant used in the base game.
	/// </summary>
	public const int DefaultMaxHandSize = 10;

	internal static readonly MethodInfo GetMaxHandSizeMethod = AccessTools.Method(typeof(MaxHandSizePatch), "GetMaxHandSize", (Type[])null, (Type[])null);

	internal static bool IsDefaultMaxHandSizeConst(CodeInstruction ins)
	{
		if (!(ins.opcode == OpCodes.Ldc_I4_S) || !(ins.operand is sbyte b) || b != 10)
		{
			if (ins.opcode == OpCodes.Ldc_I4 && ins.operand is int num)
			{
				return num == 10;
			}
			return false;
		}
		return true;
	}

	/// <summary>
	/// Calculates the max hand size for a given player by invoking all IMaxHandSizeModifier implementations.
	/// </summary>
	/// <param name="player">The player to calculate the max hand size for.</param>
	/// <returns>The calculated max hand size.</returns>
	public static int GetMaxHandSize(Player player)
	{
		object obj = ((object)player.RunState) ?? ((object)NullRunState.Instance);
		CombatState combatState = player.Creature.CombatState;
		int num = 10;
		List<IMaxHandSizeModifier> list = new List<IMaxHandSizeModifier>();
		foreach (AbstractModel item2 in ((IRunState)obj).IterateHookListeners(combatState))
		{
			if (item2 is IMaxHandSizeModifier item)
			{
				list.Add(item);
			}
		}
		foreach (IMaxHandSizeModifier item3 in list)
		{
			num = item3.ModifyMaxHandSize(player, num);
		}
		foreach (IMaxHandSizeModifier item4 in list)
		{
			num = item4.ModifyMaxHandSizeLate(player, num);
		}
		return Math.Max(0, num);
	}

	internal static int GetMaxHandSizeFromCard(CardModel? card)
	{
		Player val = ((card != null) ? card.Owner : null);
		if (val == null)
		{
			return 10;
		}
		return GetMaxHandSize(val);
	}
}
