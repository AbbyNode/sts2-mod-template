using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.GameActions;

public struct NetDiscardPotionGameAction : INetAction, IPacketSerializable
{
	public uint potionSlotIndex;

	public bool wasEnqueuedInCombat;

	public extern GameAction ToGameAction(Player player);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
