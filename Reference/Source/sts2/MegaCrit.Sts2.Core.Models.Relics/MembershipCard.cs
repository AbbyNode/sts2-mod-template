using MegaCrit.Sts2.Core.Entities.Merchant;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class MembershipCard : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern decimal ModifyMerchantPrice(Player player, MerchantEntry entry, decimal originalPrice);

	public extern MembershipCard();
}
