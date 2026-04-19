using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Debug;

public class ReleaseInfoManager
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern ReleaseInfoManager Instance { get; }

	public extern ReleaseInfo? ReleaseInfo
	{
		[CompilerGenerated]
		get;
	}
}
