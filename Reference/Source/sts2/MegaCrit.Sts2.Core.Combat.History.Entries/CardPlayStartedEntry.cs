using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class CardPlayStartedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardPlay CardPlay
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern CardPlayStartedEntry(CardPlay cardPlay, int roundNumber, CombatSide currentSide, CombatHistory history);
}
