using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.MonsterMoves.MonsterMoveStateMachine;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class MonsterPerformedMoveEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern MonsterModel Monster
	{
		[CompilerGenerated]
		get;
	}

	public extern MoveState Move
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<Creature>? Targets
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern MonsterPerformedMoveEntry(MonsterModel monster, MoveState move, IEnumerable<Creature>? targets, int roundNumber, CombatSide currentSide, CombatHistory history);
}
