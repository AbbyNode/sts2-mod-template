using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializableRunOddsSet : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("unknown_map_point_monster_odds_value")]
	public extern float UnknownMapPointMonsterOddsValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("unknown_map_point_elite_odds_value")]
	public extern float UnknownMapPointEliteOddsValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("unknown_map_point_treasure_odds_value")]
	public extern float UnknownMapPointTreasureOddsValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("unknown_map_point_shop_odds_value")]
	public extern float UnknownMapPointShopOddsValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializableRunOddsSet();
}
