using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Combat.History;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Combat;

public class CombatManager
{
	public const int baseHandDrawCount = 5;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern CombatManager Instance
	{
		[CompilerGenerated]
		get;
	}

	public extern CardModel? DebugForcedTopCardOnNextShuffle
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsPaused
	{
		[CompilerGenerated]
		get;
	}

	public extern bool PlayerActionsDisabled { get; }

	public extern IReadOnlyList<Player> PlayersTakingExtraTurn { get; }

	public extern bool IsPlayPhase
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsEnemyTurnStarted
	{
		[CompilerGenerated]
		get;
	}

	public extern bool EndingPlayerTurnPhaseTwo
	{
		[CompilerGenerated]
		get;
	}

	public extern bool EndingPlayerTurnPhaseOne
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatStateTracker StateTracker
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatHistory History
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsInProgress
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsAboutToLose { get; }

	public extern bool IsEnding { get; }

	public extern bool IsOverOrEnding { get; }

	public extern event Action<CombatState>? CombatSetUp;

	public extern event Action<CombatRoom>? CombatEnded;

	public extern event Action<CombatRoom>? CombatWon;

	public extern event Action<CombatState>? CreaturesChanged;

	public extern event Action<CombatState>? TurnStarted;

	public extern event Action<CombatState>? TurnEnded;

	public extern event Action<Player, bool>? PlayerEndedTurn;

	public extern event Action<Player>? PlayerUnendedTurn;

	public extern event Action<CombatState>? AboutToSwitchToEnemyTurn;

	public extern event Action<CombatState>? PlayerActionsDisabledChanged;

	public extern CombatState? DebugOnlyGetState();

	public extern void SetUpCombat(CombatState state);

	public extern void AfterCombatRoomLoaded();

	[AsyncStateMachine(typeof(_003CStartCombatInternal_003Ed__91))]
	public extern Task StartCombatInternal();

	public extern void SetReadyToEndTurn(Player player, bool canBackOut, Func<Task>? actionDuringEnemyTurn = null);

	public extern void UndoReadyToEndTurn(Player player);

	public extern void OnEndedTurnLocally();

	public extern void SetReadyToBeginEnemyTurn(Player player, Func<Task>? actionDuringEnemyTurn = null);

	public extern bool IsPlayerReadyToEndTurn(Player player);

	public extern bool AllPlayersReadyToEndTurn();

	public extern void AddCreature(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterCreatureAdded_003Ed__102))]
	public extern Task AfterCreatureAdded(Creature creature);

	[AsyncStateMachine(typeof(_003CCheckForEmptyHand_003Ed__103))]
	public extern Task CheckForEmptyHand(PlayerChoiceContext choiceContext, Player player);

	public extern void Reset(bool graceful);

	[AsyncStateMachine(typeof(_003CHandlePlayerDeath_003Ed__105))]
	public extern Task HandlePlayerDeath(Player player);

	public extern void LoseCombat();

	[AsyncStateMachine(typeof(_003CEndCombatInternal_003Ed__108))]
	public extern Task EndCombatInternal();

	public extern void RemoveCreature(Creature creature);

	[AsyncStateMachine(typeof(_003CCheckWinCondition_003Ed__110))]
	public extern Task<bool> CheckWinCondition();

	[AsyncStateMachine(typeof(_003CEndPlayerTurnPhaseOneInternal_003Ed__115))]
	public extern Task EndPlayerTurnPhaseOneInternal();

	[AsyncStateMachine(typeof(_003CEndPlayerTurnPhaseTwoInternal_003Ed__119))]
	public extern Task EndPlayerTurnPhaseTwoInternal();

	[AsyncStateMachine(typeof(_003CSwitchFromPlayerToEnemySide_003Ed__120))]
	public extern Task SwitchFromPlayerToEnemySide(Func<Task>? actionDuringEnemyTurn = null);

	public extern void Pause();

	public extern void Unpause();

	[AsyncStateMachine(typeof(_003CWaitForUnpause_003Ed__124))]
	public extern Task WaitForUnpause();

	public extern void DebugForceTopCardOnNextShuffle(CardModel card);

	public extern void DebugClearForcedTopCardOnNextShuffle();
}
