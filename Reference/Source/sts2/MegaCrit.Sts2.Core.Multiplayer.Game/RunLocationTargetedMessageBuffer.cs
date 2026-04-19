using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Multiplayer.Messages.Game;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public class RunLocationTargetedMessageBuffer
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern RunLocation CurrentLocation
	{
		[CompilerGenerated]
		get;
	}

	public extern RunLocationTargetedMessageBuffer(INetGameService gameService);

	public extern void OnRunLocationChanged(RunLocation location);

	public extern void RegisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage, IRunLocationTargetedMessage;

	public extern void UnregisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage, IRunLocationTargetedMessage;
}
