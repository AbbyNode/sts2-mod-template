using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.AutoSlay.Handlers.Rooms;

public class CombatRoomHandler : IRoomHandler, IHandler
{
	public extern RoomType[] HandledTypes { get; }

	public extern TimeSpan Timeout { get; }

	[AsyncStateMachine(typeof(_003CHandleAsync_003Ed__4))]
	public extern Task HandleAsync(Rng random, CancellationToken ct);

	public extern CombatRoomHandler();
}
