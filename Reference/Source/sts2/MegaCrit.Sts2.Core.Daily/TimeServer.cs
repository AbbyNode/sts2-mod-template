using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Daily;

public static class TimeServer
{
	public static extern Task<TimeServerResult?>? RequestTimeTask
	{
		[CompilerGenerated]
		get;
	}

	public static extern Task<TimeServerResult?> FetchDailyTime();
}
