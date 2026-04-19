using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Multiplayer.Messages;

namespace MegaCrit.Sts2.Core.Multiplayer.Quality;

public class ConnectionStats
{
	public const int ringBufferSize = 20;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern ulong PeerId
	{
		[CompilerGenerated]
		get;
	}

	public extern float PingMsec
	{
		[CompilerGenerated]
		get;
	}

	public extern float PacketLoss
	{
		[CompilerGenerated]
		get;
	}

	public extern ulong? LastReceivedTime
	{
		[CompilerGenerated]
		get;
	}

	public extern bool RemoteIsLoading
	{
		[CompilerGenerated]
		get;
	}

	public extern ConnectionStats(ulong peerId);

	public extern HeartbeatRequestMessage GenerateHeartbeat(ulong timeMsec);

	public extern void OnHeartbeatReceived(HeartbeatResponseMessage message, ulong timeMsec);
}
