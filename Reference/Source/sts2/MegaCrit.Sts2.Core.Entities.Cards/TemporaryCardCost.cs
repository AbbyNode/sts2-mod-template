using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public class TemporaryCardCost
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Cost
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

	public static extern TemporaryCardCost UntilPlayed(int cost);

	public static extern TemporaryCardCost ThisTurn(int cost);

	public static extern TemporaryCardCost ThisCombat(int cost);

	public extern TemporaryCardCost();
}
