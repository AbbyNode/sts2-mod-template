using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Entities.Multiplayer;

public struct NetDeckCard : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public readonly extern uint DeckIndex
	{
		[CompilerGenerated]
		get;
	}

	public static extern NetDeckCard FromModel(CardModel card);

	public readonly extern CardModel ToCardModel(Player player);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public override extern string ToString();
}
