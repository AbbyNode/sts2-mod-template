using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rooms;

public abstract class AbstractRoom
{
	public abstract RoomType RoomType { get; }

	public abstract ModelId? ModelId { get; }

	public virtual extern bool IsPreFinished { get; }

	public extern bool IsVictoryRoom { get; }

	public abstract Task Enter(IRunState? runState, bool isRestoringRoomStackBase);

	public abstract Task Exit(IRunState? runState);

	public abstract Task Resume(AbstractRoom exitedRoom, IRunState? runState);

	public virtual extern SerializableRoom ToSerializable();

	public static extern AbstractRoom? FromSerializable(SerializableRoom? serializableRoom, IRunState? runState);

	protected extern AbstractRoom();
}
