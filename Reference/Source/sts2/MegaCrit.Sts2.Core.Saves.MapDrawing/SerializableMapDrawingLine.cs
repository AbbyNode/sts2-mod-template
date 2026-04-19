using System.Collections.Generic;
using Godot;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.MapDrawing;

public class SerializableMapDrawingLine : IPacketSerializable
{
	public bool isEraser;

	public List<Vector2> mapPoints;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializableMapDrawingLine();
}
