using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Game;

public class CardRemovedMessage : INetMessage, IPacketSerializable, IRunLocationTargetedMessage
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public extern RunLocation Location
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern CardRemovedMessage();
}
