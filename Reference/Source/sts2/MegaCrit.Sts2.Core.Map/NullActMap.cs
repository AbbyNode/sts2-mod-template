using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Map;

public class NullActMap : ActMap
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern NullActMap Instance
	{
		[CompilerGenerated]
		get;
	}

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

	public extern NullActMap();
}
