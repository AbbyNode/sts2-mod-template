using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Odds;

public class RunOddsSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern UnknownMapPointOdds UnknownMapPoint
	{
		[CompilerGenerated]
		get;
	}

	public extern RunOddsSet(Rng unknownMapPointRng);

	public extern SerializableRunOddsSet ToSerializable();

	public static extern RunOddsSet FromSerializable(SerializableRunOddsSet save, Rng unknownMapPointRng);
}
