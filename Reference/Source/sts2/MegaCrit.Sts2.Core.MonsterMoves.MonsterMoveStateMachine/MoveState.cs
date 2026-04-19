using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.MonsterMoves.Intents;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

public class MoveState : MonsterState
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<AbstractIntent> Intents
	{
		[CompilerGenerated]
		get;
	}

	public extern string StateId
	{
		[CompilerGenerated]
		get;
	}

	public extern bool MustPerformOnceBeforeTransitioning
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern string? FollowUpStateId
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern MonsterState? FollowUpState
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public override extern bool CanTransitionAway { get; }

	public override extern bool IsMove { get; }

	public override extern string Id { get; }

	public extern MoveState();

	public extern MoveState(string stateId, Func<IReadOnlyList<Creature>, Task> onPerform, params AbstractIntent[] intents);

	[AsyncStateMachine(typeof(_003CPerformMove_003Ed__25))]
	public extern Task PerformMove(IEnumerable<Creature> targets);

	public override extern void OnExitState();

	public override extern string GetNextState(Creature owner, Rng rng);

	public override extern void RegisterStates(Dictionary<string, MonsterState> monsterStates);
}
