using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.TestSupport;

public static class TestMode
{
	public static extern bool IsOn
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern bool IsOff { get; }

	public static extern void AssertOn();

	public static extern void AssertOff();

	public static extern void TurnOnInternal();
}
