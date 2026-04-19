using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Unlocks;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public struct LobbyPlayer : IPacketSerializable
{
	public ulong id;

	public int slotId;

	public CharacterModel character;

	public SerializableUnlockState unlockState;

	public int maxMultiplayerAscensionUnlocked;

	public bool isReady;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
