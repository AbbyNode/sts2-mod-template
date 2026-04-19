using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Creatures;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ReptileTrinket : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterPotionUsed_003Ed__6))]
	public override extern Task AfterPotionUsed(PotionModel potion, Creature? target);

	public extern ReptileTrinket();
}
