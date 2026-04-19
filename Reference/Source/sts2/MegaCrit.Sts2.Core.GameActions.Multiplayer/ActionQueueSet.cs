using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public class ActionQueueSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsEmpty { get; }

	public extern uint NextActionId { get; }

	public extern event Action? ActionQueueChanged;

	public extern event Action<GameAction>? ActionEnqueued;

	public extern event Action<uint>? ActionResumed;

	public extern ActionQueueSet(IReadOnlyList<Player> players);

	public extern void EnqueueWithoutSynchronizing(GameAction gameAction);

	public static extern bool IsGameActionPlayerDriven(GameAction gameAction);

	public extern GameAction? GetReadyAction();

	public extern void PauseActionForPlayerChoice(GameAction action, PlayerChoiceOptions options);

	public extern Task BecameEmpty();

	public extern void PauseAllPlayerQueues();

	public extern void StartCancellingAllPlayerDrivenCombatActions();

	public extern bool ActionQueueIsPaused(ulong playerId);

	public extern void UnpauseAllPlayerQueues();

	public extern void CombatEnded();

	public extern void CombatStarted();

	public extern void Reset();

	public extern void CancelNonExecutingActionsForPlayer(ulong playerId);

	public extern void ResumeActionWithoutSynchronizing(uint id);

	public extern void FastForwardNextActionId(uint nextId);
}
