using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Multiplayer;

namespace MegaCrit.Sts2.Core.Multiplayer.Connection;

public class SteamClientConnectionInitializer : IClientConnectionInitializer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public static extern SteamClientConnectionInitializer FromPlayer(ulong playerSteamId);

	public static extern SteamClientConnectionInitializer FromLobby(ulong lobbySteamId);

	[AsyncStateMachine(typeof(_003CConnect_003Ed__4))]
	public extern Task<NetErrorInfo?> Connect(NetClientGameService gameService, CancellationToken cancelToken = default(CancellationToken));

	public override extern string ToString();

	public extern SteamClientConnectionInitializer();
}
