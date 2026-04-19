using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Quality;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Platform;

namespace MegaCrit.Sts2.Core.Multiplayer;

public class NetHostGameService : INetHostHandler, INetHandler, INetHostGameService, INetGameService
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool IsConnected { get; }

	public extern IReadOnlyList<NetClientData> ConnectedPeers { get; }

	public extern ulong NetId { get; }

	public extern bool IsGameLoading { get; }

	public extern PlatformType Platform
	{
		[CompilerGenerated]
		get;
	}

	public extern NetHost? NetHost { get; }

	public extern NetGameType Type { get; }

	public extern event Action<NetErrorInfo>? Disconnected;

	public extern event Action<ulong>? ClientConnected;

	public extern event Action<ulong, NetErrorInfo>? ClientDisconnected;

	public extern NetHostGameService();

	public extern NetErrorInfo? StartENetHost(ushort port, int maxClients);

	public extern Task<NetErrorInfo?> StartSteamHost(int maxClients);

	public extern void Update();

	public extern void SendMessage<T>(T message, ulong peerId) where T : INetMessage;

	public extern void SendMessage<T>(T message) where T : INetMessage;

	public extern void RegisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern void UnregisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern void OnPacketReceived(ulong senderId, byte[] packetBytes, NetTransferMode mode, int channel);

	public extern void SetPeerReadyForBroadcasting(ulong peerId);

	public extern void DisconnectClient(ulong peerId, NetError reason, bool now = false);

	public extern void Disconnect(NetError reason, bool now = false);

	public extern void OnDisconnected(NetErrorInfo info);

	public extern void OnPeerConnected(ulong peerId);

	public extern void OnPeerDisconnected(ulong peerId, NetErrorInfo info);

	public extern ConnectionStats? GetStatsForPeer(ulong peerId);

	public extern void SetGameLoading(bool isLoading);

	public extern string? GetRawLobbyIdentifier();
}
