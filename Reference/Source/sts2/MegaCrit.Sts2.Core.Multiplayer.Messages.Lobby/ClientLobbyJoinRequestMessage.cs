using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;

public struct ClientLobbyJoinRequestMessage : INetMessage, IPacketSerializable
{
	public int maxAscensionUnlocked;

	public SerializableUnlockState unlockState;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
