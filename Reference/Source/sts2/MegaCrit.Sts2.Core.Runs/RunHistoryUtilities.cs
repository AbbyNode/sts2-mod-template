using MegaCrit.Sts2.Core.Platform;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Runs;

public static class RunHistoryUtilities
{
	public static extern void CreateRunHistoryEntry(SerializableRun run, bool victory, bool isAbandoned, PlatformType platformType);
}
