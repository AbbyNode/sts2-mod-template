using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Odds;

public class CardRarityOdds : AbstractOdds
{
	public static float regularCommonOdds;

	public const float regularUncommonOdds = 0.37f;

	public const float eliteUncommonOdds = 0.4f;

	public const float bossCommonOdds = 0f;

	public const float bossUncommonOdds = 0f;

	public const float bossRareOdds = 1f;

	public const float shopUncommonOdds = 0.37f;

	public extern float RarityGrowth { get; }

	public static extern float RegularRareOdds { get; }

	public static extern float EliteCommonOdds { get; }

	public static extern float EliteRareOdds { get; }

	public static extern float ShopCommonOdds { get; }

	public static extern float ShopRareOdds { get; }

	public extern CardRarityOdds(Rng rng);

	public extern CardRarityOdds(float initialValue, Rng rng);

	public extern CardRarity Roll(CardRarityOddsType type);

	public extern CardRarity RollWithoutChangingFutureOdds(CardRarityOddsType oddsType);

	public extern CardRarity RollWithoutChangingFutureOdds(CardRarityOddsType type, float offset);

	public extern CardRarity RollWithBaseOdds(CardRarityOddsType type);
}
