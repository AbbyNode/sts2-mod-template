using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Actions;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;

namespace MegaCrit.Sts2.Core.GameActions;

public abstract class GameAction
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern GameActionState State
	{
		[CompilerGenerated]
		get;
	}

	public abstract ulong OwnerId { get; }

	public abstract GameActionType ActionType { get; }

	public extern uint? Id
	{
		[CompilerGenerated]
		get;
	}

	public extern Task CompletionTask { get; }

	public extern Exception? Exception { get; }

	public virtual extern bool RecordableToReplay { get; }

	public extern event Action<GameAction>? AfterFinished;

	public extern event Action<GameAction>? BeforeExecuted;

	public extern event Action<GameAction>? BeforeCancelled;

	public extern event Action<GameAction>? BeforePausedForPlayerChoice;

	public extern event Action<GameAction>? BeforeReadyToResumeAfterPlayerChoice;

	public extern event Action<GameAction>? BeforeResumedAfterPlayerChoice;

	public extern void OnEnqueued(Action<GameAction> afterFinished, uint id);

	[AsyncStateMachine(typeof(_003CExecute_003Ed__42))]
	public extern Task Execute();

	public extern void ResumeAfterGatheringPlayerChoice(uint newId);

	[AsyncStateMachine(typeof(_003CWaitForActionToResumeExecutingAfterPlayerChoice_003Ed__44))]
	public extern Task WaitForActionToResumeExecutingAfterPlayerChoice();

	public extern void PauseForPlayerChoice();

	protected abstract Task ExecuteAction();

	public extern void Cancel();

	protected virtual extern void CancelAction();

	public abstract INetAction ToNetAction();

	protected extern GameAction();
}
