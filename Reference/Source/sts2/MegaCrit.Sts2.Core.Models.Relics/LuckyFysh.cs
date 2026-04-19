using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class LuckyFysh : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool IsAllowed(IRunState runState);

	[AsyncStateMachine(typeof(_003CAfterCardChangedPiles_003Ed__5))]
	public override extern Task AfterCardChangedPiles(CardModel card, PileType oldPileType, AbstractModel? source);

	public extern LuckyFysh();
}
