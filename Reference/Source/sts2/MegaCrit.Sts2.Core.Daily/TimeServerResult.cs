using System;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Daily;

public struct TimeServerResult : IPacketSerializable
{
	public DateTimeOffset serverTime;

	public DateTimeOffset localReceivedTime;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
