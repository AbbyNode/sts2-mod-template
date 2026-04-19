using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Leaderboard;
using MegaCrit.Sts2.Core.Saves;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Daily;

public static class DailyRunUtility
{
	[AsyncStateMachine(typeof(_003CUploadScore_003Ed__0))]
	public static extern Task UploadScore(DateTimeOffset time, int score, List<SerializablePlayer> players);

	[AsyncStateMachine(typeof(_003CShouldUploadScore_003Ed__1))]
	public static extern Task<bool> ShouldUploadScore(ILeaderboardHandle? handle, IReadOnlyList<ulong> playerIdsInRun);

	public static extern string GetLeaderboardName(DateTimeOffset dateTime, int playerCount);

	public static extern void UploadScoreIfNecessary(SerializableRun serializableRun, ulong playerId, bool isVictory);
}
