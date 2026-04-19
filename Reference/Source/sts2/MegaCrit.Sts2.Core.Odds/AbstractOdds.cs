using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Odds;

public abstract class AbstractOdds
{
	protected readonly Rng _rng;

	public extern float CurrentValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		protected set;
	}

	protected extern AbstractOdds(float initialValue, Rng rng);

	public extern void OverrideCurrentValue(float newValue);
}
