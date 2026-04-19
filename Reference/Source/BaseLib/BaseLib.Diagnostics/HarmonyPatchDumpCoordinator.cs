using System.Threading;
using BaseLib.Config;

namespace BaseLib.Diagnostics;

/// <summary>
///     Manual and first-main-menu Harmony patch dumps using <see cref="T:BaseLib.Config.BaseLibConfig" />.
/// </summary>
internal static class HarmonyPatchDumpCoordinator
{
	private static int _autoDumpIssuedForSession;

	/// <summary>
	///     Deferred from <see cref="M:MegaCrit.Sts2.Core.Nodes.Screens.MainMenu.NMainMenu._Ready" />; at most once per
	///     process when enabled.
	/// </summary>
	internal static void TryAutoDumpOnFirstMainMenu()
	{
		if (BaseLibConfig.HarmonyPatchDumpOnFirstMainMenu && Interlocked.CompareExchange(ref _autoDumpIssuedForSession, 1, 0) == 0)
		{
			TryDumpToConfiguredPath(BaseLibConfig.HarmonyPatchDumpOutputPath, "[HarmonyDump][Auto]");
		}
	}

	internal static void TryManualDumpFromSettings()
	{
		TryDumpToConfiguredPath(BaseLibConfig.HarmonyPatchDumpOutputPath, "[HarmonyDump][Manual]");
	}

	private static void TryDumpToConfiguredPath(string rawPath, string logPrefix)
	{
		string text = HarmonyPatchDumpWriter.TryResolveFilesystemPath(rawPath);
		string errorMessage;
		if (string.IsNullOrEmpty(text))
		{
			BaseLibMain.Logger.Warn(logPrefix + " Output path is empty or invalid. Set a path in BaseLib mod config (or use Browse).", 1);
		}
		else if (!HarmonyPatchDumpWriter.TryWrite(text, out errorMessage))
		{
			BaseLibMain.Logger.Warn(logPrefix + " Failed to write dump: " + errorMessage, 1);
		}
		else
		{
			BaseLibMain.Logger.Info(logPrefix + " Wrote Harmony patch dump to: " + text, 1);
		}
	}
}
