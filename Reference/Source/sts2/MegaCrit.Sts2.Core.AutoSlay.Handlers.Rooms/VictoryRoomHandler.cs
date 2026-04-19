using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.AutoSlay.Handlers.Rooms;

public class VictoryRoomHandler : IHandler
{
	public extern TimeSpan Timeout { get; }

	[AsyncStateMachine(typeof(_003CHandleAsync_003Ed__2))]
	public extern Task HandleAsync(Rng random, CancellationToken ct);

	public extern VictoryRoomHandler();
}
