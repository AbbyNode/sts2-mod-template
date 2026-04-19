using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class OutbreakPower : PowerModel
{
	public const int poisonThreshold = 3;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int DisplayAmount { get; }

	[AsyncStateMachine(typeof(_003CAfterPowerAmountChanged_003Ed__13))]
	public override extern Task AfterPowerAmountChanged(PowerModel power, decimal amount, Creature? applier, CardModel? cardSource);

	public extern OutbreakPower();
}
