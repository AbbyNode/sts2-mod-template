using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Helpers;

public static class OneTimeInitialization
{
	public static extern ReadSaveResult<SettingsSave> SettingsReadResult
	{
		[CompilerGenerated]
		get;
	}

	public static extern void Execute();

	public static extern void ExecuteEssential();

	public static extern void ExecuteDeferred();
}
