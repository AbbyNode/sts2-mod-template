using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;
using MegaCrit.Sts2.Core.ValueProps;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class BeaconOfHopePower : PowerModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	[AsyncStateMachine(typeof(_003CAfterBlockGained_003Ed__8))]
	public override extern Task AfterBlockGained(Creature creature, decimal amount, ValueProp props, CardModel? cardSource);

	public extern BeaconOfHopePower();
}
