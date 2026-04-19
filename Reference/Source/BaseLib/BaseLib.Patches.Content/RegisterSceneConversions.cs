using System;
using BaseLib.Abstracts;
using HarmonyLib;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Content;

/// <summary>
/// Registers custom scene paths.
/// Called through a patch because virtual properties like CustomVisualPath
/// may depend on fields set in derived constructors that haven't run yet when
/// the base constructor occurs.
/// </summary>
[HarmonyPatch(typeof(ModelDb), "Preload")]
internal class RegisterSceneConversions
{
	[HarmonyPostfix]
	private static void EnsureScenePathsRegistered()
	{
		foreach (Type registeredType in CustomContentDictionary.RegisteredTypes)
		{
			if (registeredType.IsAssignableTo(typeof(ISceneConversions)))
			{
				(ModelDb.GetById<AbstractModel>(ModelDb.GetId(registeredType)) as ISceneConversions)?.RegisterSceneConversions();
			}
		}
	}
}
