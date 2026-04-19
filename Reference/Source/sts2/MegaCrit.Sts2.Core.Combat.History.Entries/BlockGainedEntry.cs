using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class BlockGainedEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Amount
	{
		[CompilerGenerated]
		get;
	}

	public extern Creature Receiver { get; }

	public extern ValueProp Props
	{
		[CompilerGenerated]
		get;
	}

	public extern CardPlay? CardPlay
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern BlockGainedEntry(int amount, ValueProp props, CardPlay? cardPlay, Creature receiver, int roundNumber, CombatSide currentSide, CombatHistory history);
}
