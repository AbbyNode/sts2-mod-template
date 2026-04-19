using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

public class RandomBranchState : MonsterState
{
	public struct StateWeight
	{
		public string stateId;

		public MoveRepeatType repeatType;

		public int maxTimes;

		public Func<float> weightLambda;

		public int cooldown;

		public extern float GetWeight();
	}

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string StateId
	{
		[CompilerGenerated]
		get;
	}

	public extern List<StateWeight> States
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public override extern bool ShouldAppearInLogs { get; }

	public override extern string Id { get; }

	public extern RandomBranchState(string id);

	public extern void AddBranch(MonsterState state, int cooldown, MoveRepeatType repeatType, Func<float> weight);

	public extern void AddBranch(MonsterState state, int cooldown, int maxRepeats, Func<float> weight);

	public extern void AddBranch(MonsterState state, int maxRepeats, Func<float> weight);

	public extern void AddBranch(MonsterState state, int cooldown, MoveRepeatType repeatType, float weight);

	public extern void AddBranch(MonsterState state, MoveRepeatType repeatType, float weight);

	public extern void AddBranch(MonsterState state, MoveRepeatType repeatType, Func<float> weight);

	public extern void AddBranch(MonsterState state, int maxRepeats, float weight);

	public extern void AddBranch(MonsterState state, int cooldown, MoveRepeatType repeatType);

	public extern void AddBranch(MonsterState state, int maxRepeats);

	public extern void AddBranch(MonsterState state, MoveRepeatType repeatType);

	public override extern string GetNextState(Creature owner, Rng rng);

	public override extern void RegisterStates(Dictionary<string, MonsterState> monsterStates);
}
