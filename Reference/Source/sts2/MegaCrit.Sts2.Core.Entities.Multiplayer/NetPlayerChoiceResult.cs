using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Models;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public struct NetPlayerChoiceResult : IPacketSerializable
{
	public PlayerChoiceType type;

	public List<CardModel>? canonicalCards;

	public List<NetCombatCard>? combatCards;

	public List<NetDeckCard>? deckCards;

	public List<SerializableCard>? mutableCards;

	public ulong? mutableCardOwner;

	public List<int>? indexes;

	public ulong? playerId;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
