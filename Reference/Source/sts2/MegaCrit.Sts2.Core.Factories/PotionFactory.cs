using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Random;

namespace MegaCrit.Sts2.Core.Factories;

public static class PotionFactory
{
	public static extern PotionModel CreateRandomPotionOutOfCombat(Player player, Rng rng, IEnumerable<PotionModel>? blacklist = null);

	public static extern List<PotionModel> CreateRandomPotionsOutOfCombat(Player player, int count, Rng rng, IEnumerable<PotionModel>? blacklist = null);

	public static extern PotionModel CreateRandomPotionInCombat(Player player, Rng rng, IEnumerable<PotionModel>? blacklist = null);

	public static extern IEnumerable<PotionModel> GetPotionOptions(Player player, IEnumerable<PotionModel> blacklist);
}
