using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Nodes.Events;

public class EventSplitVoteAnimation
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern EventSplitVoteAnimation(NEventLayout eventLayout, IRunState runState);

	[AsyncStateMachine(typeof(_003CTryPlay_003Ed__7))]
	public extern Task TryPlay(NEventOptionButton chosenButton);
}
