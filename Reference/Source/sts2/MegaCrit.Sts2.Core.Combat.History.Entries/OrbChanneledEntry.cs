using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Combat.History.Entries;

public class OrbChanneledEntry : CombatHistoryEntry
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern OrbModel Orb
	{
		[CompilerGenerated]
		get;
	}

	public override extern string Description { get; }

	public extern OrbChanneledEntry(OrbModel orb, int roundNumber, CombatSide currentSide, CombatHistory history);
}
