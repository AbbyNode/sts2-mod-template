using MegaCrit.Sts2.Core.Entities.Creatures;

namespace BaseLib.Hooks;

public interface IHealAmountModifier
{
	/// <summary>
	/// Return the amount to add.
	/// </summary>
	/// <param name="creature"></param>
	/// <param name="amount"></param>
	/// <returns></returns>
	decimal ModifyHealAdditive(Creature creature, decimal amount)
	{
		return 0m;
	}

	/// <summary>
	/// Return the amount to multiply by.
	/// </summary>
	/// <param name="creature"></param>
	/// <param name="amount"></param>
	/// <returns></returns>
	decimal ModifyHealMultiplicative(Creature creature, decimal amount)
	{
		return 1m;
	}
}
