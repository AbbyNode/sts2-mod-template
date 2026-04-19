using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Rooms;

public class BackgroundAssets
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern string BackgroundScenePath
	{
		[CompilerGenerated]
		get;
	}

	public extern List<string> BgLayers
	{
		[CompilerGenerated]
		get;
	}

	public extern string? FgLayer
	{
		[CompilerGenerated]
		get;
	}

	public extern IEnumerable<string> AssetPaths { get; }

	public extern BackgroundAssets(string title, Rng rng);
}
