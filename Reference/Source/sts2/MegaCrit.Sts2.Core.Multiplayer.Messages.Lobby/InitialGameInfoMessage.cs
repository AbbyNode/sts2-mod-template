using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Lobby;

public struct InitialGameInfoMessage : INetMessage, IPacketSerializable
{
	public string version;

	public uint idDatabaseHash;

	public List<string>? mods;

	public GameMode gameMode;

	public RunSessionState sessionState;

	public ConnectionFailureReason? connectionFailureReason;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public static extern InitialGameInfoMessage Basic();

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
