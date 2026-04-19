using System.Collections.Generic;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Flavor;

public class MapDrawingMessage : INetMessage, IPacketSerializable
{
	public static readonly int maxEventCount;

	public DrawingMode? drawingMode;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public extern IReadOnlyList<NetMapDrawingEvent> Events { get; }

	public extern bool TryAddEvent(NetMapDrawingEvent ev);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern MapDrawingMessage();
}
