using System;
using MegaCrit.Sts2.Core.Multiplayer.Game;

namespace MegaCrit.Sts2.Core.Multiplayer.Quality;

public class NetQualityTracker : IDisposable
{
	public const int sendRateMsec = 200;

	public const int logRateMsec = 20000;

	public Func<ulong>? getTimeMsec;

	public extern bool IsGameLoading { get; }

	public extern NetQualityTracker(INetGameService netService);

	public extern void Dispose();

	public extern void OnPeerConnected(ulong peerId);

	public extern void OnPeerDisconnected(ulong peerId);

	public extern void SetIsLoading(bool isLoading);

	public extern void Update();

	public extern ConnectionStats? GetStatsForPeer(ulong peerId);
}
