using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Map;

public class MockActMap : ActMap
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

	protected override extern MapPoint?[,] Grid
	{
		[CompilerGenerated]
		get;
	}

	public override extern MapPoint GetPoint(MapCoord coord);

	public extern void MockCurrentMapPointType(MapPointType pointType);

	public extern MockActMap();
}
