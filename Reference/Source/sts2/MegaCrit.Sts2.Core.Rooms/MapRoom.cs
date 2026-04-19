using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Rooms;

public class MapRoom : AbstractRoom
{
	public override extern RoomType RoomType { get; }

	public override extern ModelId? ModelId { get; }

	public override extern Task Enter(IRunState? runState, bool isRestoringRoomStackBase);

	public override extern Task Exit(IRunState? runState);

	public override extern Task Resume(AbstractRoom _, IRunState? runState);

	public extern MapRoom();
}
