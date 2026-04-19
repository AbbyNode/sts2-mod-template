using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class CreatureAttackedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern IReadOnlyList<DamageResult> DamageResults
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern CreatureAttackedEntry(Creature attacker, IReadOnlyList<DamageResult> damageResults, int roundNumber, CombatSide currentSide, CombatHistory history);
}
