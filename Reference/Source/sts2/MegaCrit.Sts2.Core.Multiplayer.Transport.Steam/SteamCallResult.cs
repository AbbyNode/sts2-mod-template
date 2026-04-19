using System;
using System.Threading;
using System.Threading.Tasks;
using Steamworks;

namespace MegaCrit.Sts2.Core.Multiplayer.Transport.Steam;

public class SteamCallResult<T> : IDisposable where T : struct
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern Task<T> Task { get; }

	public extern SteamCallResult(SteamAPICall_t call, CancellationToken cancelToken = default(CancellationToken));

	public extern void Cancel();

	public extern void Dispose();
}
