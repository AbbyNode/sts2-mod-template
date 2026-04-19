using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Commands.Builders;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class PainfulStabsPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldPowerBeRemovedAfterOwnerDeath();

	public override extern bool ShouldCreatureBeRemovedFromCombatAfterDeath(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterAttack_003Ed__8))]
	public override extern Task AfterAttack(AttackCommand command);

	public extern PainfulStabsPower();
}
