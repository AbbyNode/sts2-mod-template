using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class SturdyClamp : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool ShouldClearBlock(Creature creature);

	[AsyncStateMachine(typeof(_003CAfterPreventingBlockClear_003Ed__8))]
	public override extern Task AfterPreventingBlockClear(AbstractModel preventer, Creature creature);

	public extern SturdyClamp();
}
