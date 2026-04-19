using System.Collections.Generic;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.MapDrawing;

public class SerializablePlayerMapDrawings : IPacketSerializable
{
	public ulong playerId;

	public List<SerializableMapDrawingLine> lines;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializablePlayerMapDrawings Anonymized();

	public extern SerializablePlayerMapDrawings();
}
