using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public class LocalCostModifier
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern int Amount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern LocalCostType Type
	{
		[CompilerGenerated]
		get;
	}

	public extern LocalCostModifierExpiration Expiration
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsReduceOnly
	{
		[CompilerGenerated]
		get;
	}

	public extern LocalCostModifier(int amount, LocalCostType type, LocalCostModifierExpiration expiration, bool reduceOnly);

	public extern int Modify(int currentCost);
}
