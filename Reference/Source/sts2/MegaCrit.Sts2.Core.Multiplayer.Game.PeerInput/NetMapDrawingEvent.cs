using Godot;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Nodes.Screens.Map;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;

public struct NetMapDrawingEvent : IPacketSerializable
{
	public MapDrawingEventType type;

	public DrawingMode? overrideDrawingMode;

	public Vector2 position;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
