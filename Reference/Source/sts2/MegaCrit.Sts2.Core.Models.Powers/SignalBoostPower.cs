using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SignalBoostPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int ModifyCardPlayCount(CardModel card, Creature? target, int playCount);

	[AsyncStateMachine(typeof(_003CAfterModifyingCardPlayCount_003Ed__5))]
	public override extern Task AfterModifyingCardPlayCount(CardModel card);

	public extern SignalBoostPower();
}
