using System;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class NetLoadingHandle : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NetLoadingHandle(INetGameService netService);

	public extern void Dispose();

	public static extern void Release(INetGameService netService);
}
