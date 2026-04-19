using System.Runtime.InteropServices;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.GameActions;

[StructLayout(LayoutKind.Sequential, Size = 1)]
public struct NetReadyToBeginEnemyTurnAction : INetAction, IPacketSerializable
{
	public extern GameAction ToGameAction(Player player);

	public extern void Serialize(PacketWriter serializer);

	public extern void Deserialize(PacketReader deserializer);

	public override extern string ToString();
}
