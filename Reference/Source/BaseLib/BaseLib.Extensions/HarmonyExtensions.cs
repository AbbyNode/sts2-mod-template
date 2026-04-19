using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;

namespace BaseLib.Extensions;

public static class HarmonyExtensions
{
	/// <summary>
	/// Attempts to apply all patches marked by harmony attributes of the specified category in an assembly.
	/// </summary>
	/// <returns></returns>
	public static bool TryPatchAll(this Harmony harmony, Assembly assembly, string? category = null)
	{
		BaseLibMain.Logger.Info($"Starting PatchAll for assembly {assembly}", 1);
		try
		{
			IEnumerable<PatchClassProcessor> enumerable = (from type in AccessTools.GetTypesFromAssembly(assembly)
				where GeneralExtensions.HasHarmonyAttribute(type)
				select type).Select((Func<Type, PatchClassProcessor>)harmony.CreateClassProcessor);
			int successCount = 0;
			int failCount = 0;
			CollectionExtensions.DoIf<PatchClassProcessor>(enumerable, (Func<PatchClassProcessor, bool>)((PatchClassProcessor processor) => category?.Equals(processor.Category) ?? string.IsNullOrEmpty(processor.Category)), (Action<PatchClassProcessor>)delegate(PatchClassProcessor processor)
			{
				try
				{
					processor.Patch();
					int num = successCount + 1;
					successCount = num;
				}
				catch (Exception ex)
				{
					BaseLibMain.Logger.Error(ex.ToString(), 1);
					int num = failCount + 1;
					failCount = num;
				}
			});
			BaseLibMain.Logger.Info($"Applied {successCount} patches successfully, {failCount} failed", 1);
			return failCount == 0;
		}
		catch (Exception value)
		{
			BaseLibMain.Logger.Error($"Error occurred during TryPatchAll for assembly {assembly}: {value}", 1);
			return false;
		}
	}

	/// <summary>
	/// Not necessary! Use `MethodType.Async` in your HarmonyPatch annotation.
	/// </summary>
	/// <param name="harmony"></param>
	/// <param name="asyncMethod"></param>
	/// <param name="prefix"></param>
	/// <param name="postfix"></param>
	/// <param name="transpiler"></param>
	/// <param name="finalizer"></param>
	[Obsolete("Use MethodType.Async instead.")]
	public static void PatchAsyncMoveNext(this Harmony harmony, MethodInfo asyncMethod, HarmonyMethod? prefix = null, HarmonyMethod? postfix = null, HarmonyMethod? transpiler = null, HarmonyMethod? finalizer = null)
	{
		MethodInfo method = asyncMethod.StateMachineType().GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.NonPublic);
		harmony.Patch((MethodBase)method, prefix, postfix, transpiler, finalizer);
	}

	[Obsolete("Use MethodType.Async instead.")]
	public static void PatchAsyncMoveNext(this Harmony harmony, MethodInfo asyncMethod, out Type stateMachineType, HarmonyMethod? prefix = null, HarmonyMethod? postfix = null, HarmonyMethod? transpiler = null, HarmonyMethod? finalizer = null)
	{
		AsyncStateMachineAttribute customAttribute = asyncMethod.GetCustomAttribute<AsyncStateMachineAttribute>();
		if (customAttribute == null)
		{
			throw new ArgumentException("MethodInfo " + GeneralExtensions.FullDescription((MethodBase)asyncMethod) + " passed to PatchAsync is not an async method");
		}
		stateMachineType = customAttribute.StateMachineType;
		MethodInfo method = stateMachineType.GetMethod("MoveNext", BindingFlags.Instance | BindingFlags.NonPublic);
		harmony.Patch((MethodBase)method, prefix, postfix, transpiler, finalizer);
	}
}
