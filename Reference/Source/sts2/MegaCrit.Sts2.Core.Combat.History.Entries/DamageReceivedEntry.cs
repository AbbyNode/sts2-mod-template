using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class DamageReceivedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern DamageResult Result
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature? Dealer
	{
		[CompilerGenerated]
		get;
	}

	public extern CardModel? CardSource
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature Receiver { get; }

	public override extern string Description { get; }

	public extern DamageReceivedEntry(DamageResult result, Creature receiver, Creature? dealer, CardModel? cardSource, int roundNumber, CombatSide currentSide, CombatHistory history);
}
