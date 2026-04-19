using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class PotionUsedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern PotionModel Potion
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature? Target
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern PotionUsedEntry(PotionModel potion, Creature? target, int roundNumber, CombatSide currentSide, CombatHistory history);
}
