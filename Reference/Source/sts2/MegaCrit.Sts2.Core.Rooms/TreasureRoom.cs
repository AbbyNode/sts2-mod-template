using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Rooms;

public class TreasureRoom : AbstractRoom
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RoomType RoomType { get; }

	public override extern ModelId? ModelId { get; }

	public extern TreasureRoom(int actIndex);

	[AsyncStateMachine(typeof(_003CEnter_003Ed__6))]
	public override extern Task Enter(IRunState? runState, bool isRestoringRoomStackBase);

	public override extern Task Exit(IRunState? runState);

	public override extern Task Resume(AbstractRoom _, IRunState? runState);

	public extern Task<int> DoNormalRewards();

	public extern Task DoExtraRewardsIfNeeded();
}
