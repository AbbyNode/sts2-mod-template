using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

public abstract class MonsterState
{
	public abstract string Id { get; }

	public virtual extern bool ShouldAppearInLogs { get; }

	public virtual extern bool CanTransitionAway { get; }

	public virtual extern bool IsMove { get; }

	public abstract string GetNextState(Creature owner, Rng rng);

	public abstract void RegisterStates(Dictionary<string, MonsterState> monsterStates);

	public virtual extern void OnEnterState();

	public virtual extern void OnExitState();

	protected extern MonsterState();
}
