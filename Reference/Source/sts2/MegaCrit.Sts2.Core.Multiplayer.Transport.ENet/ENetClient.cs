using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.Multiplayer.Transport.ENet;

public class ENetClient : NetClient
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern bool IsConnected { get; }

	public override extern ulong NetId { get; }

	public override extern ulong HostNetId { get; }

	public extern ENetClient(INetClientHandler handler);

	[AsyncStateMachine(typeof(_003CConnectToHost_003Ed__14))]
	public extern Task<NetErrorInfo?> ConnectToHost(ulong netId, string ip, ushort port, CancellationToken cancelToken = default(CancellationToken));

	public override extern void Update();

	public override extern void DisconnectFromHost(NetError reason, bool now = false);

	public override extern void SendMessageToHost(byte[] bytes, int length, NetTransferMode mode, int channel = 0);

	public override extern string? GetRawLobbyIdentifier();
}
