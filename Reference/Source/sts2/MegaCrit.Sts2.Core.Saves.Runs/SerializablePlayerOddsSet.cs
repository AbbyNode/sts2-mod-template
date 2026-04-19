using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using MegaCrit.Sts2.Core.Multiplayer.Serialization;

namespace MegaCrit.Sts2.Core.Saves.Runs;

public class SerializablePlayerOddsSet : IPacketSerializable
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[JsonPropertyName("card_rarity_odds_value")]
	public extern float CardRarityOddsValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("potion_reward_odds_value")]
	public extern float PotionRewardOddsValue
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public extern void Serialize(PacketWriter writer);

	public extern void Deserialize(PacketReader reader);

	public extern SerializablePlayerOddsSet();
}
