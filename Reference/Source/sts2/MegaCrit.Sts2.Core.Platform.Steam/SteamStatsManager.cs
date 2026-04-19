using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Platform.Steam;

public static class SteamStatsManager
{
	public static extern bool IsGlobalStatsReady { get; }

	public static extern void Initialize();

	[AsyncStateMachine(typeof(_003CRefreshGlobalStats_003Ed__8))]
	public static extern Task RefreshGlobalStats();

	public static extern void IncrementArchitectDamage(int score);

	public static extern long GetGlobalArchitectDamage();
}
