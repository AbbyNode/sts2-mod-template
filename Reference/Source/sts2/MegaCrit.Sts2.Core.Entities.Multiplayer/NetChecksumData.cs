using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public struct NetChecksumData : IPacketSerializable
{
	public uint id;

	public uint checksum;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
