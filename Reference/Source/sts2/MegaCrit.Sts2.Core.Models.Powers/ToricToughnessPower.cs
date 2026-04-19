using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class ToricToughnessPower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern bool IsInstanced { get; }

	public extern void SetBlock(decimal block);

	[AsyncStateMachine(typeof(_003CAfterBlockCleared_003Ed__11))]
	public override extern Task AfterBlockCleared(Creature creature);

	public extern ToricToughnessPower();
}
