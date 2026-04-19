using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves;

public class SerializableExtraPlayerFields : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("card_shop_removals_used")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern int CardShopRemovalsUsed
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("wongo_points")]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public extern int WongoPoints
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializableExtraPlayerFields();
}
