using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;

public struct LobbyBeginRunMessage : INetMessage, IPacketSerializable
{
	public List<LobbyPlayer>? playersInLobby;

	public string seed;

	public List<SerializableModifier> modifiers;

	public string act1;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
