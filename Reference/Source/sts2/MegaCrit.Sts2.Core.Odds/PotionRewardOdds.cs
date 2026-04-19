using MegaCrit.Sts2.Core.Entities.Ascension;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;

namespace MegaCrit.Sts2.Core.Odds;

public class PotionRewardOdds : AbstractOdds
{
	public const float targetOdds = 0.5f;

	public const float eliteBonus = 0.25f;

	public extern PotionRewardOdds(Rng rng);

	public extern PotionRewardOdds(float initialValue, Rng rng);

	public extern bool Roll(Player player, AscensionManager ascensionManager, RoomType roomType);
}
