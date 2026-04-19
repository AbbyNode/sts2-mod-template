using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Multiplayer.Replay;

public struct ReplayChecksumData : IPacketSerializable
{
	public NetChecksumData checksumData;

	public string context;

	public NetFullCombatState fullState;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern ReplayChecksumData Anonymized();
}
