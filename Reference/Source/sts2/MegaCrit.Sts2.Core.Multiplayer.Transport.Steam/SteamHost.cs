using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using Steamworks;

namespace MegaCrit.Sts2.Core.Multiplayer.Transport.Steam;

public class SteamHost : NetHost
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool IsConnected { get; }

	public override extern ulong NetId { get; }

	public override extern IEnumerable<ulong> ConnectedPeerIds { get; }

	public extern CSteamID? LobbyId { get; }

	public extern SteamHost(INetHostHandler handler);

	[AsyncStateMachine(typeof(_003CStartHost_003Ed__17))]
	public extern Task<NetErrorInfo?> StartHost(int maxPlayers);

	public override extern void Update();

	public override extern void SetHostIsClosed(bool isClosed);

	public override extern void SendMessageToClient(ulong peerId, byte[] bytes, int length, NetTransferMode mode, int channel = 0);

	public override extern void SendMessageToAll(byte[] bytes, int length, NetTransferMode mode, int channel = 0);

	public override extern void DisconnectClient(ulong peerId, NetError reason, bool now = false);

	public override extern void StopHost(NetError reason, bool now = false);

	public override extern string? GetRawLobbyIdentifier();
}
