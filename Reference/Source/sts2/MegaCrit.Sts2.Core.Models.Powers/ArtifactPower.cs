using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class ArtifactPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldScaleInMultiplayer { get; }

	public override extern bool TryModifyPowerAmountReceived(PowerModel canonicalPower, Creature target, decimal amount, Creature? _, out decimal modifiedAmount);

	[AsyncStateMachine(typeof(_003CAfterModifyingPowerAmountReceived_003Ed__7))]
	public override extern Task AfterModifyingPowerAmountReceived(PowerModel power);

	public extern ArtifactPower();
}
