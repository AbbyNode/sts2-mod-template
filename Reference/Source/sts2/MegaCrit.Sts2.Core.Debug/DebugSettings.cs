using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Debug;

public static class DebugSettings
{
	public static extern bool DevSkip
	{
		[CompilerGenerated]
		get;
	}

	public static extern bool IgnorePackedImages { get; }
}
