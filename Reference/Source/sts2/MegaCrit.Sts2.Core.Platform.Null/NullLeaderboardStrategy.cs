using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Leaderboard;

namespace MegaCrit.Sts2.Core.Platform.Null;

public class NullLeaderboardStrategy : ILeaderboardStrategy
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern PlatformType Platform { get; }

	public extern NullLeaderboardStrategy();

	public extern Task<ILeaderboardHandle?> GetLeaderboard(string name);

	[AsyncStateMachine(typeof(_003CGetOrCreateLeaderboard_003Ed__6))]
	public extern Task<ILeaderboardHandle> GetOrCreateLeaderboard(string name);

	[AsyncStateMachine(typeof(_003CUploadLocalScore_003Ed__7))]
	public extern Task UploadLocalScore(ILeaderboardHandle handleInterface, int score, IReadOnlyList<ulong> userIds);

	[AsyncStateMachine(typeof(_003CQueryLeaderboard_003Ed__8))]
	public extern Task<List<LeaderboardEntry>> QueryLeaderboard(ILeaderboardHandle handleInterface, LeaderboardQueryType type, int startIndex, int count);

	[AsyncStateMachine(typeof(_003CQueryLeaderboardForUsers_003Ed__9))]
	public extern Task<List<LeaderboardEntry>> QueryLeaderboardForUsers(ILeaderboardHandle handleInterface, IReadOnlyList<ulong> userIds);

	public extern int GetLeaderboardEntryCount(ILeaderboardHandle handleInterface);

	public extern void DebugAddEntry(ILeaderboardHandle handleInterface, LeaderboardEntry entry);
}
