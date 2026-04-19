using System;

namespace MegaCrit.Sts2.Core.Platform.Steam;

public class SteamJoinCallbackHandler : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern SteamJoinCallbackHandler();

	public extern void CheckForCommandLineJoin();

	public extern void Dispose();
}
