using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using BaseLib.Hooks;
using BaseLib.Utils.Patching;
using HarmonyLib;
using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace BaseLib.Patches.Hooks;

/// <summary>
/// IHealAmountModifier.ModifyHealAdditive() -&gt; AbstractModel.ModifyHealAmount() -&gt; IHealAmountModifier.ModifyHealMultiplicative()
/// reserve AbstractModel.ModifyHealAmount() in the process for compatibility
/// </summary>
[HarmonyPatch(/*Could not decode attribute arguments.*/)]
public static class ModifyHealAmountPatches
{
	[HarmonyTranspiler]
	private static List<CodeInstruction> Patch(IEnumerable<CodeInstruction> code)
	{
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		List<CodeInstruction> match;
		object operand;
		return new InstructionPatcher(code).Match(new InstructionMatcher().ldarg_0().ldfld(null).ldfld(null)
			.PredicateMatch((object? op) => op is FieldInfo fieldInfo && fieldInfo.Name.Contains("creature"))).CopyMatch(out match).Match(new InstructionMatcher().ldfld(null).PredicateMatch((object? op) => op is FieldInfo fieldInfo && fieldInfo.Name.Equals("amount")))
			.Step(-1)
			.GetOperand(out operand)
			.Insert(CodeInstruction.LoadArgument(0, false))
			.Step()
			.Insert((IEnumerable<CodeInstruction>)match)
			.Insert((IEnumerable<CodeInstruction>)new _003C_003Ez__ReadOnlyArray<CodeInstruction>((CodeInstruction[])(object)new CodeInstruction[4]
			{
				CodeInstruction.Call(typeof(ModifyHealAmountPatches), "ModifyHeal", (Type[])null, (Type[])null),
				new CodeInstruction(OpCodes.Stfld, operand),
				CodeInstruction.LoadArgument(0, false),
				new CodeInstruction(OpCodes.Ldfld, operand)
			}));
	}

	public static decimal ModifyHeal(decimal amount, Creature creature)
	{
		Player player = creature.Player;
		object obj = ((player != null) ? player.RunState : null);
		if (obj == null)
		{
			CombatState combatState = creature.CombatState;
			obj = ((object)((combatState != null) ? combatState.RunState : null)) ?? ((object)NullRunState.Instance);
		}
		CombatState combatState2 = creature.CombatState;
		ModifyAdditive((IRunState)obj, combatState2, creature, ref amount);
		ModifyMultiplicative((IRunState)obj, combatState2, creature, ref amount);
		return amount;
	}

	private static void ModifyAdditive(IRunState runState, CombatState? combatState, Creature creature, ref decimal amount)
	{
		decimal num = amount;
		foreach (AbstractModel item in runState.IterateHookListeners(combatState))
		{
			if (item is IHealAmountModifier healAmountModifier)
			{
				num += healAmountModifier.ModifyHealAdditive(creature, amount);
			}
		}
		amount = num;
	}

	private static void ModifyMultiplicative(IRunState runState, CombatState? combatState, Creature creature, ref decimal __result)
	{
		decimal val = __result;
		foreach (AbstractModel item in runState.IterateHookListeners(combatState))
		{
			if (item is IHealAmountModifier healAmountModifier)
			{
				val *= healAmountModifier.ModifyHealMultiplicative(creature, __result);
			}
		}
		__result = Math.Max(0m, val);
	}
}
