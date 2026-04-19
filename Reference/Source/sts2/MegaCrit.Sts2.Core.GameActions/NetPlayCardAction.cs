using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.GameActions;

public struct NetPlayCardAction : INetAction, IPacketSerializable
{
	public NetCombatCard card;

	public ModelId modelId;

	public uint? targetId;

	public extern GameAction ToGameAction(Player player);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
