using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace MegaCrit.Sts2.Core.Commands;

public static class Cmd
{
	public static extern Task Wait(float seconds, bool ignoreCombatEnd = false);

	[AsyncStateMachine(typeof(_003CWait_003Ed__1))]
	public static extern Task Wait(float seconds, CancellationToken cancelToken, bool ignoreCombatEnd = false);

	[AsyncStateMachine(typeof(_003CCustomScaledWait_003Ed__3))]
	public static extern Task CustomScaledWait(float fastSeconds, float standardSeconds, bool ignoreCombatEnd = false, CancellationToken cancellationToken = default(CancellationToken));
}
