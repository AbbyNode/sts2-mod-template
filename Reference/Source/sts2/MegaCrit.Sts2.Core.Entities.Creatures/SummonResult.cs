using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Entities.Creatures;

public class SummonResult
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Creature? Creature
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern decimal Amount
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern SummonResult(Creature? creature, decimal amount);
}
