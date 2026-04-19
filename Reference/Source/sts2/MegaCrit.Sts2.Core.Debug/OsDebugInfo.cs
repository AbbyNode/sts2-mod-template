using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Debug;

public static class OsDebugInfo
{
	[AsyncStateMachine(typeof(_003CLogSystemInfo_003Ed__0))]
	public static extern Task LogSystemInfo();

	public static extern string GetSystemInfoString();
}
