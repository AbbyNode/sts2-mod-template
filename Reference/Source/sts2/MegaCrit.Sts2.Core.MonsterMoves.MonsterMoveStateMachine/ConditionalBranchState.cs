using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

public class ConditionalBranchState : MonsterState
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string BranchId
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Id { get; }

	public override extern bool ShouldAppearInLogs { get; }

	public extern ConditionalBranchState(string stateId);

	public extern void AddState(MonsterState move, Func<bool> condition);

	public override extern string GetNextState(Creature _, Rng __);

	public override extern void RegisterStates(Dictionary<string, MonsterState> monsterStates);
}
