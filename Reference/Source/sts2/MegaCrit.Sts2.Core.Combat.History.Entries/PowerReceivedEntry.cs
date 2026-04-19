using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class PowerReceivedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern PowerModel Power
	{
		[CompilerGenerated]
		get;
	}

	public extern decimal Amount
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature? Applier
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern PowerReceivedEntry(PowerModel power, decimal amount, Creature? applier, int roundNumber, CombatSide currentSide, CombatHistory history);
}
