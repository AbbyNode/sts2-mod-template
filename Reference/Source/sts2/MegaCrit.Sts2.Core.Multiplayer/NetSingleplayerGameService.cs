using System;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Quality;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Platform;

namespace MegaCrit.Sts2.Core.Multiplayer;

public class NetSingleplayerGameService : INetGameService
{
	public const int defaultNetId = 1;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsConnected { get; }

	public extern bool IsGameLoading { get; }

	public extern ulong NetId { get; }

	public extern NetGameType Type { get; }

	public extern PlatformType Platform { get; }

	public extern event Action<NetErrorInfo>? Disconnected;

	public extern void SendMessage<T>(T message, ulong playerId) where T : INetMessage;

	public extern void SendMessage<T>(T message) where T : INetMessage;

	public extern void RegisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern void UnregisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern void Update();

	public extern void Disconnect(NetError reason, bool now = false);

	public extern ConnectionStats GetStatsForPeer(ulong peerId);

	public extern void SetGameLoading(bool isLoading);

	public extern string? GetRawLobbyIdentifier();

	public extern NetSingleplayerGameService();
}
