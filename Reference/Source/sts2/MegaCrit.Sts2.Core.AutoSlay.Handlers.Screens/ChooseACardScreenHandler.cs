using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.AutoSlay.Handlers.Screens;

public class ChooseACardScreenHandler : IScreenHandler, IHandler
{
	public extern Type ScreenType { get; }

	public extern TimeSpan Timeout { get; }

	[AsyncStateMachine(typeof(_003CHandleAsync_003Ed__4))]
	public extern Task HandleAsync(Rng random, CancellationToken ct);

	public extern ChooseACardScreenHandler();
}
