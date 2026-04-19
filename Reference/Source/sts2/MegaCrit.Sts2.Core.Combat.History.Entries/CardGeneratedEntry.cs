using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class CardGeneratedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardModel Card
	{
		[CompilerGenerated]
		get;
	}

	public extern bool GeneratedByPlayer
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern CardGeneratedEntry(CardModel card, bool generatedByPlayer, int roundNumber, CombatSide currentSide, CombatHistory history);
}
