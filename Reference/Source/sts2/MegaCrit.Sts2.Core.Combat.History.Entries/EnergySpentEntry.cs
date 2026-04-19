using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class EnergySpentEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Amount
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern EnergySpentEntry(int amount, Player player, int roundNumber, CombatSide currentSide, CombatHistory history);
}
