using System;
using System.Runtime.CompilerServices;

namespace MegaCrit.Sts2.Core.Helpers;

public static class NonInteractiveMode
{
	public static extern Func<bool> AutoSlayerCheck
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static extern bool IsActive { get; }
}
