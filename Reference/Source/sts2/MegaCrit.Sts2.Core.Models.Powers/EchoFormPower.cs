using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class EchoFormPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern int ModifyCardPlayCount(CardModel card, Creature? target, int playCount);

	public override extern Task AfterModifyingCardPlayCount(CardModel card);

	public extern EchoFormPower();
}
