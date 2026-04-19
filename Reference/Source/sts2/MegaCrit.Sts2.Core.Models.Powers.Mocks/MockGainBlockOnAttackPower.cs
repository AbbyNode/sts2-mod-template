using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Commands.Builders;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers.Mocks;

public sealed class MockGainBlockOnAttackPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterAttack_003Ed__4))]
	public override extern Task AfterAttack(AttackCommand command);

	public extern MockGainBlockOnAttackPower();
}
