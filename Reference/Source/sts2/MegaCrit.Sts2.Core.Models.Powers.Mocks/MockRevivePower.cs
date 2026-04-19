using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers.Mocks;

public sealed class MockRevivePower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern decimal ModifyDamageMultiplicative(Creature? target, decimal amount, ValueProp props, Creature? dealer, CardModel? cardSource);

	public override extern bool TryModifyPowerAmountReceived(PowerModel canonicalPower, Creature target, decimal amount, Creature? applier, out decimal modifiedAmount);

	public override extern bool ShouldAllowHitting(Creature creature);

	public override extern bool ShouldDie(Creature creature);

	public override extern bool ShouldStopCombatFromEnding();

	[AsyncStateMachine(typeof(_003CAfterPreventingDeath_003Ed__13))]
	public override extern Task AfterPreventingDeath(Creature creature);

	public extern MockRevivePower();
}
