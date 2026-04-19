using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers.Mocks;

public sealed class MockPreventDeathPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldDie(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterPreventingDeath_003Ed__5))]
	public override extern Task AfterPreventingDeath(Creature creature);

	public extern MockPreventDeathPower();
}
