using System;
using MegaCrit.Sts2.Core.Entities.Multiplayer;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Multiplayer.Game.PeerInput;

public struct HoveredModelData : IPacketSerializable, IEquatable<HoveredModelData>
{
	public HoveredModelType type;

	public NetCombatCard? hoveredCombatCard;

	public int? hoveredRelicIndex;

	public int? hoveredPotionIndex;

	public ModelId? hoveredModelId;

	public extern bool Equals(HoveredModelData other);

	public static extern HoveredModelData FromModel(AbstractModel? model);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
