using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Relics;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class BingBong : RelicModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	public override extern RelicRarity Rarity { get; }

	[AsyncStateMachine(typeof(_003CAfterCardChangedPiles_003Ed__5))]
	public override extern Task AfterCardChangedPiles(CardModel card, PileType oldPileType, AbstractModel? source);

	public extern BingBong();
}
