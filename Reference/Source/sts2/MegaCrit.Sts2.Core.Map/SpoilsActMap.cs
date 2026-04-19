using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Map;

public sealed class SpoilsActMap : ActMap
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern MapPoint BossMapPoint
	{
		[CompilerGenerated]
		get;
	}

	public override extern MapPoint StartingMapPoint
	{
		[CompilerGenerated]
		get;
	}

	public extern SpoilsActMap(IRunState runState);
}
