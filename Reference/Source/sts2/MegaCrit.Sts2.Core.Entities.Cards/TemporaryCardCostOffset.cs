using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public class TemporaryCardCostOffset
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Offset
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ClearsWhenTurnEnds
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ClearsWhenCardIsPlayed
	{
		[CompilerGenerated]
		get;
	}

	public static extern TemporaryCardCostOffset UntilPlayed(int offset);

	public static extern TemporaryCardCostOffset ThisTurn(int offset);

	public static extern TemporaryCardCostOffset ThisCombat(int offset);

	public extern TemporaryCardCostOffset();
}
