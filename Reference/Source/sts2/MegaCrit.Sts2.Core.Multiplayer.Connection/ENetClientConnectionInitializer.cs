using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.Multiplayer.Connection;

public class ENetClientConnectionInitializer : IClientConnectionInitializer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ENetClientConnectionInitializer(ulong netId, string ip, ushort port);

	[AsyncStateMachine(typeof(_003CConnect_003Ed__4))]
	public extern Task<NetErrorInfo?> Connect(NetClientGameService gameService, CancellationToken cancelToken = default(CancellationToken));
}
