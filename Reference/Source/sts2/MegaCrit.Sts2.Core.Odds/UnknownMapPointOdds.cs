using System.Collections.Generic;
using MegaCrit.Sts2.Core.Random;
using MegaCrit.Sts2.Core.Rooms;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Odds;

public class UnknownMapPointOdds : AbstractOdds
{
	public const float baseMonsterOdds = 0.1f;

	public const float baseEliteOdds = -1f;

	public const float baseTreasureOdds = 0.02f;

	public const float baseShopOdds = 0.03f;

	private int _003CSyntheticNonEmptyStructMarker_003E;

	public extern float MonsterOdds { get; set; }

	public extern float EliteOdds { get; set; }

	public extern float TreasureOdds { get; set; }

	public extern float ShopOdds { get; set; }

	public extern float EventOdds { get; }

	public extern UnknownMapPointOdds(Rng rng);

	public extern void SetBaseOdds(RoomType roomType, float baseOdds);

	public extern RoomType Roll(IEnumerable<RoomType> blacklist, IRunState runState);

	public extern void ResetToBase();
}
