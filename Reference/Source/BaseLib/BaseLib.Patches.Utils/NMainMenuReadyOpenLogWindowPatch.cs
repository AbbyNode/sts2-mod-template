using BaseLib.Commands;
using BaseLib.Config;
using HarmonyLib;
using MegaCrit.Sts2.Core.Nodes.Screens.MainMenu;

namespace BaseLib.Patches.Utils;

[HarmonyPatch(typeof(NMainMenu), "_Ready")]
internal class NMainMenuReadyOpenLogWindowPatch
{
	private static bool _hasOpenedOnStartup;

	[HarmonyPostfix]
	private static void Postfix()
	{
		if (!_hasOpenedOnStartup && BaseLibConfig.OpenLogWindowOnStartup)
		{
			_hasOpenedOnStartup = true;
			OpenLogWindow.OpenWindow(stealFocus: false);
		}
	}
}
