using System.Collections.Generic;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.Relics;
using MegaCrit.Sts2.Core.Runs;

namespace MegaCrit.Sts2.Core.Models.Relics;

public sealed class ToxicEgg : RelicModel
{
	public override extern RelicRarity Rarity { get; }

	public override extern bool IsAllowed(IRunState runState);

	public override extern bool TryModifyCardRewardOptionsLate(Player player, List<CardCreationResult> cardRewards, CardCreationOptions options);

	public override extern void ModifyMerchantCardCreationResults(Player player, List<CardCreationResult> cards);

	public override extern bool TryModifyCardBeingAddedToDeck(CardModel card, out CardModel? newCard);

	public extern ToxicEgg();
}
