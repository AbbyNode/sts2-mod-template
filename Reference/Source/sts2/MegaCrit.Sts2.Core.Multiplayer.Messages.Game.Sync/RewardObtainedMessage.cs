using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Transport;
using MegaCrit.Sts2.Core.Rewards;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Multiplayer.Messages.Game.Sync;

public struct RewardObtainedMessage : INetMessage, IPacketSerializable, IRunLocationTargetedMessage
{
	public required RewardType rewardType;

	public required RunLocation location;

	public CardModel? cardModel;

	public PotionModel? potionModel;

	public RelicModel? relicModel;

	public int? goldAmount;

	public required bool wasSkipped;

	public extern bool ShouldBroadcast { get; }

	public extern NetTransferMode Mode { get; }

	public extern LogLevel LogLevel { get; }

	public extern RunLocation Location { get; }

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
