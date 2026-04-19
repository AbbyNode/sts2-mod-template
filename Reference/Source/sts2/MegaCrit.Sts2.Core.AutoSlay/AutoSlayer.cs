using System.Runtime.CompilerServices;
using Godot;
using MegaCrit.Sts2.Core.AutoSlay.Helpers;

namespace MegaCrit.Sts2.Core.AutoSlay;

public class AutoSlayer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern bool IsActive
	{
		[CompilerGenerated]
		get;
	}

	public static extern Watchdog? CurrentWatchdog
	{
		[CompilerGenerated]
		get;
	}

	public extern AutoSlayer();

	public extern void Start(string seed, string? logFile = null);

	public extern void Stop();

	public static extern T GetCurrentScreen<T>() where T : Node;
}
