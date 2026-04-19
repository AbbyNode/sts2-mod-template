using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;

namespace MegaCrit.Sts2.Core.Models.Modifiers;

public class Hoarder : ModifierModel
{
	private int _003CSyntheticNonEmptyStructMarker_003E;

	[AsyncStateMachine(typeof(_003CAfterCardChangedPiles_003Ed__1))]
	public override extern Task AfterCardChangedPiles(CardModel card, PileType oldPileType, AbstractModel? source);

	public override extern bool ShouldAllowMerchantCardRemoval(Player player);

	public extern Hoarder();
}
