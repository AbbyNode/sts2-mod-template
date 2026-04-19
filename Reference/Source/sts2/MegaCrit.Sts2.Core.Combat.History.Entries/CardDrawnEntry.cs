using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class CardDrawnEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardModel Card
	{
		[CompilerGenerated]
		get;
	}

	public extern bool FromHandDraw
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern CardDrawnEntry(CardModel card, int roundNumber, CombatSide currentSide, bool fromHandDraw, CombatHistory history);
}
