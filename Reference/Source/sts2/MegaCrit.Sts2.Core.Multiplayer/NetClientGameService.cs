using System;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Quality;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Platform;

namespace MegaCrit.Sts2.Core.Multiplayer;

public class NetClientGameService : INetClientHandler, INetHandler, INetClientGameService, INetGameService
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern NetClient? NetClient
	{
		[CompilerGenerated]
		get;
	}

	public extern bool IsConnected { get; }

	public extern ulong NetId { get; }

	public extern ulong HostNetId { get; }

	public extern bool IsGameLoading { get; }

	public extern PlatformType Platform
	{
		[CompilerGenerated]
		get;
	}

	public extern NetGameType Type { get; }

	public extern event Action? ConnectedToHost;

	public extern event Action<NetErrorInfo>? Disconnected;

	public extern NetClientGameService();

	public extern void Initialize(NetClient client, PlatformType platform);

	public extern void Update();

	public extern void SendMessage<T>(T message, ulong playerId) where T : INetMessage;

	public extern void SendMessage<T>(T message) where T : INetMessage;

	public extern void RegisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern void UnregisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern void OnPacketReceived(ulong senderId, byte[] packetBytes, NetTransferMode mode, int channel);

	public extern void Disconnect(NetError reason, bool now = false);

	public extern void OnConnectedToHost();

	public extern void OnDisconnectedFromHost(ulong hostNetId, NetErrorInfo info);

	public extern ConnectionStats? GetStatsForPeer(ulong peerId);

	public extern void SetGameLoading(bool isLoading);

	public extern string? GetRawLobbyIdentifier();
}
