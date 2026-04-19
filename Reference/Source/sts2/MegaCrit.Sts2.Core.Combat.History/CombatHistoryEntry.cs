using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Creatures;

namespace MegaCrit.Sts2.Core.Combat.History;

public abstract class CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Creature Actor
	{
		[CompilerGenerated]
		get;
	}

	public extern int RoundNumber
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatSide CurrentSide
	{
		[CompilerGenerated]
		get;
	}

	public extern CombatHistory History
	{
		[CompilerGenerated]
		get;
	}

	public extern string HumanReadableString { get; }

	public abstract string Description { get; }

	protected extern CombatHistoryEntry(Creature actor, int roundNumber, CombatSide currentSide, CombatHistory history);

	public extern bool HappenedThisTurn(CombatState? state);
}
