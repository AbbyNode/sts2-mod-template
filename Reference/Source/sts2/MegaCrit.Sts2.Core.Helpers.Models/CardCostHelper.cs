using MegaCrit.Sts2.Core.Combat;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Helpers.Models;

public static class CardCostHelper
{
	public static extern CardCostColor GetEnergyCostColor(CardModel card, CombatState? state);

	public static extern CardCostColor GetStarCostColor(CardModel card, CombatState? state);
}
