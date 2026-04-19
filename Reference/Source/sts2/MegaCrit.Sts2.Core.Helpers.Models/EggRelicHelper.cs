using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models;

namespace MegaCrit.Sts2.Core.Helpers.Models;

public static class EggRelicHelper
{
	public static extern void UpgradeValidCards(List<CardCreationResult> cards, CardType cardType, RelicModel eggRelic);
}
