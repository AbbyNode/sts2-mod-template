using System.Runtime.CompilerServices;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Saves.Runs;

namespace MegaCrit.Sts2.Core.Odds;

public class PlayerOddsSet
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern CardRarityOdds CardRarity
	{
		[CompilerGenerated]
		get;
	}

	public extern PotionRewardOdds PotionReward
	{
		[CompilerGenerated]
		get;
	}

	public extern PlayerOddsSet(PlayerRngSet rng);

	public extern SerializablePlayerOddsSet ToSerializable();

	public static extern PlayerOddsSet FromSerializable(SerializablePlayerOddsSet save, PlayerRngSet rng);

	public extern void LoadFromSerializable(SerializablePlayerOddsSet save);
}
