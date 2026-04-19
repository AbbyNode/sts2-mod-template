using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs.History;

public struct CardEnchantmentHistoryEntry : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("card")]
	public extern SerializableCard Card
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("enchantment")]
	public extern ModelId Enchantment
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern CardEnchantmentHistoryEntry(CardModel card, ModelId enchantment);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
