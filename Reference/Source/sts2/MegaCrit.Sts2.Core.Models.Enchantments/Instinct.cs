using MegaCrit.Sts2.Core.Entities.Cards;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Instinct : EnchantmentModel
{
	public override extern bool CanEnchantCardType(CardType cardType);

	public override extern bool CanEnchant(CardModel card);

	public extern Instinct();
}
