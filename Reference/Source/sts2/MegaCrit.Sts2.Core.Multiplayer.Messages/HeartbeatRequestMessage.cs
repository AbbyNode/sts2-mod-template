using System;
using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages;

public struct HeartbeatRequestMessage : INetMessage, IPacketSerializable, IEquatable<HeartbeatRequestMessage>
{
	public int counter;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	[CompilerGenerated]
	public override extern string ToString();

	[CompilerGenerated]
	public static extern bool operator !=(HeartbeatRequestMessage left, HeartbeatRequestMessage right);

	[CompilerGenerated]
	public static extern bool operator ==(HeartbeatRequestMessage left, HeartbeatRequestMessage right);

	[CompilerGenerated]
	public override readonly extern int GetHashCode();

	[CompilerGenerated]
	public override readonly extern bool Equals(object obj);

	[CompilerGenerated]
	public readonly extern bool Equals(HeartbeatRequestMessage other);
}
