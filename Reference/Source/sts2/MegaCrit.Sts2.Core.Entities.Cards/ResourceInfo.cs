using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Entities.Cards;

public struct ResourceInfo
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public required extern int EnergySpent
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}

	public required extern int EnergyValue
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}

	public required extern int StarsSpent
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}

	public required extern int StarValue
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		init;
	}
}
