using System;
using BaseLib.Diagnostics;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace BaseLib.Patches.Utils;

/// <summary>
///     After main menu is ready, optionally dump Harmony patch info once per session (deferred).
/// </summary>
[HarmonyPatch(typeof(NMainMenu), "_Ready")]
public static class HarmonyPatchDumpMainMenuPatch
{
	/// <summary>
	///     After main menu is ready, optionally dump Harmony patch info once per session (deferred).
	/// </summary>
	public static void Postfix()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		Callable val = Callable.From((Action)HarmonyPatchDumpCoordinator.TryAutoDumpOnFirstMainMenu);
		((Callable)(ref val)).CallDeferred(Array.Empty<Variant>());
	}
}
