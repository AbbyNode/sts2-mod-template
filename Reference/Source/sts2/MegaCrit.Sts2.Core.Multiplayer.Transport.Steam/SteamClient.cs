using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using Steamworks;

namespace MegaCrit.Sts2.Core.Multiplayer.Transport.Steam;

public class SteamClient : NetClient
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool IsConnected { get; }

	public override extern ulong NetId { get; }

	public override extern ulong HostNetId { get; }

	public extern CSteamID? LobbyId { get; }

	public extern SteamClient(INetClientHandler handler);

	public extern Task<NetErrorInfo?> ConnectToLobbyOwnedByFriend(ulong steamPlayerId, CancellationToken cancelToken = default(CancellationToken));

	[AsyncStateMachine(typeof(_003CConnectToLobby_003Ed__18))]
	public extern Task<NetErrorInfo?> ConnectToLobby(ulong lobbyId, CancellationToken cancelToken = default(CancellationToken));

	public override extern void Update();

	public override extern void SendMessageToHost(byte[] bytes, int length, NetTransferMode mode, int channel = 0);

	public override extern void DisconnectFromHost(NetError reason, bool now = false);

	public override extern string? GetRawLobbyIdentifier();
}
