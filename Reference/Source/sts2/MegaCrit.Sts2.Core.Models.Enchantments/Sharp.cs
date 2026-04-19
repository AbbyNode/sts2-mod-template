using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Sharp : EnchantmentModel
{
	public override extern bool ShowAmount { get; }

	public override extern bool CanEnchantCardType(CardType cardType);

	public override extern decimal EnchantDamageAdditive(decimal originalDamage, ValueProp props);

	public extern Sharp();
}
