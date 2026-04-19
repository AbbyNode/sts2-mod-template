using System.Collections.Generic;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Saves;

namespace MegaCrit.Sts2.Core.Multiplayer.Replay;

public class CombatReplay : IPacketSerializable
{
	public string version;

	public string gitCommit;

	public uint modelIdHash;

	public List<uint> choiceIds;

	public uint nextActionId;

	public uint nextChecksumId;

	public uint nextHookId;

	public SerializableRun serializableRun;

	public List<CombatReplayEvent> events;

	public List<ReplayChecksumData> checksumData;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern CombatReplay Anonymized();

	public extern CombatReplay();
}
