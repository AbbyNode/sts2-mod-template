using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Factories;

public static class RelicFactory
{
	public static extern RelicModel FallbackRelic { get; }

	public static extern RelicModel PullNextRelicFromFront(Player player, Rng rng);

	public static extern RelicModel PullNextRelicFromFront(Player player);

	public static extern RelicModel PullNextRelicFromFront(Player player, RelicRarity rarity);

	public static extern RelicModel PullNextRelicFromBack(Player player);

	public static extern RelicModel PullNextRelicFromBack(Player player, RelicRarity rarity, IEnumerable<RelicModel> blacklist);

	public static extern RelicRarity RollRarity(Player player);

	public static extern RelicRarity RollRarity(Rng rng);
}
