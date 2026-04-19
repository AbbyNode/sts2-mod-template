using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.GameActions;

public struct NetUsePotionAction : INetAction, IPacketSerializable
{
	public uint potionIndex;

	public uint? targetId;

	public ulong? targetPlayerId;

	public bool enqueuedInCombat;

	public extern GameAction ToGameAction(Player player);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
