using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Multiplayer.Replay;

public struct CombatReplayEvent : IPacketSerializable
{
	public CombatReplayEventType eventType;

	public ulong? playerId;

	public INetAction? action;

	public uint? hookId;

	public uint? actionId;

	public GameActionType? gameActionType;

	public uint? choiceId;

	public NetPlayerChoiceResult? playerChoiceResult;

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern CombatReplayEvent Anonymized();
}
