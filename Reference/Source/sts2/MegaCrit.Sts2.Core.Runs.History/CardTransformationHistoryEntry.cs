using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Runs.History;

public struct CardTransformationHistoryEntry : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("original_card")]
	public extern SerializableCard OriginalCard
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("final_card")]
	public extern SerializableCard FinalCard
	{
		[CompilerGenerated]
		readonly get;
		[CompilerGenerated]
		set;
	}

	public extern CardTransformationHistoryEntry(CardModel originalCard, CardModel finalCard);

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);
}
