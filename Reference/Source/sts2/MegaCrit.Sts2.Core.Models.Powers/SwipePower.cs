using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class SwipePower : PowerModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool IsInstanced { get; }

	public extern CardModel? StolenCard { get; set; }

	public override extern Task BeforeDeath(Creature target);

	[AsyncStateMachine(typeof(_003CSteal_003Ed__13))]
	public extern Task Steal(CardModel card);

	public extern SwipePower();
}
