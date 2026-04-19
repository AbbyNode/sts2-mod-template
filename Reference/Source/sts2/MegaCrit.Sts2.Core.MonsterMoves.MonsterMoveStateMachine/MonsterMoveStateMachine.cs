using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

public class MonsterMoveStateMachine
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Dictionary<string, MonsterState> States
	{
		[CompilerGenerated]
		get;
	}

	public extern List<MonsterState> StateLog
	{
		[CompilerGenerated]
		get;
	}

	public extern MonsterMoveStateMachine(IEnumerable<MonsterState> states, MonsterState initialState);

	public extern MoveState RollMove(IEnumerable<Creature> targets, Creature owner, Rng rng);

	public extern void ForceCurrentState(MonsterState state);

	public extern void OnMovePerformed(MoveState _);
}
