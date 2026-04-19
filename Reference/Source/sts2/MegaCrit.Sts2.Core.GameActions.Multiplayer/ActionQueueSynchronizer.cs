using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.GameActions.Multiplayer;

public class ActionQueueSynchronizer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern uint NextHookId { get; }

	public extern ActionSynchronizerCombatState CombatState
	{
		[CompilerGenerated]
		get;
	}

	public extern ActionQueueSynchronizer(IPlayerCollection players, ActionQueueSet actionQueueSet, RunLocationTargetedMessageBuffer messageBuffer, INetGameService netService);

	public extern void Dispose();

	public extern void SetCombatState(ActionSynchronizerCombatState combatState);

	public extern void RequestEnqueue(GameAction action);

	public extern GenericHookGameAction GenerateHookAction(ulong ownerId, GameActionType gameActionType);

	public extern void RequestEnqueueHookAction(GenericHookGameAction action);

	public extern void RequestResumeActionAfterPlayerChoice(GameAction action);

	public extern GenericHookGameAction GetHookActionForId(uint id, ulong ownerId, GameActionType gameActionType);

	public extern void FastForwardHookId(uint hookId);
}
