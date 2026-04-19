using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.Multiplayer.Transport.ENet;

public class ENetHost : NetHost
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool IsConnected { get; }

	public override extern IEnumerable<ulong> ConnectedPeerIds { get; }

	public override extern ulong NetId { get; }

	public extern ENetHost(INetHostHandler handler);

	public extern NetErrorInfo? StartHost(ushort port, int maxClients);

	public override extern void Update();

	public override extern void SendMessageToClient(ulong peerId, byte[] bytes, int length, NetTransferMode mode, int channel = 0);

	public override extern void DisconnectClient(ulong peerId, NetError reason, bool now = false);

	public override extern void SendMessageToAll(byte[] bytes, int length, NetTransferMode mode, int channel = 0);

	public override extern void SetHostIsClosed(bool isClosed);

	public override extern void StopHost(NetError reason, bool now = false);

	public override extern string? GetRawLobbyIdentifier();
}
