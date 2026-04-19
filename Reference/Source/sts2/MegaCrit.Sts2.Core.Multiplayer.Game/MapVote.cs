using MegaCrit.Sts2.Core.Map;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Multiplayer.Game;

public struct MapVote : IPacketSerializable
{
	public int mapGenerationCount;

	public MapCoord coord;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
