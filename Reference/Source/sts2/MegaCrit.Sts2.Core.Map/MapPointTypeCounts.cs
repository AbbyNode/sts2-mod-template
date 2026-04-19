using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Map;

public class MapPointTypeCounts
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern HashSet<MapPointType> PointTypesThatIgnoreRules
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern int NumOfElites
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern int NumOfShops
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern int NumOfUnknowns
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern int NumOfRests
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		init;
	}

	public extern bool ShouldIgnoreMapPointRulesForMapPointType(MapPointType pointType);

	public extern MapPointTypeCounts(Rng rng);
}
