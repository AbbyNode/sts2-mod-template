using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Helpers;

public static class TaskHelper
{
	public static extern Task RunSafely(Task task);

	[AsyncStateMachine(typeof(_003CWhenAny_003Ed__2))]
	public static extern Task WhenAny(params Task[] tasks);
}
