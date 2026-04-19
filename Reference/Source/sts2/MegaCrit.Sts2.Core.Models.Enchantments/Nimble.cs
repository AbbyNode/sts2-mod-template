using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Nimble : EnchantmentModel
{
	public override extern bool ShowAmount { get; }

	public override extern bool CanEnchant(CardModel card);

	public override extern decimal EnchantBlockAdditive(decimal originalBlock, ValueProp props);

	public extern Nimble();
}
