using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Runs;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Rooms;

public class EventRoom : AbstractRoom
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RoomType RoomType { get; }

	public override extern ModelId ModelId { get; }

	public extern EventModel CanonicalEvent
	{
		[CompilerGenerated]
		get;
	}

	public extern EventModel LocalMutableEvent { get; }

	public extern Action<EventModel>? OnStart
	{
		[CompilerGenerated]
		init;
	}

	public override extern bool IsPreFinished { get; }

	public extern EventRoom(EventModel eventModel);

	public extern EventRoom(SerializableRoom serializableRoom);

	[AsyncStateMachine(typeof(_003CEnter_003Ed__18))]
	public override extern Task Enter(IRunState? runState, bool isRestoringRoomStackBase);

	public override extern Task Exit(IRunState? runState);

	public override extern Task Resume(AbstractRoom exitedRoom, IRunState? runState);

	public override extern SerializableRoom ToSerializable();

	public extern void MarkPreFinished();
}
