using System.Collections.Generic;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.MapDrawing;

public class SerializableMapDrawings : IPacketSerializable
{
	public List<SerializablePlayerMapDrawings> drawings;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializableMapDrawings Anonymized();

	public extern SerializableMapDrawings();
}
