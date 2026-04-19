using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class CardAfflictedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardModel Card
	{
		[CompilerGenerated]
		get;
	}

	public extern AfflictionModel Affliction
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern CardAfflictedEntry(CardModel card, AfflictionModel affliction, int roundNumber, CombatSide currentSide, CombatHistory history);
}
