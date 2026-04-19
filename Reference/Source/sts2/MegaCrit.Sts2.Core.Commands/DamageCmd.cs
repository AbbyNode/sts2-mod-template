using MegaCrit.Sts2.Core.Commands.Builders;
using MegaCrit.Sts2.Core.Localization.DynamicVars;

namespace MegaCrit.Sts2.Core.Commands;

public static class DamageCmd
{
	public static extern AttackCommand Attack(decimal damagePerHit);

	public static extern AttackCommand Attack(CalculatedDamageVar calculatedDamageVar);
}
