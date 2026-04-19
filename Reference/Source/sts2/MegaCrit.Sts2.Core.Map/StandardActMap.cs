using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Map;

public sealed class StandardActMap : ActMap
{
	public const int maxElites = 15;

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

	public override extern MapPoint? SecondBossMapPoint
	{
		[CompilerGenerated]
		get;
	}

	public extern bool ShouldReplaceTreasureWithElites
	{
		[CompilerGenerated]
		get;
	}

	public extern StandardActMap(Rng mapRng, ActModel actModel, bool isMultiplayer, bool shouldReplaceTreasureWithElites, bool hasSecondBoss = false, MapPointTypeCounts? mapPointTypeCountsOverride = null, bool enablePruning = true);

	public static extern StandardActMap CreateFor(RunState runState, bool replaceTreasureWithElites);

	public extern bool IsValidPointType(MapPointType pointType, MapPoint mapPoint);
}
