using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Game;

public struct RequestResumeActionAfterPlayerChoiceMessage : INetMessage, IPacketSerializable, IRunLocationTargetedMessage
{
	public uint actionId;

	public RunLocation location;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern RunLocation Location { get; }

	public extern LogLevel LogLevel { get; }

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
