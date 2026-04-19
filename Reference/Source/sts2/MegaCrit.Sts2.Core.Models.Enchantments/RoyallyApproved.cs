using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class RoyallyApproved : EnchantmentModel
{
	public override extern bool CanEnchantCardType(CardType cardType);

	public extern RoyallyApproved();
}
