using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using BaseLib.Abstracts;
using BaseLib.Utils;
using HarmonyLib;
using MegaCrit.Sts2.Core.Helpers;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Content;

/// <summary>
/// Called in PostModInitPatch to catch modded acts
/// </summary>
public static class AddActContent
{
	public static void Patch(Harmony harmony)
	{
		StringBuilder stringBuilder = new StringBuilder("Patching act types for custom encounters and events");
		foreach (Type item in ReflectionHelper.GetSubtypes<ActModel>().Chain(ReflectionHelper.GetSubtypesInMods<ActModel>()))
		{
			bool flag = false;
			MethodInfo methodInfo = AccessTools.DeclaredMethod(item, "GenerateAllEncounters", (Type[])null, (Type[])null);
			if (methodInfo != null)
			{
				flag = true;
				harmony.Patch((MethodBase)methodInfo, (HarmonyMethod)null, HarmonyMethod.op_Implicit(AccessTools.Method(typeof(AddActContent), "AddCustomEncounters", (Type[])null, (Type[])null)), (HarmonyMethod)null, (HarmonyMethod)null);
			}
			methodInfo = AccessTools.DeclaredPropertyGetter(item, "AllEvents");
			if (methodInfo != null)
			{
				flag = true;
				harmony.Patch((MethodBase)methodInfo, (HarmonyMethod)null, HarmonyMethod.op_Implicit(AccessTools.Method(typeof(AddActContent), "AddCustomEvents", (Type[])null, (Type[])null)), (HarmonyMethod)null, (HarmonyMethod)null);
			}
			if (flag)
			{
				stringBuilder.Append(" | ").Append(item.Name);
			}
		}
		BaseLibMain.Logger.Info(stringBuilder.ToString(), 1);
	}

	private static IEnumerable<EncounterModel> AddCustomEncounters(IEnumerable<EncounterModel> result, ActModel __instance)
	{
		foreach (EncounterModel item in result)
		{
			yield return item;
		}
		foreach (CustomEncounterModel customEncounter in CustomContentDictionary.CustomEncounters)
		{
			if (customEncounter.IsValidForAct(__instance))
			{
				yield return (EncounterModel)(object)customEncounter;
			}
		}
	}

	private static IEnumerable<EventModel> AddCustomEvents(IEnumerable<EventModel> result, ActModel __instance)
	{
		foreach (EventModel item in result)
		{
			yield return item;
		}
		foreach (CustomEventModel actCustomEvent in CustomContentDictionary.ActCustomEvents)
		{
			if (actCustomEvent.Acts.Any((ActModel act) => ((AbstractModel)act).Id.Equals(((AbstractModel)__instance).Id)))
			{
				yield return (EventModel)(object)actCustomEvent;
			}
		}
	}
}
