using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class HardToKillPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern decimal ModifyDamageCap(Creature? target, ValueProp props, Creature? dealer, CardModel? cardSource);

	public override extern Task AfterModifyingDamageAmount(CardModel? cardSource);

	public extern HardToKillPower();
}
