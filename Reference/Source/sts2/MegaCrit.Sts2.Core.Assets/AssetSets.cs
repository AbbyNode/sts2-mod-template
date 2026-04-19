using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Assets;

public static class AssetSets
{
	public static extern IReadOnlySet<string> MainMenuEssentials
	{
		[CompilerGenerated]
		get;
	}

	public static extern IReadOnlySet<string> IntroLogoAssets
	{
		[CompilerGenerated]
		get;
	}

	public static extern IReadOnlySet<string> CommonAssets
	{
		[CompilerGenerated]
		get;
	}

	public static extern IReadOnlySet<string> MainMenuSet
	{
		[CompilerGenerated]
		get;
	}

	public static extern IReadOnlySet<string> RunSet
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern IReadOnlySet<string> Act
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
