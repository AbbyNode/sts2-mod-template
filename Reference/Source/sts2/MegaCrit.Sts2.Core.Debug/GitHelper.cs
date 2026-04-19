using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Debug;

public static class GitHelper
{
	public static extern Task<string?>? ShortCommitIdTask
	{
		[CompilerGenerated]
		get;
	}

	public static extern string? ShortCommitId
	{
		[CompilerGenerated]
		get;
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__8))]
	public static extern Task Initialize();
}
