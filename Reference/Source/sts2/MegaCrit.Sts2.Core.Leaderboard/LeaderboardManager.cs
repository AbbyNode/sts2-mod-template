using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Platform;

namespace MegaCrit.Sts2.Core.Leaderboard;

public static class LeaderboardManager
{
	public static extern PlatformType CurrentPlatform { get; }

	public static extern void Initialize();

	public static extern Task<ILeaderboardHandle> GetOrCreateLeaderboard(string name);

	public static extern Task<ILeaderboardHandle?> GetLeaderboard(string name);

	public static extern Task UploadLocalScore(ILeaderboardHandle handle, int score, IReadOnlyList<ulong> userIds);

	public static extern Task<List<LeaderboardEntry>> QueryLeaderboard(ILeaderboardHandle handle, LeaderboardQueryType type, int startIndex, int resultCount);

	public static extern Task<List<LeaderboardEntry>> QueryLeaderboardForUsers(ILeaderboardHandle handle, IReadOnlyList<ulong> userIds);

	public static extern int GetLeaderboardEntryCount(ILeaderboardHandle handle);

	public static extern void DebugAddEntry(ILeaderboardHandle handle, LeaderboardEntry entry);
}
