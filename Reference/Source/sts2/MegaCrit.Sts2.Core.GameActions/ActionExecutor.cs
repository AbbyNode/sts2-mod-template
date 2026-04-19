using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.GameActions;

public class ActionExecutor
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsPaused { get; }

	public extern bool IsRunning { get; }

	public extern GameAction? CurrentlyRunningAction
	{
		[CompilerGenerated]
		get;
	}

	public extern event Action<GameAction>? BeforeActionExecuted;

	public extern event Action<GameAction>? AfterActionExecuted;

	public extern ActionExecutor(ActionQueueSet actionQueueSet);

	public extern void Pause();

	public extern void Unpause();

	public extern Task FinishedExecutingActions();

	public extern void Cancel();
}
