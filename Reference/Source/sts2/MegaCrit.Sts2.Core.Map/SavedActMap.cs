using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Map;

public sealed class SavedActMap : ActMap
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

	public override extern MapPoint? SecondBossMapPoint
	{
		[CompilerGenerated]
		get;
	}

	public extern SavedActMap(SerializableActMap saved);
}
