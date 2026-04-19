using MegaCrit.Sts2.Core.Multiplayer.Game;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Multiplayer;

public class NetMessageBus
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern byte[] SerializeMessage<T>(ulong senderId, T message, out int length) where T : INetMessage;

	public extern bool TryDeserializeMessage(byte[] packetBytes, out INetMessage? message, out ulong? overrideSenderId);

	public extern void SendMessageToAllHandlers(INetMessage message, ulong senderId);

	public extern void RegisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern void UnregisterMessageHandler<T>(MessageHandlerDelegate<T> handler) where T : INetMessage;

	public extern NetMessageBus();
}
