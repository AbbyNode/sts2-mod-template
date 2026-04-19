using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Entities.Enchantments;

public struct EnchantmentOption
{
	public readonly EnchantmentModel enchantment;

	public readonly int minAmount;

	public readonly int maxAmount;

	public extern EnchantmentOption(EnchantmentModel enchantment, int minAmount, int maxAmount);
}
