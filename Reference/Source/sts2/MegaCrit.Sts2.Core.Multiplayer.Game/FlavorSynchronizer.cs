using System;
using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class FlavorSynchronizer : IDisposable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern event Action<ulong>? OnEndTurnPingReceived;

	public extern FlavorSynchronizer(INetGameService gameService, IPlayerCollection playerCollection, ulong localPlayerId);

	public extern void Dispose();

	public extern void SendEndTurnPing();

	public extern void SendMapPing(MapCoord coord);
}
