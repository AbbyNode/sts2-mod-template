using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class BurrowedPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool ShouldClearBlock(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterBlockBroken_003Ed__5))]
	public override extern Task AfterBlockBroken(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterRemoved_003Ed__6))]
	public override extern Task AfterRemoved(Creature oldOwner);

	public extern BurrowedPower();
}
