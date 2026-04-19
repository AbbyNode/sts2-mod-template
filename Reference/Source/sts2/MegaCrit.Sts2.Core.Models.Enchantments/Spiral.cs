namespace MegaCrit.Sts2.Core.Models.Enchantments;

public sealed class Spiral : EnchantmentModel
{
	public override extern bool CanEnchant(CardModel c);

	public override extern int EnchantPlayCount(int originalPlayCount);

	public extern Spiral();
}
