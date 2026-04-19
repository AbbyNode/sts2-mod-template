using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class PerfectFit : EnchantmentModel
{
	public override extern bool HasExtraCardText { get; }

	public override extern void ModifyShuffleOrder(Player player, List<CardModel> cards, bool isInitialShuffle);

	public extern PerfectFit();
}
