using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Favored : EnchantmentModel
{
	public override extern bool CanEnchantCardType(CardType cardType);

	public override extern decimal EnchantDamageMultiplicative(decimal originalDamage, ValueProp props);

	public extern Favored();
}
