using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Powers;

namespace MegaCrit.Sts2.Core.Models.Powers;

public sealed class BarricadePower : PowerModel
{
	public override extern PowerType Type { get; }

	public override extern PowerStackType StackType { get; }

	public override extern Task AfterApplied(Creature? applier, CardModel? cardSource);

	public override extern bool ShouldClearBlock(Creature creature);

	public extern BarricadePower();
}
